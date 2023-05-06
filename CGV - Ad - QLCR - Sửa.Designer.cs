namespace MyCGV
{
    partial class FormSửa_cụm_rạp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSửa_cụm_rạp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btxnsuacr = new System.Windows.Forms.Button();
            this.bthuysuacum = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbdiachisua = new System.Windows.Forms.TextBox();
            this.lbdiachicum = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbtencumsua = new System.Windows.Forms.TextBox();
            this.lbTencum = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbmacumsua = new System.Windows.Forms.TextBox();
            this.lbmacum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btxnsuacr);
            this.panel1.Controls.Add(this.bthuysuacum);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 438);
            this.panel1.TabIndex = 0;
            // 
            // btxnsuacr
            // 
            this.btxnsuacr.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btxnsuacr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btxnsuacr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxnsuacr.Location = new System.Drawing.Point(393, 346);
            this.btxnsuacr.Name = "btxnsuacr";
            this.btxnsuacr.Size = new System.Drawing.Size(137, 40);
            this.btxnsuacr.TabIndex = 3;
            this.btxnsuacr.Text = "Xác nhận";
            this.btxnsuacr.UseVisualStyleBackColor = false;
            this.btxnsuacr.Click += new System.EventHandler(this.btxnsuacr_Click);
            // 
            // bthuysuacum
            // 
            this.bthuysuacum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bthuysuacum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bthuysuacum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuysuacum.Location = new System.Drawing.Point(258, 345);
            this.bthuysuacum.Name = "bthuysuacum";
            this.bthuysuacum.Size = new System.Drawing.Size(81, 41);
            this.bthuysuacum.TabIndex = 4;
            this.bthuysuacum.Text = "Hủy";
            this.bthuysuacum.UseVisualStyleBackColor = false;
            this.bthuysuacum.Click += new System.EventHandler(this.bthuysuacum_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbdiachisua);
            this.panel4.Controls.Add(this.lbdiachicum);
            this.panel4.Location = new System.Drawing.Point(26, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 120);
            this.panel4.TabIndex = 2;
            // 
            // tbdiachisua
            // 
            this.tbdiachisua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdiachisua.Location = new System.Drawing.Point(204, 16);
            this.tbdiachisua.Multiline = true;
            this.tbdiachisua.Name = "tbdiachisua";
            this.tbdiachisua.Size = new System.Drawing.Size(277, 90);
            this.tbdiachisua.TabIndex = 0;
            // 
            // lbdiachicum
            // 
            this.lbdiachicum.AutoSize = true;
            this.lbdiachicum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiachicum.Location = new System.Drawing.Point(3, 22);
            this.lbdiachicum.Name = "lbdiachicum";
            this.lbdiachicum.Size = new System.Drawing.Size(86, 29);
            this.lbdiachicum.TabIndex = 0;
            this.lbdiachicum.Text = "Địa chỉ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbtencumsua);
            this.panel3.Controls.Add(this.lbTencum);
            this.panel3.Location = new System.Drawing.Point(26, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 60);
            this.panel3.TabIndex = 1;
            // 
            // tbtencumsua
            // 
            this.tbtencumsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtencumsua.Location = new System.Drawing.Point(204, 16);
            this.tbtencumsua.Name = "tbtencumsua";
            this.tbtencumsua.Size = new System.Drawing.Size(277, 35);
            this.tbtencumsua.TabIndex = 0;
            // 
            // lbTencum
            // 
            this.lbTencum.AutoSize = true;
            this.lbTencum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTencum.Location = new System.Drawing.Point(3, 19);
            this.lbTencum.Name = "lbTencum";
            this.lbTencum.Size = new System.Drawing.Size(148, 29);
            this.lbTencum.TabIndex = 0;
            this.lbTencum.Text = "Tên cụm rạp";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbmacumsua);
            this.panel2.Controls.Add(this.lbmacum);
            this.panel2.Location = new System.Drawing.Point(26, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 60);
            this.panel2.TabIndex = 0;
            // 
            // tbmacumsua
            // 
            this.tbmacumsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmacumsua.Location = new System.Drawing.Point(204, 13);
            this.tbmacumsua.Name = "tbmacumsua";
            this.tbmacumsua.ReadOnly = true;
            this.tbmacumsua.Size = new System.Drawing.Size(277, 35);
            this.tbmacumsua.TabIndex = 0;
            // 
            // lbmacum
            // 
            this.lbmacum.AutoSize = true;
            this.lbmacum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmacum.Location = new System.Drawing.Point(3, 19);
            this.lbmacum.Name = "lbmacum";
            this.lbmacum.Size = new System.Drawing.Size(97, 29);
            this.lbmacum.TabIndex = 0;
            this.lbmacum.Text = "Mã cụm";
            // 
            // FormSửa_cụm_rạp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 438);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSửa_cụm_rạp";
            this.Text = "CGV - Sửa cụm rạp";
            this.Load += new System.EventHandler(this.FormSửa_cụm_rạp_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btxnsuacr;
        private System.Windows.Forms.Button bthuysuacum;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbdiachicum;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbtencumsua;
        private System.Windows.Forms.Label lbTencum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbmacumsua;
        private System.Windows.Forms.Label lbmacum;
        private System.Windows.Forms.TextBox tbdiachisua;
    }
}