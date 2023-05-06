namespace MyCGV
{
    partial class FormPhim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhim));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btthemphim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btsuaphim = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPhim = new System.Windows.Forms.DataGridView();
            this.MaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTheLoaiChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTheLoaiPhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbphim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btthemphim);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btsuaphim);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbphim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 565);
            this.panel1.TabIndex = 0;
            // 
            // btthemphim
            // 
            this.btthemphim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btthemphim.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btthemphim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btthemphim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemphim.Location = new System.Drawing.Point(723, 88);
            this.btthemphim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthemphim.Name = "btthemphim";
            this.btthemphim.Size = new System.Drawing.Size(105, 42);
            this.btthemphim.TabIndex = 10;
            this.btthemphim.Text = "Thêm";
            this.btthemphim.UseVisualStyleBackColor = false;
            this.btthemphim.Click += new System.EventHandler(this.btthemphim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(796, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btsuaphim
            // 
            this.btsuaphim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btsuaphim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btsuaphim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btsuaphim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsuaphim.Location = new System.Drawing.Point(608, 88);
            this.btsuaphim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btsuaphim.Name = "btsuaphim";
            this.btsuaphim.Size = new System.Drawing.Size(100, 42);
            this.btsuaphim.TabIndex = 2;
            this.btsuaphim.Text = "Sửa";
            this.btsuaphim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsuaphim.UseVisualStyleBackColor = false;
            this.btsuaphim.Click += new System.EventHandler(this.btsuaphim_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(490, 31);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(340, 35);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dgvPhim);
            this.panel2.Location = new System.Drawing.Point(12, 148);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 406);
            this.panel2.TabIndex = 3;
            // 
            // dgvPhim
            // 
            this.dgvPhim.AllowUserToAddRows = false;
            this.dgvPhim.AllowUserToDeleteRows = false;
            this.dgvPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhim.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPhim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhim,
            this.TenPhim,
            this.MaTheLoaiChinh,
            this.MaTheLoaiPhu,
            this.ThoiLuong});
            this.dgvPhim.Location = new System.Drawing.Point(0, 0);
            this.dgvPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPhim.Name = "dgvPhim";
            this.dgvPhim.ReadOnly = true;
            this.dgvPhim.RowHeadersWidth = 62;
            this.dgvPhim.RowTemplate.Height = 28;
            this.dgvPhim.Size = new System.Drawing.Size(843, 406);
            this.dgvPhim.TabIndex = 4;
            this.dgvPhim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhim_CellClick);
            // 
            // MaPhim
            // 
            this.MaPhim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhim.DataPropertyName = "MaPhim";
            this.MaPhim.HeaderText = "Mã Phim";
            this.MaPhim.MinimumWidth = 50;
            this.MaPhim.Name = "MaPhim";
            this.MaPhim.ReadOnly = true;
            // 
            // TenPhim
            // 
            this.TenPhim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên phim";
            this.TenPhim.MinimumWidth = 50;
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            // 
            // MaTheLoaiChinh
            // 
            this.MaTheLoaiChinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTheLoaiChinh.DataPropertyName = "MaTheLoaiChinh";
            this.MaTheLoaiChinh.HeaderText = "Mã thể loại chính";
            this.MaTheLoaiChinh.MinimumWidth = 50;
            this.MaTheLoaiChinh.Name = "MaTheLoaiChinh";
            this.MaTheLoaiChinh.ReadOnly = true;
            // 
            // MaTheLoaiPhu
            // 
            this.MaTheLoaiPhu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTheLoaiPhu.DataPropertyName = "MaTheLoaiPhu";
            this.MaTheLoaiPhu.HeaderText = "Mã thể loại phụ";
            this.MaTheLoaiPhu.MinimumWidth = 50;
            this.MaTheLoaiPhu.Name = "MaTheLoaiPhu";
            this.MaTheLoaiPhu.ReadOnly = true;
            // 
            // ThoiLuong
            // 
            this.ThoiLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThoiLuong.DataPropertyName = "ThoiLuong";
            this.ThoiLuong.HeaderText = "Thời lượng";
            this.ThoiLuong.MinimumWidth = 50;
            this.ThoiLuong.Name = "ThoiLuong";
            this.ThoiLuong.ReadOnly = true;
            // 
            // lbphim
            // 
            this.lbphim.AutoSize = true;
            this.lbphim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbphim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbphim.Location = new System.Drawing.Point(12, 52);
            this.lbphim.Name = "lbphim";
            this.lbphim.Size = new System.Drawing.Size(99, 37);
            this.lbphim.TabIndex = 2;
            this.lbphim.Text = "PHIM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // FormPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 565);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPhim";
            this.Text = "Phim";
            this.Load += new System.EventHandler(this.FormPhim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btsuaphim;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbphim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPhim;
        private System.Windows.Forms.Button btthemphim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoaiChinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoaiPhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiLuong;
    }
}