using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_ShopManager.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace e_ShopManager
{
    public partial class MenuForm : Form
    {
        private Form activeForm = null;
        private string currentUsername;

        public MenuForm(string username)
        {
            InitializeComponent();
            currentUsername = username;

            this.Resize += MenuForm_Resize;
            MenuForm_Resize(null, null);
            this.OpenChildForm(new Product());
            UserBtn.Text = $"User: {currentUsername}";
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Clear();
            ChildFormPanel.Controls.Add(childForm);
            ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void MenuForm_Resize(object sender, EventArgs e)
        {
            int padding = 10;
            Closebtn.Location = new Point(this.ClientSize.Width - Closebtn.Width - padding, 10);
            Resizebtn.Location = new Point(Closebtn.Left - Resizebtn.Width - 5, 10);
            Minimizebtn.Location = new Point(Resizebtn.Left - Minimizebtn.Width - 5, 10);
        }

        private void Closebtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resizebtn_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Minimizebtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new Product());
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new Customer());
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new Order());
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new Dashboard());
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new User(this, currentUsername));
        }


        private void LogoLabel_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new Product());
        }

        internal void ReloadUserForm(string currentUsername)
        {
            this.OpenChildForm(new User(this, currentUsername));
        }
    }
    

}
