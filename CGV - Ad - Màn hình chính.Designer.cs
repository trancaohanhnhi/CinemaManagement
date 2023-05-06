
namespace MyCGV
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuqlcr = new System.Windows.Forms.ToolStripMenuItem();
            this.mncgvq1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mncgvq2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mncgvq3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mntheloai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnphim = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsuatchieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnqlkh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnqllc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnqltk = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.paneladmin = new System.Windows.Forms.Panel();
            this.mntk = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuqlcr,
            this.mntheloai,
            this.mnphim,
            this.mnsuatchieu,
            this.mnqlkh,
            this.mnqllc,
            this.mnqltk,
            this.mntk});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(9, 69);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(241, 293);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuqlcr
            // 
            this.menuqlcr.BackColor = System.Drawing.Color.Black;
            this.menuqlcr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mncgvq1,
            this.mncgvq2,
            this.mncgvq3,
            this.mnsetting});
            this.menuqlcr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.menuqlcr.ForeColor = System.Drawing.Color.Black;
            this.menuqlcr.Name = "menuqlcr";
            this.menuqlcr.Size = new System.Drawing.Size(217, 33);
            this.menuqlcr.Text = "Quản lý cụm rạp";
            this.menuqlcr.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // mncgvq1
            // 
            this.mncgvq1.Name = "mncgvq1";
            this.mncgvq1.Size = new System.Drawing.Size(270, 38);
            this.mncgvq1.Text = "CGV Quận 1 ";
            this.mncgvq1.Click += new System.EventHandler(this.mncgvq1_Click);
            // 
            // mncgvq2
            // 
            this.mncgvq2.Name = "mncgvq2";
            this.mncgvq2.Size = new System.Drawing.Size(270, 38);
            this.mncgvq2.Text = "CGV Quận 2";
            this.mncgvq2.Click += new System.EventHandler(this.mncgvq2_Click);
            // 
            // mncgvq3
            // 
            this.mncgvq3.Name = "mncgvq3";
            this.mncgvq3.Size = new System.Drawing.Size(270, 38);
            this.mncgvq3.Text = "CGV Quận 3";
            this.mncgvq3.Click += new System.EventHandler(this.mncgvq3_Click);
            // 
            // mnsetting
            // 
            this.mnsetting.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnsetting.AutoSize = false;
            this.mnsetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsetting.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mnsetting.Name = "mnsetting";
            this.mnsetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnsetting.Size = new System.Drawing.Size(270, 34);
            this.mnsetting.Text = "Cài đặt";
            this.mnsetting.Click += new System.EventHandler(this.mnsetting_Click);
            // 
            // mntheloai
            // 
            this.mntheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mntheloai.ForeColor = System.Drawing.Color.Black;
            this.mntheloai.Name = "mntheloai";
            this.mntheloai.Size = new System.Drawing.Size(125, 33);
            this.mntheloai.Text = "Thể loại";
            this.mntheloai.Click += new System.EventHandler(this.mntheloai_Click);
            // 
            // mnphim
            // 
            this.mnphim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mnphim.ForeColor = System.Drawing.Color.Black;
            this.mnphim.Name = "mnphim";
            this.mnphim.Size = new System.Drawing.Size(88, 33);
            this.mnphim.Text = "Phim";
            this.mnphim.Click += new System.EventHandler(this.mnphim_Click);
            // 
            // mnsuatchieu
            // 
            this.mnsuatchieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mnsuatchieu.ForeColor = System.Drawing.Color.Black;
            this.mnsuatchieu.Name = "mnsuatchieu";
            this.mnsuatchieu.Size = new System.Drawing.Size(151, 33);
            this.mnsuatchieu.Text = "Suất chiếu";
            this.mnsuatchieu.Click += new System.EventHandler(this.mnsuatchieu_Click);
            // 
            // mnqlkh
            // 
            this.mnqlkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mnqlkh.ForeColor = System.Drawing.Color.Black;
            this.mnqlkh.Name = "mnqlkh";
            this.mnqlkh.Size = new System.Drawing.Size(229, 33);
            this.mnqlkh.Text = "Quản lý kế hoạch";
            this.mnqlkh.Click += new System.EventHandler(this.mnqlkh_Click);
            // 
            // mnqllc
            // 
            this.mnqllc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mnqllc.ForeColor = System.Drawing.Color.Black;
            this.mnqllc.Name = "mnqllc";
            this.mnqllc.Size = new System.Drawing.Size(235, 33);
            this.mnqllc.Text = "Quản lý lịch chiếu";
            this.mnqllc.Click += new System.EventHandler(this.mnqllc_Click);
            // 
            // mnqltk
            // 
            this.mnqltk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mnqltk.ForeColor = System.Drawing.Color.Black;
            this.mnqltk.Name = "mnqltk";
            this.mnqltk.Size = new System.Drawing.Size(229, 33);
            this.mnqltk.Text = "Quản lý tài khoản";
            this.mnqltk.Click += new System.EventHandler(this.mnqltk_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.paneladmin);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1120, 594);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // paneladmin
            // 
            this.paneladmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneladmin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.paneladmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paneladmin.BackgroundImage")));
            this.paneladmin.Location = new System.Drawing.Point(253, 69);
            this.paneladmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneladmin.Name = "paneladmin";
            this.paneladmin.Size = new System.Drawing.Size(856, 522);
            this.paneladmin.TabIndex = 1;
            // 
            // mntk
            // 
            this.mntk.BackColor = System.Drawing.SystemColors.Control;
            this.mntk.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.mntk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.mntk.ForeColor = System.Drawing.Color.Black;
            this.mntk.Image = ((System.Drawing.Image)(resources.GetObject("mntk.Image")));
            this.mntk.Name = "mntk";
            this.mntk.Size = new System.Drawing.Size(155, 30);
            this.mntk.Text = "Tài khoản";
            this.mntk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1120, 594);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGV - Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuqlcr;
        private System.Windows.Forms.ToolStripMenuItem mncgvq1;
        private System.Windows.Forms.ToolStripMenuItem mncgvq2;
        private System.Windows.Forms.ToolStripMenuItem mncgvq3;
        private System.Windows.Forms.ToolStripMenuItem mnsetting;
        private System.Windows.Forms.ToolStripMenuItem mntheloai;
        private System.Windows.Forms.ToolStripMenuItem mnphim;
        private System.Windows.Forms.ToolStripMenuItem mnsuatchieu;
        private System.Windows.Forms.ToolStripMenuItem mnqlkh;
        private System.Windows.Forms.ToolStripMenuItem mnqllc;
        private System.Windows.Forms.ToolStripMenuItem mnqltk;
        private System.Windows.Forms.ToolStripMenuItem mntk;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel paneladmin;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}