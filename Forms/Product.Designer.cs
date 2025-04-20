namespace e_ShopManager.Forms
{
    partial class Product
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewProductBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ImportBtn);
            this.panel1.Controls.Add(this.ExportBtn);
            this.panel1.Controls.Add(this.NewProductBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 45);
            this.panel1.TabIndex = 0;
            // 
            // NewProductBtn
            // 
            this.NewProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.NewProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewProductBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.NewProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProductBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.NewProductBtn.Location = new System.Drawing.Point(800, 0);
            this.NewProductBtn.Name = "NewProductBtn";
            this.NewProductBtn.Size = new System.Drawing.Size(103, 43);
            this.NewProductBtn.TabIndex = 0;
            this.NewProductBtn.Text = "New Product";
            this.NewProductBtn.UseVisualStyleBackColor = false;
            // 
            // ExportBtn
            // 
            this.ExportBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ExportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExportBtn.Location = new System.Drawing.Point(697, 0);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(103, 43);
            this.ExportBtn.TabIndex = 1;
            this.ExportBtn.Text = "Export";
            this.ExportBtn.UseVisualStyleBackColor = false;
            // 
            // ImportBtn
            // 
            this.ImportBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ImportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImportBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ImportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ImportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ImportBtn.Location = new System.Drawing.Point(594, 0);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(103, 43);
            this.ImportBtn.TabIndex = 2;
            this.ImportBtn.Text = "Import";
            this.ImportBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Manager";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 558);
            this.Controls.Add(this.panel1);
            this.Name = "Product";
            this.Text = "Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewProductBtn;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Label label1;
    }
}