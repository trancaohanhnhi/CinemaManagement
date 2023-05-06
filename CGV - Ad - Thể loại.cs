using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCGV
{
    public partial class Thể_loại : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        public Thể_loại()
        {
            InitializeComponent();

        }
        
        //Button để mở Form Sửa thể loại
        private void btsuatl_Click(object sender, EventArgs e)
        {
            FormSuatheloai f = new FormSuatheloai();
            f.ShowDialog();
        }
        //Button để mở Form Thêm thể loại
        private void btthemtl_Click(object sender, EventArgs e)
        {
            FormThemtheloai f = new FormThemtheloai();
            f.ShowDialog();
        }

        //Phương thức được gọi khi Thể_loại_Load được tải lên
        public void Thể_loại_Load(object sender, EventArgs e)
        {
                hienthi();
        }

        // Phương thức hiển thị dữ liệu lên DataGridView
        public void hienthi()
        {
            connection = new SqlConnection(strc);
            connection.Open();

            cmd = new SqlCommand("select * from dbo.TheLoai", connection);
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "tblTheLoai");

            connection.Close();

            dgvtheloai.DataSource = ds.Tables["tblTheLoai"];
            dgvtheloai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }            

        //Tạo CellClick để hiển thị dữ liệu trên Form Sửa thể loại
        private void dgvtheloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = -1;
            // Lưu trữ chỉ số của dòng được chọn
            vt = e.RowIndex;
            if (vt == -1) return;

            DataRow row = ds.Tables["tblTheLoai"].Rows[vt];

            // Gán giá trị của các cột tương ứng cho các TextBox trên Form Sửa thể loại
            FormSuatlData.MTLValue = row["MaTheLoai"].ToString();
            FormSuatlData.TTLValue = row["TenTheLoai"].ToString();
        }

        //Tìm kiếm thông tin bằng mã thể loại
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaTheLoai", "*" + tbSearch.Text + "*");
            (dgvtheloai.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }

    //Tạo 1 class để lưu trữ giá trị các cột tương ứng trong textbox trên Form Sửa Thể loại
    public class FormSuatlData
    {
        public static string MTLValue;
        public static string TTLValue;
    }   
}
