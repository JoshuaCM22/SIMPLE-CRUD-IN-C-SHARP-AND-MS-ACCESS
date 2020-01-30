namespace SIMPLECRUD_CS_AND_MS_ACCESS
{
    partial class Form_ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ForgotPassword));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cmbboxSecretQuestion = new System.Windows.Forms.ComboBox();
            this.chckboxSecretAnswer = new System.Windows.Forms.CheckBox();
            this.txtSecretAnswer = new System.Windows.Forms.TextBox();
            this.lblSecretAnswer = new System.Windows.Forms.Label();
            this.lblSecretQuestion = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtShowPassword = new System.Windows.Forms.TextBox();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.cmbboxSecretQuestion);
            this.groupBox.Controls.Add(this.chckboxSecretAnswer);
            this.groupBox.Controls.Add(this.txtSecretAnswer);
            this.groupBox.Controls.Add(this.lblSecretAnswer);
            this.groupBox.Controls.Add(this.lblSecretQuestion);
            this.groupBox.Controls.Add(this.txtUsername);
            this.groupBox.Controls.Add(this.lblUsername);
            this.groupBox.Location = new System.Drawing.Point(34, 48);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(406, 222);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // cmbboxSecretQuestion
            // 
            this.cmbboxSecretQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxSecretQuestion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxSecretQuestion.FormattingEnabled = true;
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
            this.cmbboxSecretQuestion.Location = new System.Drawing.Point(135, 89);
            this.cmbboxSecretQuestion.MaxLength = 200;
            this.cmbboxSecretQuestion.Name = "cmbboxSecretQuestion";
            this.cmbboxSecretQuestion.Size = new System.Drawing.Size(240, 25);
            this.cmbboxSecretQuestion.TabIndex = 2;
            // 
            // chckboxSecretAnswer
            // 
            this.chckboxSecretAnswer.AutoSize = true;
            this.chckboxSecretAnswer.BackColor = System.Drawing.Color.Transparent;
            this.chckboxSecretAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckboxSecretAnswer.ForeColor = System.Drawing.Color.Black;
            this.chckboxSecretAnswer.Location = new System.Drawing.Point(135, 169);
            this.chckboxSecretAnswer.Name = "chckboxSecretAnswer";
            this.chckboxSecretAnswer.Size = new System.Drawing.Size(144, 21);
            this.chckboxSecretAnswer.TabIndex = 0;
            this.chckboxSecretAnswer.Text = "Show Secret Answer";
            this.chckboxSecretAnswer.UseVisualStyleBackColor = false;
            this.chckboxSecretAnswer.CheckedChanged += new System.EventHandler(this.chckboxSecretAnswer_CheckedChanged);
            // 
            // txtSecretAnswer
            // 
            this.txtSecretAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretAnswer.Location = new System.Drawing.Point(135, 129);
            this.txtSecretAnswer.MaxLength = 40;
            this.txtSecretAnswer.Name = "txtSecretAnswer";
            this.txtSecretAnswer.Size = new System.Drawing.Size(240, 25);
            this.txtSecretAnswer.TabIndex = 3;
            this.txtSecretAnswer.UseSystemPasswordChar = true;
            this.txtSecretAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecretAnswer_KeyPress);
            // 
            // lblSecretAnswer
            // 
            this.lblSecretAnswer.AutoSize = true;
            this.lblSecretAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblSecretAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSecretAnswer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretAnswer.ForeColor = System.Drawing.Color.Black;
            this.lblSecretAnswer.Location = new System.Drawing.Point(30, 132);
            this.lblSecretAnswer.Name = "lblSecretAnswer";
            this.lblSecretAnswer.Size = new System.Drawing.Size(102, 20);
            this.lblSecretAnswer.TabIndex = 44;
            this.lblSecretAnswer.Text = "Secret Answer";
            // 
            // lblSecretQuestion
            // 
            this.lblSecretQuestion.AutoSize = true;
            this.lblSecretQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblSecretQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSecretQuestion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblSecretQuestion.Location = new System.Drawing.Point(19, 92);
            this.lblSecretQuestion.Name = "lblSecretQuestion";
            this.lblSecretQuestion.Size = new System.Drawing.Size(113, 20);
            this.lblSecretQuestion.TabIndex = 43;
            this.lblSecretQuestion.Text = "Secret Question";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(135, 47);
            this.txtUsername.MaxLength = 14;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 25);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(57, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 41;
            this.lblUsername.Text = "Username";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(321, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtShowPassword
            // 
            this.txtShowPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtShowPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShowPassword.Enabled = false;
            this.txtShowPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowPassword.ForeColor = System.Drawing.Color.Black;
            this.txtShowPassword.Location = new System.Drawing.Point(222, 300);
            this.txtShowPassword.Name = "txtShowPassword";
            this.txtShowPassword.Size = new System.Drawing.Size(202, 27);
            this.txtShowPassword.TabIndex = 0;
            this.txtShowPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.Green;
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPassword.ForeColor = System.Drawing.Color.White;
            this.btnShowPassword.Location = new System.Drawing.Point(42, 297);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(162, 30);
            this.btnShowPassword.TabIndex = 4;
            this.btnShowPassword.Text = "SHOW PASSWORD";
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // Frm_ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(479, 441);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtShowPassword);
            this.Controls.Add(this.btnShowPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORGOT PASSWORD ?";
            this.Load += new System.EventHandler(this.Form_ForgotPassword_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox;
        internal System.Windows.Forms.ComboBox cmbboxSecretQuestion;
        internal System.Windows.Forms.CheckBox chckboxSecretAnswer;
        internal System.Windows.Forms.TextBox txtSecretAnswer;
        internal System.Windows.Forms.Label lblSecretAnswer;
        internal System.Windows.Forms.Label lblSecretQuestion;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Label lblUsername;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.TextBox txtShowPassword;
        internal System.Windows.Forms.Button btnShowPassword;
    }
}