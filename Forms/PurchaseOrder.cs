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
    public partial class PurchaseOrder : Form
    {
        //Creating a new product source
        BindingSource productSource = new BindingSource();

        //Create new Product List
        List<Product> productList = new List<Product>();

        //product
        Product product;

        //order total
        double total = 0;

        //supplier id
        int supplier_id = 0;

        public PurchaseOrder()
        {
            InitializeComponent();
        }

        //purchase order load
        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            lst_suppliers.View = View.Details;

            lst_suppliers.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lst_suppliers.Columns.Add("Company Name", 310, HorizontalAlignment.Left);

            lst_cart.View = View.Details;

            lst_cart.Columns.Add("PID", 50, HorizontalAlignment.Left);
            lst_cart.Columns.Add("Title", 250, HorizontalAlignment.Left);
            lst_cart.Columns.Add("Price", 90, HorizontalAlignment.Left);
            lst_cart.Columns.Add("", 0, HorizontalAlignment.Left);
            lst_cart.Columns.Add("Qantity", 90, HorizontalAlignment.Left);

            try
            {
                //Open DB Connection
                DB.connection.Open();

                String sqlString = "SELECT * FROM products";
                SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection);

                //sql data reader
                using (SqlDataReader rd = cmmnd.ExecuteReader())
                {
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            //get product
                            Product product = new Product();

                            product.Id = Convert.ToInt32(rd["id"]);
                            product.Title = rd["title"].ToString();
                            product.Code = rd["code"].ToString();
                            product.Description = rd["description"].ToString();
                            product.Price = Convert.ToDouble(rd["price"]);
                            product.Quantity = Convert.ToInt32(rd["quantity"]);

                            productList.Add(product);

                        }

                        productSource.DataSource = productList;
                        data_product_list.DataSource = productSource;

                        data_product_list.Columns["price"].DefaultCellStyle.Format = "c";
                        data_product_list.Columns["price"].DefaultCellStyle.FormatProvider = new CultureInfo("si-LK");
                    }

                    rd.Close();
                }

                String sqlString1 = "SELECT * FROM suppliers";
                SqlCommand cmmnd1 = new SqlCommand(sqlString1, DB.connection);

                //sql data reader
                using (SqlDataReader rd = cmmnd1.ExecuteReader())
                {
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            //get supplier
                            ListViewItem sItem = new ListViewItem();

                            sItem.Text = rd["id"].ToString();
                            sItem.Name = rd["id"].ToString();
                            sItem.SubItems.Add(rd["company_name"].ToString());

                            lst_suppliers.Items.Add(sItem);

                        }
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
        //click on the suplliers list
        private void lst_suppliers_Click(object sender, EventArgs e)
        {
            if (lst_suppliers.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lst_suppliers.SelectedItems.Count; i++)
                {
                    supplier_id = Convert.ToInt32(lst_suppliers.SelectedItems[i].Text);
                   
                }
                MessageBox.Show("Supplier Seleted");

            }
        }
        //click on the product list
        private void data_product_list_Click(object sender, EventArgs e)
        {
            if (data_product_list.SelectedCells.Count > 0)
            {
                int selectedrowindex = data_product_list.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = data_product_list.Rows[selectedrowindex];

                product = new Product();

                product.Id = Int32.Parse(Convert.ToString(selectedRow.Cells["id"].Value));
                product.Title = Convert.ToString(selectedRow.Cells["title"].Value);
                product.Description = Convert.ToString(selectedRow.Cells["description"].Value);
                product.Price = double.Parse(Convert.ToString(selectedRow.Cells["price"].Value));
                product.Quantity = Int32.Parse(Convert.ToString(selectedRow.Cells["quantity"].Value));

                lbl_cart_pid.Text = Convert.ToString(selectedRow.Cells["id"].Value);
                lbl_cart_ptitle.Text = Convert.ToString(selectedRow.Cells["title"].Value);
                lbl_cart_pprice.Text = Convert.ToString(selectedRow.Cells["price"].Value);
                
            }
        }
        //after databinding completed remove pre seleted item
        private void data_product_list_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (data_product_list.SelectedCells.Count > 0)
            {
                data_product_list.Rows[0].Selected = false;
            }
        }
        //product title search text box key down
        private void txt_productTitle_KeyDown(object sender, KeyEventArgs e)
        {
            BindingList<Product> filtered = new BindingList<Product>(productList.Where(obj => obj.Title.Contains(txt_productTitle.Text)).ToList());

            data_product_list.DataSource = filtered;
            data_product_list.Update();
        }
        //product code search text box key down
        private void txt_productCode_KeyDown(object sender, KeyEventArgs e)
        {
            BindingList<Product> filtered = new BindingList<Product>(productList.Where(obj => obj.Code.Contains(txt_productCode.Text)).ToList());

            data_product_list.DataSource = filtered;
            data_product_list.Update();
        }
        //add to cart button
        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            int quantity = Int32.Parse(txt_cart_pquantity.Text);

            if (product == null)
            {
                MessageBox.Show("Please select a product in the product list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lst_cart.Items.ContainsKey(Convert.ToString(product.Id)))
            {
                MessageBox.Show("Product is already in the cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (quantity > product.Quantity)
            {
                MessageBox.Show("The quantity must be below or equal to the product quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addToCart(product, quantity);
                product = null;

                lbl_cart_pid.Text = "";
                lbl_cart_ptitle.Text = "";
                lbl_cart_pprice.Text = "";
                txt_cart_pquantity.Text = "1";
            }
        }
        //add to cart process 
        private void addToCart(Product product, int quantity)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.Text = Convert.ToString(product.Id);

            lvi.Name = Convert.ToString(product.Id);

            lvi.SubItems.Add(product.Title);
            lvi.SubItems.Add(product.Price.ToString("c", new CultureInfo("si-LK")));
            lvi.SubItems.Add(product.Price.ToString());
            lvi.SubItems.Add(Convert.ToString(quantity));

            double productTotal = product.Price * quantity;
            total = total + productTotal;

            lst_cart.Items.Add(lvi);

            this.updateTotal(total);

        }
        //updating global total variable and labels
        private void updateTotal(double total)
        {
            lbl_cart_total.Text = total.ToString("c", CultureInfo.CreateSpecificCulture("si-LK"));
            lbl_cart_subtotal.Text = total.ToString("c", CultureInfo.CreateSpecificCulture("si-LK"));
        }
        //remove item in the shopping cart
        private void btn_removeCartItem_Click(object sender, EventArgs e)
        {
            if (lst_cart.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show("Are you sure wanto delete item in the cart", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    for (int i = lst_cart.Items.Count - 1; i >= 0; i--)
                    {
                        ListViewItem cartItem = lst_cart.Items[i];

                        if (cartItem.Selected)
                        {

                            double productTotal = Convert.ToDouble(lst_cart.Items[i].SubItems[3].Text) * Int32.Parse(lst_cart.Items[i].SubItems[4].Text);
                            total = total - productTotal;

                            this.updateTotal(total);

                            lst_cart.Items[i].Remove();

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item in the cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //clear cart
        private void btn_clearCart_Click(object sender, EventArgs e)
        {
            lst_cart.Items.Clear();
            total = 0;
            this.updateTotal(0);
        }
        //new purchase order
        private void btn_order_Click(object sender, EventArgs e)
        {
            if (supplier_id == 0)
            {
                MessageBox.Show("Please select a supplier in the supplier list then continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lst_cart.Items.Count == 0)
            {
                MessageBox.Show("Without adding products to the cart you cannot place an purchase order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else{

                DateTime order_date = Convert.ToDateTime(txt_order_date.Text);

                try
                {
                    //set stock status
                    bool stockStatus = false;

                    if(cb_stock_recived.Checked)
                    {
                        stockStatus = true;
                    }

                    //Open DB Connection
                    DB.connection.Open();

                    //Insert Order

                    //1st query string
                    String sqlString = "INSERT into purchases(number, date, total, supplier_id, stock) OUTPUT INSERTED.ID VALUES (@number, @date, @total, @supplier, @stockStatus)";

                    //1st sql command
                    SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection);

                    //create a new purchase order
                    Classess.PurchaseOrder order = new Classess.PurchaseOrder();

                    //1st data binding
                    cmmnd.Parameters.Add("@number", SqlDbType.VarChar).Value = order.generateOrderNumber();
                    cmmnd.Parameters.Add("@date", SqlDbType.DateTime).Value = order_date;
                    cmmnd.Parameters.Add("@total", SqlDbType.Float).Value = total;
                    cmmnd.Parameters.Add("@supplier", SqlDbType.Int).Value = supplier_id;
                    cmmnd.Parameters.Add("@stockStatus", SqlDbType.TinyInt).Value = stockStatus;

                    //Executing 1st SQL Query
                    int order_id = (Int32)cmmnd.ExecuteScalar();


                    //Insert order products and update product quantity

                    for (int i = 0; i < lst_cart.Items.Count; i++)
                    {
                        //2nd query string
                        String sqlString2 = "INSERT into purchase_products(purchase_id, product_id, unit_price, quantity) VALUES (@order, @product, @unitprice, @quantity);";

                        if (stockStatus)
                        {
                            sqlString2 = sqlString2 + "UPDATE products SET quantity = quantity + @quantity WHERE id=@product;";
                        }

                        //2nd sql command
                        SqlCommand cmmnd2 = new SqlCommand(sqlString2, DB.connection);

                        //2nd data binding
                        cmmnd2.Parameters.Add("@order", SqlDbType.Int).Value = order_id;
                        cmmnd2.Parameters.Add("@product", SqlDbType.Int).Value = Int32.Parse(lst_cart.Items[i].SubItems[0].Text);
                        cmmnd2.Parameters.Add("@unitprice", SqlDbType.Float).Value = Convert.ToDouble(lst_cart.Items[i].SubItems[3].Text);
                        cmmnd2.Parameters.Add("@quantity", SqlDbType.Int).Value = Int32.Parse(lst_cart.Items[i].SubItems[4].Text);

                        //Executing 2nd SQL Query
                        cmmnd2.ExecuteScalar();
                    }

                    MessageBox.Show("Purchase Order Placed Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    DB.connection.Close();

                    this.Close();

                    PurchaseOrders pos = new PurchaseOrders();
                    pos.Show();
                }
            }
        }
    }
}
