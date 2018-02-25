using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//Sql Client
using System.Data.SqlClient;


namespace zeus.Classess
{
    class User
    {
        protected int id;
        protected string name;
        protected string username;
        protected string password;
        protected string userType;

        private string error;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string Type
        {
            get
            {
                return userType;
            }
            set
            {
                userType = value;
            }
        }

        //user validation
        public bool validate(string currentUsername = null, bool edit = false)
        {
            if (Name == "")
            {
                error = "Pleas Enter Staff Member Full Name";
                return false;
            }
            else if (Username == "")
            {
                error = "Pleas Enter Staff Member Username";
                return false;
            }
            else if(Password == "" && edit == false)
            {
                error = "Pleas Enter a Password";
                return false;
            }
            else if (string.IsNullOrEmpty(Type))
            {
                error = "Pleas select Staff Member Type";
                return false;
            }
            else if (this.usernameExists(Username, currentUsername))
            {
                error = "Username aleready exists";
                return false;
            }

            return true;
        }
        //username exists
        private bool usernameExists(string username, string currentUsername)
        {
            bool exists = false;

            if (username == currentUsername)
            {
                return false;
            }

            String sqlString = "SELECT * FROM users WHERE username=@username";

            using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
            {
                cmmnd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;

                try
                {
                    DB.connection.Open();

                    using (SqlDataReader rd = cmmnd.ExecuteReader())
                    {

                        if (rd.HasRows)
                        {
                            exists = true;
                        }

                        rd.Close();
                    }
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

            return exists;
        }
        //get error messages
        public string getError()
        {
            return error;
        }
    }
}
