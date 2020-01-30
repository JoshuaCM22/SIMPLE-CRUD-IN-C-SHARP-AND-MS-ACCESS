using System;
using System.Windows.Forms;
namespace SIMPLECRUD_CS_AND_MS_ACCESS // Created by: Joshua C. Magoliman
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTimeNow.Focus();
            lblDateToday.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            lblDayToday.Text = DateTime.Now.DayOfWeek.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeNow.Text = DateTime.Now.ToLongTimeString();
            lblDateToday.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            lblDayToday.Text = DateTime.Now.DayOfWeek.ToString();
        }
        private void btnStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Students nextForm = new Form_Students();
            nextForm.Show();
            nextForm.lblTotal.Text = "TOTAL ENTRY: " + nextForm.dgvStudents.Rows.Count.ToString();
        }
        private void toolstrip_CreateAnotherAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nextForm = new Form_CreateAnotherAccount();
            nextForm.Show();
        }
        private void toolstrip_ChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nextForm = new Form_ChangePassword();
            nextForm.Show();
        }
        private void toolstrip_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log-out ?", "ATTENTION",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                var myForm = new Form_Login();
                myForm.Show();
            }
        }
    }
}
