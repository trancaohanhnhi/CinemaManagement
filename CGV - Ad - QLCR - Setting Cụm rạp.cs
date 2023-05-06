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
    public partial class FormSetting : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        public FormSetting()
        {
            InitializeComponent();
        }

        //Phương thức được gọi khi FormSetting được tải lên
        private void FormSetting_Load(object sender, EventArgs e)
        {
                hienthi();
        }

        // Phương thức hiển thị dữ liệu lên DataGridView
        public void hienthi()
        {
            // Tạo kết nối đến cơ sở dữ liệu
            connection = new SqlConnection(strc);
            connection.Open();

            // Thực hiện câu lệnh SQL để lấy dữ liệu từ bảng "CumRap"
            cmd = new SqlCommand("select * from CumRap", connection);
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "tblCumRap");

            //Đóng kết nối
            connection.Close();

            // Hiển thị dữ liệu lên DataGridView
            dgvsettingcumrap.DataSource = ds.Tables["tblCumRap"];
            dgvsettingcumrap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Chọn nút Thêm để hiển thị Form 'FormThêm_cụm_rạp'
        private void themcumrap_Click(object sender, EventArgs e)
        {
            FormThêm_cụm_rạp f = new FormThêm_cụm_rạp();
            f.ShowDialog();
        }

        //Chọn nút Sửa để hiển thị Form 'FormThêm_cụm_rạp'
        private void suacumrap_Click(object sender, EventArgs e)
        {
            FormSửa_cụm_rạp f = new FormSửa_cụm_rạp();
            f.ShowDialog();
        }

        //Tìm kiếm thông tin theo mã cụm
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaCum", "*" + tbSearch.Text + "*");
            (dgvsettingcumrap.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        int vt = -1;

        //Khai báo phương thức dgvsettingcumrap_CellClick để khi nhấp chuột chọn 1 hàng trong datagridview
        private void dgvsettingcumrap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;

            DataRow row = ds.Tables["tblCumRap"].Rows[vt];

            // Gán giá trị của các cột tương ứng cho các TextBox trên Form Thêm, sửa cụm rạp
            FormCumRapData.MCValue = row["MaCum"].ToString();
            FormCumRapData.TCValue = row["TenCum"].ToString();
            FormCumRapData.DCValue = row["DiaChi"].ToString();

        }

        //Khai báo Lớp gồm các thuộc tính với kiểu dữ liệu để lưu trữ giá trị của các cột từ datagridview
        public class FormCumRapData
        {
            public static string MCValue;
            public static string TCValue;
            public static string DCValue;
        }
    }
}

