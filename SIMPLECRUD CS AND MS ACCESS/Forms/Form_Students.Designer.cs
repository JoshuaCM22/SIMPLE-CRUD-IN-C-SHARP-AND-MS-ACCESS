namespace SIMPLECRUD_CS_AND_MS_ACCESS
{
    partial class Form_Students
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Students));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cmbboxFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.cmbboxFilter);
            this.groupBox.Controls.Add(this.txtSearch);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(21, 28);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(403, 69);
            this.groupBox.TabIndex = 65;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "SEARCH BY :";
            // 
            // cmbboxFilter
            // 
            this.cmbboxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxFilter.FormattingEnabled = true;
            this.cmbboxFilter.Items.AddRange(new object[] {
            "None",
            "Student ID",
            "Last Name",
            "Given Name",
            "Middle Name",
            "Gender",
            "Date of Birth",
            "Age",
            "Address"});
            this.cmbboxFilter.Location = new System.Drawing.Point(14, 28);
            this.cmbboxFilter.Name = "cmbboxFilter";
            this.cmbboxFilter.Size = new System.Drawing.Size(138, 24);
            this.cmbboxFilter.TabIndex = 0;
            this.cmbboxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbboxFilter_KeyPress);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(158, 28);
            this.txtSearch.MaxLength = 22;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.BackColor = System.Drawing.Color.Green;
            this.btnAddNewStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewStudent.FlatAppearance.BorderSize = 0;
            this.btnAddNewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddNewStudent.Location = new System.Drawing.Point(1121, 64);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(199, 33);
            this.btnAddNewStudent.TabIndex = 64;
            this.btnAddNewStudent.Text = "ADD A NEW STUDENT";
            this.btnAddNewStudent.UseVisualStyleBackColor = false;
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(20, 567);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 26);
            this.btnBack.TabIndex = 63;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToResizeColumns = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.Green;
            this.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.ColumnHeadersHeight = 41;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudents.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudents.Location = new System.Drawing.Point(19, 118);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "---------";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1301, 429);
            this.dgvStudents.TabIndex = 62;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(1203, 559);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 20);
            this.lblTotal.TabIndex = 67;
            this.lblTotal.Text = "TOTAL ENTRY";
            // 
            // Frm_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1345, 612);
            this.ControlBox = false;
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnAddNewStudent);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Students_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox;
        internal System.Windows.Forms.ComboBox cmbboxFilter;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Button btnAddNewStudent;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.DataGridView dgvStudents;
        internal System.Windows.Forms.Label lblTotal;

        
    }
}