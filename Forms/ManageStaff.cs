using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Sql Client
using System.Data.SqlClient;

using zeus.Classess;

namespace zeus.Forms
{
    public partial class ManageStaff : Form
    {
        private int? userId;
        private int gridIndex;
        private string username;

        //Create new User List
        List<User> userList = new List<User>();

        //Create new Binding source
        BindingSource source = new BindingSource();

        public ManageStaff()
        {
            InitializeComponent();
        }

        //load all staff users
        private void ManageStaff_Load(object sender, EventArgs e)
        {
            //sql select query
            String sqlString = "SELECT * FROM users WHERE type != 'admin' ORDER BY id DESC";

            using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
            {
                try
                {

                    //Open DB Connection
                    DB.connection.Open();

                    //sql data reader
                    using (SqlDataReader rd = cmmnd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                User user = new User();

                                user.Id = Convert.ToInt32(rd["id"]);
                                user.Name = rd["name"].ToString();
                                user.Username = rd["username"].ToString();
                                user.Type = rd["type"].ToString();

                                userList.Add(user);
                            }

                            source.DataSource = userList;
                            data_staff_list.DataSource = source;

                            data_staff_list.Columns[3].Visible = false;
                        }

                        rd.Close();
                    }
                }

                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                finally
                {
                    //Close DB Connection
                    DB.connection.Close();
                }
            }
        }

        //add staff member
        private void btn_add_Click(object sender, EventArgs e)
        {
            userId = 0;

            User user = new User();

            user.Id = (int)userId;
            user.Name = txt_name.Text;
            user.Username = txt_username.Text;
            user.Password = txt_password.Text;
            user.Type = cmb_role.Text;

            if (user.validate())
            {
                String sqlString = "INSERT into users (name, username, password, type) OUTPUT INSERTED.ID VALUES (@name , @username, @password, @type)";

                using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
                {

                    cmmnd.Parameters.Add("@name", SqlDbType.VarChar).Value = user.Name;
                    cmmnd.Parameters.Add("@username", SqlDbType.Text).Value = user.Username;
                    cmmnd.Parameters.Add("@password", SqlDbType.Text).Value = user.Password;
                    cmmnd.Parameters.Add("@type", SqlDbType.VarChar).Value = user.Type;

                    try
                    {
                        DB.connection.Open();

                        userId = (Int32)cmmnd.ExecuteScalar();

                        user.Id = Convert.ToInt32(userId);

                        userList.Add(user);

                        source.DataSource = userList;

                        data_staff_list.DataSource = null;
                        data_staff_list.DataSource = source;

                        MessageBox.Show("User addedd successful");

                        Clear.ClearFormFields(this);

                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);

                    }
                    finally
                    {
                        DB.connection.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show(user.getError());
            }
        }

        //edit staff member
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (userId.HasValue && userId.Value > 0)
            {
                User user = new User();

                user.Id = (int)userId;
                user.Name = txt_name.Text;
                user.Username = txt_username.Text;
                user.Password = txt_password.Text;
                user.Type = cmb_role.Text;

                //Datagrid Selected row
                DataGridViewRow selectedRow = data_staff_list.Rows[gridIndex];

                if (user.validate(username, true))
                {
                    String sqlString = "UPDATE users SET name=@name, username=@username, password=@password, type=@type WHERE id=@id";

                    using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
                    {
                        cmmnd.Parameters.Add("@name", SqlDbType.VarChar).Value = user.Name;
                        cmmnd.Parameters.Add("@username", SqlDbType.Text).Value = user.Username;
                        cmmnd.Parameters.Add("@password", SqlDbType.Text).Value = user.Password;
                        cmmnd.Parameters.Add("@type", SqlDbType.VarChar).Value = user.Type;

                        cmmnd.Parameters.Add("@id", SqlDbType.Int).Value = userId;

                        try
                        {
                            //Open DB Connection
                            DB.connection.Open();
                            //Executing SQL Query
                            cmmnd.ExecuteNonQuery();

                            //Updating patient row data
                            selectedRow.Cells["name"].Value = user.Name;
                            selectedRow.Cells["username"].Value = user.Name;
                            selectedRow.Cells["type"].Value = user.Type;

                            userId = 0;

                            MessageBox.Show("User Updated successful");

                            Clear.ClearFormFields(this);

                        }
                        catch (SqlException ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        finally
                        {
                            DB.connection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(user.getError());
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to edit");
            }

        }
        //delete staff member
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (userId.HasValue && userId.Value > 0)
            {
                DialogResult dialogResult = MessageBox.Show("If you delete this user, you cannot recover data again", "Are you Sure ?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    String sqlString = "DELETE FROM users WHERE id=@id";

                    using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
                    {

                        cmmnd.Parameters.Add("@id", SqlDbType.Int).Value = userId;

                        try
                        {
                            //Open DB Connection
                            DB.connection.Open();
                            //Executing SQL Query
                            cmmnd.ExecuteNonQuery();

                            data_staff_list.Rows.RemoveAt(gridIndex);

                            userId = 0;

                            MessageBox.Show("User Deleted successful");
                            Clear.ClearFormFields(this);
                        }
                        catch (SqlException ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        finally
                        {
                            DB.connection.Close();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to delete");
            }
        }
        //clear form
        private void btn_clear_Click(object sender, EventArgs e)
        {
            userId = 0;
            Clear.ClearFormFields(this);
        }

        //data grid view actions
        private void data_staff_list_Click(object sender, EventArgs e)
        {
            if (data_staff_list.SelectedCells.Count > 0)
            {
                int selectedrowindex = data_staff_list.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = data_staff_list.Rows[selectedrowindex];

                this.gridIndex = selectedrowindex;
                this.userId = Int32.Parse(Convert.ToString(selectedRow.Cells["id"].Value));
                this.username = Convert.ToString(selectedRow.Cells["username"].Value);

                txt_name.Text = Convert.ToString(selectedRow.Cells["name"].Value);
                txt_username.Text = Convert.ToString(selectedRow.Cells["username"].Value);
                txt_password.Text = "";
                string type = Convert.ToString(selectedRow.Cells["type"].Value);

                if(type == "sales-officer")
                {
                    cmb_role.Text = "sales-officer";
                }
                else if( type == "issue-officer")
                {
                    cmb_role.Text = "issue-officer";
                }
            }
        }

        //generate password
        private void btn_generate_Click(object sender, EventArgs e)
        {
            txt_password.Text = PasswordHash.generatePassword();
        }

        //false default select row
        private void data_staff_list_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (data_staff_list.SelectedCells.Count > 0)
            {
                data_staff_list.Rows[0].Selected = false;
            }
        }
    }
}
