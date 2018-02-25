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
    class Product
    {
        private int id;
        private string title;
        private string code;
        private string description;
        private double price;
        private int quantity;

        public int Id
        {
            get {

                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
    }
}
