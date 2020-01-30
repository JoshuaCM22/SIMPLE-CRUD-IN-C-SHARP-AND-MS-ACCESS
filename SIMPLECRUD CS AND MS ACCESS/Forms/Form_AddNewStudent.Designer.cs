namespace SIMPLECRUD_CS_AND_MS_ACCESS
{
    partial class Form_AddNewStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddNewStudent));
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.cmbboxMonth = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbboxDay = new System.Windows.Forms.ComboBox();
            this.lblFemale = new System.Windows.Forms.Label();
            this.lblMale = new System.Windows.Forms.Label();
            this.radiobtnFemale = new System.Windows.Forms.RadioButton();
            this.radiobtnMale = new System.Windows.Forms.RadioButton();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtGivenName = new System.Windows.Forms.TextBox();
            this.lblGivenName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnTakeAPicture = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureboxProfile = new System.Windows.Forms.PictureBox();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox
            // 
            this.groupbox.BackColor = System.Drawing.Color.Transparent;
            this.groupbox.Controls.Add(this.lblAge);
            this.groupbox.Controls.Add(this.cmbboxMonth);
            this.groupbox.Controls.Add(this.txtYear);
            this.groupbox.Controls.Add(this.lblDateOfBirth);
            this.groupbox.Controls.Add(this.txtAge);
            this.groupbox.Controls.Add(this.cmbboxDay);
            this.groupbox.Controls.Add(this.lblFemale);
            this.groupbox.Controls.Add(this.lblMale);
            this.groupbox.Controls.Add(this.radiobtnFemale);
            this.groupbox.Controls.Add(this.radiobtnMale);
            this.groupbox.Controls.Add(this.txtMiddleName);
            this.groupbox.Controls.Add(this.txtAddress);
            this.groupbox.Controls.Add(this.lblMiddleName);
            this.groupbox.Controls.Add(this.txtLastName);
            this.groupbox.Controls.Add(this.txtGivenName);
            this.groupbox.Controls.Add(this.lblGivenName);
            this.groupbox.Controls.Add(this.lblAddress);
            this.groupbox.Controls.Add(this.lblGender);
            this.groupbox.Controls.Add(this.lblLastName);
            this.groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox.ForeColor = System.Drawing.Color.Black;
            this.groupbox.Location = new System.Drawing.Point(12, 66);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(900, 231);
            this.groupbox.TabIndex = 148;
            this.groupbox.TabStop = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Black;
            this.lblAge.Location = new System.Drawing.Point(614, 111);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 20);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age";
            // 
            // cmbboxMonth
            // 
            this.cmbboxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxMonth.FormattingEnabled = true;
            this.cmbboxMonth.Items.AddRange(new object[] {
            "Month",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbboxMonth.Location = new System.Drawing.Point(331, 108);
            this.cmbboxMonth.MaxLength = 9;
            this.cmbboxMonth.Name = "cmbboxMonth";
            this.cmbboxMonth.Size = new System.Drawing.Size(98, 28);
            this.cmbboxMonth.TabIndex = 6;
            this.cmbboxMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbboxMonth_KeyPress);
            this.cmbboxMonth.Leave += new System.EventHandler(this.cmbboxMonth_Leave);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.White;
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.Color.Black;
            this.txtYear.Location = new System.Drawing.Point(517, 109);
            this.txtYear.MaxLength = 4;
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(91, 22);
            this.txtYear.TabIndex = 8;
            this.txtYear.Click += new System.EventHandler(this.txtYear_Click);
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.Black;
            this.lblDateOfBirth.Location = new System.Drawing.Point(235, 111);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(96, 20);
            this.lblDateOfBirth.TabIndex = 0;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.Location = new System.Drawing.Point(649, 109);
            this.txtAge.MaxLength = 2;
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(95, 22);
            this.txtAge.TabIndex = 9;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // cmbboxDay
            // 
            this.cmbboxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxDay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxDay.FormattingEnabled = true;
            this.cmbboxDay.Items.AddRange(new object[] {
            "Day",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbboxDay.Location = new System.Drawing.Point(435, 107);
            this.cmbboxDay.MaxLength = 2;
            this.cmbboxDay.Name = "cmbboxDay";
            this.cmbboxDay.Size = new System.Drawing.Size(76, 28);
            this.cmbboxDay.TabIndex = 7;
            this.cmbboxDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbboxDay_KeyPress);
            this.cmbboxDay.Leave += new System.EventHandler(this.cmbboxDay_Leave);
            // 
            // lblFemale
            // 
            this.lblFemale.AutoSize = true;
            this.lblFemale.BackColor = System.Drawing.Color.Transparent;
            this.lblFemale.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemale.ForeColor = System.Drawing.Color.Black;
            this.lblFemale.Location = new System.Drawing.Point(169, 111);
            this.lblFemale.Name = "lblFemale";
            this.lblFemale.Size = new System.Drawing.Size(58, 20);
            this.lblFemale.TabIndex = 0;
            this.lblFemale.Text = "Female";
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.BackColor = System.Drawing.Color.Transparent;
            this.lblMale.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMale.ForeColor = System.Drawing.Color.Black;
            this.lblMale.Location = new System.Drawing.Point(105, 111);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(43, 20);
            this.lblMale.TabIndex = 0;
            this.lblMale.Text = "Male";
            // 
            // radiobtnFemale
            // 
            this.radiobtnFemale.AutoSize = true;
            this.radiobtnFemale.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnFemale.ForeColor = System.Drawing.Color.White;
            this.radiobtnFemale.Location = new System.Drawing.Point(154, 115);
            this.radiobtnFemale.Name = "radiobtnFemale";
            this.radiobtnFemale.Size = new System.Drawing.Size(14, 13);
            this.radiobtnFemale.TabIndex = 5;
            this.radiobtnFemale.TabStop = true;
            this.radiobtnFemale.UseVisualStyleBackColor = true;
            this.radiobtnFemale.CheckedChanged += new System.EventHandler(this.radiobtnFemale_CheckedChanged);
            // 
            // radiobtnMale
            // 
            this.radiobtnMale.AutoSize = true;
            this.radiobtnMale.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnMale.ForeColor = System.Drawing.Color.White;
            this.radiobtnMale.Location = new System.Drawing.Point(85, 113);
            this.radiobtnMale.Name = "radiobtnMale";
            this.radiobtnMale.Size = new System.Drawing.Size(14, 13);
            this.radiobtnMale.TabIndex = 4;
            this.radiobtnMale.TabStop = true;
            this.radiobtnMale.UseVisualStyleBackColor = true;
            this.radiobtnMale.CheckedChanged += new System.EventHandler(this.radiobtnMale_CheckedChanged);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.White;
            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiddleName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.ForeColor = System.Drawing.Color.Black;
            this.txtMiddleName.Location = new System.Drawing.Point(689, 66);
            this.txtMiddleName.MaxLength = 16;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(185, 27);
            this.txtMiddleName.TabIndex = 3;
            this.txtMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiddleName_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(79, 152);
            this.txtAddress.MaxLength = 80;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(805, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.BackColor = System.Drawing.Color.Transparent;
            this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.ForeColor = System.Drawing.Color.Black;
            this.lblMiddleName.Location = new System.Drawing.Point(583, 70);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(102, 20);
            this.lblMiddleName.TabIndex = 0;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(92, 66);
            this.txtLastName.MaxLength = 16;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(185, 27);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtGivenName
            // 
            this.txtGivenName.BackColor = System.Drawing.Color.White;
            this.txtGivenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGivenName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGivenName.ForeColor = System.Drawing.Color.Black;
            this.txtGivenName.Location = new System.Drawing.Point(399, 66);
            this.txtGivenName.MaxLength = 16;
            this.txtGivenName.Name = "txtGivenName";
            this.txtGivenName.Size = new System.Drawing.Size(166, 27);
            this.txtGivenName.TabIndex = 2;
            this.txtGivenName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGivenName_KeyPress);
            // 
            // lblGivenName
            // 
            this.lblGivenName.AutoSize = true;
            this.lblGivenName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGivenName.ForeColor = System.Drawing.Color.Black;
            this.lblGivenName.Location = new System.Drawing.Point(300, 70);
            this.lblGivenName.Name = "lblGivenName";
            this.lblGivenName.Size = new System.Drawing.Size(93, 20);
            this.lblGivenName.TabIndex = 0;
            this.lblGivenName.Text = "Given Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(10, 152);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 20);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(10, 111);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(59, 20);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(9, 70);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 20);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // btnTakeAPicture
            // 
            this.btnTakeAPicture.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTakeAPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakeAPicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTakeAPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAPicture.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAPicture.ForeColor = System.Drawing.Color.Black;
            this.btnTakeAPicture.Location = new System.Drawing.Point(1092, 287);
            this.btnTakeAPicture.Name = "btnTakeAPicture";
            this.btnTakeAPicture.Size = new System.Drawing.Size(134, 25);
            this.btnTakeAPicture.TabIndex = 0;
            this.btnTakeAPicture.Text = "TAKE A PICTURE";
            this.btnTakeAPicture.UseVisualStyleBackColor = false;
            this.btnTakeAPicture.Click += new System.EventHandler(this.btnTakeAPicture_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.Location = new System.Drawing.Point(935, 287);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(145, 25);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(661, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 33);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(461, 393);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 33);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // pictureboxProfile
            // 
            this.pictureboxProfile.BackColor = System.Drawing.Color.White;
            this.pictureboxProfile.BackgroundImage = global::SIMPLECRUD_CS_AND_MS_ACCESS.Properties.Resources.usericon;
            this.pictureboxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureboxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureboxProfile.ErrorImage = null;
            this.pictureboxProfile.InitialImage = null;
            this.pictureboxProfile.Location = new System.Drawing.Point(935, 66);
            this.pictureboxProfile.Name = "pictureboxProfile";
            this.pictureboxProfile.Size = new System.Drawing.Size(291, 198);
            this.pictureboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxProfile.TabIndex = 160;
            this.pictureboxProfile.TabStop = false;
            // 
            // Frm_AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 456);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureboxProfile);
            this.Controls.Add(this.btnTakeAPicture);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AddNewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD NEW STUDENT";
            this.Load += new System.EventHandler(this.Form_AddNewStudent_Load);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupbox;
        internal System.Windows.Forms.Label lblAge;
        internal System.Windows.Forms.ComboBox cmbboxMonth;
        internal System.Windows.Forms.TextBox txtYear;
        internal System.Windows.Forms.Label lblDateOfBirth;
        internal System.Windows.Forms.TextBox txtAge;
        internal System.Windows.Forms.ComboBox cmbboxDay;
        internal System.Windows.Forms.Label lblFemale;
        internal System.Windows.Forms.Label lblMale;
        internal System.Windows.Forms.RadioButton radiobtnFemale;
        internal System.Windows.Forms.RadioButton radiobtnMale;
        internal System.Windows.Forms.TextBox txtMiddleName;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Label lblMiddleName;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.TextBox txtGivenName;
        internal System.Windows.Forms.Label lblGivenName;
        internal System.Windows.Forms.Label lblAddress;
        internal System.Windows.Forms.Label lblGender;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.PictureBox pictureboxProfile;
        internal System.Windows.Forms.Button btnTakeAPicture;
        internal System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
    }
}