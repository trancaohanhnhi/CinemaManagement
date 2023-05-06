using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.InteropServices;
using Trang_chủ_của_NVQL;

namespace MyCGV
{
    public partial class FormDangNhap : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection conn;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (tbtk1.Text == "admin")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(strc);

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_login", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TenTaiKhoan", SqlDbType.NVarChar, 50).Value = tbtk1.Text;
                    cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 50).Value = tbmk1.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    conn.Close();

                    FormAdmin f = new FormAdmin();
                    f.Show();
                    this.Hide();
                }
                catch
                {
                   MessageBox.Show("Mật khẩu sai!", "Lỗi");
                }
            }
            else
            {
               MessageBox.Show("Chỉ cho phép tài khoản của admin!", "Lỗi");
            }
        }

        private void btnvdangnhap_Click(object sender, EventArgs e)
        {
            if (tbtk2.Text == "nhanvienq3")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(strc);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_login", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TenTaiKhoan", SqlDbType.NVarChar, 50).Value = tbtk2.Text;
                    cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 50).Value = tbmk2.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    conn.Close();

                    cgvquan3 f = new cgvquan3();
                    f.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Mật khẩu sai!", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Chỉ cho phép tài khoản của nhân viên!", "Lỗi");
            }
        }
        private void anmk_Click(object sender, EventArgs e)
        {
            if (tbmk1.PasswordChar == '*')
            {
                hienmk.BringToFront();
                tbmk1.PasswordChar = '\0';
            }
        }

        private void hienmk_Click(object sender, EventArgs e)
        {
            if (tbmk1.PasswordChar == '\0')
            {
                anmk.BringToFront();
                tbmk1.PasswordChar = '*';
            }
        }

        private void anmknv_Click(object sender, EventArgs e)
        {
            if (tbmk2.PasswordChar == '*')
            {
                hienmknv.BringToFront();
                tbmk2.PasswordChar = '\0';
            }
        }

        private void hienmknv_Click(object sender, EventArgs e)
        {
            if (tbmk2.PasswordChar == '\0')
            {
                anmk.BringToFront();
                tbmk2.PasswordChar = '*';
            }
        }

        private void btnDangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
            }
        }

        private void btnvdangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
            }
        }

        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
