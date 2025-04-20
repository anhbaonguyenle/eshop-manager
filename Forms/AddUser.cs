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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace e_ShopManager.Forms
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (Checkconfirmpass())
            {
                try
                {
                    using (SqlConnection conn = DBHelper.Instance.GetConnection())
                    {
                        conn.Open();
                        string UpdateQuery = "INSERT INTO empinfo(username, password, full_name, email) VALUES(@username, @password, @full_name, @email);";

                        SqlCommand cmd = new SqlCommand(UpdateQuery, conn);
                        cmd.Parameters.AddWithValue("@username", UserNameTxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(PasswordTxt.Text.Trim()));
                        cmd.Parameters.AddWithValue("@full_name", FullNameTxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", EmailTxt.Text.Trim());
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Add user successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Failed to add user account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }
        private bool Checkconfirmpass()
        {
            if(string.IsNullOrEmpty(UserNameTxt.Text) || string.IsNullOrEmpty(FullNameTxt.Text) || string.IsNullOrEmpty(EmailTxt.Text) || string.IsNullOrEmpty(PasswordTxt.Text) || string.IsNullOrEmpty(ConfirmPassTxt.Text))
            {
                MessageBox.Show("Please fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (PasswordTxt.Text != ConfirmPassTxt.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
