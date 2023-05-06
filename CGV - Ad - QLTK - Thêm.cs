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

namespace MyCGV
{
    public partial class FormThemTK : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public FormThemTK()
        {
            InitializeComponent();
        }

        //Button Hủy
        private void bthuythemtk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Button Thêm
        private void btxnthemtk_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các TextBox rỗng
                if (tbthemtk.Text == "" || tbthemmk.Text == "" || tbchutk.Text == "" || cbmc.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Kết nối CSDL
                connection = new SqlConnection(strc);
                connection.Open();
                
                //Thêm dữ liệu vào bảng trong CSDL bằng cách sử dụng SqlCommand thực hiện truy vấn SQL
                cmd = new SqlCommand("insert into TaiKhoan values (@TenTaiKhoan, @MatKhau, @TenChuTaiKhoan, @MaCum)", connection);
                DataTable tb = new DataTable();
                adapter = new SqlDataAdapter(cmd);

                //Thực hiện truy vấn SQL với SQLParameter
                SqlParameter ttk = new SqlParameter("@TenTaiKhoan", SqlDbType.NVarChar, 50);
                ttk.Value = tbthemtk.Text;
                SqlParameter mk = new SqlParameter("@MatKhau", SqlDbType.NVarChar, 50);
                mk.Value = tbthemmk.Text;
                SqlParameter ctk = new SqlParameter("@TenChuTaiKhoan", SqlDbType.NVarChar, 50);
                ctk.Value = tbchutk.Text;
                SqlParameter mc = new SqlParameter("@MaCum", SqlDbType.VarChar, 5);
                mc.Value = cbmc.Text;

                cmd.Parameters.Add(ttk);
                cmd.Parameters.Add(mk);
                cmd.Parameters.Add(ctk);
                cmd.Parameters.Add(mc);
                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị dữ liệu trên DataGridView của form 'FormQuản_lý_tài_khoản'
                FormQuản_lý_tài_khoản f = (FormQuản_lý_tài_khoản)Application.OpenForms["FormQuản_lý_tài_khoản"];//Lấy đối tượng của 'FormQuản_lý_tài_khoản'
                f.hienthi();//Tải lại dữ liệu vào DataGridView
                this.Close();
            }
            catch
            {
                MessageBox.Show("Mã tài khoản bị trùng, vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        //Phương thức để ComboBox Mã cụm hiển thị danh sách mã cụm
        private void cbtaikhoan()
        {
            connection = new SqlConnection(strc);
            connection.Open();

            cmd = new SqlCommand("select * from CumRap where MaCum != 'Null'", connection);
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.Fill(dt);
            connection.Close();

            cbmc.DataSource = dt;
            cbmc.DisplayMember = "MaCum";
            cbmc.ValueMember = "MaCum";
        }

        private void FormThemTK_Load(object sender, EventArgs e)
        {
            cbtaikhoan();
        }
    }
}
