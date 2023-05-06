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
    public partial class FormThêm_cụm_rạp : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        public FormThêm_cụm_rạp()
        {
            InitializeComponent();
        }

        //Chọn nút Hủy thì 'FormThêm_cụm_rạp' đóng
        private void bthuythemcum_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Phương thức khi Chọn nút Xác nhận thì dữ liệu được thêm vào datagridview
        private void btxnthemcr_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các TextBox rỗng
                if (tbmacumthem.Text == ""||tbtencumthem.Text ==""||tbthemdccum.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Kết nối CSDL
                connection = new SqlConnection(strc);
               connection.Open();

                //Thêm dữ liệu vào bảng trong CSDL bằng cách sử dụng SqlCommand thực hiện truy vấn SQL
                cmd = new SqlCommand("insert into dbo.CumRap values (@MaCum, @TenCum, @DiaChi)", connection);
                DataTable tb = new DataTable();
                adapter = new SqlDataAdapter(cmd);

                //Thực hiện truy vấn SQL với SQLParameter
                SqlParameter marap = new SqlParameter("@MaCum", SqlDbType.VarChar, 5);
                marap.Value = tbmacumthem.Text;
                SqlParameter tongghe = new SqlParameter("@TenCum", SqlDbType.NVarChar, 50);
                tongghe.Value = tbtencumthem.Text;
                SqlParameter macum = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 100);
                macum.Value = tbthemdccum.Text;

                cmd.Parameters.Add(marap);
                cmd.Parameters.Add(tongghe);
                cmd.Parameters.Add(macum);
                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị dữ liệu trên DataGridView của 'FormSetting'
                FormSetting f = (FormSetting)Application.OpenForms["FormSetting"];//Lấy đối tượng của 'FormSetting'
                f.hienthi();//Tải lại dữ liệu vào DataGridView
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Mã cụm bị trùng, vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
    }
}
