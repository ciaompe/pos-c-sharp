using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sql Client
using System.Data.SqlClient;
using System.Data;

namespace zeus.Classess
{
    class Supplier
    {
        private int id;
        private string compayName;
        private string address;
        private string telephone;

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
        public string CompanyName
        {
            get
            {
                return compayName;
            }
            set
            {
                compayName = value;
            }
        }
        public string Address
        {

            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string Telephone
        {

            get
            {
                return telephone;
            }
            set
            {
                telephone = value;
            }
        }

        //customer validation
        public bool validate(string currentTel = null)
        {
            if (CompanyName == "")
            {
                error = "Pleas Enter Company Name";
                return false;
            }
            else if (Address == "")
            {
                error = "Pleas Enter Company Address";
                return false;
            }
            else if (Telephone == "")
            {
                error = "Pleas Enter Company Telephone number";
                return false;
            }
            else if (this.phoneExists(Telephone, currentTel))
            {
                error = "Phone number aleready exists";
                return false;
            }

            return true;
        }

        //customer phone exists
        private bool phoneExists(string phone, string currentTel)
        {
            bool exists = false;

            if (phone == currentTel)
            {
                return false;
            }

            String sqlString = "SELECT * FROM suppliers WHERE telephone=@phone";

            using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
            {
                cmmnd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;

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
