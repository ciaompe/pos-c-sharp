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
    public partial class Login : Form
    {

        public Login()
        {
            //string password = PasswordHash.encodePassword("12345");
            //throw new Exception(password);
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            //checking all field are empty or not

            if (username == "")
            {
                MessageBox.Show("Type a username");
            }
            else if (password == "")
            {
                MessageBox.Show("Type a Password");
            }
            else
            {

                //sql select user query
                String sqlString = "SELECT * FROM users WHERE username=@username AND password=@password";

                using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
                {

                    //sql bind param list (username, password)
                    cmmnd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                    cmmnd.Parameters.Add("@password", SqlDbType.VarChar).Value = PasswordHash.encodePassword(password);

                    try
                    {

                        //Open DB Connection
                        DB.connection.Open();

                        //sql command eka reader
                        using (SqlDataReader rd = cmmnd.ExecuteReader())
                        {
                            //if username and password matched, do this
                            if (rd.HasRows)
                            {
    
                                while (rd.Read())
                                {
                                    //set id property
                                    LoginInfo.Id = Convert.ToInt32(rd["id"]);
                                    //set username property
                                    LoginInfo.Username = rd["username"].ToString();
                                    //set passsword hash property
                                    LoginInfo.Password = rd["password"].ToString();

                                    //set usertype property
                                    LoginInfo.Type = rd["type"].ToString();

                                }

                                this.Hide();

                                Main homeForm = new Main();
                                homeForm.Show();


                                rd.Close();
                            }
                            else
                            {
                                MessageBox.Show("Authentication Faild");
                            }
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

        }
    }
}
