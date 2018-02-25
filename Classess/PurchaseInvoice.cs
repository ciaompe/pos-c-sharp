using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zeus.Classess
{
    class PurchaseInvoice : Invoice
    {
        private bool stockStatus;

        public bool StockStatus
        {
            get
            {
                return stockStatus;
            }
            set
            {
                stockStatus = value;
            }
        }
    }
}
