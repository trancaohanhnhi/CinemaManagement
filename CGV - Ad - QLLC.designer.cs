namespace MyCGV
{
    partial class FormQLLichchieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLLichchieu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btxoalc = new System.Windows.Forms.Button();
            this.btthemlc = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvqllc = new System.Windows.Forms.DataGridView();
            this.MaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuoiMaSuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqllc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btxoalc);
            this.panel1.Controls.Add(this.btthemlc);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.dgvqllc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 360);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(671, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btxoalc
            // 
            this.btxoalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btxoalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btxoalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btxoalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoalc.Location = new System.Drawing.Point(540, 49);
            this.btxoalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btxoalc.Name = "btxoalc";
            this.btxoalc.Size = new System.Drawing.Size(68, 34);
            this.btxoalc.TabIndex = 3;
            this.btxoalc.Text = "Xóa";
            this.btxoalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btxoalc.UseVisualStyleBackColor = false;
            this.btxoalc.Click += new System.EventHandler(this.btxoalc_Click);
            // 
            // btthemlc
            // 
            this.btthemlc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btthemlc.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btthemlc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btthemlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemlc.Location = new System.Drawing.Point(623, 49);
            this.btthemlc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthemlc.Name = "btthemlc";
            this.btthemlc.Size = new System.Drawing.Size(77, 34);
            this.btthemlc.TabIndex = 2;
            this.btthemlc.Text = "Thêm";
            this.btthemlc.UseVisualStyleBackColor = false;
            this.btthemlc.Click += new System.EventHandler(this.btthemlc_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(392, 10);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(309, 30);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged_1);
            // 
            // dgvqllc
            // 
            this.dgvqllc.AllowUserToAddRows = false;
            this.dgvqllc.AllowUserToDeleteRows = false;
            this.dgvqllc.AllowUserToOrderColumns = true;
            this.dgvqllc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvqllc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvqllc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvqllc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqllc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhim,
            this.MaRap,
            this.NgayChieu,
            this.ChuoiMaSuat});
            this.dgvqllc.Location = new System.Drawing.Point(7, 87);
            this.dgvqllc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvqllc.Name = "dgvqllc";
            this.dgvqllc.ReadOnly = true;
            this.dgvqllc.RowHeadersWidth = 62;
            this.dgvqllc.RowTemplate.Height = 28;
            this.dgvqllc.Size = new System.Drawing.Size(697, 266);
            this.dgvqllc.TabIndex = 0;
            this.dgvqllc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqllc_CellClick);
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
            // MaRap
            // 
            this.MaRap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaRap.DataPropertyName = "MaRap";
            this.MaRap.HeaderText = "Mã rạp";
            this.MaRap.MinimumWidth = 8;
            this.MaRap.Name = "MaRap";
            this.MaRap.ReadOnly = true;
            // 
            // NgayChieu
            // 
            this.NgayChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayChieu.DataPropertyName = "NgayChieu";
            this.NgayChieu.HeaderText = "Ngày chiếu";
            this.NgayChieu.MinimumWidth = 8;
            this.NgayChieu.Name = "NgayChieu";
            this.NgayChieu.ReadOnly = true;
            // 
            // ChuoiMaSuat
            // 
            this.ChuoiMaSuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChuoiMaSuat.DataPropertyName = "ChuoiMaSuat";
            this.ChuoiMaSuat.HeaderText = "Chuỗi mã suất";
            this.ChuoiMaSuat.MinimumWidth = 8;
            this.ChuoiMaSuat.Name = "ChuoiMaSuat";
            this.ChuoiMaSuat.ReadOnly = true;
            // 
            // FormQLLichchieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQLLichchieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGV - Quản lý lịch chiếu";
            this.Load += new System.EventHandler(this.FormQLLichchieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqllc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvqllc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btxoalc;
        private System.Windows.Forms.Button btthemlc;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuoiMaSuat;
    }
}