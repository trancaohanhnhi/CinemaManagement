namespace MyCGV
{
    partial class FormQuản_lý_tài_khoản
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuản_lý_tài_khoản));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btthemtk = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvqltk = new System.Windows.Forms.DataGridView();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbqltk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btdoimk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqltk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btdoimk);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btthemtk);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbqltk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 529);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(742, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btthemtk
            // 
            this.btthemtk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btthemtk.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btthemtk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btthemtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemtk.Location = new System.Drawing.Point(651, 74);
            this.btthemtk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthemtk.Name = "btthemtk";
            this.btthemtk.Size = new System.Drawing.Size(125, 42);
            this.btthemtk.TabIndex = 1;
            this.btthemtk.Text = "Thêm";
            this.btthemtk.UseVisualStyleBackColor = false;
            this.btthemtk.Click += new System.EventHandler(this.btthemtk_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSearch.Location = new System.Drawing.Point(422, 21);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(354, 35);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvqltk);
            this.panel2.Location = new System.Drawing.Point(12, 134);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 369);
            this.panel2.TabIndex = 3;
            // 
            // dgvqltk
            // 
            this.dgvqltk.AllowUserToAddRows = false;
            this.dgvqltk.AllowUserToDeleteRows = false;
            this.dgvqltk.AllowUserToOrderColumns = true;
            this.dgvqltk.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvqltk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvqltk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqltk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTaiKhoan,
            this.MatKhau,
            this.TenChuTaiKhoan,
            this.MaCum});
            this.dgvqltk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvqltk.Location = new System.Drawing.Point(0, 0);
            this.dgvqltk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvqltk.Name = "dgvqltk";
            this.dgvqltk.ReadOnly = true;
            this.dgvqltk.RowHeadersWidth = 62;
            this.dgvqltk.RowTemplate.Height = 28;
            this.dgvqltk.Size = new System.Drawing.Size(776, 369);
            this.dgvqltk.TabIndex = 0;
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoan.HeaderText = "Tên tài khoản";
            this.TenTaiKhoan.MinimumWidth = 8;
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 8;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // TenChuTaiKhoan
            // 
            this.TenChuTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenChuTaiKhoan.DataPropertyName = "TenChuTaiKhoan";
            this.TenChuTaiKhoan.HeaderText = "Tên chủ tài khoản";
            this.TenChuTaiKhoan.MinimumWidth = 8;
            this.TenChuTaiKhoan.Name = "TenChuTaiKhoan";
            this.TenChuTaiKhoan.ReadOnly = true;
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
            // lbqltk
            // 
            this.lbqltk.AutoSize = true;
            this.lbqltk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbqltk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbqltk.Location = new System.Drawing.Point(12, 32);
            this.lbqltk.Name = "lbqltk";
            this.lbqltk.Size = new System.Drawing.Size(360, 37);
            this.lbqltk.TabIndex = 2;
            this.lbqltk.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // btdoimk
            // 
            this.btdoimk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btdoimk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btdoimk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btdoimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdoimk.Location = new System.Drawing.Point(422, 74);
            this.btdoimk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btdoimk.Name = "btdoimk";
            this.btdoimk.Size = new System.Drawing.Size(206, 42);
            this.btdoimk.TabIndex = 12;
            this.btdoimk.Text = "Đổi mật khẩu";
            this.btdoimk.UseVisualStyleBackColor = false;
            this.btdoimk.Click += new System.EventHandler(this.btdoimk_Click);
            // 
            // FormQuản_lý_tài_khoản
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQuản_lý_tài_khoản";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGV - Quản lý tài khoản";
            this.Load += new System.EventHandler(this.FormQuản_lý_tài_khoản_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqltk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btthemtk;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbqltk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvqltk;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCum;
        private System.Windows.Forms.Button btdoimk;
    }
}