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
    public partial class FormThemQLKH : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public FormThemQLKH()
        {
            InitializeComponent();
        }

        //Button Hủy
        private void bthuyqlkh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Button xác nhận thêm
        private void btxnthemqlkh_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các TextBox rỗng
                if (tbthemmpkh.Text == "")
                {
                    MessageBox.Show("Vui lòng điền mã phim!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Kết nối CSDL
                connection = new SqlConnection(strc);

                connection.Open();

                //Thêm dữ liệu vào bảng trong CSDL bằng cách sử dụng SqlCommand thực hiện truy vấn SQL
                cmd = new SqlCommand("insert into KeHoach values (@MaPhim, @MaCum, @NgayKhoiChieu, @NgayKetThuc, @GhiChu)", connection);
                DataTable tb = new DataTable();
                adapter = new SqlDataAdapter(cmd);

                //Thực hiện truy vấn SQL với SQLParameter
                SqlParameter mp = new SqlParameter("@MaPhim", SqlDbType.VarChar, 10);
                mp.Value = tbthemmpkh.Text;
                SqlParameter mc = new SqlParameter("@MaCum", SqlDbType.VarChar, 5);
                mc.Value = cbthemmckh.Text;
                SqlParameter nkc = new SqlParameter("@NgayKhoiChieu", SqlDbType.DateTime, 3);
                nkc.Value = dtthemngaykc.Value;
                SqlParameter nkt = new SqlParameter("@NgayKetThuc", SqlDbType.DateTime, 3);
                nkt.Value = dtthemngaykt.Value;
                SqlParameter gc = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 100);
                gc.Value = tbghichu.Text;

                cmd.Parameters.Add(mp);
                cmd.Parameters.Add(mc);
                cmd.Parameters.Add(nkc);
                cmd.Parameters.Add(nkt);
                cmd.Parameters.Add(gc);

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị dữ liệu trên DataGridView của 'FormQuản_lý_kế_hoạch'
                FormQuản_lý_kế_hoạch f = (FormQuản_lý_kế_hoạch)Application.OpenForms["FormQuản_lý_kế_hoạch"];//Lấy đối tượng của 'FormQuản_lý_kế_hoạch'
                f.hienthi();//Tải lại dữ liệu vào DataGridView
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        //Hiển thị danh sách mã cụm cho combobox
        private void cbmacum()
        {
            connection = new SqlConnection(strc);

            connection.Open();
            cmd = new SqlCommand("select MaCum from CumRap", connection);
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.Fill(dt);
            connection.Close();

            cbthemmckh.DataSource = dt;
            cbthemmckh.DisplayMember = "MaCum";
            cbthemmckh.ValueMember = "MaCum";
        }

        //Gọi hàm lên để hiện trên form
        private void FormThemQLKH_Load(object sender, EventArgs e)
        {
            cbmacum();
        }
    }
}
