using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace zeus.Classess
{
    class DB
    {
        public static SqlConnection connection;

        public static void connect(string type, string cstr)
        {
            if(type == "sql")
            {
                sql(cstr);
            }
        }

        public static void sql(string cstr)
        {
            try
            {
                connection = new SqlConnection(cstr);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
         }

    }
}
