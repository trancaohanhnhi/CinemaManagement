namespace MyCGV
{
    partial class FormThemtheloai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemtheloai));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btxnthemtl = new System.Windows.Forms.Button();
            this.bthuythemtl = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbthemtentl = new System.Windows.Forms.TextBox();
            this.lbtentl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbmatl = new System.Windows.Forms.Label();
            this.tbthemmtl = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btxnthemtl);
            this.panel1.Controls.Add(this.bthuythemtl);
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
            this.btxnthemtl.TabIndex = 2;
            this.btxnthemtl.Text = "Xác nhận";
            this.btxnthemtl.UseVisualStyleBackColor = false;
            this.btxnthemtl.Click += new System.EventHandler(this.btxnthemtl_Click);
            // 
            // bthuythemtl
            // 
            this.bthuythemtl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bthuythemtl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bthuythemtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuythemtl.Location = new System.Drawing.Point(215, 202);
            this.bthuythemtl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bthuythemtl.Name = "bthuythemtl";
            this.bthuythemtl.Size = new System.Drawing.Size(100, 42);
            this.bthuythemtl.TabIndex = 3;
            this.bthuythemtl.Text = "Hủy";
            this.bthuythemtl.UseVisualStyleBackColor = false;
            this.bthuythemtl.Click += new System.EventHandler(this.bthuythemtl_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbthemtentl);
            this.panel3.Controls.Add(this.lbtentl);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 64);
            this.panel3.TabIndex = 1;
            // 
            // tbthemtentl
            // 
            this.tbthemtentl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbthemtentl.Location = new System.Drawing.Point(181, 18);
            this.tbthemtentl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbthemtentl.Name = "tbthemtentl";
            this.tbthemtentl.Size = new System.Drawing.Size(304, 35);
            this.tbthemtentl.TabIndex = 0;
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
            this.panel2.Controls.Add(this.tbthemmtl);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 64);
            this.panel2.TabIndex = 0;
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
            // tbthemmtl
            // 
            this.tbthemmtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbthemmtl.Location = new System.Drawing.Point(181, 14);
            this.tbthemmtl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbthemmtl.Name = "tbthemmtl";
            this.tbthemmtl.Size = new System.Drawing.Size(304, 35);
            this.tbthemmtl.TabIndex = 1;
            // 
            // FormThemtheloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 280);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThemtheloai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGV - Thêm thể loại";
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
        private System.Windows.Forms.Button bthuythemtl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbthemtentl;
        private System.Windows.Forms.Label lbtentl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbmatl;
        private System.Windows.Forms.TextBox tbthemmtl;
    }
}