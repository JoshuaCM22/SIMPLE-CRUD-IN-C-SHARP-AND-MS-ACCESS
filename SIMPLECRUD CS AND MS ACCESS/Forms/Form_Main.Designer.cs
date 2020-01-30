namespace SIMPLECRUD_CS_AND_MS_ACCESS
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.btnStudents = new System.Windows.Forms.Button();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.lblDayToday = new System.Windows.Forms.Label();
            this.lblDateToday = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolstrip_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_CreateAnotherAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.Green;
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Location = new System.Drawing.Point(324, 210);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(219, 44);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "STUDENTS";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.AutoSize = true;
            this.lblTimeNow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeNow.ForeColor = System.Drawing.Color.Black;
            this.lblTimeNow.Location = new System.Drawing.Point(673, 390);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(107, 24);
            this.lblTimeNow.TabIndex = 136;
            this.lblTimeNow.Text = "TIME NOW";
            // 
            // lblDayToday
            // 
            this.lblDayToday.AutoSize = true;
            this.lblDayToday.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDayToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayToday.ForeColor = System.Drawing.Color.Black;
            this.lblDayToday.Location = new System.Drawing.Point(382, 390);
            this.lblDayToday.Name = "lblDayToday";
            this.lblDayToday.Size = new System.Drawing.Size(118, 24);
            this.lblDayToday.TabIndex = 135;
            this.lblDayToday.Text = "DAY TODAY";
            // 
            // lblDateToday
            // 
            this.lblDateToday.AutoSize = true;
            this.lblDateToday.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateToday.ForeColor = System.Drawing.Color.Black;
            this.lblDateToday.Location = new System.Drawing.Point(66, 390);
            this.lblDateToday.Name = "lblDateToday";
            this.lblDateToday.Size = new System.Drawing.Size(131, 24);
            this.lblDateToday.TabIndex = 134;
            this.lblDateToday.Text = "DATE TODAY";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(162, 92);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(539, 31);
            this.lblTitle.TabIndex = 137;
            this.lblTitle.Text = "SIMPLE CRUD IN C# AND MS ACCESS";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_Settings});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(856, 24);
            this.menuStrip.TabIndex = 138;
            this.menuStrip.Text = "MenuStrip1";
            // 
            // toolstrip_Settings
            // 
            this.toolstrip_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_CreateAnotherAccount,
            this.toolstrip_ChangePassword,
            this.toolstrip_Logout});
            this.toolstrip_Settings.Name = "toolstrip_Settings";
            this.toolstrip_Settings.Size = new System.Drawing.Size(69, 20);
            this.toolstrip_Settings.Text = "SETTINGS";
            // 
            // toolstrip_CreateAnotherAccount
            // 
            this.toolstrip_CreateAnotherAccount.BackColor = System.Drawing.Color.White;
            this.toolstrip_CreateAnotherAccount.Name = "toolstrip_CreateAnotherAccount";
            this.toolstrip_CreateAnotherAccount.Size = new System.Drawing.Size(232, 22);
            this.toolstrip_CreateAnotherAccount.Text = "CREATE ANOTHER ACCOUNT ";
            this.toolstrip_CreateAnotherAccount.Click += new System.EventHandler(this.toolstrip_CreateAnotherAccount_Click);
            // 
            // toolstrip_ChangePassword
            // 
            this.toolstrip_ChangePassword.BackColor = System.Drawing.Color.White;
            this.toolstrip_ChangePassword.Name = "toolstrip_ChangePassword";
            this.toolstrip_ChangePassword.Size = new System.Drawing.Size(232, 22);
            this.toolstrip_ChangePassword.Text = "CHANGE PASSWORD";
            this.toolstrip_ChangePassword.Click += new System.EventHandler(this.toolstrip_ChangePassword_Click);
            // 
            // toolstrip_Logout
            // 
            this.toolstrip_Logout.BackColor = System.Drawing.Color.White;
            this.toolstrip_Logout.Name = "toolstrip_Logout";
            this.toolstrip_Logout.Size = new System.Drawing.Size(232, 22);
            this.toolstrip_Logout.Text = "LOG-OUT";
            this.toolstrip_Logout.Click += new System.EventHandler(this.toolstrip_Logout_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(856, 447);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTimeNow);
            this.Controls.Add(this.lblDayToday);
            this.Controls.Add(this.lblDateToday);
            this.Controls.Add(this.btnStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnStudents;
        internal System.Windows.Forms.Label lblDayToday;
        internal System.Windows.Forms.Label lblDateToday;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblTimeNow;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.MenuStrip menuStrip;
        internal System.Windows.Forms.ToolStripMenuItem toolstrip_Settings;
        internal System.Windows.Forms.ToolStripMenuItem toolstrip_CreateAnotherAccount;
        internal System.Windows.Forms.ToolStripMenuItem toolstrip_ChangePassword;
        internal System.Windows.Forms.ToolStripMenuItem toolstrip_Logout;
    }
}