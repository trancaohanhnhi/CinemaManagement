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
    public partial class FormRapQuan3 : Form
    {
        public FormRapQuan3()
        {
            InitializeComponent();
        }

        private void lbcgvq2_Click(object sender, EventArgs e)
        {

        }

        private void FormRapQuan3_Load(object sender, EventArgs e)
        {
            // Tạo kết nối đến cơ sở dữ liệu
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            // Thực hiện câu lệnh SQL để lấy dữ liệu từ bảng "Rap"
            string query = "select * from dbo.Rap where MaCum='CGVQ3'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            // Gán DataSet vào DataGridView
            dgvcgvq3.DataSource = dataSet.Tables[0];
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaRap", "*" + tbSearch.Text + "*");
            (dgvcgvq3.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }
}
