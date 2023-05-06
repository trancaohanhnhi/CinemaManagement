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
using static MyCGV.FormQLLichchieu;

namespace MyCGV
{
    public partial class FormXoaQLLC : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection conn;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        public FormXoaQLLC()
        {
            InitializeComponent();
        }

        private void btxnx_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = MessageBox.Show("Dữ liệu bị xoá sẽ không được khôi phục.\r\nBạn có chắc chắn muốn xoá lịch chiếu phim này không?", "Xóa phim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    xoa();
                    this.Close();                    
                    FormQLLichchieu g = (FormQLLichchieu)Application.OpenForms["FormQLLichchieu"];
                    g.hienthi();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void xoa()
        {
            conn = new SqlConnection(strc);

            conn.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "sp_DeleteChuoi";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhim", SqlDbType.VarChar, 10).Value =tbmaphimllcx.Text;
            cmd.Parameters.Add("@MaRap", SqlDbType.VarChar, 5).Value = tbmaraplcx.Text;
            cmd.Parameters.Add("@NgayChieu", SqlDbType.Date).Value = tbngaychieulcx.Text;
            cmd.Parameters.Add("@ChuoiMaSuat", SqlDbType.NVarChar).Value = tbsuatchieux.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void FormXoaQLLC_Load(object sender, EventArgs e)
        {
            DateTime n = DateTime.Parse(dataa.ngaychieu);
            tbmaphimllcx.Text = dataa.maphim;
            tbmaraplcx.Text = dataa.marap;
            tbngaychieulcx.Text = n.ToString("dd/MM/yyyy");
            tbsuatchieux.Text = dataa.csuatchieu;
        }
    }
}
