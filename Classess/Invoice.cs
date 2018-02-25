using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zeus.Classess
{
    class Invoice : Order
    {

        private string name;
        private string address;
        private string telephone;

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
    }
}
