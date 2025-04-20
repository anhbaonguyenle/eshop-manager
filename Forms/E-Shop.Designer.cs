namespace e_ShopManager
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.Minimizebtn = new System.Windows.Forms.Label();
            this.Resizebtn = new System.Windows.Forms.PictureBox();
            this.Closebtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserBtn = new FontAwesome.Sharp.IconButton();
            this.DashboardBtn = new FontAwesome.Sharp.IconButton();
            this.OrderBtn = new FontAwesome.Sharp.IconButton();
            this.CustomerBtn = new FontAwesome.Sharp.IconButton();
            this.ProductBtn = new FontAwesome.Sharp.IconButton();
            this.AddressPanel = new System.Windows.Forms.Panel();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resizebtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.AddressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlPanel.Controls.Add(this.LogoLabel);
            this.ControlPanel.Controls.Add(this.Minimizebtn);
            this.ControlPanel.Controls.Add(this.Resizebtn);
            this.ControlPanel.Controls.Add(this.Closebtn);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(965, 34);
            this.ControlPanel.TabIndex = 0;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.LogoLabel.Location = new System.Drawing.Point(40, 4);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(174, 25);
            this.LogoLabel.TabIndex = 11;
            this.LogoLabel.Text = "E-Shop Manager";
            this.LogoLabel.Click += new System.EventHandler(this.LogoLabel_Click);
            // 
            // Minimizebtn
            // 
            this.Minimizebtn.AutoSize = true;
            this.Minimizebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimizebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Minimizebtn.Location = new System.Drawing.Point(649, 12);
            this.Minimizebtn.Name = "Minimizebtn";
            this.Minimizebtn.Size = new System.Drawing.Size(15, 20);
            this.Minimizebtn.TabIndex = 10;
            this.Minimizebtn.Text = "-";
            this.Minimizebtn.Click += new System.EventHandler(this.Minimizebtn_Click_1);
            // 
            // Resizebtn
            // 
            this.Resizebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Resizebtn.Image = global::e_ShopManager.Properties.Resources.Resize;
            this.Resizebtn.Location = new System.Drawing.Point(670, 12);
            this.Resizebtn.Name = "Resizebtn";
            this.Resizebtn.Size = new System.Drawing.Size(19, 15);
            this.Resizebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Resizebtn.TabIndex = 8;
            this.Resizebtn.TabStop = false;
            this.Resizebtn.Click += new System.EventHandler(this.Resizebtn_Click_1);
            // 
            // Closebtn
            // 
            this.Closebtn.AutoSize = true;
            this.Closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Closebtn.Location = new System.Drawing.Point(695, 12);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(16, 15);
            this.Closebtn.TabIndex = 9;
            this.Closebtn.Text = "X";
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.UserBtn);
            this.panel2.Controls.Add(this.DashboardBtn);
            this.panel2.Controls.Add(this.OrderBtn);
            this.panel2.Controls.Add(this.CustomerBtn);
            this.panel2.Controls.Add(this.ProductBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 631);
            this.panel2.TabIndex = 1;
            // 
            // UserBtn
            // 
            this.UserBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserBtn.FlatAppearance.BorderSize = 0;
            this.UserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.UserBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.UserBtn.IconColor = System.Drawing.SystemColors.Control;
            this.UserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserBtn.Location = new System.Drawing.Point(0, 523);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(248, 104);
            this.UserBtn.TabIndex = 4;
            this.UserBtn.Text = "User";
            this.UserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UserBtn.UseVisualStyleBackColor = true;
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardBtn.FlatAppearance.BorderSize = 0;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.DashboardBtn.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.DashboardBtn.IconColor = System.Drawing.SystemColors.Control;
            this.DashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.Location = new System.Drawing.Point(0, 312);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(248, 104);
            this.DashboardBtn.TabIndex = 3;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderBtn.FlatAppearance.BorderSize = 0;
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.OrderBtn.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.OrderBtn.IconColor = System.Drawing.SystemColors.Control;
            this.OrderBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrderBtn.Location = new System.Drawing.Point(0, 208);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(248, 104);
            this.OrderBtn.TabIndex = 2;
            this.OrderBtn.Text = "Order";
            this.OrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerBtn.FlatAppearance.BorderSize = 0;
            this.CustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomerBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.CustomerBtn.IconColor = System.Drawing.SystemColors.Control;
            this.CustomerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CustomerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerBtn.Location = new System.Drawing.Point(0, 104);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Size = new System.Drawing.Size(248, 104);
            this.CustomerBtn.TabIndex = 1;
            this.CustomerBtn.Text = "Customer";
            this.CustomerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CustomerBtn.UseVisualStyleBackColor = true;
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductBtn.FlatAppearance.BorderSize = 0;
            this.ProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ProductBtn.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.ProductBtn.IconColor = System.Drawing.SystemColors.Control;
            this.ProductBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProductBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductBtn.Location = new System.Drawing.Point(0, 0);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(248, 104);
            this.ProductBtn.TabIndex = 0;
            this.ProductBtn.Text = "Product";
            this.ProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProductBtn.UseVisualStyleBackColor = true;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // AddressPanel
            // 
            this.AddressPanel.Controls.Add(this.AddressLabel);
            this.AddressPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddressPanel.Location = new System.Drawing.Point(252, 34);
            this.AddressPanel.Name = "AddressPanel";
            this.AddressPanel.Size = new System.Drawing.Size(713, 29);
            this.AddressPanel.TabIndex = 2;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(6, 7);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(77, 13);
            this.AddressLabel.TabIndex = 0;
            this.AddressLabel.Text = "Home/Product";
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(252, 63);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(713, 602);
            this.ChildFormPanel.TabIndex = 3;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 665);
            this.ControlBox = false;
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.AddressPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "E-shop Manager";
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resizebtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.AddressPanel.ResumeLayout(false);
            this.AddressPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Minimizebtn;
        private System.Windows.Forms.PictureBox Resizebtn;
        private System.Windows.Forms.Label Closebtn;
        private System.Windows.Forms.Label LogoLabel;
        private FontAwesome.Sharp.IconButton UserBtn;
        private FontAwesome.Sharp.IconButton DashboardBtn;
        private FontAwesome.Sharp.IconButton OrderBtn;
        private FontAwesome.Sharp.IconButton CustomerBtn;
        private FontAwesome.Sharp.IconButton ProductBtn;
        private System.Windows.Forms.Panel AddressPanel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Panel ChildFormPanel;
    }
}