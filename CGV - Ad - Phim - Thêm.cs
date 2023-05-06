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
    public partial class Thêm_phim : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        public Thêm_phim()
        {
            InitializeComponent();
        }

        //Chọn nút Hủy thì 'Thêm_phim' đóng
        private void bthuythemphim_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Phương thức khi Chọn nút Xác nhận thì dữ liệu được thêm vào datagridview
        private void btxnthemphim_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các TextBox rỗng
                if (tbmaphimthem.Text == "" || tbtenphimthem.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                them(); //Gọi phương thức 'them' để hiển thị dữ liệu lên DataGridView

                // Hiển thị dữ liệu trên DataGridView của form Phim
                FormPhim f = (FormPhim)Application.OpenForms["FormPhim"];//Lấy đối tượng của form Phim
                f.hienthi();//Tải lại dữ liệu vào DataGridView
            }                
                catch
            {
                MessageBox.Show("Mã phim bị trùng, vui lòng xem lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Phương thức để thêm dữ liệu
        private void them()
        {
            //Kết nối CSDL
            connection = new SqlConnection(strc);
            connection.Open();

            //Thêm dữ liệu vào bảng trong CSDL bằng cách sử dụng SqlCommand thực hiện truy vấn SQL
            cmd = new SqlCommand();
            cmd.CommandText = "sp_ThemPhim";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaPhim", SqlDbType.VarChar, 5).Value = tbmaphimthem.Text;
            cmd.Parameters.Add("@TenPhim", SqlDbType.NVarChar, 50).Value = tbtenphimthem.Text;
            cmd.Parameters.Add("@MaTheLoaiChinh", SqlDbType.VarChar, 5).Value = cbthemtlc.Text;
            cmd.Parameters.Add("@ThoiLuong", SqlDbType.Int, 4).Value = nudthoiluongthem.Value;
            cmd.Parameters.Add("@CoLa3D", SqlDbType.Bit, 1).Value = cbthemphim3d.Checked;
            cmd.Parameters.Add("@CoLongTieng", SqlDbType.Bit, 1).Value = cbthemphimlongtieng.Checked;
            cmd.Parameters.Add("@MaTheLoai", SqlDbType.VarChar, 5).Value = cbthemtlp.Text;
            cmd.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        //Phương thức cbtlc() được sử dụng để hiển thị danh sách các thể loại trong ComboBox 'cbthemtlc'
        private void cbtlc()
        {
            connection = new SqlConnection(strc);

            connection.Open();
            cmd = new SqlCommand("select * from dbo.TheLoai", connection);
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.Fill(dt);
            connection.Close();

            cbthemtlc.DataSource = dt;
            cbthemtlc.DisplayMember = "MaTheLoai";
            cbthemtlc.ValueMember = "MaTheLoai";
        }
        private void cbthemtlc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbtlp(); // Gọi phương thức 'cbtlp' để lấy danh sách Mã thể loại phụ mới cho ComboBox 'cbthemtlp', dựa trên Mã thể loại chính được chọn trên 'cbthemtlc'
        }

        //Phương thức cbtlp() được sử dụng để hiển thị danh sách các thể loại trong ComboBox 'cbthemtlp'
        private void cbtlp()
        {
            connection = new SqlConnection(strc);
            connection.Open();

            cmd = new SqlCommand("select MaTheLoai from TheLoai where MaTheLoai <> @MaTheLoaiChinh", connection);
            cmd.Parameters.AddWithValue("@MaTheLoaiChinh", cbthemtlc.SelectedValue.ToString());
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();

            cbthemtlp.DataSource = dt;
            cbthemtlp.DisplayMember = "MaTheLoai";
            cbthemtlp.ValueMember = "MaTheLoai";
        }
        private void Thêm_phim_Load(object sender, EventArgs e)
        {
            cbtlc();
            cbtlp();
        }
    }
}
