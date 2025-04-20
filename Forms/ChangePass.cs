using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_ShopManager.Forms
{
    public partial class ChangePass : Form
    {
        private string currentUsername;
        public ChangePass(string Username)
        {
            InitializeComponent();
            currentUsername = Username;
        }
        private void CheckPass()
        {
            string oldPass = OldPasstxt.Text.Trim();
            string newPass = Passtxt.Text.Trim();
            string confirmPass = ComfirmPasstxt.Text.Trim();

            if (string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Please fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckComfirmPass()) return;

            try
            {
                using (SqlConnection conn = DBHelper.Instance.GetConnection())
                {
                    conn.Open();

                    string selectQuery = "SELECT password FROM empinfo WHERE username = @username";
                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@username", currentUsername);
                        object result = selectCmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string currentHashedPassword = result.ToString();

                        if (!BCrypt.Net.BCrypt.Verify(oldPass, currentHashedPassword))
                        {
                            MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string newHashedPass = BCrypt.Net.BCrypt.HashPassword(newPass);

                        string updateQuery = "UPDATE empinfo SET password = @newPass WHERE username = @username";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@newPass", newHashedPass);
                            updateCmd.Parameters.AddWithValue("@username", currentUsername);

                            int rowsAffected = updateCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Password update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckComfirmPass()
        {
            if (ComfirmPasstxt.Text == Passtxt.Text)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Confirm Password not match");
                return false;
            }
        }
        private void ChanePassBtn_Click(object sender, EventArgs e)
        {
            CheckPass();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
