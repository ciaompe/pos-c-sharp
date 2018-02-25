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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txt_newPassword.Text;
            string currentPassword = txt_currentPassword.Text;

            string password = PasswordHash.encodePassword(newPassword);
            String sqlString = "UPDATE users SET password=@password WHERE id=@id";

            if (newPassword == "")
            {
                MessageBox.Show("New Passowrd is required");
            }
            else if (currentPassword == "")
            {
                MessageBox.Show("Current Passowrd is required");
            }
            else if (!PasswordHash.passwordMatch(currentPassword, LoginInfo.Password))
            {
                MessageBox.Show("Current Passowrd is invalid");
            }
            else
            {
                newPassword = PasswordHash.encodePassword(newPassword);

                using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
                {
                    //sql bind param list
                    cmmnd.Parameters.Add("@password", SqlDbType.VarChar).Value = newPassword;
                    cmmnd.Parameters.Add("@id", SqlDbType.Int).Value = LoginInfo.Id;

                    try
                    {
                        //Open DB Connection
                        DB.connection.Open();
                        //Executing SQL Query
                        cmmnd.ExecuteNonQuery();

                        MessageBox.Show("Passowrd change successful");

                        this.Close();

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
    }
}
