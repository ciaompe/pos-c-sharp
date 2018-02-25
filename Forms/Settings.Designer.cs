namespace zeus.Forms
{
    partial class Settings
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
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_currentPassword = new System.Windows.Forms.TextBox();
            this.txt_newPassword = new System.Windows.Forms.TextBox();
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(41, 96);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(143, 20);
            this.lbl_password.TabIndex = 9;
            this.lbl_password.Text = "Current Password :";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(36, 38);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(121, 20);
            this.lbl_username.TabIndex = 8;
            this.lbl_username.Text = "New Password :";
            // 
            // txt_currentPassword
            // 
            this.txt_currentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currentPassword.Location = new System.Drawing.Point(190, 87);
            this.txt_currentPassword.Name = "txt_currentPassword";
            this.txt_currentPassword.PasswordChar = '*';
            this.txt_currentPassword.Size = new System.Drawing.Size(356, 29);
            this.txt_currentPassword.TabIndex = 7;
            // 
            // txt_newPassword
            // 
            this.txt_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newPassword.Location = new System.Drawing.Point(190, 38);
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.PasswordChar = '*';
            this.txt_newPassword.Size = new System.Drawing.Size(356, 29);
            this.txt_newPassword.TabIndex = 6;
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePassword.Location = new System.Drawing.Point(190, 151);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(209, 39);
            this.btn_changePassword.TabIndex = 5;
            this.btn_changePassword.Text = "Change Password";
            this.btn_changePassword.UseVisualStyleBackColor = true;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 247);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_currentPassword);
            this.Controls.Add(this.txt_newPassword);
            this.Controls.Add(this.btn_changePassword);
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_currentPassword;
        private System.Windows.Forms.TextBox txt_newPassword;
        private System.Windows.Forms.Button btn_changePassword;
    }
}