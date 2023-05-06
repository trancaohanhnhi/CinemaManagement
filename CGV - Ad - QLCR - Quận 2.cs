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
    public partial class FormCGVQuan2 : Form
    {
        public FormCGVQuan2()
        {
            InitializeComponent();
        }

        private void FormCGVQuan2_Load(object sender, EventArgs e)
        {
            // Tạo kết nối đến cơ sở dữ liệu
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            // Thực hiện câu lệnh SQL để lấy dữ liệu từ bảng "Rap"
            string query = "select * from dbo.Rap where MaCum='CGVQ2'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            // Gán DataSet vào DataGridView
            dgvcgvq2.DataSource = dataSet.Tables[0];
        }


        //Tìm kiếm thông tin theo mã rạp
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaRap", "*" + tbSearch.Text + "*");
            (dgvcgvq2.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }
}
