using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace MyCGV
{
    public partial class FormThêm_rạp_Q1 : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public FormThêm_rạp_Q1()

        {
            InitializeComponent();
        }

        //Button Hủy
        private void bthuysrq1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Gán giá trị textbox vào để Form CGV Quận 1 truy cập dl thông qua Formrapq1Data
        private void FormThêm_rạp_Q1_Load(object sender, EventArgs e)
        {
            //Set giá trị cho tb mã cụm là CGVQ1
            tbmacumq1.Text = "CGVQ1";
        }

        //Button Xác nhận thêm
        private void btxacnhantrq1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các TextBox rỗng
                if (tbmarapq1.Text == "")
                {
                    MessageBox.Show("Vui lòng điền mã rạp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Kết nối CSDL
                connection = new SqlConnection(strc);
                connection.Open();

                //Thêm dữ liệu vào bảng trong CSDL bằng cách sử dụng SqlCommand thực hiện truy vấn SQL
                cmd = new SqlCommand("insert into dbo.Rap values (@MaRap, @TongGhe, @MaCum)", connection);
                DataTable tb = new DataTable();
                adapter = new SqlDataAdapter(cmd);

                //Thực hiện truy vấn SQL với SQLParameter
                SqlParameter marap = new SqlParameter("@MaRap", SqlDbType.VarChar, 5);
                marap.Value = tbmarapq1.Text;
                SqlParameter tongghe = new SqlParameter("@TongGhe", SqlDbType.Int);
                tongghe.Value = nudtonggherq1.Value;
                SqlParameter macum = new SqlParameter("@MaCum", SqlDbType.VarChar, 5);
                macum.Value = tbmacumq1.Text;

                cmd.Parameters.Add(marap);
                cmd.Parameters.Add(tongghe);
                cmd.Parameters.Add(macum);
                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị dữ liệu trên DataGridView của 'FormCGV_Quận_1'
                FormCGV_Quận_1 f = (FormCGV_Quận_1)Application.OpenForms["FormCGV_Quận_1"];//Lấy đối tượng của 'FormCGV_Quận_1'
                f.hienthi();//Tải lại dữ liệu vào DataGridView
                this.Close();
            }
            catch
            {
                MessageBox.Show("Mã rạp bị trùng, vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}