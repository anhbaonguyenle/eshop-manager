namespace e_ShopManager.Forms
{
    partial class User
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
            this.HiLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChangePassBtn = new System.Windows.Forms.Button();
            this.EditUserBtn = new System.Windows.Forms.Button();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.createdattxt = new System.Windows.Forms.Label();
            this.Roletxt = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.Label();
            this.Full_nametxt = new System.Windows.Forms.Label();
            this.Usernametxt = new System.Windows.Forms.Label();
            this.Idtxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // HiLabel
            // 
            this.HiLabel.AutoSize = true;
            this.HiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.HiLabel.Location = new System.Drawing.Point(11, 10);
            this.HiLabel.Name = "HiLabel";
            this.HiLabel.Size = new System.Drawing.Size(131, 24);
            this.HiLabel.TabIndex = 1;
            this.HiLabel.Text = "Hi Username";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.HiLabel);
            this.panel1.Controls.Add(this.ChangePassBtn);
            this.panel1.Controls.Add(this.EditUserBtn);
            this.panel1.Controls.Add(this.AddUserBtn);
            this.panel1.Controls.Add(this.LogOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 1;
            // 
            // ChangePassBtn
            // 
            this.ChangePassBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ChangePassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePassBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChangePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangePassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePassBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChangePassBtn.Location = new System.Drawing.Point(339, 0);
            this.ChangePassBtn.Name = "ChangePassBtn";
            this.ChangePassBtn.Size = new System.Drawing.Size(150, 43);
            this.ChangePassBtn.TabIndex = 2;
            this.ChangePassBtn.Text = "Change Password";
            this.ChangePassBtn.UseVisualStyleBackColor = false;
            this.ChangePassBtn.Click += new System.EventHandler(this.ChangePassBtn_Click);
            // 
            // EditUserBtn
            // 
            this.EditUserBtn.BackColor = System.Drawing.SystemColors.Control;
            this.EditUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditUserBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.EditUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditUserBtn.Location = new System.Drawing.Point(489, 0);
            this.EditUserBtn.Name = "EditUserBtn";
            this.EditUserBtn.Size = new System.Drawing.Size(103, 43);
            this.EditUserBtn.TabIndex = 1;
            this.EditUserBtn.Text = "Edit";
            this.EditUserBtn.UseVisualStyleBackColor = false;
            this.EditUserBtn.Click += new System.EventHandler(this.EditUserBtn_Click);
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.AddUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUserBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddUserBtn.Location = new System.Drawing.Point(592, 0);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(103, 43);
            this.AddUserBtn.TabIndex = 0;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = false;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 405);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(657, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(143, 405);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.createdattxt);
            this.panel4.Controls.Add(this.Roletxt);
            this.panel4.Controls.Add(this.Emailtxt);
            this.panel4.Controls.Add(this.Full_nametxt);
            this.panel4.Controls.Add(this.Usernametxt);
            this.panel4.Controls.Add(this.Idtxt);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.IdLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(143, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(514, 405);
            this.panel4.TabIndex = 4;
            // 
            // createdattxt
            // 
            this.createdattxt.AutoSize = true;
            this.createdattxt.Location = new System.Drawing.Point(194, 220);
            this.createdattxt.Name = "createdattxt";
            this.createdattxt.Size = new System.Drawing.Size(53, 13);
            this.createdattxt.TabIndex = 11;
            this.createdattxt.Text = "Create at:";
            // 
            // Roletxt
            // 
            this.Roletxt.AutoSize = true;
            this.Roletxt.Location = new System.Drawing.Point(194, 182);
            this.Roletxt.Name = "Roletxt";
            this.Roletxt.Size = new System.Drawing.Size(32, 13);
            this.Roletxt.TabIndex = 10;
            this.Roletxt.Text = "Role:";
            // 
            // Emailtxt
            // 
            this.Emailtxt.AutoSize = true;
            this.Emailtxt.Location = new System.Drawing.Point(194, 145);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(35, 13);
            this.Emailtxt.TabIndex = 9;
            this.Emailtxt.Text = "Email:";
            // 
            // Full_nametxt
            // 
            this.Full_nametxt.AutoSize = true;
            this.Full_nametxt.Location = new System.Drawing.Point(194, 107);
            this.Full_nametxt.Name = "Full_nametxt";
            this.Full_nametxt.Size = new System.Drawing.Size(57, 13);
            this.Full_nametxt.TabIndex = 8;
            this.Full_nametxt.Text = "Full Name:";
            // 
            // Usernametxt
            // 
            this.Usernametxt.AutoSize = true;
            this.Usernametxt.Location = new System.Drawing.Point(194, 73);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(58, 13);
            this.Usernametxt.TabIndex = 7;
            this.Usernametxt.Text = "Username:";
            // 
            // Idtxt
            // 
            this.Idtxt.AutoSize = true;
            this.Idtxt.Location = new System.Drawing.Point(194, 37);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(21, 13);
            this.Idtxt.TabIndex = 6;
            this.Idtxt.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Create at:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(41, 37);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 13);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID:";
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.Firebrick;
            this.LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.LogOut.Location = new System.Drawing.Point(695, 0);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(103, 43);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "User";
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HiLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChangePassBtn;
        private System.Windows.Forms.Button EditUserBtn;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label createdattxt;
        private System.Windows.Forms.Label Roletxt;
        private System.Windows.Forms.Label Emailtxt;
        private System.Windows.Forms.Label Full_nametxt;
        private System.Windows.Forms.Label Usernametxt;
        private System.Windows.Forms.Label Idtxt;
        private System.Windows.Forms.Button LogOut;
    }
}