using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace SIMPLECRUD_CS_AND_MS_ACCESS // Created by: Joshua C. Magoliman
{
    public partial class Form_Students : Form
    {
        public Form_Students()
        {
            InitializeComponent();
        }
        private void Form_Students_Load(object sender, EventArgs e)
        {
            GetData();
            cmbboxFilter.Text = "None";
        }
        public void GetData()
        {
            txtSearch.Clear();
            btnBack.Visible = true;
            Objects.da = new OleDbDataAdapter();
            Objects.dt = new DataTable();
            Objects.ds = new DataSet();
            try
            {
                Objects.con.Open();
                Objects.da = new OleDbDataAdapter("vWGetAllStudents", Objects.con);
                Objects.da.SelectCommand.CommandType = CommandType.TableDirect;
                Objects.da.Fill(Objects.ds);
                dgvStudents.DataSource = Objects.ds.Tables[0];
                dgvStudents.Columns[8].Visible = false;
                dgvStudents.Columns[0].Width = 200;
                dgvStudents.Columns[1].Width = 200;
                dgvStudents.Columns[2].Width = 200;
                dgvStudents.Columns[3].Width = 200;
                dgvStudents.Columns[4].Width = 100;
                dgvStudents.Columns[5].Width = 130;
                dgvStudents.Columns[6].Width = 60;
                dgvStudents.Columns[7].Width = 400;
                Objects.da.Update(Objects.dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Objects.con.Close();
                txtSearch.Focus();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main nextForm = new Form_Main();
            nextForm.Show();
        }
        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            this.Close();
            var nextForm = new Form_AddNewStudent();
            nextForm.ShowDialog();
        }
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Objects.con.Open();
            DataGridViewRow row = dgvStudents.CurrentRow;
            btnBack.Visible = false;
            lblTotal.Visible = false;
            var nextForm = new Form_Profile();
            nextForm.txtStudentId.Text = row.Cells[0].Value.ToString();
            nextForm.txtLastName.Text = row.Cells[1].Value.ToString();
            nextForm.txtGivenName.Text = row.Cells[2].Value.ToString();
            nextForm.txtMiddleName.Text = row.Cells[3].Value.ToString();
            string gettingGender = row.Cells["Gender"].Value.ToString();
            if (gettingGender == "Male")
            {
                nextForm.radiobtnMale.Checked = true;
            }
            else if (gettingGender == "Female")
            {
                nextForm.radiobtnFemale.Checked = true;
            }
            nextForm.dtpDateOfBirth.Value = (DateTime)row.Cells[5].Value;
            nextForm.txtAge.Text = row.Cells[6].Value.ToString();
            nextForm.txtAddress.Text = row.Cells[7].Value.ToString();
            byte[] arrImage = (byte[])(row.Cells["photo"].Value);
            MemoryStream mstream = new MemoryStream(arrImage);
            nextForm.pictureboxProfile.Image = Image.FromStream(mstream);
            Objects.con.Close();
            nextForm.ShowDialog();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Objects.da = new OleDbDataAdapter();
            Objects.dt = new DataTable();
            Objects.ds = new DataSet();
            if (txtSearch.Text == "")
            {
                GetData();
            }
            else if (cmbboxFilter.Text == "Student ID")
            {
                Objects.con.Open();
                Objects.da = new OleDbDataAdapter("spGetStudentByStudentId", Objects.con);
                Objects.da.SelectCommand.CommandType = CommandType.StoredProcedure;
                Objects.da.SelectCommand.Parameters.AddWithValue("@studentId", "%" + txtSearch.Text + "%");
                Objects.da.Fill(Objects.ds);
                dgvStudents.DataSource = Objects.ds.Tables[0];
                dgvStudents.Columns[8].Visible = false;
                dgvStudents.Columns[0].Width = 200;
                dgvStudents.Columns[1].Width = 200;
                dgvStudents.Columns[2].Width = 200;
                dgvStudents.Columns[3].Width = 200;
                dgvStudents.Columns[4].Width = 100;
                dgvStudents.Columns[5].Width = 130;
                dgvStudents.Columns[6].Width = 60;
                dgvStudents.Columns[7].Width = 400;
            }
            else if (cmbboxFilter.Text == "Last Name")
            {
                Objects.con.Open();
                Objects.da = new OleDbDataAdapter("spGetStudentByLastName", Objects.con);
                Objects.da.SelectCommand.CommandType = CommandType.StoredProcedure;
                Objects.da.SelectCommand.Parameters.AddWithValue("@lastname", "%" + txtSearch.Text + "%");
                Objects.da.Fill(Objects.ds);
                dgvStudents.DataSource = Objects.ds.Tables[0];
                dgvStudents.Columns[8].Visible = false;
                dgvStudents.Columns[0].Width = 200;
                dgvStudents.Columns[1].Width = 200;
                dgvStudents.Columns[2].Width = 200;
                dgvStudents.Columns[3].Width = 200;
                dgvStudents.Columns[4].Width = 100;
                dgvStudents.Columns[5].Width = 130;
                dgvStudents.Columns[6].Width = 60;
                dgvStudents.Columns[7].Width = 400;
            }
            else if (cmbboxFilter.Text == "Given Name")
            {
                Objects.con.Open();
                Objects.da = new OleDbDataAdapter("spGetStudentByGivenName", Objects.con);
                Objects.da.SelectCommand.CommandType = CommandType.StoredProcedure;
                Objects.da.SelectCommand.Parameters.AddWithValue("@givenname", "%" + txtSearch.Text + "%");
                Objects.da.Fill(Objects.ds);
                dgvStudents.DataSource = Objects.ds.Tables[0];
                dgvStudents.Columns[8].Visible = false;
                dgvStudents.Columns[0].Width = 200;
                dgvStudents.Columns[1].Width = 200;
                dgvStudents.Columns[2].Width = 200;
                dgvStudents.Columns[3].Width = 200;
                dgvStudents.Columns[4].Width = 100;
                dgvStudents.Columns[5].Width = 130;
                dgvStudents.Columns[6].Width = 60;
                dgvStudents.Columns[7].Width = 400;
            }
            else if (cmbboxFilter.Text == "Middle Name")
            {
                Objects.con.Open();
                Objects.da = new OleDbDataAdapter("spGetStudentByMiddleName", Objects.con);
                Objects.da.SelectCommand.CommandType = CommandType.StoredProcedure;
                Objects.da.SelectCommand.Parameters.AddWithValue("@middlename", "%" + txtSearch.Text + "%");
                Objects.da.Fill(Objects.ds);
                dgvStudents.DataSource = Objects.ds.Tables[0];
                dgvStudents.Columns[8].Visible = false;
                dgvStudents.Columns[0].Width = 200;
                dgvStudents.Columns[1].Width = 200;
                dgvStudents.Columns[2].Width = 200;
                dgvStudents.Columns[3].Width = 200;
                dgvStudents.Columns[4].Width = 100;
                dgvStudents.Columns[5].Width = 130;
                dgvStudents.Columns[6].Width = 60;
                dgvStudents.Columns[7].Width = 400;
            }
            else if (cmbboxFilter.Text == "Gender")
            {
                Objects.con.Open();
                Objects.da = new OleDbDataAdapter("spGetStudentByGender", Objects.con);
                Objects.da.SelectCommand.CommandType = CommandType.StoredProcedure;
                Objects.da.SelectCommand.Parameters.AddWithValue("@gender", txtSearch.Text + "%");
                Objects.da.Fill(Objects.ds);
                dgvStudents.DataSource = Objects.ds.Tables[0];
                dgvStudents.Columns[8].Visible = false;
                dgvStudents.Columns[0].Width = 200;
                dgvStudents.Columns[1].Width = 200;
                dgvStudents.Columns[2].Width = 200;
                dgvStudents.Columns[3].Width = 200;
                dgvStudents.Columns[4].Width = 100;
                dgvStudents.Columns[5].Width = 130;
                dgvStudents.Columns[6].Width = 60;
                dgvStudents.Columns[7].Width = 400;
            }
            else if (cmbboxFilter.Text == "Date of Birth")
            {
                Objects.con.Open();
                Objects.da = new OleDbDataAdapter("spGetStudentByDateOfBirth", Objects.con);
                Objects.da.SelectCommand.CommandType = CommandType.StoredProcedure;
                Objects.da.SelectCommand.Parameters.AddWithValue("@dateofbirth", "%" + txtSearch.Text + "%");
                Objects.da.Fill(Objects.ds);
                dgvStudents.DataSource = Objects.ds.Tables[0];
                dgvStudents.Columns[8].Visible = false;
                dgvStudents.Columns[0].Width = 200;
                dgvStudents.Columns[1].Width = 200;
                dgvStudents.Columns[2].Width = 200;
                dgvStudents.Columns[3].Width = 200;
                dgvStudents.Columns[4].Width = 100;
                dgvStudents.Columns[5].Width = 130;
                dgvStudents.Columns[6].Width = 60;
                dgvStudents.Columns[7].Width = 400;
            }
            else if (cmbboxFilter.Text == "Age")
            {
                Objects.con.Open();
                Objects.da = new OleDbDataAdapter("spGetStudentByAge", Objects.con);
                Objects.da.SelectCommand.CommandType = CommandType.StoredProcedure;
                Objects.da.SelectCommand.Parameters.AddWithValue("@age", "%" + txtSearch.Text + "%");
                Objects.da.Fill(Objects.ds);
                dgvStudents.DataSource = Objects.ds.Tables[0];
                dgvStudents.Columns[8].Visible = false;
                dgvStudents.Columns[0].Width = 200;
                dgvStudents.Columns[1].Width = 200;
                dgvStudents.Columns[2].Width = 200;
                dgvStudents.Columns[3].Width = 200;
                dgvStudents.Columns[4].Width = 100;
                dgvStudents.Columns[5].Width = 130;
                dgvStudents.Columns[6].Width = 60;
                dgvStudents.Columns[7].Width = 400;
            }
            else if (cmbboxFilter.Text == "Address")
            {
                Objects.con.Open();
                Objects.da = new OleDbDataAdapter("spGetStudentByAddress", Objects.con);
                Objects.da.SelectCommand.CommandType = CommandType.StoredProcedure;
                Objects.da.SelectCommand.Parameters.AddWithValue("@address", "%" + txtSearch.Text + "%");
                Objects.da.Fill(Objects.ds);
                dgvStudents.DataSource = Objects.ds.Tables[0];
                dgvStudents.Columns[8].Visible = false;
                dgvStudents.Columns[0].Width = 200;
                dgvStudents.Columns[1].Width = 200;
                dgvStudents.Columns[2].Width = 200;
                dgvStudents.Columns[3].Width = 200;
                dgvStudents.Columns[4].Width = 100;
                dgvStudents.Columns[5].Width = 130;
                dgvStudents.Columns[6].Width = 60;
                dgvStudents.Columns[7].Width = 400;
            }
            Objects.da.Update(Objects.dt);
            Objects.con.Close();
            this.lblTotal.Text = "TOTAL ENTRY: " + dgvStudents.Rows.Count.ToString();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string stringHolder = cmbboxFilter.Text;
            switch (stringHolder)
            {
                case "None":
                    if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "Student ID":
                    if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "Last Name":
                    if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "Given Name":
                    if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "Middle Name":
                    if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "Gender":
                    if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "Date of Birth":
                    if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "Age":
                    if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }
        private void cmbboxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
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
