
namespace MyCGV
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.lbquan1 = new System.Windows.Forms.Label();
            this.suacumrap = new System.Windows.Forms.Button();
            this.themcumrap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvsettingcumrap = new System.Windows.Forms.DataGridView();
            this.MaCum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsettingcumrap)).BeginInit();
            this.SuspendLayout();
            // 
            // lbquan1
            // 
            this.lbquan1.AutoSize = true;
            this.lbquan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquan1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbquan1.Location = new System.Drawing.Point(21, 40);
            this.lbquan1.Name = "lbquan1";
            this.lbquan1.Size = new System.Drawing.Size(146, 31);
            this.lbquan1.TabIndex = 1;
            this.lbquan1.Text = "CỤM RẠP";
            // 
            // suacumrap
            // 
            this.suacumrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.suacumrap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.suacumrap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.suacumrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suacumrap.Location = new System.Drawing.Point(566, 46);
            this.suacumrap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suacumrap.Name = "suacumrap";
            this.suacumrap.Size = new System.Drawing.Size(76, 35);
            this.suacumrap.TabIndex = 3;
            this.suacumrap.Text = "Sửa";
            this.suacumrap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.suacumrap.UseVisualStyleBackColor = false;
            this.suacumrap.Click += new System.EventHandler(this.suacumrap_Click);
            // 
            // themcumrap
            // 
            this.themcumrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.themcumrap.BackColor = System.Drawing.Color.PaleTurquoise;
            this.themcumrap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.themcumrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themcumrap.Location = new System.Drawing.Point(660, 46);
            this.themcumrap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.themcumrap.Name = "themcumrap";
            this.themcumrap.Size = new System.Drawing.Size(99, 34);
            this.themcumrap.TabIndex = 2;
            this.themcumrap.Text = "Thêm";
            this.themcumrap.UseVisualStyleBackColor = false;
            this.themcumrap.Click += new System.EventHandler(this.themcumrap_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.themcumrap);
            this.panel1.Controls.Add(this.suacumrap);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.lbquan1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 458);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(726, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dgvsettingcumrap);
            this.panel2.Location = new System.Drawing.Point(17, 97);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 349);
            this.panel2.TabIndex = 5;
            // 
            // dgvsettingcumrap
            // 
            this.dgvsettingcumrap.AllowUserToAddRows = false;
            this.dgvsettingcumrap.AllowUserToDeleteRows = false;
            this.dgvsettingcumrap.AllowUserToOrderColumns = true;
            this.dgvsettingcumrap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvsettingcumrap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvsettingcumrap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvsettingcumrap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsettingcumrap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCum,
            this.TenCum,
            this.DiaChi});
            this.dgvsettingcumrap.Location = new System.Drawing.Point(0, 0);
            this.dgvsettingcumrap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvsettingcumrap.Name = "dgvsettingcumrap";
            this.dgvsettingcumrap.ReadOnly = true;
            this.dgvsettingcumrap.RowHeadersWidth = 62;
            this.dgvsettingcumrap.RowTemplate.Height = 28;
            this.dgvsettingcumrap.Size = new System.Drawing.Size(751, 349);
            this.dgvsettingcumrap.TabIndex = 0;
            this.dgvsettingcumrap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsettingcumrap_CellClick);
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
            // TenCum
            // 
            this.TenCum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCum.DataPropertyName = "TenCum";
            this.TenCum.HeaderText = "Tên Cụm";
            this.TenCum.MinimumWidth = 8;
            this.TenCum.Name = "TenCum";
            this.TenCum.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(524, 10);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(231, 30);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 458);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSetting";
            this.Text = "CGV - Admin/Setting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsettingcumrap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbquan1;
        private System.Windows.Forms.Button suacumrap;
        private System.Windows.Forms.Button themcumrap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvsettingcumrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}