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
    public partial class FormCGV_Quận_1 : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();

        public FormCGV_Quận_1()
        {
            InitializeComponent();
        }

        //Chọn nút Thêm để hiển thị Form 'FormThêm_rạp_Q1'
        private void btthemrapcgvq1_Click(object sender, EventArgs e)
        {
            FormThêm_rạp_Q1 f = new FormThêm_rạp_Q1();
            f.Show();
        }

        //Phương thức được gọi khi FormCGV_Quận_1 được tải lên
        private void FormCGV_Quận_1_Load(object sender, EventArgs e)
        {
            hienthi(); //Gọi phương thức 'hienthi' để hiển thị dữ liệu lên DataGridView
        }

        // Phương thức hiển thị dữ liệu lên DataGridView
        public void hienthi()
        {
            // Tạo kết nối đến cơ sở dữ liệu
            connection = new SqlConnection(strc);
            connection.Open();

            // Thực hiện câu lệnh SQL để lấy dữ liệu từ bảng "Rap"
            cmd = new SqlCommand("select MaRap, TongGhe, MaCum from Rap where MaCum = 'CGVQ1'", connection);
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "tblcgvq1");

            //Đóng kết nối
            connection.Close();

            // Hiển thị dữ liệu lên DataGridView
            dgvcgvq1.DataSource = ds.Tables["tblcgvq1"];
            dgvcgvq1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Phương thức được gọi click vào nút Sửa và hiển thị Form 'FormSửa_rạp_quận_1'
        private void btsuacgvq1_Click(object sender, EventArgs e)
        {
            FormSửa_rạp_quận_1 f = new FormSửa_rạp_quận_1();
            f.ShowDialog();
        }


        //Tìm kiếm thông tin theo mã rạp
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaRap", "*" + tbSearch.Text + "*");
            (dgvcgvq1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        //Khởi tạo biến 'vt' với giá trị ban đầu là -1
        int vt = -1;

        //Khai báo phương thức dgvcgvq1_CellClick để khi nhấp chuột chọn 1 hàng trong datagridview
        private void dgvcgvq1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex; // gán biến vt bằng chỉ mục hàng được chọn trong DataGridView
            if (vt == -1) return; // nếu không có hàng nào được chọn thì kết thúc phương thức

            DataRow row = ds.Tables["tblcgvq1"].Rows[vt]; // lấy dòng tương ứng với hàng được chọn từ DataTable có tên là "tblcgvq1"

            // Gán giá trị của các cột tương ứng cho các TextBox trên Form Thêm, sửa rạp quận 1
            Formrapq1Data.MRValue = row["MaRap"].ToString(); // gán giá trị của cột "MaRap" cho thuộc tính "MRValue" của Form "Formrapq1Data"
            Formrapq1Data.TGValue = Convert.ToInt32(row["TongGhe"]);// gán giá trị của cột "TongGhe" cho thuộc tính "TGValue" của Form "Formrapq1Data"
            Formrapq1Data.MCValue = row["MaCum"].ToString();// gán giá trị của cột "MaCum" cho thuộc tính "MCValue" của Form "Formrapq1Data"
        }
    }
    //Khai báo Lớp gồm các thuộc tính với kiểu dữ liệu để lưu trữ giá trị của các cột từ datagridview
    public class Formrapq1Data
    {
        public static string MRValue;//khai báo biến 'MRValue' kiểu 'string' để lưu trữ giá trị của cột "MaRap" từ DataGridView.
        public static int TGValue; //khai báo biến 'TGValue' kiểu 'int' để lưu trữ giá trị của cột "TongGhe" từ DataGridView.
        public static string MCValue; //khai báo biến 'MCValue' kiểu 'string' để lưu trữ giá trị của cột "MaCum" từ DataGridView.
    }
}
