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
    public partial class Formthemlc : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        DataTable dt;
        public Formthemlc()
        {
            InitializeComponent();
        }

        //Xử lý sự kiện cho dtp  Ngày chiếu
        private void dtpngaychieu_ValueChanged(object sender, EventArgs e)
        {
            cbsuatchieu();
        }

        //Xử lý sự kiện cho combox Rạp chiếu
        private void cbraplct_SelectedValueChanged(object sender, EventArgs e)
        {
            cbsuatchieu();
        }

        //Xử lý sự kiện cho load Form thêm lịch chiếu
        private void Formthemlc_Load(object sender, EventArgs e)
        {
            cbtenphim();
            cbrapchieu();
        }

        public void cbtenphim()
        {
            conn = new SqlConnection(strc);

            conn.Open();
            cmd = new SqlCommand("select * from dbo.Phim", conn);
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.Fill(dt);
            conn.Close();

            cbtenphimlct.DataSource = dt;
            cbtenphimlct.DisplayMember = "MaPhim";
            cbtenphimlct.ValueMember = "MaPhim";
        }

        private void cbrapchieu()
        {
            conn = new SqlConnection(strc);

            conn.Open();
            cmd = new SqlCommand("select * from dbo.Rap", conn);
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.Fill(dt);
            conn.Close();

            cbraplct.DataSource = dt;
            cbraplct.DisplayMember = "MaRap";
            cbraplct.ValueMember = "MaRap";
        }

        private void cbsuatchieu()
        {
            conn = new SqlConnection(strc);
            string t = dtpngaychieu.Value.ToString("dd/MM/yyyy");
            string i = cbraplct.SelectedValue.ToString();
            cmd = new SqlCommand();
            cmd.CommandText = "sp_LayMaSuat";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaRap", SqlDbType.VarChar).Value = i;
            cmd.Parameters.Add("@NgayChieu", SqlDbType.Date).Value = t;

            conn.Open();
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(dt);
            conn.Close();

            cbsuatchieulct.DataSource = dt;
            cbsuatchieulct.DisplayMember = "MaSuat";
            cbsuatchieulct.ValueMember = "MaSuat";
        }

        //Xử lý sự kiện cho button Xác nhận
        private void nxlct_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = MessageBox.Show("Đồng ý thêm lịch chiếu ?", "Xác nhận thêm lịch chiếu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    update();
                    this.Close();
                    FormQLLichchieu f = (FormQLLichchieu)Application.OpenForms["FormQLLichchieu"];
                    f.hienthi();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void update()
        {
            conn = new SqlConnection(strc);

            conn.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "sp_checksuatchieu";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhim", SqlDbType.VarChar, 10).Value = cbtenphimlct.Text;
            cmd.Parameters.Add("@MaRap", SqlDbType.VarChar, 5).Value = cbraplct.Text;
            cmd.Parameters.Add("@NgayChieu", SqlDbType.Date).Value = dtpngaychieu.Value.ToString("dd/MM/yyyy");
            cmd.Parameters.Add("@MaSuat", SqlDbType.VarChar, 3).Value = cbsuatchieulct.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
