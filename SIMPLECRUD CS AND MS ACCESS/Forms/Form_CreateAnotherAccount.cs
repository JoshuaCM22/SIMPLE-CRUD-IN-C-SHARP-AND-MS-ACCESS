using System;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SIMPLECRUD_CS_AND_MS_ACCESS // Created by: Joshua C. Magoliman
{
    public partial class Form_CreateAnotherAccount : Form
    {
        public Form_CreateAnotherAccount()
        {
            InitializeComponent();
        }
        private void Form_CreateAnotherAccount_Load(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            this.ActiveControl = txtUsername;
            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.cmbboxSecretQuestion.Text = "";
            this.txtSecretAnswer.Clear();
            this.chckbox_ShowPassword.Checked = false;
            this.chckbox_ShowSecretAnswer.Checked = false;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nextForm = new Form_Main();
            nextForm.Show();
            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.cmbboxSecretQuestion.Text = "";
            this.txtSecretAnswer.Clear();
            this.chckbox_ShowPassword.Checked = false;
            this.chckbox_ShowSecretAnswer.Checked = false;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "" && txtPassword.Text == "" && cmbboxSecretQuestion.Text == "" && txtSecretAnswer.Text == ""))
            {
                MessageBox.Show("Fill up account details", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtUsername;
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("No Username Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtUsername;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("No Password Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtPassword;
            }
            else if (cmbboxSecretQuestion.Text == "")
            {
                MessageBox.Show("No Secret Question Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = cmbboxSecretQuestion;
            }
            else if (txtSecretAnswer.Text == "")
            {
                MessageBox.Show("No Secret Password Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtSecretAnswer;
            }
            else
            {
                try
                {
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_Users] WHERE [Username]=@username  ", Objects.con);
                    Objects.cmd.CommandType = System.Data.CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@username", txtUsername.Text));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    int count = 0;
                    while (Objects.dr.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("This Username is already taken, Please try different Username", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Objects.con.Close();
                        this.ActiveControl = txtUsername;
                    }
                    else
                    {
                        Objects.con.Close();
                        CreatingAccount();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Objects.con.Close();
                }
            }
        }
        private void CreatingAccount()
        {
            try
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("spInsertNewUser", Objects.con);
                Objects.cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Objects.cmd.Parameters.Add(new OleDbParameter("@username", txtUsername.Text));
                Objects.cmd.Parameters.Add(new OleDbParameter("@password", txtPassword.Text));
                Objects.cmd.Parameters.Add(new OleDbParameter("@secretquestion", cmbboxSecretQuestion.Text));
                Objects.cmd.Parameters.Add(new OleDbParameter("@secretanswer", txtSecretAnswer.Text));
                Objects.cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Registered !", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Objects.con.Close();
                this.ActiveControl = txtUsername;
                this.txtUsername.Clear();
                this.txtPassword.Clear();
                this.cmbboxSecretQuestion.Text = "";
                this.txtSecretAnswer.Clear();
                this.chckbox_ShowPassword.Checked = false;
                this.chckbox_ShowSecretAnswer.Checked = false;
            }
        }
        private void chckbox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbox_ShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            this.ActiveControl = lblUsername;
        }
        private void chckbox_ShowSecretAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbox_ShowSecretAnswer.Checked)
            {
                txtSecretAnswer.UseSystemPasswordChar = false;
            }
            else
            {
                txtSecretAnswer.UseSystemPasswordChar = true;
            }
            this.ActiveControl = lblUsername;
        }
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtSecretAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
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
