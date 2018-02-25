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
    public partial class PurchaseOrderView : Form
    {
        int orderId;
        public PurchaseOrderView(int order_id)
        {
            this.orderId = order_id;
            InitializeComponent();

        }

        private void PurchaseOrderView_Load(object sender, EventArgs e)
        {
            lst_cart.View = View.Details;
            lst_cart.Columns.Add("#", 20, HorizontalAlignment.Left);
            lst_cart.Columns.Add("PID", 0, HorizontalAlignment.Left);
            lst_cart.Columns.Add("Title", 400, HorizontalAlignment.Left);
            lst_cart.Columns.Add("Unit Price", 120, HorizontalAlignment.Left);
            lst_cart.Columns.Add("Qantity", 90, HorizontalAlignment.Left);
            lst_cart.Columns.Add("Total", 120, HorizontalAlignment.Left);

            try
            {
                //Open DB Connection
                DB.connection.Open();

                //query get purchase order and supplier form database
                String sqlString = "SELECT purchases.id AS order_id, purchases.number AS order_number, purchases.total AS order_total, purchases.date AS order_date, purchases.stock AS stock_status, suppliers.company_name AS supplier_name, suppliers.address AS supplier_address, suppliers.telephone AS supplier_telephone FROM purchases JOIN suppliers ON purchases.supplier_id = suppliers.id WHERE purchases.id = @id";

                SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection);
                cmmnd.Parameters.Add("@id", SqlDbType.Int).Value = orderId;

                //sql data reader
                SqlDataReader rd = cmmnd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        PurchaseInvoice invoice = new PurchaseInvoice();

                        invoice.Id = Int32.Parse(rd["order_id"].ToString());
                        invoice.Number = rd["order_number"].ToString();
                        invoice.Total = double.Parse(rd["order_total"].ToString());

                        DateTime parsedDate;

                        if (DateTime.TryParse(rd["order_date"].ToString(), out parsedDate))
                        {
                            invoice.Date = parsedDate;
                        }

                        invoice.Name = rd["supplier_name"].ToString();
                        invoice.Address = rd["supplier_address"].ToString();
                        invoice.Telephone = rd["supplier_telephone"].ToString();

                        if (rd["stock_status"].ToString() == "1")
                        {
                            invoice.StockStatus = true;
                        }
                        else
                        {
                            invoice.StockStatus = false;
                        }

                        //set invoice data to form
                        lbl_orderNumber.Text = invoice.Number;
                        lbl_orderDate.Text = invoice.Date.ToString();

                        lbl_supplierName.Text = invoice.Name;
                        lbl_supplierAddress.Text = invoice.Address;
                        lbl_supplierTel.Text = invoice.Telephone;

                        lbl_orderTotal.Text = "Rs :"+invoice.Total.ToString();
                        lbl_orderSubTotal.Text = "Rs :" +invoice.Total.ToString();

                        if (invoice.StockStatus)
                        {
                            lbl_status.Text = "Received";
                            btn_received.Hide();
                        }
                        else
                        {
                            lbl_status.Text = "Pending";
                            btn_received.Show();
                        }

                    }
                }

                //query get purchase products
                String sqlString1 = "SELECT products.id, products.title, purchase_products.quantity, purchase_products.unit_price AS uprice FROM purchase_products LEFT JOIN products on purchase_products.product_id = products.id WHERE purchase_products.purchase_id = @id";

                SqlCommand cmmnd1 = new SqlCommand(sqlString1, DB.connection);
                cmmnd1.Parameters.Add("@id", SqlDbType.Int).Value = orderId;

                //sql data reader
                SqlDataReader rd1 = cmmnd1.ExecuteReader();
                
                if (rd1.HasRows)
                {
                    int i = 1;

                    while (rd1.Read())
                    {
                        ListViewItem lvi = new ListViewItem();

                        lvi.Text = Convert.ToString(i);

                        lvi.SubItems.Add(rd1["id"].ToString());

                        lvi.SubItems.Add(rd1["title"].ToString());

                        double price = Convert.ToDouble(rd1["uprice"].ToString());

                        lvi.SubItems.Add(price.ToString("c", CultureInfo.CreateSpecificCulture("si-LK")));
                        lvi.SubItems.Add(rd1["quantity"].ToString());

                        int quantity = Int32.Parse(rd1["quantity"].ToString());

                        double total = price * quantity;

                        lvi.SubItems.Add(total.ToString("c", CultureInfo.CreateSpecificCulture("si-LK")));

                        lst_cart.Items.Add(lvi);
                        i++;
                    }
                }

                rd.Close();
                
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

        private void btn_received_Click(object sender, EventArgs e)
        {
            try
            {
                //Open DB Connection
                DB.connection.Open();

                String sqlString;
                SqlCommand cmmnd;

                for (int i = 0; i < lst_cart.Items.Count; i++)
                {
                    //query string
                    sqlString = "UPDATE products SET quantity = quantity + @quantity WHERE id=@product;";

                    //sql command
                    cmmnd = new SqlCommand(sqlString, DB.connection);

                    //data binding
                    cmmnd.Parameters.Add("@product", SqlDbType.Int).Value = Int32.Parse(lst_cart.Items[i].SubItems[1].Text);
                    cmmnd.Parameters.Add("@quantity", SqlDbType.Int).Value = Int32.Parse(lst_cart.Items[i].SubItems[4].Text);

                    //Executing query
                    cmmnd.ExecuteScalar();
                }

                //query string
                sqlString = "UPDATE purchases SET stock = 1 WHERE id=@id";

                //sql command
                cmmnd = new SqlCommand(sqlString, DB.connection);

                //data binding
                cmmnd.Parameters.Add("@id", SqlDbType.Int).Value = orderId;

                //Executing query
                cmmnd.ExecuteScalar();

                MessageBox.Show("Product stock updated successful");
                lbl_status.Text = "Received";
                btn_received.Hide();

            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                DB.connection.Close();
            }
        }
    }
}
