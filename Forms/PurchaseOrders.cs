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
    public partial class PurchaseOrders : Form
    {
        //Creating a new invoice source
        BindingSource invoiceSource = new BindingSource();

        List<Classess.PurchaseOrder> orderList = new List<Classess.PurchaseOrder>();

        public PurchaseOrders()
        {
            InitializeComponent();
        }

        private void PurchaseOrders_Load(object sender, EventArgs e)
        {
            //sql select patient query
            String sqlString = "SELECT * FROM purchases ORDER BY id DESC";

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
                                Classess.PurchaseOrder order = new Classess.PurchaseOrder();

                                order.Id = Int32.Parse(rd["id"].ToString());
                                order.Number = rd["number"].ToString();
                                order.Total = double.Parse(rd["total"].ToString());

                                DateTime parsedDate;

                                if (DateTime.TryParse(rd["date"].ToString(), out parsedDate))
                                {
                                    order.Date = parsedDate;
                                }

                                if (rd["stock"].ToString() == "1") {
                                    order.StockStatus = true;
                                } else
                                {
                                    order.StockStatus = false;
                                }

                                orderList.Add(order);
                            }

                            invoiceSource.DataSource = orderList;
                            data_order_list.DataSource = invoiceSource;

                            rd.Close();

                            data_order_list.Columns["number"].HeaderText = "Purchase Order Number";
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

        private void txt_orderNumber_KeyDown(object sender, KeyEventArgs e)
        {
            BindingList<Classess.PurchaseOrder> filtered = new BindingList<Classess.PurchaseOrder>(orderList.Where(obj => obj.Number.Contains(txt_orderNumber.Text)).ToList());

            data_order_list.DataSource = filtered;
            data_order_list.Update();
        }

        private void data_order_list_Click(object sender, EventArgs e)
        {
            if (data_order_list.SelectedCells.Count > 0)
            {
                int selectedrowindex = data_order_list.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = data_order_list.Rows[selectedrowindex];

                int order_id = Int32.Parse(selectedRow.Cells["id"].Value.ToString());

                PurchaseOrderView po_view = new PurchaseOrderView(order_id);
                po_view.Show();
            }
        }
    }
}
