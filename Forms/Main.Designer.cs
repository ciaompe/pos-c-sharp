namespace zeus.Forms
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_customers = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_prdoucts = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_orders = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_allOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_createOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_suppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_addPurchaseOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_allPurchaseOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_staff = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_myaccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_customers,
            this.menu_prdoucts,
            this.menu_orders,
            this.menu_suppliers,
            this.purchaseOrdersToolStripMenuItem,
            this.menu_staff,
            this.helpToolStripMenuItem,
            this.menu_myaccount});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mainMenu";
            // 
            // menu_customers
            // 
            this.menu_customers.Name = "menu_customers";
            this.menu_customers.Size = new System.Drawing.Size(97, 25);
            this.menu_customers.Text = "Customers";
            this.menu_customers.Click += new System.EventHandler(this.menu_customers_Click);
            // 
            // menu_prdoucts
            // 
            this.menu_prdoucts.Name = "menu_prdoucts";
            this.menu_prdoucts.Size = new System.Drawing.Size(83, 25);
            this.menu_prdoucts.Text = "Products";
            this.menu_prdoucts.Click += new System.EventHandler(this.menu_prdoucts_Click);
            // 
            // menu_orders
            // 
            this.menu_orders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_allOrders,
            this.menu_createOrder});
            this.menu_orders.Name = "menu_orders";
            this.menu_orders.Size = new System.Drawing.Size(70, 25);
            this.menu_orders.Text = "Orders";
            // 
            // menu_allOrders
            // 
            this.menu_allOrders.Name = "menu_allOrders";
            this.menu_allOrders.Size = new System.Drawing.Size(170, 26);
            this.menu_allOrders.Text = "ALL Orders";
            this.menu_allOrders.Click += new System.EventHandler(this.menu_allOrders_Click);
            // 
            // menu_createOrder
            // 
            this.menu_createOrder.Name = "menu_createOrder";
            this.menu_createOrder.Size = new System.Drawing.Size(170, 26);
            this.menu_createOrder.Text = "Create Order";
            this.menu_createOrder.Click += new System.EventHandler(this.menu_createOrder_Click);
            // 
            // menu_suppliers
            // 
            this.menu_suppliers.Name = "menu_suppliers";
            this.menu_suppliers.Size = new System.Drawing.Size(87, 25);
            this.menu_suppliers.Text = "Suppliers";
            this.menu_suppliers.Click += new System.EventHandler(this.menu_suppliers_Click);
            // 
            // purchaseOrdersToolStripMenuItem
            // 
            this.purchaseOrdersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_addPurchaseOrder,
            this.menu_allPurchaseOrders});
            this.purchaseOrdersToolStripMenuItem.Name = "purchaseOrdersToolStripMenuItem";
            this.purchaseOrdersToolStripMenuItem.Size = new System.Drawing.Size(137, 25);
            this.purchaseOrdersToolStripMenuItem.Text = "Purchase Orders";
            // 
            // menu_addPurchaseOrder
            // 
            this.menu_addPurchaseOrder.Name = "menu_addPurchaseOrder";
            this.menu_addPurchaseOrder.Size = new System.Drawing.Size(220, 26);
            this.menu_addPurchaseOrder.Text = "Add Purchase Order";
            this.menu_addPurchaseOrder.Click += new System.EventHandler(this.menu_addPurchaseOrder_Click);
            // 
            // menu_allPurchaseOrders
            // 
            this.menu_allPurchaseOrders.Name = "menu_allPurchaseOrders";
            this.menu_allPurchaseOrders.Size = new System.Drawing.Size(220, 26);
            this.menu_allPurchaseOrders.Text = "All Purchase Orders";
            this.menu_allPurchaseOrders.Click += new System.EventHandler(this.menu_allPurchaseOrders_Click);
            // 
            // menu_staff
            // 
            this.menu_staff.Name = "menu_staff";
            this.menu_staff.Size = new System.Drawing.Size(113, 25);
            this.menu_staff.Text = "Manage Staff";
            this.menu_staff.Click += new System.EventHandler(this.menu_staff_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // menu_myaccount
            // 
            this.menu_myaccount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menu_myaccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_changePassword});
            this.menu_myaccount.Name = "menu_myaccount";
            this.menu_myaccount.Size = new System.Drawing.Size(106, 25);
            this.menu_myaccount.Text = "My Acoount";
            // 
            // menu_changePassword
            // 
            this.menu_changePassword.Name = "menu_changePassword";
            this.menu_changePassword.Size = new System.Drawing.Size(203, 26);
            this.menu_changePassword.Text = "Change Password";
            this.menu_changePassword.Click += new System.EventHandler(this.menu_changePassword_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 132);
            this.button1.TabIndex = 1;
            this.button1.Text = "Customers";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(218, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 132);
            this.button2.TabIndex = 2;
            this.button2.Text = "Products";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(409, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 132);
            this.button3.TabIndex = 3;
            this.button3.Text = "Orders";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(600, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 132);
            this.button4.TabIndex = 4;
            this.button4.Text = "Suppliers";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(793, 81);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 132);
            this.button5.TabIndex = 5;
            this.button5.Text = "Staff";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(36, 240);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 132);
            this.button6.TabIndex = 6;
            this.button6.Text = "Purchases";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(998, 465);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zeuses Adminstration Panel";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_customers;
        private System.Windows.Forms.ToolStripMenuItem menu_prdoucts;
        private System.Windows.Forms.ToolStripMenuItem menu_orders;
        private System.Windows.Forms.ToolStripMenuItem menu_suppliers;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_myaccount;
        private System.Windows.Forms.ToolStripMenuItem menu_changePassword;
        private System.Windows.Forms.ToolStripMenuItem menu_createOrder;
        private System.Windows.Forms.ToolStripMenuItem menu_allOrders;
        private System.Windows.Forms.ToolStripMenuItem menu_staff;
        private System.Windows.Forms.ToolStripMenuItem menu_addPurchaseOrder;
        private System.Windows.Forms.ToolStripMenuItem menu_allPurchaseOrders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}