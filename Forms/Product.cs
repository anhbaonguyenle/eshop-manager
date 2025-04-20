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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
     private void ProductForm_Load(object sender, EventArgs e)
        {
            Label titleLabel = new Label();
            titleLabel.Text = "Product Management";
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(20, 20);

            this.Controls.Add(titleLabel);
        }

    }
}
