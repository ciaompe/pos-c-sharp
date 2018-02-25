namespace zeus.Forms
{
    partial class FormInvoice
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
            this.grp_orderInfo = new System.Windows.Forms.GroupBox();
            this.lbl_customerTel = new System.Windows.Forms.Label();
            this.lbl_customerAddress = new System.Windows.Forms.Label();
            this.lbl_customerName = new System.Windows.Forms.Label();
            this.lbl_orderDate = new System.Windows.Forms.Label();
            this.lbl_orderNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_telephone = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lst_cart = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_orderSubTotal = new System.Windows.Forms.Label();
            this.lbl_orderTotal = new System.Windows.Forms.Label();
            this.grp_orderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_orderInfo
            // 
            this.grp_orderInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grp_orderInfo.Controls.Add(this.lbl_customerTel);
            this.grp_orderInfo.Controls.Add(this.lbl_customerAddress);
            this.grp_orderInfo.Controls.Add(this.lbl_customerName);
            this.grp_orderInfo.Controls.Add(this.lbl_orderDate);
            this.grp_orderInfo.Controls.Add(this.lbl_orderNumber);
            this.grp_orderInfo.Controls.Add(this.label1);
            this.grp_orderInfo.Controls.Add(this.label2);
            this.grp_orderInfo.Controls.Add(this.lbl_name);
            this.grp_orderInfo.Controls.Add(this.lbl_address);
            this.grp_orderInfo.Controls.Add(this.lbl_telephone);
            this.grp_orderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_orderInfo.Location = new System.Drawing.Point(28, 150);
            this.grp_orderInfo.Name = "grp_orderInfo";
            this.grp_orderInfo.Size = new System.Drawing.Size(777, 288);
            this.grp_orderInfo.TabIndex = 91;
            this.grp_orderInfo.TabStop = false;
            this.grp_orderInfo.Text = "Order Information";
            // 
            // lbl_customerTel
            // 
            this.lbl_customerTel.AutoSize = true;
            this.lbl_customerTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerTel.Location = new System.Drawing.Point(209, 238);
            this.lbl_customerTel.Name = "lbl_customerTel";
            this.lbl_customerTel.Size = new System.Drawing.Size(103, 20);
            this.lbl_customerTel.TabIndex = 103;
            this.lbl_customerTel.Text = "0772087820,";
            // 
            // lbl_customerAddress
            // 
            this.lbl_customerAddress.AutoSize = true;
            this.lbl_customerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerAddress.Location = new System.Drawing.Point(209, 195);
            this.lbl_customerAddress.Name = "lbl_customerAddress";
            this.lbl_customerAddress.Size = new System.Drawing.Size(299, 20);
            this.lbl_customerAddress.TabIndex = 102;
            this.lbl_customerAddress.Text = "No 1960, Lake Road , Colombo , Srilanka";
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.AutoSize = true;
            this.lbl_customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerName.Location = new System.Drawing.Point(209, 149);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.Size = new System.Drawing.Size(120, 20);
            this.lbl_customerName.TabIndex = 101;
            this.lbl_customerName.Text = "Lanka Hostpital";
            // 
            // lbl_orderDate
            // 
            this.lbl_orderDate.AutoSize = true;
            this.lbl_orderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderDate.Location = new System.Drawing.Point(209, 104);
            this.lbl_orderDate.Name = "lbl_orderDate";
            this.lbl_orderDate.Size = new System.Drawing.Size(145, 20);
            this.lbl_orderDate.TabIndex = 100;
            this.lbl_orderDate.Text = "08-November-2016";
            // 
            // lbl_orderNumber
            // 
            this.lbl_orderNumber.AutoSize = true;
            this.lbl_orderNumber.BackColor = System.Drawing.Color.Gold;
            this.lbl_orderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderNumber.Location = new System.Drawing.Point(209, 61);
            this.lbl_orderNumber.Name = "lbl_orderNumber";
            this.lbl_orderNumber.Size = new System.Drawing.Size(63, 20);
            this.lbl_orderNumber.TabIndex = 99;
            this.lbl_orderNumber.Text = "245896";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "Order Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 97;
            this.label2.Text = "Order Date";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(22, 149);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(124, 20);
            this.lbl_name.TabIndex = 91;
            this.lbl_name.Text = "Customer Name";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(22, 195);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(68, 20);
            this.lbl_address.TabIndex = 92;
            this.lbl_address.Text = "Address";
            // 
            // lbl_telephone
            // 
            this.lbl_telephone.AutoSize = true;
            this.lbl_telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telephone.Location = new System.Drawing.Point(22, 238);
            this.lbl_telephone.Name = "lbl_telephone";
            this.lbl_telephone.Size = new System.Drawing.Size(88, 20);
            this.lbl_telephone.TabIndex = 93;
            this.lbl_telephone.Text = " Telephone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(321, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 37);
            this.label8.TabIndex = 104;
            this.label8.Text = "INVOICE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(197, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(418, 20);
            this.label9.TabIndex = 104;
            this.label9.Text = "Zeus Pvt Ltd, NO 25 Nwaloka Road Colombo 10, SriLanka";
            // 
            // lst_cart
            // 
            this.lst_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_cart.FullRowSelect = true;
            this.lst_cart.GridLines = true;
            this.lst_cart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lst_cart.Location = new System.Drawing.Point(31, 464);
            this.lst_cart.Name = "lst_cart";
            this.lst_cart.Size = new System.Drawing.Size(774, 160);
            this.lst_cart.TabIndex = 105;
            this.lst_cart.UseCompatibleStateImageBehavior = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(595, 696);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 24);
            this.label11.TabIndex = 117;
            this.label11.Text = "Sub Total :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(629, 660);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 24);
            this.label10.TabIndex = 116;
            this.label10.Text = "Total  :";
            // 
            // lbl_orderSubTotal
            // 
            this.lbl_orderSubTotal.AutoSize = true;
            this.lbl_orderSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderSubTotal.Location = new System.Drawing.Point(730, 696);
            this.lbl_orderSubTotal.Name = "lbl_orderSubTotal";
            this.lbl_orderSubTotal.Size = new System.Drawing.Size(75, 24);
            this.lbl_orderSubTotal.TabIndex = 119;
            this.lbl_orderSubTotal.Text = "0000.00";
            // 
            // lbl_orderTotal
            // 
            this.lbl_orderTotal.AutoSize = true;
            this.lbl_orderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderTotal.Location = new System.Drawing.Point(730, 660);
            this.lbl_orderTotal.Name = "lbl_orderTotal";
            this.lbl_orderTotal.Size = new System.Drawing.Size(75, 24);
            this.lbl_orderTotal.TabIndex = 118;
            this.lbl_orderTotal.Text = "0000.00";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 767);
            this.Controls.Add(this.lbl_orderSubTotal);
            this.Controls.Add(this.lbl_orderTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lst_cart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grp_orderInfo);
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "invoice";
            this.Load += new System.EventHandler(this.invoice_Load);
            this.grp_orderInfo.ResumeLayout(false);
            this.grp_orderInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_orderInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_telephone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_customerAddress;
        private System.Windows.Forms.Label lbl_customerName;
        private System.Windows.Forms.Label lbl_orderDate;
        private System.Windows.Forms.Label lbl_orderNumber;
        private System.Windows.Forms.Label lbl_customerTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lst_cart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_orderSubTotal;
        private System.Windows.Forms.Label lbl_orderTotal;
    }
}