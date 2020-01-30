using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace SIMPLECRUD_CS_AND_MS_ACCESS // Created by: Joshua C. Magoliman
{
    public partial class Form_AddNewStudent : Form
    {
        public Form_AddNewStudent()
        {
            InitializeComponent();
        }
        private string gender, holder = "";
        private void Form_AddNewStudent_Load(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            this.ActiveControl = txtLastName;
            btnBack.Text = "BACK";
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtGivenName.Clear();
            radiobtnMale.Checked = false;
            radiobtnFemale.Checked = false;
            cmbboxMonth.Text = "Month";
            cmbboxDay.Text = "Day";
            txtYear.Text = "Year";
            txtAge.Clear();
            txtAddress.Clear();
            pictureboxProfile.Image = null;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtLastName.Text == "" && txtMiddleName.Text == "" && txtGivenName.Text == "" && radiobtnMale.Checked == false && radiobtnFemale.Checked == false && cmbboxMonth.Text == "Month" && cmbboxDay.Text == "Day" && txtYear.Text == "Year" && txtAge.Text == "" && txtAddress.Text == ""))
            {
                MessageBox.Show("Fill up all details", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtLastName;
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("No Surname", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtLastName;
            }
            else if (txtMiddleName.Text == "")
            {
                MessageBox.Show("No First Name Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtMiddleName;
            }
            else if (txtGivenName.Text == "")
            {
                MessageBox.Show("No Middle Name Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtGivenName;
            }
            else if ((radiobtnMale.Checked == false && radiobtnFemale.Checked == false))
            {
                MessageBox.Show("No Gender Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbboxMonth.Text == "Month")
            {
                MessageBox.Show("No Month Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbboxDay.Text == "Day")
            {
                MessageBox.Show("No Day Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtYear.Text == "Year")
            {
                MessageBox.Show("No Year Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAge.Text == "")
            {
                MessageBox.Show("No Age Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtAge;
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("No Address Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtAddress;
            }
            else if (pictureboxProfile.Image == null)
            {
                MessageBox.Show("No Photo Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnBrowseClicked();
            }
            else
            {
                try
                {
                    byte[] imageByte = null;
                    FileStream fstream = new FileStream(holder, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fstream);
                    imageByte = binaryReader.ReadBytes((int)fstream.Length);
                    string combine, month, day, year;
                    month = cmbboxMonth.Text;
                    day = cmbboxDay.Text + (",");
                    year = txtYear.Text;
                    combine = month + " " + day + " " + year;
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("spInsertNewStudent", Objects.con);
                    Objects.cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@lastname", txtLastName.Text));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@givenname", txtGivenName.Text));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@middlename", txtMiddleName.Text));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@gender", gender));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@date_of_birth", combine));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@age", txtAge.Text));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@address", txtAddress.Text));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@photo", imageByte));
                    Objects.cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Registered !", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    Objects.con.Close();
                    Reset();
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (btnBack.Text == "BACK")
            {
                Reset();
                Form_Students nextForm = new Form_Students();
                nextForm.Show();
                nextForm.lblTotal.Text = "TOTAL ENTRY: " + nextForm.dgvStudents.Rows.Count.ToString();
                this.Close();
            }
            else if (btnBack.Text == "CANCEL")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel ?", "ATTENTION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    Reset();
                    Form_Students nextForm = new Form_Students();
                    nextForm.Show();
                    nextForm.lblTotal.Text = "TOTAL ENTRY: " + nextForm.dgvStudents.Rows.Count.ToString();
                }
            }
        }
        private void radiobtnMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "1";
        }
        private void radiobtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "2";
        }
        private void btnTakeAPicture_Click(object sender, EventArgs e)
        {
            this.ActiveControl = lblLastName;
            Form_Camera nextForm = new Form_Camera();
            nextForm.HidebtnAddNewStudent();
            nextForm.ShowDialog();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            btnBrowseClicked();
        }
        private void btnBrowseClicked()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string picturelocation = openFileDialog1.FileName.ToString();
                holder = picturelocation;
                pictureboxProfile.ImageLocation = picturelocation;
            }
            this.ActiveControl = lblLastName;
        }
        private void cmbboxMonth_Leave(object sender, EventArgs e)
        {
            if (cmbboxMonth.Text == "")
            {
               cmbboxMonth.Text = "Month";
            }
        }
        private void cmbboxDay_Leave(object sender, EventArgs e)
        {
            if (cmbboxDay.Text == "")
            {
                cmbboxDay.Text = "Day";
            }
        }
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            int todayYear = DateTime.Today.Year;
            int todayDay = DateTime.Today.Day;
            int todayMonth = DateTime.Today.Month;
            int getValueOfYear = Convert.ToInt32(NumericHelper.Val(txtYear.Text));
            int getValueopenFileDialog1ay = Convert.ToInt32(NumericHelper.Val(cmbboxDay.Text));
            string getValueOfMonth = (cmbboxMonth.SelectedIndex + 1).ToString();
            int finalOutput = todayYear - getValueOfYear;
            if (todayMonth == Convert.ToInt32(getValueOfMonth))
            {
                if (todayDay < getValueopenFileDialog1ay)
                {
                    finalOutput -= 1;
                }
            }
            else if (todayMonth < Convert.ToInt32(getValueOfMonth))
            {
                finalOutput -= 1;
            }
            txtAge.Text = finalOutput.ToString();
        }
        private void txtYear_Leave(object sender, EventArgs e)
        {
            if (txtYear.Text == "")
            {
               txtYear.Text = "Year";
                txtAge.Clear();
            }
        }
        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtYear_Click(object sender, EventArgs e)
        {
            if (txtYear.Text == "Year")
            {
                txtYear.Text = "";
            }
        }
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                btnBack.Text = "BACK";
            }
            else
            {
                btnBack.Text = "CANCEL";
            }
        }
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtGivenName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void cmbboxMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void cmbboxDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}