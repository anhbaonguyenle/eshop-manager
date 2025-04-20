using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public User(string Username)
        {
            InitializeComponent();
            currentUsername = Username;
            HiLabel.Text = $"Hello {currentUsername}";
        }

        private void ChangePassBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
