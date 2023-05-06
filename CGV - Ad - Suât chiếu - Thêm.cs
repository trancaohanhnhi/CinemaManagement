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
    public partial class Thêm_suất_chiếu : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        public Thêm_suất_chiếu()
        {
            InitializeComponent();
        }

        //Button Hủy
        private void bthuythemxc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Button Xác nhận thêm
        private void btxnthemxc_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các TextBox rỗng
                if (tbmasuat.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Kết nối CSDL
                connection = new SqlConnection(strc);

                connection.Open();
                //Thêm dữ liệu vào bảng trong CSDL bằng cách sử dụng SqlCommand thực hiện truy vấn SQL
                cmd = new SqlCommand("insert into SuatChieu values (@MaSuat, @GioBatDau, @PhutBatDau)", connection);
                DataTable tb = new DataTable();
                adapter = new SqlDataAdapter(cmd);

                //Thực hiện truy vấn SQL với SQLParameter
                SqlParameter ms = new SqlParameter("@MaSuat", SqlDbType.VarChar, 3);
                ms.Value = tbmasuat.Text;
                SqlParameter gbd = new SqlParameter("@GioBatDau", SqlDbType.Int, 4);
                gbd.Value = nudgioBD.Value;
                SqlParameter pbd = new SqlParameter("@PhutBatDau", SqlDbType.Int, 4);
                pbd.Value = nudphutBD.Value;
                cmd.Parameters.Add(ms);
                cmd.Parameters.Add(gbd);
                cmd.Parameters.Add(pbd);
                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị dữ liệu trên DataGridView của 'FormSuất_chiếu'
                FormSuất_chiếu f = (FormSuất_chiếu)Application.OpenForms["FormSuất_chiếu"];//Lấy đối tượng của 'FormSuất_chiếu'
                f.hienthi();//Tải lại dữ liệu vào DataGridView
                this.Close();
            }
            catch
            {
                MessageBox.Show("Mã suất bị trùng, vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
