namespace MyCGV
{
    partial class FormSuatheloai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuatheloai));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btxnthemtl = new System.Windows.Forms.Button();
            this.bthuysuatl = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbsuatentl = new System.Windows.Forms.TextBox();
            this.lbtentl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbmatl = new System.Windows.Forms.Label();
            this.tbsuamtl = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btxnthemtl);
            this.panel1.Controls.Add(this.bthuysuatl);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 280);
            this.panel1.TabIndex = 0;
            // 
            // btxnthemtl
            // 
            this.btxnthemtl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btxnthemtl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btxnthemtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxnthemtl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btxnthemtl.Location = new System.Drawing.Point(340, 205);
            this.btxnthemtl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btxnthemtl.Name = "btxnthemtl";
            this.btxnthemtl.Size = new System.Drawing.Size(181, 40);
            this.btxnthemtl.TabIndex = 1;
            this.btxnthemtl.Text = "Xác nhận";
            this.btxnthemtl.UseVisualStyleBackColor = false;
            this.btxnthemtl.Click += new System.EventHandler(this.btxnsuatl_Click);
            // 
            // bthuysuatl
            // 
            this.bthuysuatl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bthuysuatl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bthuysuatl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuysuatl.Location = new System.Drawing.Point(215, 202);
            this.bthuysuatl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bthuysuatl.Name = "bthuysuatl";
            this.bthuysuatl.Size = new System.Drawing.Size(100, 42);
            this.bthuysuatl.TabIndex = 2;
            this.bthuysuatl.Text = "Hủy";
            this.bthuysuatl.UseVisualStyleBackColor = false;
            this.bthuysuatl.Click += new System.EventHandler(this.bthuysuatl_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbsuatentl);
            this.panel3.Controls.Add(this.lbtentl);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 64);
            this.panel3.TabIndex = 0;
            // 
            // tbsuatentl
            // 
            this.tbsuatentl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbsuatentl.Location = new System.Drawing.Point(181, 18);
            this.tbsuatentl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbsuatentl.Name = "tbsuatentl";
            this.tbsuatentl.Size = new System.Drawing.Size(304, 35);
            this.tbsuatentl.TabIndex = 0;
            // 
            // lbtentl
            // 
            this.lbtentl.AutoSize = true;
            this.lbtentl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtentl.Location = new System.Drawing.Point(22, 20);
            this.lbtentl.Name = "lbtentl";
            this.lbtentl.Size = new System.Drawing.Size(140, 29);
            this.lbtentl.TabIndex = 0;
            this.lbtentl.Text = "Tên thể loại";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbmatl);
            this.panel2.Controls.Add(this.tbsuamtl);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 64);
            this.panel2.TabIndex = 2;
            // 
            // lbmatl
            // 
            this.lbmatl.AutoSize = true;
            this.lbmatl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatl.Location = new System.Drawing.Point(22, 20);
            this.lbmatl.Name = "lbmatl";
            this.lbmatl.Size = new System.Drawing.Size(130, 29);
            this.lbmatl.TabIndex = 0;
            this.lbmatl.Text = "Mã thể loại";
            // 
            // tbsuamtl
            // 
            this.tbsuamtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbsuamtl.Location = new System.Drawing.Point(181, 14);
            this.tbsuamtl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbsuamtl.Name = "tbsuamtl";
            this.tbsuamtl.ReadOnly = true;
            this.tbsuamtl.Size = new System.Drawing.Size(304, 35);
            this.tbsuamtl.TabIndex = 0;
            // 
            // FormSuatheloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 280);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSuatheloai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGV - Sửa thể loại";
            this.Load += new System.EventHandler(this.FormSuatheloai_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btxnthemtl;
        private System.Windows.Forms.Button bthuysuatl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbtentl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbmatl;
        private System.Windows.Forms.TextBox tbsuamtl;
        private System.Windows.Forms.TextBox tbsuatentl;
    }
}