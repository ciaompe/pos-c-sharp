namespace zeus.Forms
{
    partial class Orders
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
            this.data_order_list = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_customerTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_orderNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_order_list)).BeginInit();
            this.SuspendLayout();
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
            this.data_order_list.Location = new System.Drawing.Point(29, 122);
            this.data_order_list.Name = "data_order_list";
            this.data_order_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_order_list.Size = new System.Drawing.Size(649, 403);
            this.data_order_list.TabIndex = 68;
            this.data_order_list.Click += new System.EventHandler(this.data_order_list_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Search With Customer Telephone :";
            // 
            // txt_customerTel
            // 
            this.txt_customerTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerTel.Location = new System.Drawing.Point(386, 69);
            this.txt_customerTel.Name = "txt_customerTel";
            this.txt_customerTel.Size = new System.Drawing.Size(293, 26);
            this.txt_customerTel.TabIndex = 69;
            this.txt_customerTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_customerTel_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Search With Order Number:";
            // 
            // txt_orderNumber
            // 
            this.txt_orderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderNumber.Location = new System.Drawing.Point(29, 69);
            this.txt_orderNumber.Name = "txt_orderNumber";
            this.txt_orderNumber.Size = new System.Drawing.Size(293, 26);
            this.txt_orderNumber.TabIndex = 71;
            this.txt_orderNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_orderNumber_KeyDown);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(703, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_orderNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_customerTel);
            this.Controls.Add(this.data_order_list);
            this.MaximizeBox = false;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_order_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_order_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_customerTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_orderNumber;
    }
}