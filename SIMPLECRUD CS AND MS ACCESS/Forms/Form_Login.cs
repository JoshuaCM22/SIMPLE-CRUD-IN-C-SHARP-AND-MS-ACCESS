using System;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SIMPLECRUD_CS_AND_MS_ACCESS // Created by: Joshua C. Magoliman
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            this.ActiveControl = txtUsername;
            chckboxShowPassword.Checked = false;
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private void Form_Login_Load(object sender, EventArgs e)
        {
            Reset();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "" && txtPassword.Text == ""))
            {
                MessageBox.Show("No Username and Password Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtUsername;
            }
            else if ((txtUsername.Text == ""))
            {
                MessageBox.Show("No Username Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtUsername;
            }
            else if ((txtPassword.Text == ""))
            {
                MessageBox.Show("No Password Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtPassword;
            }
            else
            {
                try
                {
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_Users] WHERE [username]=[@username] AND StrComp([password],@password , 0) = 0 ", Objects.con);
                    Objects.cmd.CommandType = System.Data.CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@username", txtUsername.Text));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@password", txtPassword.Text));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    int count = 0;
                    while (Objects.dr.Read())
                    {
                        count = count + 1;
                    }
                    switch (count)
                    {
                        case 1:
                            Form_ChangePassword.usernameGetter = this.txtUsername.Text;
                            Form_ChangePassword.passwordGetter = this.txtPassword.Text;
                            Objects.con.Close();
                            this.Hide();
                            var myForm = new Form_Main();
                            myForm.Show();
                            break;
                        default:
                            MessageBox.Show("Invalid Details", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Reset();
                            Objects.con.Close();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nextForm = new Form_ForgotPassword();
            nextForm.Show();
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
            if (e.KeyChar == (char)13)
            {
                btnLogin.PerformClick();
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
            if (e.KeyChar == (char)13)
            {
                btnLogin.PerformClick();
            }
        }
        private void chckboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool verifying = chckboxShowPassword.Checked == true ? txtPassword.UseSystemPasswordChar = false : txtPassword.UseSystemPasswordChar = true;
            this.ActiveControl = lblUsername;
        }
    }
}
