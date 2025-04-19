namespace e_ShopManager
{
    partial class UserAuth
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
            this.UserAuthPanel = new System.Windows.Forms.Panel();
            this.UserAuthIntroPanel = new System.Windows.Forms.Panel();
            this.LinkGithub = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserAuthLabel = new System.Windows.Forms.Label();
            this.UserAuthImg = new System.Windows.Forms.PictureBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.ForgetPassbtn = new System.Windows.Forms.LinkLabel();
            this.Closebtn = new System.Windows.Forms.Label();
            this.UserAuthPanel.SuspendLayout();
            this.UserAuthIntroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserAuthImg)).BeginInit();
            this.SuspendLayout();
            // 
            // UserAuthPanel
            // 
            this.UserAuthPanel.BackColor = System.Drawing.SystemColors.Control;
            this.UserAuthPanel.Controls.Add(this.Closebtn);
            this.UserAuthPanel.Controls.Add(this.ForgetPassbtn);
            this.UserAuthPanel.Controls.Add(this.Loginbtn);
            this.UserAuthPanel.Controls.Add(this.PassTxt);
            this.UserAuthPanel.Controls.Add(this.Usernametxt);
            this.UserAuthPanel.Controls.Add(this.LoginLabel);
            this.UserAuthPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserAuthPanel.Location = new System.Drawing.Point(242, 0);
            this.UserAuthPanel.Name = "UserAuthPanel";
            this.UserAuthPanel.Size = new System.Drawing.Size(492, 491);
            this.UserAuthPanel.TabIndex = 0;
            // 
            // UserAuthIntroPanel
            // 
            this.UserAuthIntroPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.UserAuthIntroPanel.Controls.Add(this.LinkGithub);
            this.UserAuthIntroPanel.Controls.Add(this.label2);
            this.UserAuthIntroPanel.Controls.Add(this.label1);
            this.UserAuthIntroPanel.Controls.Add(this.UserAuthLabel);
            this.UserAuthIntroPanel.Controls.Add(this.UserAuthImg);
            this.UserAuthIntroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserAuthIntroPanel.Location = new System.Drawing.Point(0, 0);
            this.UserAuthIntroPanel.Name = "UserAuthIntroPanel";
            this.UserAuthIntroPanel.Size = new System.Drawing.Size(242, 491);
            this.UserAuthIntroPanel.TabIndex = 1;
            // 
            // LinkGithub
            // 
            this.LinkGithub.AutoSize = true;
            this.LinkGithub.LinkColor = System.Drawing.Color.White;
            this.LinkGithub.Location = new System.Drawing.Point(14, 443);
            this.LinkGithub.Name = "LinkGithub";
            this.LinkGithub.Size = new System.Drawing.Size(70, 13);
            this.LinkGithub.TabIndex = 4;
            this.LinkGithub.TabStop = true;
            this.LinkGithub.Text = "Github Profile";
            this.LinkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGithub_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(14, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Develop by";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Shop Manager";
            // 
            // UserAuthLabel
            // 
            this.UserAuthLabel.AutoSize = true;
            this.UserAuthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAuthLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UserAuthLabel.Location = new System.Drawing.Point(39, 168);
            this.UserAuthLabel.Name = "UserAuthLabel";
            this.UserAuthLabel.Size = new System.Drawing.Size(163, 31);
            this.UserAuthLabel.TabIndex = 1;
            this.UserAuthLabel.Text = "Welcome to ";
            // 
            // UserAuthImg
            // 
            this.UserAuthImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UserAuthImg.Image = global::e_ShopManager.Properties.Resources.management;
            this.UserAuthImg.Location = new System.Drawing.Point(12, 82);
            this.UserAuthImg.Name = "UserAuthImg";
            this.UserAuthImg.Size = new System.Drawing.Size(209, 83);
            this.UserAuthImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.UserAuthImg.TabIndex = 0;
            this.UserAuthImg.TabStop = false;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.LoginLabel.Location = new System.Drawing.Point(25, 134);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(104, 31);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "LOGIN";
            // 
            // Usernametxt
            // 
            this.Usernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametxt.ForeColor = System.Drawing.Color.Gray;
            this.Usernametxt.Location = new System.Drawing.Point(31, 178);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(434, 22);
            this.Usernametxt.TabIndex = 1;
            this.Usernametxt.Text = "Username";
            this.Usernametxt.Enter += new System.EventHandler(this.Usernametxt_Enter);
            this.Usernametxt.Leave += new System.EventHandler(this.Usernametxt_Leave);
            // 
            // PassTxt
            // 
            this.PassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTxt.ForeColor = System.Drawing.Color.Gray;
            this.PassTxt.Location = new System.Drawing.Point(31, 211);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(434, 22);
            this.PassTxt.TabIndex = 2;
            this.PassTxt.Text = "Password";
            this.PassTxt.Enter += new System.EventHandler(this.PassTxt_Enter);
            this.PassTxt.Leave += new System.EventHandler(this.PassTxt_Leave);
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Loginbtn.Location = new System.Drawing.Point(31, 249);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(98, 31);
            this.Loginbtn.TabIndex = 3;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // ForgetPassbtn
            // 
            this.ForgetPassbtn.AutoSize = true;
            this.ForgetPassbtn.Location = new System.Drawing.Point(135, 258);
            this.ForgetPassbtn.Name = "ForgetPassbtn";
            this.ForgetPassbtn.Size = new System.Drawing.Size(92, 13);
            this.ForgetPassbtn.TabIndex = 4;
            this.ForgetPassbtn.TabStop = true;
            this.ForgetPassbtn.Text = "Forget Password?";
            this.ForgetPassbtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgetPassbtn_LinkClicked);
            // 
            // Closebtn
            // 
            this.Closebtn.AutoSize = true;
            this.Closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Closebtn.Location = new System.Drawing.Point(440, 9);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(25, 24);
            this.Closebtn.TabIndex = 5;
            this.Closebtn.Text = "X";
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // UserAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 491);
            this.ControlBox = false;
            this.Controls.Add(this.UserAuthIntroPanel);
            this.Controls.Add(this.UserAuthPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserAuth";
            this.Text = "Login";
            this.UserAuthPanel.ResumeLayout(false);
            this.UserAuthPanel.PerformLayout();
            this.UserAuthIntroPanel.ResumeLayout(false);
            this.UserAuthIntroPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserAuthImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UserAuthPanel;
        private System.Windows.Forms.Panel UserAuthIntroPanel;
        private System.Windows.Forms.PictureBox UserAuthImg;
        private System.Windows.Forms.LinkLabel LinkGithub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserAuthLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Label Closebtn;
        private System.Windows.Forms.LinkLabel ForgetPassbtn;
    }
}

