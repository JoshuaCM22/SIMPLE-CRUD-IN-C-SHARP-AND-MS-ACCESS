namespace SIMPLECRUD_CS_AND_MS_ACCESS
{
    partial class Form_ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChangePassword));
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.chckbox_ShowPassword2 = new System.Windows.Forms.CheckBox();
            this.chckbox_ShowPassword1 = new System.Windows.Forms.CheckBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox
            // 
            this.groupbox.BackColor = System.Drawing.Color.Transparent;
            this.groupbox.Controls.Add(this.chckbox_ShowPassword2);
            this.groupbox.Controls.Add(this.chckbox_ShowPassword1);
            this.groupbox.Controls.Add(this.lblCurrentPassword);
            this.groupbox.Controls.Add(this.txtCurrentPassword);
            this.groupbox.Controls.Add(this.lblConfirmNewPassword);
            this.groupbox.Controls.Add(this.txtConfirmNewPassword);
            this.groupbox.Controls.Add(this.lblNewPassword);
            this.groupbox.Controls.Add(this.txtNewPassword);
            this.groupbox.Location = new System.Drawing.Point(19, 23);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(449, 307);
            this.groupbox.TabIndex = 0;
            this.groupbox.TabStop = false;
            // 
            // chckbox_ShowPassword2
            // 
            this.chckbox_ShowPassword2.AutoSize = true;
            this.chckbox_ShowPassword2.BackColor = System.Drawing.Color.Transparent;
            this.chckbox_ShowPassword2.FlatAppearance.BorderSize = 0;
            this.chckbox_ShowPassword2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbox_ShowPassword2.ForeColor = System.Drawing.Color.Black;
            this.chckbox_ShowPassword2.Location = new System.Drawing.Point(183, 254);
            this.chckbox_ShowPassword2.Name = "chckbox_ShowPassword2";
            this.chckbox_ShowPassword2.Size = new System.Drawing.Size(118, 21);
            this.chckbox_ShowPassword2.TabIndex = 61;
            this.chckbox_ShowPassword2.Text = "Show Password";
            this.chckbox_ShowPassword2.UseVisualStyleBackColor = false;
            this.chckbox_ShowPassword2.CheckedChanged += new System.EventHandler(this.chckbox_ShowPassword2_CheckedChanged);
            // 
            // chckbox_ShowPassword1
            // 
            this.chckbox_ShowPassword1.AutoSize = true;
            this.chckbox_ShowPassword1.BackColor = System.Drawing.Color.Transparent;
            this.chckbox_ShowPassword1.FlatAppearance.BorderSize = 0;
            this.chckbox_ShowPassword1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbox_ShowPassword1.ForeColor = System.Drawing.Color.Black;
            this.chckbox_ShowPassword1.Location = new System.Drawing.Point(183, 109);
            this.chckbox_ShowPassword1.Name = "chckbox_ShowPassword1";
            this.chckbox_ShowPassword1.Size = new System.Drawing.Size(118, 21);
            this.chckbox_ShowPassword1.TabIndex = 60;
            this.chckbox_ShowPassword1.Text = "Show Password";
            this.chckbox_ShowPassword1.UseVisualStyleBackColor = false;
            this.chckbox_ShowPassword1.CheckedChanged += new System.EventHandler(this.chckbox_ShowPassword1_CheckedChanged);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentPassword.Location = new System.Drawing.Point(54, 73);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(122, 20);
            this.lblCurrentPassword.TabIndex = 58;
            this.lblCurrentPassword.Text = "Current Password";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(183, 71);
            this.txtCurrentPassword.MaxLength = 14;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(234, 25);
            this.txtCurrentPassword.TabIndex = 1;
            this.txtCurrentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            this.txtCurrentPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentPassword_KeyPress);
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPassword.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(15, 215);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(161, 20);
            this.lblConfirmNewPassword.TabIndex = 59;
            this.lblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(182, 214);
            this.txtConfirmNewPassword.MaxLength = 14;
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(234, 25);
            this.txtConfirmNewPassword.TabIndex = 3;
            this.txtConfirmNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirmNewPassword.UseSystemPasswordChar = true;
            this.txtConfirmNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmNewPassword_KeyPress);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.Black;
            this.lblNewPassword.Location = new System.Drawing.Point(72, 167);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(104, 20);
            this.lblNewPassword.TabIndex = 55;
            this.lblNewPassword.Text = "New Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(182, 166);
            this.txtNewPassword.MaxLength = 14;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(234, 25);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPassword_KeyPress);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(276, 370);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(164, 33);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Green;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(52, 370);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(173, 33);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "CHANGE PASSWORD";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // Frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 443);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHANGE PASSWORD";
            this.Load += new System.EventHandler(this.Form_ChangePassword_Load);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupbox;
        internal System.Windows.Forms.Label lblCurrentPassword;
        internal System.Windows.Forms.TextBox txtCurrentPassword;
        internal System.Windows.Forms.Label lblConfirmNewPassword;
        internal System.Windows.Forms.TextBox txtConfirmNewPassword;
        internal System.Windows.Forms.Label lblNewPassword;
        internal System.Windows.Forms.TextBox txtNewPassword;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnChangePassword;
        internal System.Windows.Forms.CheckBox chckbox_ShowPassword2;
        internal System.Windows.Forms.CheckBox chckbox_ShowPassword1;
    }
}