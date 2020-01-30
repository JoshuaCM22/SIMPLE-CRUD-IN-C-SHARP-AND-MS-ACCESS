using System;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SIMPLECRUD_CS_AND_MS_ACCESS // Created by: Joshua C. Magoliman
{
    public partial class Form_ChangePassword : Form
    {
        public static string usernameGetter, passwordGetter;
        public Form_ChangePassword()
        {
            InitializeComponent();
        }
        private void Form_ChangePassword_Load(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            this.txtCurrentPassword.Clear();
            this.txtNewPassword.Clear();
            this.txtConfirmNewPassword.Clear();
            this.ActiveControl = txtCurrentPassword;
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if ((txtCurrentPassword.Text == "" && txtNewPassword.Text == "" && txtConfirmNewPassword.Text == ""))
            {
                MessageBox.Show("Fill up password details", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtCurrentPassword;
            }
            else if (txtCurrentPassword.Text == "")
            {
                MessageBox.Show("No Current Password Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtCurrentPassword;
            }
            else if (txtNewPassword.Text == "")
            {
                MessageBox.Show("No New Password Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtNewPassword;
            }
            else if (txtConfirmNewPassword.Text == "")
            {
                MessageBox.Show("No Confirm Password Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtConfirmNewPassword;
            }
            else
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_Users] WHERE StrComp([username],@username , 0) = 0  AND StrComp([Password],@password , 0) = 0 ", Objects.con);
                Objects.cmd.CommandType = System.Data.CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@username", usernameGetter));
                Objects.cmd.Parameters.Add(new OleDbParameter("@password", txtCurrentPassword.Text));
                Objects.dr = Objects.cmd.ExecuteReader();
                if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                {
                    Objects.dr.Close();
                    Objects.con.Close();
                    Reading();
                }
                else
                {
                    Objects.dr.Close();
                    Objects.con.Close();
                    MessageBox.Show("Current Password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Reading()
        {
            if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                MessageBox.Show("Your New Password and Confirm New Password are not same!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtConfirmNewPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Your New Password and Confirm New Password are not same!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_Users] WHERE StrComp([username],@username , 0) = 0  AND StrComp([Password],@password , 0) = 0 ", Objects.con);
                    Objects.cmd.CommandType = System.Data.CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@username", usernameGetter));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@password", txtConfirmNewPassword.Text));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        Objects.dr.Close();
                        Objects.con.Close();
                        MessageBox.Show("Your new and confirm password is currently used, please try another password!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Objects.dr.Close();
                        Objects.con.Close();
                        Updating();
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
        private void Updating()
        {
            try
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("UPDATE [tbl_Users] set [password]=@password  where [username]=@username ", Objects.con);
                Objects.cmd.CommandType = System.Data.CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@password", txtNewPassword.Text));
                Objects.cmd.Parameters.Add(new OleDbParameter("@username", usernameGetter));
                Objects.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Objects.con.Close();
                MessageBox.Show("SUCCESSFULLY UPDATED", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                passwordGetter = txtNewPassword.Text;
                this.Hide();
                Reset();
                var nextForm = new Form_Main();
                nextForm.Show();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nextForm = new Form_Main();
            nextForm.Show();
            this.txtCurrentPassword.Clear();
            this.txtNewPassword.Clear();
            this.txtConfirmNewPassword.Clear();
        }
        private void chckbox_ShowPassword1_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbox_ShowPassword1.Checked)
            {
                txtCurrentPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtCurrentPassword.UseSystemPasswordChar = true;
            }
            this.ActiveControl = lblCurrentPassword;
        }
        private void chckbox_ShowPassword2_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbox_ShowPassword2.Checked)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                txtConfirmNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                txtConfirmNewPassword.UseSystemPasswordChar = true;
            }
            this.ActiveControl = lblCurrentPassword;
        }
        private void txtCurrentPassword_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtNewPassword_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtConfirmNewPassword_KeyPress(object sender, KeyPressEventArgs e)
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
