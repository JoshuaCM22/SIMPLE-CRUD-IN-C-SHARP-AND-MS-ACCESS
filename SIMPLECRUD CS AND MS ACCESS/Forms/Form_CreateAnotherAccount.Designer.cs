namespace SIMPLECRUD_CS_AND_MS_ACCESS
{
    partial class Form_CreateAnotherAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CreateAnotherAccount));
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chckbox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cmbboxSecretQuestion = new System.Windows.Forms.ComboBox();
            this.chckbox_ShowSecretAnswer = new System.Windows.Forms.CheckBox();
            this.txtSecretAnswer = new System.Windows.Forms.TextBox();
            this.lblSecretAnswer = new System.Windows.Forms.Label();
            this.lblSecretQuestion = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Green;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(49, 376);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(164, 33);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(258, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(164, 33);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.txtPassword);
            this.groupBox.Controls.Add(this.chckbox_ShowPassword);
            this.groupBox.Controls.Add(this.txtUsername);
            this.groupBox.Controls.Add(this.lblPassword);
            this.groupBox.Controls.Add(this.lblUsername);
            this.groupBox.Controls.Add(this.cmbboxSecretQuestion);
            this.groupBox.Controls.Add(this.chckbox_ShowSecretAnswer);
            this.groupBox.Controls.Add(this.txtSecretAnswer);
            this.groupBox.Controls.Add(this.lblSecretAnswer);
            this.groupBox.Controls.Add(this.lblSecretQuestion);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox.Location = new System.Drawing.Point(32, 53);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(406, 292);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(138, 86);
            this.txtPassword.MaxLength = 14;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(234, 25);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // chckbox_ShowPassword
            // 
            this.chckbox_ShowPassword.AutoSize = true;
            this.chckbox_ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chckbox_ShowPassword.FlatAppearance.BorderSize = 0;
            this.chckbox_ShowPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbox_ShowPassword.ForeColor = System.Drawing.Color.Black;
            this.chckbox_ShowPassword.Location = new System.Drawing.Point(138, 117);
            this.chckbox_ShowPassword.Name = "chckbox_ShowPassword";
            this.chckbox_ShowPassword.Size = new System.Drawing.Size(118, 21);
            this.chckbox_ShowPassword.TabIndex = 0;
            this.chckbox_ShowPassword.Text = "Show Password";
            this.chckbox_ShowPassword.UseVisualStyleBackColor = false;
            this.chckbox_ShowPassword.CheckedChanged += new System.EventHandler(this.chckbox_ShowPassword_CheckedChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(138, 48);
            this.txtUsername.MaxLength = 14;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(234, 25);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(63, 86);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 32;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(58, 48);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 31;
            this.lblUsername.Text = "Username";
            // 
            // cmbboxSecretQuestion
            // 
            this.cmbboxSecretQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxSecretQuestion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxSecretQuestion.FormattingEnabled = true;
            this.cmbboxSecretQuestion.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.cmbboxSecretQuestion.Items.AddRange(new object[] {
            "",
            "What is your favorite color?",
            "What is your contact number?",
            "When is your birthday?",
            "What is love for you?",
            "Where were you born ?",
            "What is the meaning of life?",
            "What is your gender?",
            "What is your civil status in life?",
            "What is your dream in life?",
            "What things that makes you happy?",
            "What things that makes you sad?",
            "What things that makes you mad?",
            "What is your job?",
            "What is your favorite song?",
            "What is your favorite band?",
            "What is your favorite singer?"});
            this.cmbboxSecretQuestion.Location = new System.Drawing.Point(138, 149);
            this.cmbboxSecretQuestion.MaxLength = 40;
            this.cmbboxSecretQuestion.Name = "cmbboxSecretQuestion";
            this.cmbboxSecretQuestion.Size = new System.Drawing.Size(234, 25);
            this.cmbboxSecretQuestion.TabIndex = 3;
            // 
            // chckbox_ShowSecretAnswer
            // 
            this.chckbox_ShowSecretAnswer.AutoSize = true;
            this.chckbox_ShowSecretAnswer.BackColor = System.Drawing.Color.Transparent;
            this.chckbox_ShowSecretAnswer.FlatAppearance.BorderSize = 0;
            this.chckbox_ShowSecretAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbox_ShowSecretAnswer.ForeColor = System.Drawing.Color.Black;
            this.chckbox_ShowSecretAnswer.Location = new System.Drawing.Point(138, 226);
            this.chckbox_ShowSecretAnswer.Name = "chckbox_ShowSecretAnswer";
            this.chckbox_ShowSecretAnswer.Size = new System.Drawing.Size(144, 21);
            this.chckbox_ShowSecretAnswer.TabIndex = 0;
            this.chckbox_ShowSecretAnswer.Text = "Show Secret Answer";
            this.chckbox_ShowSecretAnswer.UseVisualStyleBackColor = false;
            this.chckbox_ShowSecretAnswer.CheckedChanged += new System.EventHandler(this.chckbox_ShowSecretAnswer_CheckedChanged);
            // 
            // txtSecretAnswer
            // 
            this.txtSecretAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretAnswer.Location = new System.Drawing.Point(138, 189);
            this.txtSecretAnswer.MaxLength = 40;
            this.txtSecretAnswer.Name = "txtSecretAnswer";
            this.txtSecretAnswer.Size = new System.Drawing.Size(234, 25);
            this.txtSecretAnswer.TabIndex = 4;
            this.txtSecretAnswer.UseSystemPasswordChar = true;
            this.txtSecretAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecretAnswer_KeyPress);
            // 
            // lblSecretAnswer
            // 
            this.lblSecretAnswer.AutoSize = true;
            this.lblSecretAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblSecretAnswer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretAnswer.ForeColor = System.Drawing.Color.Black;
            this.lblSecretAnswer.Location = new System.Drawing.Point(33, 190);
            this.lblSecretAnswer.Name = "lblSecretAnswer";
            this.lblSecretAnswer.Size = new System.Drawing.Size(102, 20);
            this.lblSecretAnswer.TabIndex = 32;
            this.lblSecretAnswer.Text = "Secret Answer";
            // 
            // lblSecretQuestion
            // 
            this.lblSecretQuestion.AutoSize = true;
            this.lblSecretQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblSecretQuestion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblSecretQuestion.Location = new System.Drawing.Point(23, 150);
            this.lblSecretQuestion.Name = "lblSecretQuestion";
            this.lblSecretQuestion.Size = new System.Drawing.Size(113, 20);
            this.lblSecretQuestion.TabIndex = 31;
            this.lblSecretQuestion.Text = "Secret Question";
            // 
            // Frm_CreateAnotherAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 447);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CreateAnotherAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREATE ANOTHER ACCOUNT";
            this.Load += new System.EventHandler(this.Form_CreateAnotherAccount_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnRegister;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.GroupBox groupBox;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.CheckBox chckbox_ShowPassword;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Label lblPassword;
        internal System.Windows.Forms.Label lblUsername;
        internal System.Windows.Forms.ComboBox cmbboxSecretQuestion;
        internal System.Windows.Forms.CheckBox chckbox_ShowSecretAnswer;
        internal System.Windows.Forms.TextBox txtSecretAnswer;
        internal System.Windows.Forms.Label lblSecretAnswer;
        internal System.Windows.Forms.Label lblSecretQuestion;
    }
}