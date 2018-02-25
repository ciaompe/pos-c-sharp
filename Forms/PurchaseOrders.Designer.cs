namespace zeus.Forms
{
    partial class PurchaseOrders
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_orderNumber = new System.Windows.Forms.TextBox();
            this.data_order_list = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_order_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Search With Purchase Order Number:";
            // 
            // txt_orderNumber
            // 
            this.txt_orderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderNumber.Location = new System.Drawing.Point(28, 71);
            this.txt_orderNumber.Name = "txt_orderNumber";
            this.txt_orderNumber.Size = new System.Drawing.Size(649, 26);
            this.txt_orderNumber.TabIndex = 76;
            this.txt_orderNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_orderNumber_KeyDown);
            // 
            // data_order_list
            // 
            this.data_order_list.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.data_order_list.AllowUserToAddRows = false;
            this.data_order_list.AllowUserToDeleteRows = false;
            this.data_order_list.AllowUserToResizeColumns = false;
            this.data_order_list.AllowUserToResizeRows = false;
            this.data_order_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data_order_list.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data_order_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_order_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data_order_list.Location = new System.Drawing.Point(28, 124);
            this.data_order_list.Name = "data_order_list";
            this.data_order_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_order_list.Size = new System.Drawing.Size(649, 403);
            this.data_order_list.TabIndex = 73;
            this.data_order_list.Click += new System.EventHandler(this.data_order_list_Click);
            // 
            // PurchaseOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_orderNumber);
            this.Controls.Add(this.data_order_list);
            this.MaximizeBox = false;
            this.Name = "PurchaseOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Orders";
            this.Load += new System.EventHandler(this.PurchaseOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_order_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_orderNumber;
        private System.Windows.Forms.DataGridView data_order_list;
    }
}