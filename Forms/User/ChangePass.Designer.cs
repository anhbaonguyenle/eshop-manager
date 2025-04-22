namespace e_ShopManager.Forms
{
    partial class ChangePass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChanePassBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.OldPasstxt = new System.Windows.Forms.TextBox();
            this.Passtxt = new System.Windows.Forms.TextBox();
            this.ComfirmPasstxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // ChanePassBtn
            // 
            this.ChanePassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ChanePassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChanePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChanePassBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ChanePassBtn.Location = new System.Drawing.Point(32, 139);
            this.ChanePassBtn.Name = "ChanePassBtn";
            this.ChanePassBtn.Size = new System.Drawing.Size(118, 23);
            this.ChanePassBtn.TabIndex = 3;
            this.ChanePassBtn.Text = "Change Password";
            this.ChanePassBtn.UseVisualStyleBackColor = false;
            this.ChanePassBtn.Click += new System.EventHandler(this.ChanePassBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseBtn.Location = new System.Drawing.Point(205, 139);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(118, 23);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // OldPasstxt
            // 
            this.OldPasstxt.Location = new System.Drawing.Point(123, 17);
            this.OldPasstxt.Name = "OldPasstxt";
            this.OldPasstxt.Size = new System.Drawing.Size(235, 20);
            this.OldPasstxt.TabIndex = 5;
            // 
            // Passtxt
            // 
            this.Passtxt.Location = new System.Drawing.Point(123, 53);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.Size = new System.Drawing.Size(235, 20);
            this.Passtxt.TabIndex = 6;
            // 
            // ComfirmPasstxt
            // 
            this.ComfirmPasstxt.Location = new System.Drawing.Point(123, 91);
            this.ComfirmPasstxt.Name = "ComfirmPasstxt";
            this.ComfirmPasstxt.Size = new System.Drawing.Size(235, 20);
            this.ComfirmPasstxt.TabIndex = 7;
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 174);
            this.Controls.Add(this.ComfirmPasstxt);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.OldPasstxt);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ChanePassBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePass";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ChanePassBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TextBox OldPasstxt;
        private System.Windows.Forms.TextBox Passtxt;
        private System.Windows.Forms.TextBox ComfirmPasstxt;
    }
}