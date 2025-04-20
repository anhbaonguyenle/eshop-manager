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
    public partial class EditUser : Form
    {
        private string currentUsername;
        public EditUser(string UserName)
        {
            InitializeComponent();
            currentUsername = UserName;
            GetData(currentUsername);
        }
        private void GetData(string Username)
        {
            try
            {
                using (SqlConnection conn = DBHelper.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id,username,full_name,email,role FROM empinfo WHERE Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Idtxt.Text = reader["id"].ToString();
                        Usernametxt.Text = reader["username"].ToString();
                        FullNameTxt.Text = reader["full_name"].ToString();
                        EmailTxt.Text = reader["email"].ToString();
                        Roletxt.Text = reader["role"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        private void Edit()
        {
            try
            {
                using (SqlConnection conn = DBHelper.Instance.GetConnection())
                {
                    conn.Open();
                    string UpdateQuery = "UPDATE empinfo SET full_name = @full_name, email = @email WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(UpdateQuery, conn);
                    cmd.Parameters.AddWithValue("@full_name", FullNameTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", EmailTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", Idtxt.Text.Trim());
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Gọi lại form User từ Owner
                        if (this.Owner is MenuForm menuForm)
                        {
                            menuForm.ReloadUserForm(currentUsername); // reload User form
                        }

                        this.Close(); // đóng Edit form



                    }
                    else
                    {
                        MessageBox.Show("Failed to update user information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Edit();
        }
    }
}
