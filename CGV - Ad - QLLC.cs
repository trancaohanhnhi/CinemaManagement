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
    public partial class FormQLLichchieu : Form
    {
        public String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        DataTable dt;
        
        public FormQLLichchieu()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện TextBox Tìm kiếm
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaPhim", "*" + tbSearch.Text + "*");
            (dgvqllc.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        // Xử lý sự kiện load màn hình Quản lý lịch chiếu
        private void FormQLLichchieu_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        public void hienthi()
        {
            connection = new SqlConnection(strc);

            connection.Open();
            command = new SqlCommand("select * from dbo.LichChieucms", connection);
            adapter = new SqlDataAdapter(command);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();

            dgvqllc.DataSource = dt;
            dgvqllc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Xử lý sự kiện CellClick của DGV Quản lý lich chiếu
        public class dataa
        {
            public static string maphim;
            public static string marap;
            public static string ngaychieu;
            public static string csuatchieu;
        }

        int q3qllca = -1;
        public void dgvqllc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            q3qllca = e.RowIndex;
            if (q3qllca == -1) return;
            DataRow row = dt.Rows[q3qllca];
            dataa.maphim = row["MaPhim"].ToString();
            dataa.marap = row["MaRap"].ToString();
            dataa.ngaychieu = row["NgayChieu"].ToString();
            dataa.csuatchieu = row["ChuoiMaSuat"].ToString();
        }

        private void btxoalc_Click(object sender, EventArgs e)
        {
            if (q3qllca == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo");
                return;
            }
            FormXoaQLLC cgvqllcx = new FormXoaQLLC();
            cgvqllcx.ShowDialog();
        }

        private void btthemlc_Click(object sender, EventArgs e)
        {
            Formthemlc f = new Formthemlc();
            f.ShowDialog();
        }

        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaPhim", "*" + tbSearch.Text + "*");
            (dgvqllc.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }
}
