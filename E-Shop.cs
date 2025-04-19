using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_ShopManager
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.Resize += MenuForm_Resize;
            MenuForm_Resize(null, null);
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
    }

}
