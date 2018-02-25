namespace zeus.Forms
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.lbl_code = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_editProduct = new System.Windows.Forms.Button();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            this.data_product_list = new System.Windows.Forms.DataGridView();
            this.grp_searhProduct = new System.Windows.Forms.GroupBox();
            this.txt_productTitle = new System.Windows.Forms.TextBox();
            this.txt_productCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_product_list)).BeginInit();
            this.grp_searhProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(32, 453);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(381, 26);
            this.txt_quantity.TabIndex = 58;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(29, 423);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(135, 20);
            this.lbl_quantity.TabIndex = 57;
            this.lbl_quantity.Text = "Product Quantity :";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(31, 371);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(381, 26);
            this.txt_price.TabIndex = 56;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(28, 341);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(185, 20);
            this.lbl_price.TabIndex = 55;
            this.lbl_price.Text = "Product Price (unit price):";
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(31, 226);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(381, 87);
            this.txt_description.TabIndex = 54;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(28, 196);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(147, 20);
            this.lbl_description.TabIndex = 53;
            this.lbl_description.Text = "Product Discrption :";
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(31, 142);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(381, 26);
            this.txt_code.TabIndex = 52;
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.Location = new System.Drawing.Point(28, 112);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(211, 20);
            this.lbl_code.TabIndex = 51;
            this.lbl_code.Text = "Product Code (unique code):";
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.Location = new System.Drawing.Point(31, 62);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(381, 26);
            this.txt_title.TabIndex = 50;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(28, 32);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(105, 20);
            this.lbl_title.TabIndex = 49;
            this.lbl_title.Text = "Product Title :";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(340, 511);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(73, 34);
            this.btn_clear.TabIndex = 60;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_editProduct
            // 
            this.btn_editProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editProduct.Location = new System.Drawing.Point(137, 511);
            this.btn_editProduct.Name = "btn_editProduct";
            this.btn_editProduct.Size = new System.Drawing.Size(82, 34);
            this.btn_editProduct.TabIndex = 59;
            this.btn_editProduct.Text = "Edit";
            this.btn_editProduct.UseVisualStyleBackColor = true;
            this.btn_editProduct.Click += new System.EventHandler(this.btn_editProduct_Click);
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.BackColor = System.Drawing.Color.Red;
            this.btn_deleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deleteProduct.Location = new System.Drawing.Point(238, 511);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(88, 34);
            this.btn_deleteProduct.TabIndex = 61;
            this.btn_deleteProduct.Text = "Delete";
            this.btn_deleteProduct.UseVisualStyleBackColor = false;
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // data_product_list
            // 
            this.data_product_list.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.data_product_list.AllowUserToAddRows = false;
            this.data_product_list.AllowUserToDeleteRows = false;
            this.data_product_list.AllowUserToResizeColumns = false;
            this.data_product_list.AllowUserToResizeRows = false;
            this.data_product_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data_product_list.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data_product_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_product_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data_product_list.Location = new System.Drawing.Point(451, 142);
            this.data_product_list.Name = "data_product_list";
            this.data_product_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_product_list.Size = new System.Drawing.Size(649, 403);
            this.data_product_list.TabIndex = 67;
            this.data_product_list.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.data_product_list_DataBindingComplete);
            this.data_product_list.Click += new System.EventHandler(this.data_product_list_Click);
            // 
            // grp_searhProduct
            // 
            this.grp_searhProduct.Controls.Add(this.txt_productTitle);
            this.grp_searhProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_searhProduct.Location = new System.Drawing.Point(451, 32);
            this.grp_searhProduct.Name = "grp_searhProduct";
            this.grp_searhProduct.Size = new System.Drawing.Size(386, 89);
            this.grp_searhProduct.TabIndex = 68;
            this.grp_searhProduct.TabStop = false;
            this.grp_searhProduct.Text = "Search with Product Title :";
            // 
            // txt_productTitle
            // 
            this.txt_productTitle.Location = new System.Drawing.Point(20, 37);
            this.txt_productTitle.Name = "txt_productTitle";
            this.txt_productTitle.Size = new System.Drawing.Size(340, 26);
            this.txt_productTitle.TabIndex = 0;
            this.txt_productTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_productTitle_KeyDown);
            // 
            // txt_productCode
            // 
            this.txt_productCode.Location = new System.Drawing.Point(20, 37);
            this.txt_productCode.Name = "txt_productCode";
            this.txt_productCode.Size = new System.Drawing.Size(203, 26);
            this.txt_productCode.TabIndex = 0;
            this.txt_productCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_productCode_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_productCode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(856, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 89);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saech with Product Code :";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(31, 511);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 34);
            this.btn_add.TabIndex = 70;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1134, 572);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.grp_searhProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.data_product_list);
            this.Controls.Add(this.btn_deleteProduct);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_editProduct);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lbl_title);
            this.MaximizeBox = false;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_product_list)).EndInit();
            this.grp_searhProduct.ResumeLayout(false);
            this.grp_searhProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_editProduct;
        private System.Windows.Forms.Button btn_deleteProduct;
        private System.Windows.Forms.DataGridView data_product_list;
        private System.Windows.Forms.GroupBox grp_searhProduct;
        private System.Windows.Forms.TextBox txt_productTitle;
        private System.Windows.Forms.TextBox txt_productCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add;
    }
}