namespace MyCGV
{
    partial class FormQuản_lý_kế_hoạch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuản_lý_kế_hoạch));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btxoakh = new System.Windows.Forms.Button();
            this.btthemkh = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvqlkh = new System.Windows.Forms.DataGridView();
            this.MaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKhoiChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbqlkh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlkh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btxoakh);
            this.panel1.Controls.Add(this.btthemkh);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbqlkh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 423);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(716, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btxoakh
            // 
            this.btxoakh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btxoakh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btxoakh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btxoakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoakh.Location = new System.Drawing.Point(579, 58);
            this.btxoakh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btxoakh.Name = "btxoakh";
            this.btxoakh.Size = new System.Drawing.Size(68, 34);
            this.btxoakh.TabIndex = 3;
            this.btxoakh.Text = "Xóa";
            this.btxoakh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btxoakh.UseVisualStyleBackColor = false;
            this.btxoakh.Click += new System.EventHandler(this.btxoakh_Click);
            // 
            // btthemkh
            // 
            this.btthemkh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btthemkh.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btthemkh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btthemkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemkh.Location = new System.Drawing.Point(668, 58);
            this.btthemkh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthemkh.Name = "btthemkh";
            this.btthemkh.Size = new System.Drawing.Size(77, 34);
            this.btthemkh.TabIndex = 2;
            this.btthemkh.Text = "Thêm";
            this.btthemkh.UseVisualStyleBackColor = false;
            this.btthemkh.Click += new System.EventHandler(this.btthemkh_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(502, 16);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(244, 30);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dgvqlkh);
            this.panel2.Location = new System.Drawing.Point(11, 103);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 310);
            this.panel2.TabIndex = 3;
            // 
            // dgvqlkh
            // 
            this.dgvqlkh.AllowUserToAddRows = false;
            this.dgvqlkh.AllowUserToDeleteRows = false;
            this.dgvqlkh.AllowUserToOrderColumns = true;
            this.dgvqlkh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvqlkh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvqlkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqlkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhim,
            this.MaCum,
            this.NgayKhoiChieu,
            this.NgayKetThuc,
            this.GhiChu});
            this.dgvqlkh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvqlkh.Location = new System.Drawing.Point(0, 0);
            this.dgvqlkh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvqlkh.Name = "dgvqlkh";
            this.dgvqlkh.ReadOnly = true;
            this.dgvqlkh.RowHeadersWidth = 62;
            this.dgvqlkh.RowTemplate.Height = 28;
            this.dgvqlkh.Size = new System.Drawing.Size(747, 310);
            this.dgvqlkh.TabIndex = 0;
            this.dgvqlkh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqlkh_CellClick);
            // 
            // MaPhim
            // 
            this.MaPhim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhim.DataPropertyName = "MaPhim";
            this.MaPhim.HeaderText = "Mã phim";
            this.MaPhim.MinimumWidth = 8;
            this.MaPhim.Name = "MaPhim";
            this.MaPhim.ReadOnly = true;
            // 
            // MaCum
            // 
            this.MaCum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCum.DataPropertyName = "MaCum";
            this.MaCum.HeaderText = "Mã cụm";
            this.MaCum.MinimumWidth = 8;
            this.MaCum.Name = "MaCum";
            this.MaCum.ReadOnly = true;
            // 
            // NgayKhoiChieu
            // 
            this.NgayKhoiChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayKhoiChieu.DataPropertyName = "NgayKhoiChieu";
            this.NgayKhoiChieu.HeaderText = "Ngày khởi chiếu";
            this.NgayKhoiChieu.MinimumWidth = 8;
            this.NgayKhoiChieu.Name = "NgayKhoiChieu";
            this.NgayKhoiChieu.ReadOnly = true;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.MinimumWidth = 8;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 8;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // lbqlkh
            // 
            this.lbqlkh.AutoSize = true;
            this.lbqlkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbqlkh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbqlkh.Location = new System.Drawing.Point(11, 32);
            this.lbqlkh.Name = "lbqlkh";
            this.lbqlkh.Size = new System.Drawing.Size(282, 31);
            this.lbqlkh.TabIndex = 2;
            this.lbqlkh.Text = "QUẢN LÝ KẾ HOẠCH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // FormQuản_lý_kế_hoạch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 423);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQuản_lý_kế_hoạch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGV - Quản lý kế hoạch";
            this.Load += new System.EventHandler(this.FormQuản_lý_kế_hoạch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlkh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btxoakh;
        private System.Windows.Forms.Button btthemkh;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbqlkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvqlkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCum;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKhoiChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}