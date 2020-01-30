using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
namespace SIMPLECRUD_CS_AND_MS_ACCESS // Created by: Joshua C. Magoliman
{
    public partial class Form_Camera : Form
    {
        public Form_Camera()
        {
            InitializeComponent();
        }
        private VideoCaptureDevice videoCaptureDevice;
        private Bitmap bitmap;
        private void Captured(object sender, NewFrameEventArgs eventArgs)
        {
            bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureboxOne.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void Form_Camera_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoCaptureDevice.Stop();
        }
        private void Form_Camera_Load(object sender, EventArgs e)
        {
            pictureboxTwo.Image = SIMPLECRUD_CS_AND_MS_ACCESS.Properties.Resources.usericon;
            btnCaptured.Hide();
            btnSaveImage.Hide();
            btnStart.Show();
        }
        public void HidebtnStudentProfile()
        {
            btnStudentProfile.Hide();
        }
        public void HidebtnAddNewStudent()
        {
            btnAddNewStudent.Hide();
        }
        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }
        private void btnStudentProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }
        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog.DefaultExt = ".jpg";
            if (SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureboxTwo.Image.Save(SaveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                pictureboxTwo.Image = SIMPLECRUD_CS_AND_MS_ACCESS.Properties.Resources.usericon;
                pictureboxTwo.BackColor = Color.DimGray;
            }
        }
        private void btnCaptured_Click(object sender, EventArgs e)
        {
            pictureboxTwo.Image = pictureboxOne.Image;
            pictureboxTwo.BackColor = Color.Black;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            VideoCaptureDeviceForm vcdf = new VideoCaptureDeviceForm();
            if (vcdf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                videoCaptureDevice = vcdf.VideoDevice;
                videoCaptureDevice.NewFrame += new NewFrameEventHandler(Captured);
                videoCaptureDevice.Start();
                Button1.Hide();
                btnCaptured.Show();
                btnSaveImage.Show();
                btnStart.Hide();
            }
        }
    }
}
