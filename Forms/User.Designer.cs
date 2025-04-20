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
            this.panel1.SuspendLayout();
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
            this.ChangePassBtn.Location = new System.Drawing.Point(442, 0);
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
            this.EditUserBtn.Location = new System.Drawing.Point(592, 0);
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
            this.AddUserBtn.Location = new System.Drawing.Point(695, 0);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(103, 43);
            this.AddUserBtn.TabIndex = 0;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = false;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "User";
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HiLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChangePassBtn;
        private System.Windows.Forms.Button EditUserBtn;
        private System.Windows.Forms.Button AddUserBtn;
    }
}