using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zeus.Classess
{
    static class LoginInfo
    {
        public static int _id;
        public static string _username;
        public static string _password;
        public static string _userType;

        public static int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        public static string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        public static string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public static string Type
        {
            get
            {
                return _userType;
            }
            set
            {
                _userType = value;
            }
        }

        //check permission
        public static bool admin()
        {
            if (Type == "admin")
            {
                return true;
            }

            return false;
        }
        public static bool salesOfficer()
        {
            if (Type == "sales-officer")
            {
                return true;
            }

            return false;
        }
        public static bool issueOfficer()
        {
            if(Type == "issue-officer")
            {
                return true;
            }
            return false;
        }
    }
}
