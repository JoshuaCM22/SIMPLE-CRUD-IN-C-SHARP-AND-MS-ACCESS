namespace SIMPLECRUD_CS_AND_MS_ACCESS
{
    partial class Form_Camera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Camera));
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCaptured = new System.Windows.Forms.Button();
            this.btnStudentProfile = new System.Windows.Forms.Button();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pictureboxTwo = new System.Windows.Forms.PictureBox();
            this.pictureboxOne = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxOne)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.BackColor = System.Drawing.Color.Black;
            this.btnSaveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImage.ForeColor = System.Drawing.Color.White;
            this.btnSaveImage.Location = new System.Drawing.Point(950, 509);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(115, 33);
            this.btnSaveImage.TabIndex = 63;
            this.btnSaveImage.Text = "SAVE IMAGE";
            this.btnSaveImage.UseVisualStyleBackColor = false;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(292, 7);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(94, 33);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "START";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Black;
            this.panel.Controls.Add(this.btnStart);
            this.panel.Controls.Add(this.btnCaptured);
            this.panel.Controls.Add(this.Button1);
            this.panel.Location = new System.Drawing.Point(46, 566);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(674, 60);
            this.panel.TabIndex = 64;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(292, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 33);
            this.btnStart.TabIndex = 67;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCaptured
            // 
            this.btnCaptured.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCaptured.BackgroundImage = global::SIMPLECRUD_CS_AND_MS_ACCESS.Properties.Resources.cameraicon;
            this.btnCaptured.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCaptured.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaptured.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCaptured.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptured.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptured.ForeColor = System.Drawing.Color.Black;
            this.btnCaptured.Location = new System.Drawing.Point(292, 7);
            this.btnCaptured.Name = "btnCaptured";
            this.btnCaptured.Size = new System.Drawing.Size(94, 44);
            this.btnCaptured.TabIndex = 8;
            this.btnCaptured.UseVisualStyleBackColor = false;
            this.btnCaptured.Click += new System.EventHandler(this.btnCaptured_Click);
            // 
            // btnStudentProfile
            // 
            this.btnStudentProfile.BackColor = System.Drawing.Color.Green;
            this.btnStudentProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentProfile.FlatAppearance.BorderSize = 0;
            this.btnStudentProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentProfile.ForeColor = System.Drawing.Color.White;
            this.btnStudentProfile.Location = new System.Drawing.Point(1128, 600);
            this.btnStudentProfile.Name = "btnStudentProfile";
            this.btnStudentProfile.Size = new System.Drawing.Size(129, 26);
            this.btnStudentProfile.TabIndex = 65;
            this.btnStudentProfile.Text = "BACK";
            this.btnStudentProfile.UseVisualStyleBackColor = false;
            this.btnStudentProfile.Click += new System.EventHandler(this.btnStudentProfile_Click);
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.BackColor = System.Drawing.Color.Green;
            this.btnAddNewStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewStudent.FlatAppearance.BorderSize = 0;
            this.btnAddNewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddNewStudent.Location = new System.Drawing.Point(1128, 600);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(129, 26);
            this.btnAddNewStudent.TabIndex = 66;
            this.btnAddNewStudent.Text = "BACK";
            this.btnAddNewStudent.UseVisualStyleBackColor = false;
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "jpg|*.jpg|gif|*.gif ";
            // 
            // pictureboxTwo
            // 
            this.pictureboxTwo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureboxTwo.Location = new System.Drawing.Point(770, 106);
            this.pictureboxTwo.Name = "pictureboxTwo";
            this.pictureboxTwo.Size = new System.Drawing.Size(465, 383);
            this.pictureboxTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxTwo.TabIndex = 61;
            this.pictureboxTwo.TabStop = false;
            // 
            // pictureboxOne
            // 
            this.pictureboxOne.BackColor = System.Drawing.Color.Black;
            this.pictureboxOne.Location = new System.Drawing.Point(46, 22);
            this.pictureboxOne.Name = "pictureboxOne";
            this.pictureboxOne.Size = new System.Drawing.Size(674, 580);
            this.pictureboxOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxOne.TabIndex = 60;
            this.pictureboxOne.TabStop = false;
            // 
            // Frm_Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 650);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureboxTwo);
            this.Controls.Add(this.pictureboxOne);
            this.Controls.Add(this.btnAddNewStudent);
            this.Controls.Add(this.btnStudentProfile);
            this.Controls.Add(this.btnSaveImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Camera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAKE A PICTURE";
            this.Load += new System.EventHandler(this.Form_Camera_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnSaveImage;
        internal System.Windows.Forms.Button btnCaptured;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Panel panel;
        internal System.Windows.Forms.Button btnStudentProfile;
        internal System.Windows.Forms.Button btnAddNewStudent;
        internal System.Windows.Forms.PictureBox pictureboxOne;
        internal System.Windows.Forms.PictureBox pictureboxTwo;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog;
        internal System.Windows.Forms.Button btnStart;

    }
}