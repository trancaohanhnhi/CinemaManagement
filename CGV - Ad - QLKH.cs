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
    public partial class FormQuản_lý_kế_hoạch : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public DataTable dt;
        public FormQuản_lý_kế_hoạch()
        {
            InitializeComponent();
        }

        //Chọn nút Xóa để xóa 1 dòng trên datagridview
        private void btxoakh_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Khi xóa Kế hoạch, Lịch chiếu sẽ bị xóa theo. Bạn có chắc chắn muốn xoá không?", "Xóa kế hoạch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    XoaDuLieu();
                }
                catch (Exception ex)
                {
                    // Hiển thị dữ liệu trên DataGridView của 'FormQuản_lý_kế_hoạch'
                    FormQuản_lý_kế_hoạch f = (FormQuản_lý_kế_hoạch)Application.OpenForms["FormQuản_lý_kế_hoạch"];//Lấy đối tượng của 'FormQuản_lý_kế_hoạch'
                    f.hienthi();//Tải lại dữ liệu vào DataGridView
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }
        //Vị trí
        int vt = -1;

        // Phương thức xóa dữ liệu
        private void XoaDuLieu()
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!");
                return;
            }

            DataRow row = dt.Rows[vt];
            row.Delete();

            int kq = adapter.Update(dt);
            if (kq > 0)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Chọn nút Thêm để hiển thị Form 'FormThemQLKH'
        private void btthemkh_Click(object sender, EventArgs e)
        {
            FormThemQLKH f = new FormThemQLKH();
            f.ShowDialog();
        }

        //Phương thức được gọi khi 'FormQuản_lý_kế_hoạch' được tải lên
        private void FormQuản_lý_kế_hoạch_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        // Phương thức hiển thị dữ liệu lên DataGridView
        public void hienthi()
        {
            connection = new SqlConnection(strc);
            connection.Open();

            cmd = new SqlCommand("select * from KeHoach", connection);
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();

            dgvqlkh.DataSource = dt;
            dgvqlkh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Tìm kiếm thông tin theo mã phim
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaPhim", "*" + tbSearch.Text + "*");
            (dgvqlkh.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        //Khai báo phương thức dgvqlkh_CellClick để khi nhấp chuột chọn 1 hàng trong datagridview
        private void dgvqlkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;

            DataRow row = dt.Rows[vt];

            // Gán giá trị của các cột tương ứng cho các TextBox trên Form Sửa thể loại
            FormKHData.MCValue = row["MaCum"].ToString();
            FormKHData.MPValue = row["MaPhim"].ToString();
            FormKHData.NKCValue = Convert.ToDateTime(row["NgayKhoiChieu"]);
            FormKHData.NKTValue = Convert.ToDateTime(row["NgayKetThuc"]);
            FormKHData.GCValue = row["GhiChu"].ToString();
        }
    }

    //Khai báo Lớp gồm các thuộc tính với kiểu dữ liệu để lưu trữ giá trị của các cột từ datagridview
    public class FormKHData
    {
        public static string MCValue;
        public static string MPValue;
        public static DateTime NKCValue;
        public static DateTime NKTValue;
        public static string GCValue;
    }
}

