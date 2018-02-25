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
    public partial class Customers : Form
    {
        private int? customerId;
        private int gridIndex;
        private string currentTel;

        //Create new Customer List
        List<Classess.Customer> customerList = new List<Classess.Customer>();

        //Create new Binding source
        BindingSource source = new BindingSource();

        public Customers()
        {
            InitializeComponent();
        }

        //load all customers
        private void Customers_Load(object sender, EventArgs e)
        {
            //sql select query
            String sqlString = "SELECT * FROM customers ORDER BY id DESC";

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
                                Customer customer = new Customer();

                                customer.Id = Convert.ToInt32(rd["id"]);
                                customer.Name = rd["name"].ToString();
                                customer.Address = rd["address"].ToString();
                                customer.Telephone = rd["telephone"].ToString();

                                customerList.Add(customer);
                            }

                            source.DataSource = customerList;
                            data_customer_list.DataSource = source;
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

        //add customer
        private void btn_add_Click(object sender, EventArgs e)
        {
            customerId = 0;

            Customer customer = new Customer();

            customer.Id = (int)customerId;
            customer.Name = txt_name.Text;
            customer.Address = txt_address.Text;
            customer.Telephone = txt_telephone.Text;

            if (customer.validate())
            {
                String sqlString = "INSERT into customers (name, address, telephone) OUTPUT INSERTED.ID VALUES (@name , @address, @telephone)";

                using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
                {

                    cmmnd.Parameters.Add("@name", SqlDbType.VarChar).Value = customer.Name;
                    cmmnd.Parameters.Add("@address", SqlDbType.Text).Value = customer.Address;
                    cmmnd.Parameters.Add("@telephone", SqlDbType.VarChar).Value = customer.Telephone;

                    try
                    {
                        DB.connection.Open();

                        customerId = (Int32)cmmnd.ExecuteScalar();

                        customer.Id = Convert.ToInt32(customerId);

                        customerList.Add(customer);

                        source.DataSource = customerList;

                        data_customer_list.DataSource = null;
                        data_customer_list.DataSource = source;

                        MessageBox.Show("Customer addedd successful");

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
                MessageBox.Show(customer.getError());
            }
        }
        //edit customer
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (customerId.HasValue && customerId.Value > 0)
            {
                Customer customer = new Customer();

                customer.Id = (int)customerId;
                customer.Name = txt_name.Text;
                customer.Address = txt_address.Text;
                customer.Telephone = txt_telephone.Text;

                //Datagrid Selected row
                DataGridViewRow selectedRow = data_customer_list.Rows[gridIndex];

                if (customer.validate(currentTel))
                {

                    String sqlString = "UPDATE customers SET name=@name, address=@address, telephone=@telephone WHERE id=@id";

                    using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
                    {

                        //sql bind param list
                        cmmnd.Parameters.Add("@name", SqlDbType.VarChar).Value = customer.Name;
                        cmmnd.Parameters.Add("@address", SqlDbType.Text).Value = customer.Address;
                        cmmnd.Parameters.Add("@telephone", SqlDbType.VarChar).Value = customer.Telephone;

                        cmmnd.Parameters.Add("@id", SqlDbType.Int).Value = customerId;

                        try
                        {
                            //Open DB Connection
                            DB.connection.Open();
                            //Executing SQL Query
                            cmmnd.ExecuteNonQuery();

                            //Updating patient row data
                            selectedRow.Cells["name"].Value = customer.Name;
                            selectedRow.Cells["address"].Value = customer.Address;
                            selectedRow.Cells["telephone"].Value = customer.Telephone;

                            customerId = 0;

                            MessageBox.Show("Customer Updated successful");

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
                    MessageBox.Show(customer.getError());
                }

            } else
            {
                MessageBox.Show("Please select a customer to edit");
            }
        }
        //delete customer
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(!LoginInfo.admin())
            {
                MessageBox.Show("Permission Denied");
                this.Close();
            }

            if (customerId.HasValue && customerId.Value > 0)
            {
                DialogResult dialogResult = MessageBox.Show("If you delete this customer, you cannot recover data again", "Are you Sure ?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                    String sqlString = "DELETE FROM customers WHERE id=@id";

                    using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
                    {

                        cmmnd.Parameters.Add("@id", SqlDbType.Int).Value = customerId;

                        try
                        {
                            //Open DB Connection
                            DB.connection.Open();
                            //Executing SQL Query
                            cmmnd.ExecuteNonQuery();

                            data_customer_list.Rows.RemoveAt(gridIndex);

                            customerId = 0;

                            MessageBox.Show("Customer Deleted successful");
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

            } else
            {
                MessageBox.Show("Please select a customer to delete");
            }
            
        }
        //clear form
        private void btn_clear_Click(object sender, EventArgs e)
        {
            customerId = 0;
            Clear.ClearFormFields(this);
        }

        //data  grid view
        private void data_customer_list_Click(object sender, EventArgs e)
        {
            if (data_customer_list.SelectedCells.Count > 0)
            {
                int selectedrowindex = data_customer_list.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = data_customer_list.Rows[selectedrowindex];

                this.gridIndex = selectedrowindex;
                this.customerId = Int32.Parse(Convert.ToString(selectedRow.Cells["id"].Value));
                this.currentTel = Convert.ToString(selectedRow.Cells["telephone"].Value);

                txt_name.Text = Convert.ToString(selectedRow.Cells["name"].Value);
                txt_address.Text = Convert.ToString(selectedRow.Cells["address"].Value);
                txt_telephone.Text = currentTel;
            }
        }
        private void txt_customerTel_KeyDown(object sender, KeyEventArgs e)
        {
            BindingList<Classess.Customer> filtered = new BindingList<Classess.Customer>(customerList.Where(obj => obj.Telephone.Contains(txt_customerTel.Text)).ToList());

            data_customer_list.DataSource = filtered;
            data_customer_list.Update();
        }
        private void txt_customerName_KeyDown(object sender, KeyEventArgs e)
        {
            BindingList<Classess.Customer> filtered = new BindingList<Classess.Customer>(customerList.Where(obj => obj.Name.Contains(txt_customerName.Text)).ToList());

            data_customer_list.DataSource = filtered;
            data_customer_list.Update();
        }
        private void data_customer_list_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (data_customer_list.SelectedCells.Count > 0)
            {
                data_customer_list.Rows[0].Selected = false;
            }
        }
    }
}
