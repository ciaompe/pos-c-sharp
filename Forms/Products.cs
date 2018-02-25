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
    public partial class Products : Form
    {
        private int? pid;
        private int gridIndex;
        private string pcode;

        //Create new source 
        BindingSource source = new BindingSource();

        //Create new Patient List
        List<Product> productList = new List<Product>();

        public Products()
        {
            InitializeComponent();
        }

        //form load event
        private void Products_Load(object sender, EventArgs e)
        {
            //sql select patient query
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

                            source.DataSource = productList;
                            data_product_list.DataSource = source;

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

        //product add
        private void btn_add_Click(object sender, EventArgs e)
        {
            pid = 0;
            pcode = null;

            string title = txt_title.Text;
            string code = txt_code.Text;
            string description = txt_description.Text;
            double price;
            int quantity;

            if (title == "")
            {
                MessageBox.Show("Product Title is required");
            }
            else if (code == "")
            {
                MessageBox.Show("Product Code is required");
            }
            else if (this.codeExists(code))
            {
                MessageBox.Show("Product Code exists, the code must be a unique value");
            }
            else if (description == "")
            {
                MessageBox.Show("Product Description is required");
            }
            else if (!double.TryParse(txt_price.Text, out price))
            {
                MessageBox.Show("Please Enter valid price for the product (ex: 53.20)");
            }
            else if (!Int32.TryParse(txt_quantity.Text, out quantity))
            {
                MessageBox.Show("Please Enter valid quantity for the product (ex: 100)");
            }
            else
            {
                String sqlString = "INSERT into products(code, title, description, price, quantity) OUTPUT INSERTED.ID VALUES (@code, @title, @description, @price, @quantity)";

                using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
                {

                    //sql bind param list
                    cmmnd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;
                    cmmnd.Parameters.Add("@title", SqlDbType.Text).Value = title;
                    cmmnd.Parameters.Add("@description", SqlDbType.Text).Value = description;
                    cmmnd.Parameters.Add("@price", SqlDbType.Float).Value = price;
                    cmmnd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;

                    try
                    {
                        //Open DB Connection
                        DB.connection.Open();

                        //Executing SQL Query
                        pid = (Int32)cmmnd.ExecuteScalar();

                        Product product = new Product();

                        product.Id = Convert.ToInt32(pid);
                        product.Title = title;
                        product.Code = code;
                        product.Description = description;
                        product.Price = price;
                        product.Quantity = quantity;

                        productList.Add(product);

                        source.DataSource = productList;

                        data_product_list.DataSource = null;
                        data_product_list.DataSource = source;

                        MessageBox.Show("Product addedd successful");
                    }
                    catch (SqlException ex)
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

        //product edit
        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            if (pid.HasValue && pid.Value > 0)
            {
                string title = txt_title.Text;
                string code = txt_code.Text;
                string description = txt_description.Text;
                double price;
                int quantity;

                if (title == "")
                {
                    MessageBox.Show("Product Title is required");
                }
                else if (code == "")
                {
                    MessageBox.Show("Product Code is required");
                }
                else if(this.codeExists(code))
                {
                   MessageBox.Show("Product Code exists, the code must be a unique value");
                }
                else if (description == "")
                {
                    MessageBox.Show("Product Description is required");
                }
                else if (!double.TryParse(txt_price.Text, out price))
                {
                    MessageBox.Show("Please Enter valid price for the product (ex: 53.20)");
                }
                else if (!Int32.TryParse(txt_quantity.Text, out quantity))
                {
                    MessageBox.Show("Please Enter valid quantity for the product (ex: 100)");
                }
                else
                {
                    String sqlString = "UPDATE products SET code=@code, title=@title, description=@description, price=@price, quantity=@quantity WHERE id=@id";

                    using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
                    {

                        //sql bind param list
                        //sql bind param list
                        cmmnd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;
                        cmmnd.Parameters.Add("@title", SqlDbType.Text).Value = title;
                        cmmnd.Parameters.Add("@description", SqlDbType.Text).Value = description;
                        cmmnd.Parameters.Add("@price", SqlDbType.Float).Value = price;
                        cmmnd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;

                        cmmnd.Parameters.Add("@id", SqlDbType.Int).Value = pid;

                        try
                        {
                            //Open DB Connection
                            DB.connection.Open();
                            //Executing SQL Query
                            cmmnd.ExecuteNonQuery();

                            DataGridViewRow selectedRow = data_product_list.Rows[gridIndex];

                            selectedRow.Cells["title"].Value = title;
                            selectedRow.Cells["code"].Value = code;
                            selectedRow.Cells["description"].Value = description;
                            selectedRow.Cells["price"].Value = txt_price.Text;
                            selectedRow.Cells["quantity"].Value = txt_quantity.Text;

                            pid = 0;

                            MessageBox.Show("Product Updated successful");
                            Clear.ClearFormFields(this);

                        }
                        catch (SqlException ex)
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
            else
            {
                MessageBox.Show("Please select a product to edit");
            }
        }

        //product delete
        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            if (!LoginInfo.admin())
            {
                MessageBox.Show("Permission Denied");
                this.Close();
            }

            if (pid.HasValue && pid.Value > 0)
            {
                DialogResult dialogResult = MessageBox.Show("If you delete this product, you cannot recover data again", "Are you Sure ?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                    String sqlString = "DELETE FROM products WHERE id=@id";

                    using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
                    {

                        cmmnd.Parameters.Add("@id", SqlDbType.Int).Value = pid;

                        try
                        {
                            //Open DB Connection
                            DB.connection.Open();
                            //Executing SQL Query
                            cmmnd.ExecuteNonQuery();

                            data_product_list.Rows.RemoveAt(gridIndex);
                            pid = 0;

                            MessageBox.Show("Product Deleted successful");
                            Clear.ClearFormFields(this);
                        }
                        catch (SqlException ex)
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
            else
            {
                MessageBox.Show("Please select a product to delete");
            }
        }

        //form clear
        private void btn_clear_Click(object sender, EventArgs e)
        {
            pid = 0;
            Clear.ClearFormFields(this);
        }

        //check product code is exists or not
        private bool codeExists(string code)
        {
            bool exists = false;

            if (code == pcode)
            {
                return false;
            }

            String sqlString = "SELECT * FROM products WHERE code=@code";

            using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
            {
                cmmnd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

                try
                {
                    DB.connection.Open();

                    using (SqlDataReader rd = cmmnd.ExecuteReader())
                    {

                        if (rd.HasRows)
                        {
                           exists = true;
                        }

                        rd.Close();
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);

                }
                finally
                {
                    DB.connection.Close();
                }

            }

            return exists;

        }

        //product data grid
        private void data_product_list_Click(object sender, EventArgs e)
        {
            if (data_product_list.SelectedCells.Count > 0)
            {
                int selectedrowindex = data_product_list.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = data_product_list.Rows[selectedrowindex];

                this.pid = Int32.Parse(Convert.ToString(selectedRow.Cells["id"].Value));
                this.gridIndex = selectedrowindex;
                this.pcode = Convert.ToString(selectedRow.Cells["code"].Value);

                txt_title.Text = Convert.ToString(selectedRow.Cells["title"].Value);
                txt_code.Text = Convert.ToString(selectedRow.Cells["code"].Value);
                txt_description.Text = Convert.ToString(selectedRow.Cells["description"].Value);
                txt_price.Text = Convert.ToString(selectedRow.Cells["price"].Value);
                txt_quantity.Text = Convert.ToString(selectedRow.Cells["quantity"].Value);
            }
        }

        //product title search
        private void txt_productTitle_KeyDown(object sender, KeyEventArgs e)
        {
            BindingList<Product> filtered = new BindingList<Product>(productList.Where(obj => obj.Title.Contains(txt_productTitle.Text)).ToList());

            data_product_list.DataSource = filtered;
            data_product_list.Update();
        }

        //product code search
        private void txt_productCode_KeyDown(object sender, KeyEventArgs e)
        {
            BindingList<Product> filtered = new BindingList<Product>(productList.Where(obj => obj.Code.Contains(txt_productCode.Text)).ToList());

            data_product_list.DataSource = filtered;
            data_product_list.Update();
        }

        //false default seleted row
        private void data_product_list_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (data_product_list.SelectedCells.Count > 0)
            {
                data_product_list.Rows[0].Selected = false;
            }
        }
    }
}
