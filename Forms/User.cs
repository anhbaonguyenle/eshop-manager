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
    public partial class User : Form
    {
        private string currentUsername;
        private MenuForm menuForm;
        public User(MenuForm parent, string Username)
        {
            InitializeComponent();
            currentUsername = Username;
            GetData(currentUsername);
            CheckBoss(currentUsername);
            HiLabel.Text = $"Hello {currentUsername}";
            this.menuForm = parent;
        }
        private void GetData(string Username)
        {
            try
            {
                using (SqlConnection conn = DBHelper.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id,username,full_name,email,role,created_at FROM empinfo WHERE Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Idtxt.Text = reader["id"].ToString();
                        Usernametxt.Text = reader["username"].ToString();
                        Full_nametxt.Text = reader["full_name"].ToString();
                        Emailtxt.Text = reader["email"].ToString();
                        Roletxt.Text = reader["role"].ToString();
                        createdattxt.Text = reader["created_at"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        private void CheckBoss(string Username)
        {
            try
            {
                using (SqlConnection conn = DBHelper.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT role FROM empinfo WHERE Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string role = reader["role"].ToString();
                        if (role == "BOSS")
                        {
                            AddUserBtn.Visible = true;
                        }
                        else
                        {
                            AddUserBtn.Visible = false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        private void ChangePassBtn_Click(object sender, EventArgs e)
        {
            ChangePass changePass = new ChangePass(currentUsername);
            changePass.ShowDialog();
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            EditUser editForm = new EditUser(currentUsername);
            editForm.Owner = this.menuForm;
            editForm.ShowDialog();

        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUser addform = new AddUser();
            addform.ShowDialog();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                menuForm.Hide();
                UserAuth loginForm = new UserAuth();
                loginForm.ShowDialog();
                menuForm.Close();
            }

        }
    }
}
