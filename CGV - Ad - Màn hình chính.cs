using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trang_chủ_của_NVQL;

namespace MyCGV
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        //Chọn Menu CGV Quận 2 để hiển thị Form con 'FormCGVQuan2'
        private void mncgvq2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCGVQuan2 ());
        }

        //Chọn Đăng xuất và hiển thị lại 'FormDangNhap'
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //nếu đăng xuất : frmLogin.show(); this.hide()
            this.Hide();
            FormDangNhap f = new FormDangNhap();
            f.ShowDialog();
        }

        //Chọn Đổi mật khẩu và hiển thị 'FormDoimatkhau' 
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cgvquan3doimk f = new cgvquan3doimk();
            f.ShowDialog();
        }

        //Chọn Menu Thể loại để hiển thị Form con 'Thể_loại'
        private void mntheloai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Thể_loại());
        }

        //Chọn nút X trên 'FormAdmin'mvà tắt hoàn toàn chương trình
        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
        }

        //Chọn Menu CGV Quận 1 để hiển thị Form con 'FormCGV_Quận_1'
        private void mncgvq1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCGV_Quận_1());

        }

        // khởi tạo biến currentFormChild để lưu trữ form con đang hiển thị
        private Form currentFormChild;
        private void OpenChildForm(Form childform) 
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.Dock = DockStyle.Fill;
            paneladmin.Controls.Add(childform);
            paneladmin.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        //Chọn hình CGV trên 'FormAdmin' để đóng Form con hiện tại
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        //Chọn Menu Cài đặt để hiển thị Form con 'FormSetting'
        private void mnsetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSetting());
        }

        //Chọn Menu Phim để hiển thị Form con 'FormPhim'
        private void mnphim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPhim());
        }

        //Chọn Menu Suất chiếu để hiển thị Form con 'FormSuất_chiếu'
        private void mnsuatchieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSuất_chiếu());
        }

        //Chọn Menu Quản lý kế hoạch để mở Form 'FormQuản_lý_kế_hoạch'
        private void mnqlkh_Click(object sender, EventArgs e)
        {
            FormQuản_lý_kế_hoạch f = new FormQuản_lý_kế_hoạch();
            f.Show();
        }

        //Chọn Menu Quản lý lịch chiếu để mở Form 'FormQLLichchieu'
        private void mnqllc_Click(object sender, EventArgs e)
        {
            FormQLLichchieu f = new FormQLLichchieu();
            f.Show();
        }

        //Chọn Menu Quản lý tài khoản để mở Form 'FormQuản_lý_tài_khoản'
        private void mnqltk_Click(object sender, EventArgs e)
        {
            FormQuản_lý_tài_khoản f = new FormQuản_lý_tài_khoản();
            f.Show();
        }

        private void mncgvq3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRapQuan3());
        }
    }
}
