
namespace MyCGV
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.tabLogin = new System.Windows.Forms.TabControl();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.anmk = new System.Windows.Forms.PictureBox();
            this.hienmk = new System.Windows.Forms.PictureBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.tbmk1 = new System.Windows.Forms.TextBox();
            this.lbMk1 = new System.Windows.Forms.Label();
            this.lbTentk1 = new System.Windows.Forms.Label();
            this.tbtk1 = new System.Windows.Forms.TextBox();
            this.tabNhanvien = new System.Windows.Forms.TabPage();
            this.anmknv = new System.Windows.Forms.PictureBox();
            this.btnvdangnhap = new System.Windows.Forms.Button();
            this.tbmk2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtentk2 = new System.Windows.Forms.Label();
            this.tbtk2 = new System.Windows.Forms.TextBox();
            this.hienmknv = new System.Windows.Forms.PictureBox();
            this.tabLogin.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anmk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienmk)).BeginInit();
            this.tabNhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anmknv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienmknv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.tabAdmin);
            this.tabLogin.Controls.Add(this.tabNhanvien);
            this.tabLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLogin.Location = new System.Drawing.Point(52, 34);
            this.tabLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.SelectedIndex = 0;
            this.tabLogin.Size = new System.Drawing.Size(397, 255);
            this.tabLogin.TabIndex = 0;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.anmk);
            this.tabAdmin.Controls.Add(this.hienmk);
            this.tabAdmin.Controls.Add(this.btnDangnhap);
            this.tabAdmin.Controls.Add(this.tbmk1);
            this.tabAdmin.Controls.Add(this.lbMk1);
            this.tabAdmin.Controls.Add(this.lbTentk1);
            this.tabAdmin.Controls.Add(this.tbtk1);
            this.tabAdmin.Location = new System.Drawing.Point(4, 34);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdmin.Size = new System.Drawing.Size(389, 217);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.Text = "Admin";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // anmk
            // 
            this.anmk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anmk.BackgroundImage")));
            this.anmk.Image = ((System.Drawing.Image)(resources.GetObject("anmk.Image")));
            this.anmk.Location = new System.Drawing.Point(359, 122);
            this.anmk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anmk.Name = "anmk";
            this.anmk.Size = new System.Drawing.Size(24, 21);
            this.anmk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anmk.TabIndex = 6;
            this.anmk.TabStop = false;
            this.anmk.Click += new System.EventHandler(this.anmk_Click);
            // 
            // hienmk
            // 
            this.hienmk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hienmk.BackgroundImage")));
            this.hienmk.Image = ((System.Drawing.Image)(resources.GetObject("hienmk.Image")));
            this.hienmk.Location = new System.Drawing.Point(359, 122);
            this.hienmk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hienmk.Name = "hienmk";
            this.hienmk.Size = new System.Drawing.Size(24, 21);
            this.hienmk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hienmk.TabIndex = 5;
            this.hienmk.TabStop = false;
            this.hienmk.Click += new System.EventHandler(this.hienmk_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangnhap.Location = new System.Drawing.Point(188, 166);
            this.btnDangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(163, 36);
            this.btnDangnhap.TabIndex = 4;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            this.btnDangnhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnDangnhap_KeyPress);
            // 
            // tbmk1
            // 
            this.tbmk1.Location = new System.Drawing.Point(47, 117);
            this.tbmk1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmk1.Name = "tbmk1";
            this.tbmk1.PasswordChar = '*';
            this.tbmk1.Size = new System.Drawing.Size(304, 30);
            this.tbmk1.TabIndex = 3;
            // 
            // lbMk1
            // 
            this.lbMk1.AutoSize = true;
            this.lbMk1.Location = new System.Drawing.Point(20, 91);
            this.lbMk1.Name = "lbMk1";
            this.lbMk1.Size = new System.Drawing.Size(93, 25);
            this.lbMk1.TabIndex = 2;
            this.lbMk1.Text = "Mật khẩu";
            // 
            // lbTentk1
            // 
            this.lbTentk1.AutoSize = true;
            this.lbTentk1.Location = new System.Drawing.Point(20, 20);
            this.lbTentk1.Name = "lbTentk1";
            this.lbTentk1.Size = new System.Drawing.Size(131, 25);
            this.lbTentk1.TabIndex = 1;
            this.lbTentk1.Text = "Tên tài khoản";
            // 
            // tbtk1
            // 
            this.tbtk1.Location = new System.Drawing.Point(47, 46);
            this.tbtk1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbtk1.Name = "tbtk1";
            this.tbtk1.Size = new System.Drawing.Size(304, 30);
            this.tbtk1.TabIndex = 0;
            // 
            // tabNhanvien
            // 
            this.tabNhanvien.Controls.Add(this.anmknv);
            this.tabNhanvien.Controls.Add(this.btnvdangnhap);
            this.tabNhanvien.Controls.Add(this.tbmk2);
            this.tabNhanvien.Controls.Add(this.label1);
            this.tabNhanvien.Controls.Add(this.lbtentk2);
            this.tabNhanvien.Controls.Add(this.tbtk2);
            this.tabNhanvien.Controls.Add(this.hienmknv);
            this.tabNhanvien.Location = new System.Drawing.Point(4, 34);
            this.tabNhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNhanvien.Name = "tabNhanvien";
            this.tabNhanvien.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNhanvien.Size = new System.Drawing.Size(389, 217);
            this.tabNhanvien.TabIndex = 1;
            this.tabNhanvien.Text = "Nhân viên ";
            this.tabNhanvien.UseVisualStyleBackColor = true;
            // 
            // anmknv
            // 
            this.anmknv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anmknv.BackgroundImage")));
            this.anmknv.Image = ((System.Drawing.Image)(resources.GetObject("anmknv.Image")));
            this.anmknv.Location = new System.Drawing.Point(350, 117);
            this.anmknv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anmknv.Name = "anmknv";
            this.anmknv.Size = new System.Drawing.Size(24, 21);
            this.anmknv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anmknv.TabIndex = 10;
            this.anmknv.TabStop = false;
            this.anmknv.Click += new System.EventHandler(this.anmknv_Click);
            // 
            // btnvdangnhap
            // 
            this.btnvdangnhap.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnvdangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvdangnhap.Location = new System.Drawing.Point(167, 168);
            this.btnvdangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvdangnhap.Name = "btnvdangnhap";
            this.btnvdangnhap.Size = new System.Drawing.Size(177, 37);
            this.btnvdangnhap.TabIndex = 9;
            this.btnvdangnhap.Text = "Đăng nhập";
            this.btnvdangnhap.UseVisualStyleBackColor = false;
            this.btnvdangnhap.Click += new System.EventHandler(this.btnvdangnhap_Click);
            this.btnvdangnhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnvdangnhap_KeyPress);
            // 
            // tbmk2
            // 
            this.tbmk2.Location = new System.Drawing.Point(51, 113);
            this.tbmk2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmk2.Name = "tbmk2";
            this.tbmk2.PasswordChar = '*';
            this.tbmk2.Size = new System.Drawing.Size(294, 30);
            this.tbmk2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mật khẩu";
            // 
            // lbtentk2
            // 
            this.lbtentk2.AutoSize = true;
            this.lbtentk2.Location = new System.Drawing.Point(25, 18);
            this.lbtentk2.Name = "lbtentk2";
            this.lbtentk2.Size = new System.Drawing.Size(131, 25);
            this.lbtentk2.TabIndex = 6;
            this.lbtentk2.Text = "Tên tài khoản";
            // 
            // tbtk2
            // 
            this.tbtk2.Location = new System.Drawing.Point(51, 44);
            this.tbtk2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbtk2.Name = "tbtk2";
            this.tbtk2.Size = new System.Drawing.Size(294, 30);
            this.tbtk2.TabIndex = 5;
            // 
            // hienmknv
            // 
            this.hienmknv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hienmknv.BackgroundImage")));
            this.hienmknv.Image = ((System.Drawing.Image)(resources.GetObject("hienmknv.Image")));
            this.hienmknv.Location = new System.Drawing.Point(350, 117);
            this.hienmknv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hienmknv.Name = "hienmknv";
            this.hienmknv.Size = new System.Drawing.Size(24, 21);
            this.hienmknv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hienmknv.TabIndex = 11;
            this.hienmknv.TabStop = false;
            this.hienmknv.Click += new System.EventHandler(this.hienmknv_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 316);
            this.Controls.Add(this.tabLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGV - Đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDangNhap_FormClosed);
            this.tabLogin.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            this.tabAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anmk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienmk)).EndInit();
            this.tabNhanvien.ResumeLayout(false);
            this.tabNhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anmknv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienmknv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLogin;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.TabPage tabNhanvien;
        private System.Windows.Forms.TextBox tbtk1;
        private System.Windows.Forms.TextBox tbmk1;
        private System.Windows.Forms.Label lbMk1;
        private System.Windows.Forms.Label lbTentk1;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnvdangnhap;
        private System.Windows.Forms.TextBox tbmk2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtentk2;
        private System.Windows.Forms.TextBox tbtk2;
        private System.Windows.Forms.PictureBox hienmk;
        private System.Windows.Forms.PictureBox anmk;
        private System.Windows.Forms.PictureBox anmknv;
        private System.Windows.Forms.PictureBox hienmknv;
    }
}

