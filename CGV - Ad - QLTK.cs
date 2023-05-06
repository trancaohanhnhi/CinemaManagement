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
using Trang_chủ_của_NVQL;

namespace MyCGV
{
    public partial class FormQuản_lý_tài_khoản : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        public FormQuản_lý_tài_khoản()
        {
            InitializeComponent();
        }

        private void btthemtk_Click(object sender, EventArgs e)
        {
            FormThemTK f = new FormThemTK();
            f.ShowDialog();
        }

        //Tìm kiếm tài khoản theo tên tài khoản
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "TenTaiKhoan", "*" + tbSearch.Text + "*");
            (dgvqltk.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void FormQuản_lý_tài_khoản_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        // Phương thức hiển thị dữ liệu lên DataGridView
        public void hienthi()
        {
            connection = new SqlConnection(strc);
            connection.Open();
            cmd = new SqlCommand("select * from TaiKhoan", connection);
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "tblQLTK");
            connection.Close();

            dgvqltk.DataSource = ds.Tables["tblQLTK"];
            dgvqltk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btdoimk_Click(object sender, EventArgs e)
        {
            cgvquan3doimk f = new cgvquan3doimk();
            f.ShowDialog();
        }
    }
}
