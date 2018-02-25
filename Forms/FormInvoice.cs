using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Sql Client
using System.Data.SqlClient;

using zeus.Classess;
using System.Globalization;

namespace zeus.Forms
{
    public partial class FormInvoice : Form
    {
        private int order_id;

        public FormInvoice(int orderid, string order_number, string order_name, string order_address, string order_telephone, string order_date, string order_total)
        {
            InitializeComponent();

            this.order_id = orderid;

            lbl_orderNumber.Text = order_number;
            lbl_orderDate.Text = order_date;
            lbl_customerName.Text = order_name;
            lbl_customerAddress.Text = order_address;
            lbl_customerTel.Text = order_telephone;
            lbl_orderTotal.Text = order_total;
            lbl_orderSubTotal.Text = order_total;
        }

        private void invoice_Load(object sender, EventArgs e)
        {
            lst_cart.View = View.Details;
            lst_cart.Columns.Add("#", 20, HorizontalAlignment.Left);
            lst_cart.Columns.Add("Title", 400, HorizontalAlignment.Left);
            lst_cart.Columns.Add("Unit Price", 120, HorizontalAlignment.Left);
            lst_cart.Columns.Add("Qantity", 90, HorizontalAlignment.Left);
            lst_cart.Columns.Add("Total", 120, HorizontalAlignment.Left);

            try
            {
                //Open DB Connection
                DB.connection.Open();

                //sql select query
                String sqlString = "SELECT products.title, order_products.quantity, order_products.unit_price AS uprice FROM order_products LEFT JOIN products on order_products.product_id = products.id WHERE order_products.order_id = @id";

                SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection);
                cmmnd.Parameters.Add("@id", SqlDbType.Int).Value = order_id;

                //sql data reader
                using (SqlDataReader rd = cmmnd.ExecuteReader())
                {
                    if (rd.HasRows)
                    {
                        int i = 1;
                        while (rd.Read())
                        {
                            ListViewItem lvi = new ListViewItem();

                            lvi.Text = Convert.ToString(i);

                            lvi.SubItems.Add(rd["title"].ToString());

                            double price = Convert.ToDouble(rd["uprice"].ToString());

                            lvi.SubItems.Add(price.ToString("c", CultureInfo.CreateSpecificCulture("si-LK")));
                            lvi.SubItems.Add(rd["quantity"].ToString());


                            int quantity = Int32.Parse(rd["quantity"].ToString());

                            double total = price * quantity;

                            lvi.SubItems.Add(total.ToString("c", CultureInfo.CreateSpecificCulture("si-LK")));

                            lst_cart.Items.Add(lvi);
                            i++;
                        }
                    }

                    rd.Close();
                }


            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                //Close DB Connection
                DB.connection.Close();
            }

        }
    }
}
