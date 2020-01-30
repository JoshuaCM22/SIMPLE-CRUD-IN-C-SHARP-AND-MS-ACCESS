namespace SIMPLECRUD_CS_AND_MS_ACCESS
{
    partial class Form_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Profile));
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFemale = new System.Windows.Forms.Label();
            this.lblMale = new System.Windows.Forms.Label();
            this.radiobtnMale = new System.Windows.Forms.RadioButton();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.btnTakeAPicture = new System.Windows.Forms.Button();
            this.radiobtnFemale = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtGivenName = new System.Windows.Forms.TextBox();
            this.lblGivenName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblAddress = new System.Windows.Forms.Label();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.groupboxButtons = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureboxProfile = new System.Windows.Forms.PictureBox();
            this.groupbox.SuspendLayout();
            this.groupboxButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Black;
            this.lblAge.Location = new System.Drawing.Point(539, 117);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 20);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.Black;
            this.lblDateOfBirth.Location = new System.Drawing.Point(243, 116);
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
            this.txtAge.Location = new System.Drawing.Point(574, 115);
            this.txtAge.MaxLength = 2;
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(95, 22);
            this.txtAge.TabIndex = 7;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.Location = new System.Drawing.Point(951, 301);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(145, 25);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblFemale
            // 
            this.lblFemale.AutoSize = true;
            this.lblFemale.BackColor = System.Drawing.Color.Transparent;
            this.lblFemale.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemale.ForeColor = System.Drawing.Color.Black;
            this.lblFemale.Location = new System.Drawing.Point(169, 116);
            this.lblFemale.Name = "lblFemale";
            this.lblFemale.Size = new System.Drawing.Size(58, 20);
            this.lblFemale.TabIndex = 135;
            this.lblFemale.Text = "Female";
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.BackColor = System.Drawing.Color.Transparent;
            this.lblMale.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMale.ForeColor = System.Drawing.Color.Black;
            this.lblMale.Location = new System.Drawing.Point(105, 116);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(43, 20);
            this.lblMale.TabIndex = 134;
            this.lblMale.Text = "Male";
            // 
            // radiobtnMale
            // 
            this.radiobtnMale.AutoSize = true;
            this.radiobtnMale.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnMale.ForeColor = System.Drawing.Color.White;
            this.radiobtnMale.Location = new System.Drawing.Point(85, 118);
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
            this.txtMiddleName.Location = new System.Drawing.Point(699, 70);
            this.txtMiddleName.MaxLength = 16;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(185, 27);
            this.txtMiddleName.TabIndex = 3;
            this.txtMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiddleName_KeyPress);
            // 
            // btnTakeAPicture
            // 
            this.btnTakeAPicture.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTakeAPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakeAPicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTakeAPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAPicture.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAPicture.ForeColor = System.Drawing.Color.Black;
            this.btnTakeAPicture.Location = new System.Drawing.Point(1108, 301);
            this.btnTakeAPicture.Name = "btnTakeAPicture";
            this.btnTakeAPicture.Size = new System.Drawing.Size(134, 25);
            this.btnTakeAPicture.TabIndex = 0;
            this.btnTakeAPicture.Text = "TAKE A PICTURE";
            this.btnTakeAPicture.UseVisualStyleBackColor = false;
            this.btnTakeAPicture.Click += new System.EventHandler(this.btnTakeAPicture_Click);
            // 
            // radiobtnFemale
            // 
            this.radiobtnFemale.AutoSize = true;
            this.radiobtnFemale.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnFemale.ForeColor = System.Drawing.Color.White;
            this.radiobtnFemale.Location = new System.Drawing.Point(154, 120);
            this.radiobtnFemale.Name = "radiobtnFemale";
            this.radiobtnFemale.Size = new System.Drawing.Size(14, 13);
            this.radiobtnFemale.TabIndex = 5;
            this.radiobtnFemale.TabStop = true;
            this.radiobtnFemale.UseVisualStyleBackColor = true;
            this.radiobtnFemale.CheckedChanged += new System.EventHandler(this.radiobtnFemale_CheckedChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(79, 157);
            this.txtAddress.MaxLength = 80;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(805, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.BackColor = System.Drawing.Color.Transparent;
            this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.ForeColor = System.Drawing.Color.Black;
            this.lblMiddleName.Location = new System.Drawing.Point(592, 75);
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
            this.txtLastName.Location = new System.Drawing.Point(94, 70);
            this.txtLastName.MaxLength = 16;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(185, 27);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtGivenName
            // 
            this.txtGivenName.BackColor = System.Drawing.Color.White;
            this.txtGivenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGivenName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGivenName.ForeColor = System.Drawing.Color.Black;
            this.txtGivenName.Location = new System.Drawing.Point(409, 70);
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
            this.lblGivenName.Location = new System.Drawing.Point(304, 75);
            this.lblGivenName.Name = "lblGivenName";
            this.lblGivenName.Size = new System.Drawing.Size(93, 20);
            this.lblGivenName.TabIndex = 0;
            this.lblGivenName.Text = "Given Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(10, 116);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(59, 20);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            // 
            // txtStudentId
            // 
            this.txtStudentId.BackColor = System.Drawing.Color.White;
            this.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentId.Enabled = false;
            this.txtStudentId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.ForeColor = System.Drawing.Color.Black;
            this.txtStudentId.Location = new System.Drawing.Point(94, 32);
            this.txtStudentId.MaxLength = 10;
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(164, 27);
            this.txtStudentId.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(9, 75);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 20);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.ForeColor = System.Drawing.Color.Black;
            this.lblStudentId.Location = new System.Drawing.Point(11, 34);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(81, 20);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student ID";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(10, 157);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 20);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // groupbox
            // 
            this.groupbox.BackColor = System.Drawing.Color.Transparent;
            this.groupbox.Controls.Add(this.dtpDateOfBirth);
            this.groupbox.Controls.Add(this.lblAge);
            this.groupbox.Controls.Add(this.lblDateOfBirth);
            this.groupbox.Controls.Add(this.txtAge);
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
            this.groupbox.Controls.Add(this.txtStudentId);
            this.groupbox.Controls.Add(this.lblLastName);
            this.groupbox.Controls.Add(this.lblStudentId);
            this.groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox.ForeColor = System.Drawing.Color.Black;
            this.groupbox.Location = new System.Drawing.Point(28, 80);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(900, 231);
            this.groupbox.TabIndex = 164;
            this.groupbox.TabStop = false;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(350, 116);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(163, 22);
            this.dtpDateOfBirth.TabIndex = 160;
            // 
            // groupboxButtons
            // 
            this.groupboxButtons.BackColor = System.Drawing.Color.Transparent;
            this.groupboxButtons.Controls.Add(this.btnDelete);
            this.groupboxButtons.Controls.Add(this.btnEdit);
            this.groupboxButtons.Controls.Add(this.btnUpdate);
            this.groupboxButtons.ForeColor = System.Drawing.Color.Black;
            this.groupboxButtons.Location = new System.Drawing.Point(399, 386);
            this.groupboxButtons.Name = "groupboxButtons";
            this.groupboxButtons.Size = new System.Drawing.Size(344, 69);
            this.groupboxButtons.TabIndex = 170;
            this.groupboxButtons.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Green;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(229, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 33);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Green;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(19, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 33);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(125, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 33);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Green;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1143, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureboxProfile
            // 
            this.pictureboxProfile.BackColor = System.Drawing.Color.White;
            this.pictureboxProfile.BackgroundImage = global::SIMPLECRUD_CS_AND_MS_ACCESS.Properties.Resources.usericon;
            this.pictureboxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureboxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureboxProfile.ErrorImage = null;
            this.pictureboxProfile.InitialImage = null;
            this.pictureboxProfile.Location = new System.Drawing.Point(951, 80);
            this.pictureboxProfile.Name = "pictureboxProfile";
            this.pictureboxProfile.Size = new System.Drawing.Size(291, 198);
            this.pictureboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxProfile.TabIndex = 167;
            this.pictureboxProfile.TabStop = false;
            // 
            // Frm_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1302, 507);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupboxButtons);
            this.Controls.Add(this.pictureboxProfile);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnTakeAPicture);
            this.Controls.Add(this.groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Profile_Load);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.groupboxButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox pictureboxProfile;
        internal System.Windows.Forms.Label lblAge;
        internal System.Windows.Forms.Label lblDateOfBirth;
        internal System.Windows.Forms.TextBox txtAge;
        internal System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.Label lblFemale;
        internal System.Windows.Forms.Label lblMale;
        internal System.Windows.Forms.RadioButton radiobtnMale;
        internal System.Windows.Forms.TextBox txtMiddleName;
        internal System.Windows.Forms.Button btnTakeAPicture;
        internal System.Windows.Forms.RadioButton radiobtnFemale;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Label lblMiddleName;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.TextBox txtGivenName;
        internal System.Windows.Forms.Label lblGivenName;
        internal System.Windows.Forms.Label lblGender;
        internal System.Windows.Forms.TextBox txtStudentId;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.Label lblAddress;
        internal System.Windows.Forms.GroupBox groupbox;
        internal System.Windows.Forms.GroupBox groupboxButtons;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.DateTimePicker dtpDateOfBirth;
    }
}