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

namespace zeus.Forms
{
    public partial class Suppliers : Form
    {
        private int? supplierId;
        private int gridIndex;
        private string currentTel;

        //Create new Patient List
        List<Classess.Supplier> supplierList = new List<Classess.Supplier>();

        //Create new Binding source
        BindingSource source = new BindingSource();

        public Suppliers()
        {
            InitializeComponent();
        }
        //form load event get all suppliers
        private void Suppliers_Load(object sender, EventArgs e)
        {
            //sql select query
            String sqlString = "SELECT * FROM suppliers";

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
                                Supplier supplier = new Supplier();

                                supplier.Id = Convert.ToInt32(rd["id"]);
                                supplier.CompanyName = rd["company_name"].ToString();
                                supplier.Address = rd["address"].ToString();
                                supplier.Telephone = rd["telephone"].ToString();

                                supplierList.Add(supplier);
                            }

                            source.DataSource = supplierList;
                            data_supplier_list.DataSource = source;
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

        //add new supplier to database
        private void btn_add_Click(object sender, EventArgs e)
        {
            supplierId = 0;

            Supplier supplier = new Supplier();

            supplier.Id = (int)supplierId;
            supplier.CompanyName = txt_name.Text;
            supplier.Address = txt_address.Text;
            supplier.Telephone = txt_telephone.Text;

            if (supplier.validate())
            {
                String sqlString = "INSERT into suppliers (company_name, address, telephone) OUTPUT INSERTED.ID VALUES (@name , @address, @telephone)";

                using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
                {

                    cmmnd.Parameters.Add("@name", SqlDbType.VarChar).Value = supplier.CompanyName;
                    cmmnd.Parameters.Add("@address", SqlDbType.Text).Value = supplier.Address;
                    cmmnd.Parameters.Add("@telephone", SqlDbType.VarChar).Value = supplier.Telephone;

                    try
                    {
                        DB.connection.Open();

                        supplierId = (Int32)cmmnd.ExecuteScalar();

                        supplier.Id = Convert.ToInt32(supplierId);

                        supplierList.Add(supplier);

                        source.DataSource = supplierList;

                        data_supplier_list.DataSource = null;
                        data_supplier_list.DataSource = source;

                        MessageBox.Show("Supplier addedd successful");

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
            else
            {
                MessageBox.Show(supplier.getError());
            }
        }
        //edit supplier 
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (supplierId.HasValue && supplierId.Value > 0)
            {
                Supplier supplier = new Supplier();

                supplier.Id = (int)supplierId;
                supplier.CompanyName = txt_name.Text;
                supplier.Address = txt_address.Text;
                supplier.Telephone = txt_telephone.Text;

                //Datagrid Selected row
                DataGridViewRow selectedRow = data_supplier_list.Rows[gridIndex];

                if (supplier.validate(currentTel))
                {

                    String sqlString = "UPDATE suppliers SET company_name=@name, address=@address, telephone=@telephone WHERE id=@id";

                    using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
                    {

                        //sql bind param list
                        cmmnd.Parameters.Add("@name", SqlDbType.VarChar).Value = supplier.CompanyName;
                        cmmnd.Parameters.Add("@address", SqlDbType.Text).Value = supplier.Address;
                        cmmnd.Parameters.Add("@telephone", SqlDbType.VarChar).Value = supplier.Telephone;

                        cmmnd.Parameters.Add("@id", SqlDbType.Int).Value = supplierId;

                        try
                        {
                            //Open DB Connection
                            DB.connection.Open();
                            //Executing SQL Query
                            cmmnd.ExecuteNonQuery();

                            //Updating patient row data
                            selectedRow.Cells["companyName"].Value = supplier.CompanyName;
                            selectedRow.Cells["address"].Value = supplier.Address;
                            selectedRow.Cells["telephone"].Value = supplier.Telephone;

                            supplierId = 0;

                            MessageBox.Show("Supplier Updated successful");

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
                else
                {
                    MessageBox.Show(supplier.getError());
                }

            }
            else
            {
                MessageBox.Show("Please select a supplier to edit");
            }
        }
        //delete supplier
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!LoginInfo.admin())
            {
                MessageBox.Show("Permission Denied");
                this.Close();
            }

            if (supplierId.HasValue && supplierId.Value > 0)
            {
                DialogResult dialogResult = MessageBox.Show("If you delete this supplier, you cannot recover data again", "Are you Sure ?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                    String sqlString = "DELETE FROM supplier WHERE id=@id";

                    using (SqlCommand cmmnd = new SqlCommand(sqlString, DB.connection))
                    {

                        cmmnd.Parameters.Add("@id", SqlDbType.Int).Value = supplierId;

                        try
                        {
                            //Open DB Connection
                            DB.connection.Open();
                            //Executing SQL Query
                            cmmnd.ExecuteNonQuery();

                            data_supplier_list.Rows.RemoveAt(gridIndex);

                            supplierId = 0;

                            MessageBox.Show("Supplier Deleted successful");
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
                MessageBox.Show("Please select a supplier to delete");
            }
        }
        //clear form
        private void btn_clear_Click(object sender, EventArgs e)
        {
            supplierId = 0;
            Clear.ClearFormFields(this);
        }

        //data  grid view
        private void data_supplier_list_Click(object sender, EventArgs e)
        {
            if (data_supplier_list.SelectedCells.Count > 0)
            {
                int selectedrowindex = data_supplier_list.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = data_supplier_list.Rows[selectedrowindex];

                this.gridIndex = selectedrowindex;
                this.supplierId = Int32.Parse(Convert.ToString(selectedRow.Cells["id"].Value));
                this.currentTel = Convert.ToString(selectedRow.Cells["telephone"].Value);

                txt_name.Text = Convert.ToString(selectedRow.Cells["companyName"].Value);
                txt_address.Text = Convert.ToString(selectedRow.Cells["address"].Value);
                txt_telephone.Text = currentTel;
            }
        }

        private void txt_companyName_KeyDown(object sender, KeyEventArgs e)
        {
            BindingList<Classess.Supplier> filtered = new BindingList<Classess.Supplier>(supplierList.Where(obj => obj.CompanyName.Contains(txt_companyName.Text)).ToList());

            data_supplier_list.DataSource = filtered;
            data_supplier_list.Update();
        }

        private void txt_companyTel_KeyDown(object sender, KeyEventArgs e)
        {
            BindingList<Classess.Supplier> filtered = new BindingList<Classess.Supplier>(supplierList.Where(obj => obj.Telephone.Contains(txt_companyTel.Text)).ToList());

            data_supplier_list.DataSource = filtered;
            data_supplier_list.Update();
        }

        private void data_supplier_list_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            data_supplier_list.Rows[0].Selected = false;
        }
    }
}
