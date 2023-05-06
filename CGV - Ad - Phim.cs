using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace MyCGV
{
    public partial class FormPhim : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormPhim()
        {
            InitializeComponent();
        }

        //Chọn nút Thêm để hiển thị Form 'Thêm_phim'
        private void btthemphim_Click(object sender, EventArgs e)
        {
            Thêm_phim f = new Thêm_phim();
            f.ShowDialog();
        }

        //Tìm kiếm thông tin theo tên phim
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "TenPhim", "*" + tbSearch.Text + "*");
            (dgvPhim.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        //Chọn nút Sửa để hiển thị Form 'FormSửa_phim'
        private void btsuaphim_Click(object sender, EventArgs e)
        {
            FormSửa_phim f = new FormSửa_phim();
            f.ShowDialog();
        }

        //Phương thức được gọi khi FormPhim được tải lên
        public void FormPhim_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        // Phương thức hiển thị dữ liệu lên DataGridView
        public void hienthi()
        {
            connection = new SqlConnection(strc);
            connection.Open();

            command = new SqlCommand("select Phim.MaPhim, Phim.TenPhim, Phim.MaTheLoaiChinh, PhimTheLoaiPhu.MaTheLoai as MaTheLoaiPhu, Phim.ThoiLuong, Phim.CoLa3D, Phim.CoLongTieng from Phim inner join PhimTheLoaiPhu on Phim.MaPhim = PhimTheLoaiPhu.MaPhim", connection);
            adapter = new SqlDataAdapter(command);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();

            dgvPhim.DataSource = dt;
            dgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        int vt = -1;

        //Khai báo phương thức dgvPhim_CellClick để khi nhấp chuột chọn 1 hàng trong datagridview
        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lưu trữ chỉ số của dòng được chọn
            vt = e.RowIndex;
            if (vt == -1) return;
            DataRow row = dt.Rows[vt];

            // Gán giá trị của các cột tương ứng cho các TextBox trên Form Sửa thể loại
            FormPhimData.MPValue = row["MaPhim"].ToString();
            FormPhimData.TPValue = row["TenPhim"].ToString();
            FormPhimData.TLValue = Convert.ToInt32(row["ThoiLuong"]);
            FormPhimData.MTLCValue = row["MaTheLoaiChinh"].ToString();
            FormPhimData.MTLPValue = row["MaTheLoaiPhu"].ToString();
            FormPhimData.DValue = Convert.ToBoolean(row["CoLa3D"]);
            FormPhimData.LTValue = Convert.ToBoolean(row["CoLongTieng"]);
        }
    }

    //Khai báo Lớp gồm các thuộc tính với kiểu dữ liệu để lưu trữ giá trị của các cột từ datagridview
    public class FormPhimData
    {
        public static string MPValue;
        public static string TPValue;
        public static string MTLCValue;
        public static string MTLPValue;
        public static int TLValue;
        public static bool DValue;
        public static bool LTValue;
    }
}