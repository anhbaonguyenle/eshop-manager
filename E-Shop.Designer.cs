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
            this.label1 = new System.Windows.Forms.Label();
            this.Minimizebtn = new System.Windows.Forms.Label();
            this.Resizebtn = new System.Windows.Forms.PictureBox();
            this.Closebtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resizebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Controls.Add(this.Minimizebtn);
            this.ControlPanel.Controls.Add(this.Resizebtn);
            this.ControlPanel.Controls.Add(this.Closebtn);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(965, 52);
            this.ControlPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "E-Shop Manager";
            // 
            // Minimizebtn
            // 
            this.Minimizebtn.AutoSize = true;
            this.Minimizebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimizebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Minimizebtn.Location = new System.Drawing.Point(623, 11);
            this.Minimizebtn.Name = "Minimizebtn";
            this.Minimizebtn.Size = new System.Drawing.Size(30, 39);
            this.Minimizebtn.TabIndex = 10;
            this.Minimizebtn.Text = "-";
            this.Minimizebtn.Click += new System.EventHandler(this.Minimizebtn_Click_1);
            // 
            // Resizebtn
            // 
            this.Resizebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Resizebtn.Image = global::e_ShopManager.Properties.Resources.Resize;
            this.Resizebtn.Location = new System.Drawing.Point(658, 12);
            this.Resizebtn.Name = "Resizebtn";
            this.Resizebtn.Size = new System.Drawing.Size(31, 24);
            this.Resizebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Resizebtn.TabIndex = 8;
            this.Resizebtn.TabStop = false;
            this.Resizebtn.Click += new System.EventHandler(this.Resizebtn_Click_1);
            // 
            // Closebtn
            // 
            this.Closebtn.AutoSize = true;
            this.Closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Closebtn.Location = new System.Drawing.Point(695, 12);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(25, 24);
            this.Closebtn.TabIndex = 9;
            this.Closebtn.Text = "X";
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 613);
            this.panel2.TabIndex = 1;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 665);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "E-shop Manager";
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resizebtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Minimizebtn;
        private System.Windows.Forms.PictureBox Resizebtn;
        private System.Windows.Forms.Label Closebtn;
        private System.Windows.Forms.Label label1;
    }
}