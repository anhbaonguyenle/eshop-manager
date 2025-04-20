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

namespace e_ShopManager
{
    public partial class UserAuth : Form
    {
        public UserAuth()
        {
            InitializeComponent();
        }

        private void LinkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Link Error");
            }
        }
        private void OpenLink()
        {
            LinkGithub.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/anhbaonguyenle");
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usernametxt_Enter(object sender, EventArgs e)
        {
            if (Usernametxt.Text == "Username")
            {
                Usernametxt.Text = "";
                Usernametxt.ForeColor = Color.Black;
            }
        }

        private void Usernametxt_Leave(object sender, EventArgs e)
        {
            if (Usernametxt.Text == "")
            {
                Usernametxt.Text = "Username";
                Usernametxt.ForeColor = Color.Gray;
            }
        }

        private void PassTxt_Enter(object sender, EventArgs e)
        {
            if (PassTxt.Text == "Password")
            {
                PassTxt.Text = "";
                PassTxt.ForeColor = Color.Black;
                PassTxt.UseSystemPasswordChar = true;
            }
        }

        private void PassTxt_Leave(object sender, EventArgs e)
        {
            if (PassTxt.Text == "")
            {
                PassTxt.Text = "Password";
                PassTxt.ForeColor = Color.Gray;
                PassTxt.UseSystemPasswordChar = false;
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = Usernametxt.Text.Trim();
            string password = PassTxt.Text.Trim();

            if (username == "" || username == "Username" || password == "" || password == "Password")
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DBHelper.Instance.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT password FROM empinfo WHERE username = @username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string hashedFromDb = result.ToString();
                            bool isValid = BCrypt.Net.BCrypt.Verify(password, hashedFromDb);

                            if (isValid)
                            {
                                MenuForm mnf = new MenuForm(username);
                                this.Visible = false;
                                mnf.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ForgetPassbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
