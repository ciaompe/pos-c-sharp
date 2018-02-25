namespace zeus.Forms
{
    partial class Suppliers
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_companyTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_companyName = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.data_supplier_list = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_telephone = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_supplier_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(38, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 2);
            this.label3.TabIndex = 103;
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer.Location = new System.Drawing.Point(32, 46);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(233, 29);
            this.lbl_customer.TabIndex = 102;
            this.lbl_customer.Text = "Supplier Infomation :";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(38, 446);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(102, 34);
            this.btn_add.TabIndex = 101;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(826, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "Search With Tel :";
            // 
            // txt_companyTel
            // 
            this.txt_companyTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_companyTel.Location = new System.Drawing.Point(830, 67);
            this.txt_companyTel.Name = "txt_companyTel";
            this.txt_companyTel.Size = new System.Drawing.Size(191, 26);
            this.txt_companyTel.TabIndex = 99;
            this.txt_companyTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_companyTel_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "Search With  Company Name :";
            // 
            // txt_companyName
            // 
            this.txt_companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_companyName.Location = new System.Drawing.Point(519, 67);
            this.txt_companyName.Name = "txt_companyName";
            this.txt_companyName.Size = new System.Drawing.Size(289, 26);
            this.txt_companyName.TabIndex = 97;
            this.txt_companyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_companyName_KeyDown);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(393, 446);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(88, 34);
            this.btn_clear.TabIndex = 96;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // data_supplier_list
            // 
            this.data_supplier_list.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.data_supplier_list.AllowUserToAddRows = false;
            this.data_supplier_list.AllowUserToDeleteRows = false;
            this.data_supplier_list.AllowUserToResizeColumns = false;
            this.data_supplier_list.AllowUserToResizeRows = false;
            this.data_supplier_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data_supplier_list.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data_supplier_list.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.data_supplier_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_supplier_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data_supplier_list.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_supplier_list.Location = new System.Drawing.Point(521, 111);
            this.data_supplier_list.Name = "data_supplier_list";
            this.data_supplier_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.data_supplier_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_supplier_list.Size = new System.Drawing.Size(500, 369);
            this.data_supplier_list.TabIndex = 95;
            this.data_supplier_list.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.data_supplier_list_DataBindingComplete);
            this.data_supplier_list.Click += new System.EventHandler(this.data_supplier_list_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Location = new System.Drawing.Point(275, 446);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(109, 34);
            this.btn_delete.TabIndex = 94;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(153, 446);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(109, 34);
            this.btn_edit.TabIndex = 93;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(37, 228);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(444, 87);
            this.txt_address.TabIndex = 92;
            // 
            // txt_telephone
            // 
            this.txt_telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telephone.Location = new System.Drawing.Point(37, 374);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(444, 26);
            this.txt_telephone.TabIndex = 91;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(37, 151);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(444, 26);
            this.txt_name.TabIndex = 90;
            // 
            // lbl_telephone
            // 
            this.lbl_telephone.AutoSize = true;
            this.lbl_telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telephone.Location = new System.Drawing.Point(33, 340);
            this.lbl_telephone.Name = "lbl_telephone";
            this.lbl_telephone.Size = new System.Drawing.Size(92, 20);
            this.lbl_telephone.TabIndex = 89;
            this.lbl_telephone.Text = "Telephone :";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(34, 198);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(76, 20);
            this.lbl_address.TabIndex = 88;
            this.lbl_address.Text = "Address :";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(34, 121);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(130, 20);
            this.lbl_name.TabIndex = 87;
            this.lbl_name.Text = "Company Name :";
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 514);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_customer);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_companyTel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_companyName);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.data_supplier_list);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_telephone);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_telephone);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_name);
            this.MaximizeBox = false;
            this.Name = "Suppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_supplier_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_companyTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_companyName;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView data_supplier_list;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_telephone;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_name;
    }
}