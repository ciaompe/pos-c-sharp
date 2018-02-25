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
    public partial class Order : Form
    {
        
        //Creating a new product source
        BindingSource productSource = new BindingSource();

        //Create new Product List
        List<Product> productList = new List<Product>();

        //Creating a new customer source
        BindingSource customerSource = new BindingSource();

        //Create new Customer List
        List<Customer> customerList = new List<Customer>();

        //customer
        Customer customer;

        //product
        Product product;

        //order total
        double total = 0;

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            data_customer_list.Visible = false;

            lst_cart.View = View.Details;

            lst_cart.Columns.Add("PID", 50, HorizontalAlignment.Left);
            lst_cart.Columns.Add("Title", 250, HorizontalAlignment.Left);
            lst_cart.Columns.Add("Price", 90, HorizontalAlignment.Left);
            lst_cart.Columns.Add("", 0, HorizontalAlignment.Left);
            lst_cart.Columns.Add("Qantity", 90, HorizontalAlignment.Left);

            String sqlString = "SELECT * FROM products";

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

        //search product
        private void txt_productTitle_KeyDown(object sender, KeyEventArgs e)
        {
            BindingList<Product> filtered = new BindingList<Product>(productList.Where(obj => obj.Title.Contains(txt_productTitle.Text)).ToList());

            data_product_list.DataSource = filtered;
            data_product_list.Update();
        }

        private void txt_productCode_KeyDown(object sender, KeyEventArgs e)
        {
            BindingList<Product> filtered = new BindingList<Product>(productList.Where(obj => obj.Code.Contains(txt_productCode.Text)).ToList());

            data_product_list.DataSource = filtered;
            data_product_list.Update();
        }

        //open customers
        private void btn_customer_Click(object sender, EventArgs e)
        {
            grp_orderInfo.Visible = false;
            data_customer_list.Visible = true;

            //sql select query
            String sqlString = "SELECT * FROM customers";

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
                                Customer customer = new Customer();

                                customer.Id = Convert.ToInt32(rd["id"]);
                                customer.Name = rd["name"].ToString();
                                customer.Address = rd["address"].ToString();
                                customer.Telephone = rd["telephone"].ToString();

                                customerList.Add(customer);
                            }

                            customerSource.DataSource = customerList;
                            data_customer_list.DataSource = customerSource;

                            data_customer_list.Columns[2].Visible = false;
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

        //click on customer list
        private void data_customer_list_Click(object sender, EventArgs e)
        {
            //check if clicked on customer list row 
            if (data_customer_list.SelectedCells.Count > 0)
            {
                //hid customer list for the user
                data_customer_list.Visible = false;
                //get seleted row index
                int selectedrowindex = data_customer_list.SelectedCells[0].RowIndex;
                //get seleted row
                DataGridViewRow selectedRow = data_customer_list.Rows[selectedrowindex];
                //creating a new customer object
                customer = new Customer();
                //set customer object properties
                this.customer.Id = Int32.Parse(Convert.ToString(selectedRow.Cells["id"].Value));
                this.customer.Name = Convert.ToString(selectedRow.Cells["name"].Value);
                this.customer.Address = Convert.ToString(selectedRow.Cells["address"].Value);
                this.customer.Telephone = Convert.ToString(selectedRow.Cells["telephone"].Value);

                //assign customer values into the order info form
                txt_name.Text = this.customer.Name;
                txt_address.Text = this.customer.Address;
                txt_telephone.Text = this.customer.Telephone;

                //displaying order info form 
                grp_orderInfo.Visible = true;
            }
           


        }

        //click on product list
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

                //check if product contains 0 qantity
                if(product.Quantity == 0)
                {
                    MessageBox.Show("Cannot order product contains '0' quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    lbl_cart_pid.Text = Convert.ToString(selectedRow.Cells["id"].Value);
                    lbl_cart_ptitle.Text = Convert.ToString(selectedRow.Cells["title"].Value);
                    lbl_cart_pprice.Text = Convert.ToString(selectedRow.Cells["price"].Value);
                }

            }
        }

        //add to cart click
        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            int quantity = Int32.Parse(txt_cart_pquantity.Text);

            if(product == null)
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

            double productTotal =  product.Price * quantity;
            total = total + productTotal;

            lst_cart.Items.Add(lvi);

            this.updateTotal(total);

        }

        //clear cart
        private void btn_clearCart_Click(object sender, EventArgs e)
        {
            lst_cart.Items.Clear();
            total = 0;
            this.updateTotal(0);
        }

        //update total
        private void updateTotal(double total)
        {
            lbl_cart_total.Text = total.ToString("c", CultureInfo.CreateSpecificCulture("si-LK"));
            lbl_cart_subtotal.Text = total.ToString("c", CultureInfo.CreateSpecificCulture("si-LK"));
        }

        //remove item from cart
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

        //place an order
        private void btn_order_Click(object sender, EventArgs e)
        {
            if (customer == null)
            {
                MessageBox.Show("Without selecting a customer you cannot place an order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (lst_cart.Items.Count == 0)
            {
                MessageBox.Show("Without adding products to the cart you cannot place an order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime order_date = Convert.ToDateTime(txt_order_date.Text);

                try
                {
                    //Open DB Connection
                    DB.connection.Open();

                    //Insert Order

                    //1st query string
                    String sqlString = "INSERT into orders(number, date, total, customer_id) OUTPUT INSERTED.ID VALUES (@number, @date, @total, @customer)";

                    //1st sql command
                    SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection);

                    zeus.Classess.Order order = new zeus.Classess.Order();

                    //1st data binding
                    cmmnd.Parameters.Add("@number", SqlDbType.VarChar).Value = order.generateOrderNumber();
                    cmmnd.Parameters.Add("@date", SqlDbType.DateTime).Value = order_date;
                    cmmnd.Parameters.Add("@total", SqlDbType.Float).Value = total;
                    cmmnd.Parameters.Add("@customer", SqlDbType.Int).Value = customer.Id;

                    //Executing 1st SQL Query
                    int order_id = (Int32)cmmnd.ExecuteScalar();


                    //Insert order products and update product quantity

                    for (int i = 0; i < lst_cart.Items.Count; i++)
                    {
                        //2nd query string
                        String sqlString2 = "INSERT into order_products(order_id, product_id, unit_price, quantity) VALUES (@order, @product, @unitprice, @quantity); UPDATE products SET quantity = quantity - @quantity WHERE id=@product";

                        //2nd sql command
                        SqlCommand cmmnd2= new SqlCommand(sqlString2, DB.connection);

                        //2nd data binding
                        cmmnd2.Parameters.Add("@order", SqlDbType.Int).Value = order_id;
                        cmmnd2.Parameters.Add("@product", SqlDbType.Int).Value = Int32.Parse(lst_cart.Items[i].SubItems[0].Text);
                        cmmnd2.Parameters.Add("@unitprice", SqlDbType.Float).Value = Convert.ToDouble(lst_cart.Items[i].SubItems[3].Text);
                        cmmnd2.Parameters.Add("@quantity", SqlDbType.Int).Value = Int32.Parse(lst_cart.Items[i].SubItems[4].Text);

                        //Executing 2nd SQL Query
                        cmmnd2.ExecuteScalar();
                    }

                    MessageBox.Show("Order Placed Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    DB.connection.Close();

                    this.Close();

                    Orders orders = new Orders();
                    orders.Show();
                }
            }
        }

        //false defautl select row
        private void data_product_list_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (data_product_list.SelectedCells.Count > 0)
            {
                data_product_list.Rows[0].Selected = false;
            }
        }
    }
}
