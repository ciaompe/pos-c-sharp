using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zeus.Classess
{
    class POrder : Order
    {
        public override string generateOrderNumber()
        {
            Random generator = new Random();
            String r = generator.Next(100000, 999999).ToString("D6");

            return r;
        }
    }
}
