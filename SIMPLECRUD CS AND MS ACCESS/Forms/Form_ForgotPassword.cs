using System;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SIMPLECRUD_CS_AND_MS_ACCESS // Created by: Joshua C. Magoliman
{
    public partial class Form_ForgotPassword : Form
    {
        public Form_ForgotPassword()
        {
            InitializeComponent();
        }
        private void Form_ForgotPassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsername;
        }
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "" && cmbboxSecretQuestion.Text == "" && txtSecretAnswer.Text == ""))
            {
                MessageBox.Show("Fill up account details", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtUsername;
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("No Username Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtUsername;
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
                    Objects.cmd = new OleDbCommand("SELECT [password] FROM [tbl_Users] WHERE [username]= @username AND StrComp(secret_question,@secretquestion,0) = 0 AND StrComp(secret_answer,@secretanswer,0) = 0;", Objects.con);
                    Objects.cmd.CommandType = System.Data.CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@username", txtUsername.Text));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@secretquestion", cmbboxSecretQuestion.Text));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@secretanswer", txtSecretAnswer.Text));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        txtShowPassword.Text = Objects.dr["password"].ToString();
                        txtShowPassword.Enabled = true;
                        Objects.dr.Close();
                    }
                    else
                    {
                        MessageBox.Show("Your details was invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtShowPassword.Enabled = false;
                        txtShowPassword.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    Objects.con.Close();
                    this.ActiveControl = lblUsername;
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login nextForm = new Form_Login();
            nextForm.Show();
            this.txtUsername.Clear();
            this.cmbboxSecretQuestion.Text = "";
            this.txtSecretAnswer.Clear();
            this.txtShowPassword.Clear();
            this.chckboxSecretAnswer.Checked = false;
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT secret_question FROM [tbl_Users] WHERE [username]=@username", Objects.con);
                Objects.cmd.CommandType = System.Data.CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@username", txtUsername.Text));
                Objects.dr = Objects.cmd.ExecuteReader();
                if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                {
                    cmbboxSecretQuestion.Text = Objects.dr["secret_question"].ToString();
                    Objects.con.Close();
                }
                else
                {
                    cmbboxSecretQuestion.Text = "";
                    Objects.con.Close();
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
        private void chckboxSecretAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (chckboxSecretAnswer.Checked)
            {
                txtSecretAnswer.UseSystemPasswordChar = false;
            }
            else
            {
                txtSecretAnswer.UseSystemPasswordChar = true;
            }
            this.ActiveControl = lblUsername;
        }
    }
}
