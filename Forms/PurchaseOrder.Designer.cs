namespace zeus.Forms
{
    partial class PurchaseOrder
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
            this.lbl_cart_pprice = new System.Windows.Forms.Label();
            this.txt_order_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cart_ptitle = new System.Windows.Forms.Label();
            this.lbl_cart_pid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cart_pquantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_removeCartItem = new System.Windows.Forms.Button();
            this.lbl_cart_total = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_cart_subtotal = new System.Windows.Forms.Label();
            this.grp_orderInfo = new System.Windows.Forms.GroupBox();
            this.cb_stock_recived = new System.Windows.Forms.CheckBox();
            this.lst_cart = new System.Windows.Forms.ListView();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_clearCart = new System.Windows.Forms.Button();
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_searh_code = new System.Windows.Forms.GroupBox();
            this.txt_productCode = new System.Windows.Forms.TextBox();
            this.data_product_list = new System.Windows.Forms.DataGridView();
            this.txt_productTitle = new System.Windows.Forms.TextBox();
            this.grp_searh_title = new System.Windows.Forms.GroupBox();
            this.lst_suppliers = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.grp_orderInfo.SuspendLayout();
            this.grp_searh_code.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_product_list)).BeginInit();
            this.grp_searh_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_cart_pprice
            // 
            this.lbl_cart_pprice.AutoSize = true;
            this.lbl_cart_pprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cart_pprice.Location = new System.Drawing.Point(271, 102);
            this.lbl_cart_pprice.MaximumSize = new System.Drawing.Size(80, 0);
            this.lbl_cart_pprice.Name = "lbl_cart_pprice";
            this.lbl_cart_pprice.Size = new System.Drawing.Size(0, 20);
            this.lbl_cart_pprice.TabIndex = 109;
            // 
            // txt_order_date
            // 
            this.txt_order_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_order_date.Location = new System.Drawing.Point(86, 260);
            this.txt_order_date.Name = "txt_order_date";
            this.txt_order_date.Size = new System.Drawing.Size(292, 24);
            this.txt_order_date.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 97;
            this.label2.Text = "Date  :";
            // 
            // lbl_cart_ptitle
            // 
            this.lbl_cart_ptitle.AutoSize = true;
            this.lbl_cart_ptitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cart_ptitle.Location = new System.Drawing.Point(95, 102);
            this.lbl_cart_ptitle.MaximumSize = new System.Drawing.Size(160, 0);
            this.lbl_cart_ptitle.Name = "lbl_cart_ptitle";
            this.lbl_cart_ptitle.Size = new System.Drawing.Size(0, 20);
            this.lbl_cart_ptitle.TabIndex = 108;
            // 
            // lbl_cart_pid
            // 
            this.lbl_cart_pid.AutoSize = true;
            this.lbl_cart_pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cart_pid.Location = new System.Drawing.Point(27, 102);
            this.lbl_cart_pid.MaximumSize = new System.Drawing.Size(50, 0);
            this.lbl_cart_pid.Name = "lbl_cart_pid";
            this.lbl_cart_pid.Size = new System.Drawing.Size(0, 20);
            this.lbl_cart_pid.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 61);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 105;
            this.label6.Text = "Quantity";
            // 
            // txt_cart_pquantity
            // 
            this.txt_cart_pquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cart_pquantity.Location = new System.Drawing.Point(380, 102);
            this.txt_cart_pquantity.Name = "txt_cart_pquantity";
            this.txt_cart_pquantity.Size = new System.Drawing.Size(72, 24);
            this.txt_cart_pquantity.TabIndex = 106;
            this.txt_cart_pquantity.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 61);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 62, 0);
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 103;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 61);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 78, 0);
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 101;
            this.label4.Text = "Product Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 61);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 99;
            this.label3.Text = "PID ";
            // 
            // btn_removeCartItem
            // 
            this.btn_removeCartItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeCartItem.Location = new System.Drawing.Point(620, 642);
            this.btn_removeCartItem.Name = "btn_removeCartItem";
            this.btn_removeCartItem.Size = new System.Drawing.Size(85, 36);
            this.btn_removeCartItem.TabIndex = 132;
            this.btn_removeCartItem.Text = "Remove";
            this.btn_removeCartItem.UseVisualStyleBackColor = true;
            this.btn_removeCartItem.Click += new System.EventHandler(this.btn_removeCartItem_Click);
            // 
            // lbl_cart_total
            // 
            this.lbl_cart_total.AutoSize = true;
            this.lbl_cart_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cart_total.Location = new System.Drawing.Point(1025, 654);
            this.lbl_cart_total.Name = "lbl_cart_total";
            this.lbl_cart_total.Size = new System.Drawing.Size(75, 24);
            this.lbl_cart_total.TabIndex = 130;
            this.lbl_cart_total.Text = "0000.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(903, 699);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 24);
            this.label11.TabIndex = 129;
            this.label11.Text = "Sub Total :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(937, 654);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 24);
            this.label10.TabIndex = 128;
            this.label10.Text = "Total  :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_cart_pprice);
            this.groupBox1.Controls.Add(this.lbl_cart_ptitle);
            this.groupBox1.Controls.Add(this.lbl_cart_pid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_cart_pquantity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 170);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shopping Cart";
            // 
            // lbl_cart_subtotal
            // 
            this.lbl_cart_subtotal.AutoSize = true;
            this.lbl_cart_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cart_subtotal.Location = new System.Drawing.Point(1025, 699);
            this.lbl_cart_subtotal.Name = "lbl_cart_subtotal";
            this.lbl_cart_subtotal.Size = new System.Drawing.Size(75, 24);
            this.lbl_cart_subtotal.TabIndex = 131;
            this.lbl_cart_subtotal.Text = "0000.00";
            // 
            // grp_orderInfo
            // 
            this.grp_orderInfo.Controls.Add(this.cb_stock_recived);
            this.grp_orderInfo.Controls.Add(this.txt_order_date);
            this.grp_orderInfo.Controls.Add(this.label2);
            this.grp_orderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_orderInfo.Location = new System.Drawing.Point(30, 37);
            this.grp_orderInfo.Name = "grp_orderInfo";
            this.grp_orderInfo.Size = new System.Drawing.Size(399, 345);
            this.grp_orderInfo.TabIndex = 125;
            this.grp_orderInfo.TabStop = false;
            this.grp_orderInfo.Text = "Purchase Order Information";
            // 
            // cb_stock_recived
            // 
            this.cb_stock_recived.AutoSize = true;
            this.cb_stock_recived.Checked = true;
            this.cb_stock_recived.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_stock_recived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_stock_recived.Location = new System.Drawing.Point(86, 301);
            this.cb_stock_recived.Name = "cb_stock_recived";
            this.cb_stock_recived.Size = new System.Drawing.Size(139, 24);
            this.cb_stock_recived.TabIndex = 100;
            this.cb_stock_recived.Text = "Stock Received";
            this.cb_stock_recived.UseVisualStyleBackColor = true;
            // 
            // lst_cart
            // 
            this.lst_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_cart.FullRowSelect = true;
            this.lst_cart.GridLines = true;
            this.lst_cart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lst_cart.Location = new System.Drawing.Point(620, 461);
            this.lst_cart.Name = "lst_cart";
            this.lst_cart.Size = new System.Drawing.Size(481, 160);
            this.lst_cart.TabIndex = 124;
            this.lst_cart.UseCompatibleStateImageBehavior = false;
            // 
            // btn_order
            // 
            this.btn_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.Location = new System.Drawing.Point(983, 757);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(118, 36);
            this.btn_order.TabIndex = 123;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_clearCart
            // 
            this.btn_clearCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearCart.Location = new System.Drawing.Point(716, 642);
            this.btn_clearCart.Name = "btn_clearCart";
            this.btn_clearCart.Size = new System.Drawing.Size(81, 36);
            this.btn_clearCart.TabIndex = 122;
            this.btn_clearCart.Text = "Clear";
            this.btn_clearCart.UseVisualStyleBackColor = true;
            this.btn_clearCart.Click += new System.EventHandler(this.btn_clearCart_Click);
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addToCart.Location = new System.Drawing.Point(541, 524);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Size = new System.Drawing.Size(42, 36);
            this.btn_addToCart.TabIndex = 120;
            this.btn_addToCart.Text = ">";
            this.btn_addToCart.UseVisualStyleBackColor = true;
            this.btn_addToCart.Click += new System.EventHandler(this.btn_addToCart_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(30, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1070, 2);
            this.label1.TabIndex = 121;
            // 
            // grp_searh_code
            // 
            this.grp_searh_code.Controls.Add(this.txt_productCode);
            this.grp_searh_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_searh_code.Location = new System.Drawing.Point(849, 37);
            this.grp_searh_code.Name = "grp_searh_code";
            this.grp_searh_code.Size = new System.Drawing.Size(252, 89);
            this.grp_searh_code.TabIndex = 118;
            this.grp_searh_code.TabStop = false;
            this.grp_searh_code.Text = "Saech with Product Code :";
            // 
            // txt_productCode
            // 
            this.txt_productCode.Location = new System.Drawing.Point(20, 37);
            this.txt_productCode.Name = "txt_productCode";
            this.txt_productCode.Size = new System.Drawing.Size(214, 26);
            this.txt_productCode.TabIndex = 0;
            this.txt_productCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_productCode_KeyDown);
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
            this.data_product_list.Location = new System.Drawing.Point(452, 150);
            this.data_product_list.Name = "data_product_list";
            this.data_product_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_product_list.Size = new System.Drawing.Size(649, 232);
            this.data_product_list.TabIndex = 119;
            this.data_product_list.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.data_product_list_DataBindingComplete);
            this.data_product_list.Click += new System.EventHandler(this.data_product_list_Click);
            // 
            // txt_productTitle
            // 
            this.txt_productTitle.Location = new System.Drawing.Point(20, 37);
            this.txt_productTitle.Name = "txt_productTitle";
            this.txt_productTitle.Size = new System.Drawing.Size(340, 26);
            this.txt_productTitle.TabIndex = 0;
            this.txt_productTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_productTitle_KeyDown);
            // 
            // grp_searh_title
            // 
            this.grp_searh_title.Controls.Add(this.txt_productTitle);
            this.grp_searh_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_searh_title.Location = new System.Drawing.Point(452, 37);
            this.grp_searh_title.Name = "grp_searh_title";
            this.grp_searh_title.Size = new System.Drawing.Size(386, 89);
            this.grp_searh_title.TabIndex = 117;
            this.grp_searh_title.TabStop = false;
            this.grp_searh_title.Text = "Search with Product Title :";
            // 
            // lst_suppliers
            // 
            this.lst_suppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_suppliers.FullRowSelect = true;
            this.lst_suppliers.GridLines = true;
            this.lst_suppliers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lst_suppliers.Location = new System.Drawing.Point(47, 86);
            this.lst_suppliers.Name = "lst_suppliers";
            this.lst_suppliers.Size = new System.Drawing.Size(361, 189);
            this.lst_suppliers.TabIndex = 133;
            this.lst_suppliers.UseCompatibleStateImageBehavior = false;
            this.lst_suppliers.Click += new System.EventHandler(this.lst_suppliers_Click);
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 831);
            this.Controls.Add(this.lst_suppliers);
            this.Controls.Add(this.btn_removeCartItem);
            this.Controls.Add(this.lbl_cart_total);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_cart_subtotal);
            this.Controls.Add(this.grp_orderInfo);
            this.Controls.Add(this.lst_cart);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_clearCart);
            this.Controls.Add(this.btn_addToCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_searh_code);
            this.Controls.Add(this.data_product_list);
            this.Controls.Add(this.grp_searh_title);
            this.MaximizeBox = false;
            this.Name = "PurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrder";
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_orderInfo.ResumeLayout(false);
            this.grp_orderInfo.PerformLayout();
            this.grp_searh_code.ResumeLayout(false);
            this.grp_searh_code.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_product_list)).EndInit();
            this.grp_searh_title.ResumeLayout(false);
            this.grp_searh_title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_cart_pprice;
        private System.Windows.Forms.DateTimePicker txt_order_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cart_ptitle;
        private System.Windows.Forms.Label lbl_cart_pid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cart_pquantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_removeCartItem;
        private System.Windows.Forms.Label lbl_cart_total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_cart_subtotal;
        private System.Windows.Forms.GroupBox grp_orderInfo;
        private System.Windows.Forms.ListView lst_cart;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_clearCart;
        private System.Windows.Forms.Button btn_addToCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_searh_code;
        private System.Windows.Forms.TextBox txt_productCode;
        private System.Windows.Forms.DataGridView data_product_list;
        private System.Windows.Forms.TextBox txt_productTitle;
        private System.Windows.Forms.GroupBox grp_searh_title;
        private System.Windows.Forms.ListView lst_suppliers;
        private System.Windows.Forms.CheckBox cb_stock_recived;
    }
}