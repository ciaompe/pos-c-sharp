using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace zeus.Classess
{
    class Order
    {
        private int id;
        private DateTime date;
        private double total;
        private string number;

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
        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public virtual string generateOrderNumber()
        {
            Random generator = new Random();
            String r = generator.Next(0, 100000).ToString("D6");

            return r;
        }

    }
}
