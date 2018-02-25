using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using zeus.Classess;

namespace zeus.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if(!LoginInfo.admin())
            {
                menu_staff.Enabled = false;
            }

            if (!LoginInfo.admin() && !LoginInfo.salesOfficer())
            {
                menu_customers.Enabled = false;
                menu_prdoucts.Enabled = false;
                menu_createOrder.Enabled = false;
            }

            menu_myaccount.Text = "! Welcome " + LoginInfo.Username;
        }

        private void menu_customers_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            
        }

        private void menu_prdoucts_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void menu_allOrders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
        }

        private void menu_createOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void menu_suppliers_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.Show();
        }

        private void menu_changePassword_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void menu_addPurchaseOrder_Click(object sender, EventArgs e)
        {
            PurchaseOrder po = new PurchaseOrder();
            po.Show();
        }

        private void menu_allPurchaseOrders_Click(object sender, EventArgs e)
        {
            PurchaseOrders pos = new PurchaseOrders();
            pos.Show();
        }

        private void menu_staff_Click(object sender, EventArgs e)
        {
            ManageStaff staff = new ManageStaff();
            staff.Show();
        }
    }
}
