namespace MyCGV
{
    partial class FormSuất_chiếu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuất_chiếu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btxoasc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btthemsc = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvsuatchieu = new System.Windows.Forms.DataGridView();
            this.MaSuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhutBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbsuatchieu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsuatchieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btxoasc);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btthemsc);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbsuatchieu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 565);
            this.panel1.TabIndex = 0;
            // 
            // btxoasc
            // 
            this.btxoasc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btxoasc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btxoasc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btxoasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoasc.Location = new System.Drawing.Point(648, 72);
            this.btxoasc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btxoasc.Name = "btxoasc";
            this.btxoasc.Size = new System.Drawing.Size(87, 42);
            this.btxoasc.TabIndex = 11;
            this.btxoasc.Text = "Xóa";
            this.btxoasc.UseVisualStyleBackColor = false;
            this.btxoasc.Click += new System.EventHandler(this.btxoasc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(809, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btthemsc
            // 
            this.btthemsc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btthemsc.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btthemsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btthemsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemsc.Location = new System.Drawing.Point(756, 72);
            this.btthemsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthemsc.Name = "btthemsc";
            this.btthemsc.Size = new System.Drawing.Size(87, 42);
            this.btthemsc.TabIndex = 1;
            this.btthemsc.Text = "Thêm";
            this.btthemsc.UseVisualStyleBackColor = false;
            this.btthemsc.Click += new System.EventHandler(this.btthemsc_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(496, 24);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(347, 35);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dgvsuatchieu);
            this.panel2.Location = new System.Drawing.Point(19, 128);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 426);
            this.panel2.TabIndex = 3;
            // 
            // dgvsuatchieu
            // 
            this.dgvsuatchieu.AllowUserToAddRows = false;
            this.dgvsuatchieu.AllowUserToDeleteRows = false;
            this.dgvsuatchieu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvsuatchieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvsuatchieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsuatchieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSuat,
            this.GioBatDau,
            this.PhutBatDau});
            this.dgvsuatchieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsuatchieu.Location = new System.Drawing.Point(0, 0);
            this.dgvsuatchieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvsuatchieu.Name = "dgvsuatchieu";
            this.dgvsuatchieu.ReadOnly = true;
            this.dgvsuatchieu.RowHeadersWidth = 62;
            this.dgvsuatchieu.RowTemplate.Height = 28;
            this.dgvsuatchieu.Size = new System.Drawing.Size(824, 426);
            this.dgvsuatchieu.TabIndex = 0;
            // 
            // MaSuat
            // 
            this.MaSuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSuat.DataPropertyName = "MaSuat";
            this.MaSuat.HeaderText = "Mã suất chiếu";
            this.MaSuat.MinimumWidth = 8;
            this.MaSuat.Name = "MaSuat";
            this.MaSuat.ReadOnly = true;
            // 
            // GioBatDau
            // 
            this.GioBatDau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioBatDau.DataPropertyName = "GioBatDau";
            this.GioBatDau.HeaderText = "Giờ bắt đầu";
            this.GioBatDau.MinimumWidth = 8;
            this.GioBatDau.Name = "GioBatDau";
            this.GioBatDau.ReadOnly = true;
            // 
            // PhutBatDau
            // 
            this.PhutBatDau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhutBatDau.DataPropertyName = "PhutBatDau";
            this.PhutBatDau.HeaderText = "Phút bắt đầu";
            this.PhutBatDau.MinimumWidth = 8;
            this.PhutBatDau.Name = "PhutBatDau";
            this.PhutBatDau.ReadOnly = true;
            // 
            // lbsuatchieu
            // 
            this.lbsuatchieu.AutoSize = true;
            this.lbsuatchieu.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsuatchieu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbsuatchieu.Location = new System.Drawing.Point(12, 52);
            this.lbsuatchieu.Name = "lbsuatchieu";
            this.lbsuatchieu.Size = new System.Drawing.Size(227, 40);
            this.lbsuatchieu.TabIndex = 2;
            this.lbsuatchieu.Text = "SUẤT CHIẾU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // FormSuất_chiếu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 565);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSuất_chiếu";
            this.Text = "CGV - Suất chiếu";
            this.Load += new System.EventHandler(this.FormSuất_chiếu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsuatchieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btthemsc;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbsuatchieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvsuatchieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhutBatDau;
        private System.Windows.Forms.Button btxoasc;
    }
}