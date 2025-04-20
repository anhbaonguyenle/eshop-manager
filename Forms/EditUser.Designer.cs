namespace e_ShopManager.Forms
{
    partial class EditUser
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.FullNameTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Idtxt = new System.Windows.Forms.Label();
            this.Roletxt = new System.Windows.Forms.Label();
            this.Usernametxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(12, 9);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 13);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CloseBtn);
            this.panel4.Controls.Add(this.EditBtn);
            this.panel4.Controls.Add(this.EmailTxt);
            this.panel4.Controls.Add(this.FullNameTxt);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(408, 180);
            this.panel4.TabIndex = 5;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(106, 83);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(268, 20);
            this.EmailTxt.TabIndex = 14;
            // 
            // FullNameTxt
            // 
            this.FullNameTxt.Location = new System.Drawing.Point(106, 51);
            this.FullNameTxt.Name = "FullNameTxt";
            this.FullNameTxt.Size = new System.Drawing.Size(268, 20);
            this.FullNameTxt.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IdLabel);
            this.panel1.Controls.Add(this.Idtxt);
            this.panel1.Controls.Add(this.Roletxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Usernametxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 34);
            this.panel1.TabIndex = 12;
            // 
            // Idtxt
            // 
            this.Idtxt.AutoSize = true;
            this.Idtxt.Location = new System.Drawing.Point(39, 9);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(21, 13);
            this.Idtxt.TabIndex = 6;
            this.Idtxt.Text = "ID:";
            // 
            // Roletxt
            // 
            this.Roletxt.AutoSize = true;
            this.Roletxt.Location = new System.Drawing.Point(342, 9);
            this.Roletxt.Name = "Roletxt";
            this.Roletxt.Size = new System.Drawing.Size(32, 13);
            this.Roletxt.TabIndex = 10;
            this.Roletxt.Text = "Role:";
            // 
            // Usernametxt
            // 
            this.Usernametxt.AutoSize = true;
            this.Usernametxt.Location = new System.Drawing.Point(167, 9);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(58, 13);
            this.Usernametxt.TabIndex = 7;
            this.Usernametxt.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Role:";
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseBtn.Location = new System.Drawing.Point(229, 135);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(118, 23);
            this.CloseBtn.TabIndex = 16;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.EditBtn.Location = new System.Drawing.Point(56, 135);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(118, 23);
            this.EditBtn.TabIndex = 15;
            this.EditBtn.Text = "Edit User";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 180);
            this.Controls.Add(this.panel4);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Roletxt;
        private System.Windows.Forms.Label Usernametxt;
        private System.Windows.Forms.Label Idtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox FullNameTxt;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button EditBtn;
    }
}