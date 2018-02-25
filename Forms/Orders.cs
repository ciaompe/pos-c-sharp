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
    public partial class Orders : Form
    {
        //Creating a new invoice source
        BindingSource invoiceSource = new BindingSource();

        List<Invoice> orderList = new List<Invoice>();

        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            //sql select patient query
            String sqlString = "SELECT orders.id AS order_id, orders.number AS order_number, orders.total AS order_total, orders.date AS order_date, customers.name AS customer_name, customers.address AS customer_address, customers.telephone AS customer_telephone FROM orders JOIN customers ON orders.customer_id = customers.id";

            using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
            {
                try
                {
                    //Open DB Connection
                    DB.connection.Open();

                    //sql data reader
                    using (SqlDataReader rd = cmmnd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                Invoice invoice = new Invoice();

                                invoice.Id = Int32.Parse(rd["order_id"].ToString());
                                invoice.Number = rd["order_number"].ToString();
                                invoice.Total = double.Parse(rd["order_total"].ToString());

                                DateTime parsedDate;

                                if (DateTime.TryParse(rd["order_date"].ToString(), out parsedDate))
                                {
                                    invoice.Date = parsedDate;
                                }

                                invoice.Name = rd["customer_name"].ToString();
                                invoice.Address = rd["customer_address"].ToString();
                                invoice.Telephone = rd["customer_telephone"].ToString();

                                orderList.Add(invoice);
                            }

                            invoiceSource.DataSource = orderList;
                            data_order_list.DataSource = invoiceSource;

                            rd.Close();
                            data_order_list.Columns["number"].HeaderText = "Order Number";
                            data_order_list.Columns["name"].HeaderText = "Customer Name";
                            data_order_list.Columns["total"].DefaultCellStyle.Format = "c";
                            data_order_list.Columns["total"].DefaultCellStyle.FormatProvider = new CultureInfo("si-LK");
                            data_order_list.Columns["id"].Visible = false;
                        }
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

        private void data_order_list_Click(object sender, EventArgs e)
        {
            if (data_order_list.SelectedCells.Count > 0)
            {
                int selectedrowindex = data_order_list.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = data_order_list.Rows[selectedrowindex];

                int order_id = Int32.Parse(selectedRow.Cells["id"].Value.ToString());
                string order_number = selectedRow.Cells["number"].Value.ToString();
                string order_name = selectedRow.Cells["name"].Value.ToString();
                string order_address = selectedRow.Cells["address"].Value.ToString();
                string order_telephone = selectedRow.Cells["telephone"].Value.ToString();
                string order_date = selectedRow.Cells["date"].Value.ToString();
                string order_total = selectedRow.Cells["total"].Value.ToString();

                FormInvoice order_invoice = new FormInvoice(order_id, order_number, order_name, order_address, order_telephone, order_date, order_total);
                order_invoice.Show();
            }
        }

        private void txt_orderNumber_KeyDown(object sender, KeyEventArgs e)
        {
            BindingList<Invoice> filtered = new BindingList<Invoice>(orderList.Where(obj => obj.Number.Contains(txt_orderNumber.Text)).ToList());

            data_order_list.DataSource = filtered;
            data_order_list.Update();
        }

        private void txt_customerTel_KeyDown(object sender, KeyEventArgs e)
        {
            BindingList<Invoice> filtered = new BindingList<Invoice>(orderList.Where(obj => obj.Telephone.Contains(txt_customerTel.Text)).ToList());

            data_order_list.DataSource = filtered;
            data_order_list.Update();
        }
    }
}
