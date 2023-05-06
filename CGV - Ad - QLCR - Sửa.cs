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
using static MyCGV.FormSetting;

namespace MyCGV
{
    public partial class FormSửa_cụm_rạp : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;
        public FormSửa_cụm_rạp()
        {
            InitializeComponent();
        }

        //Chọn nút Hủy thì 'FormSửa_cụm_rạp' đóng
        private void bthuysuacum_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Phương thức khi Chọn nút Xác nhận thì dữ liệu được cập nhật vào datagridview
        private void btxnsuacr_Click(object sender, EventArgs e)
        {
            // Kiểm tra các TextBox rỗng
            if (tbtencumsua.Text == ""||tbdiachisua.Text == "" )
            {
                MessageBox.Show("Vui lòng điền đầy đủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result;
            result = MessageBox.Show("Bạn chắn chắn muốn sửa thông tin?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Kết nối CSDL
                connection = new SqlConnection(strc);
                connection.Open();

                //Update dữ liệu sửa
                cmd = new SqlCommand("update dbo.CumRap set TenCum = @TenCum, DiaChi = @DiaChi WHERE MaCum = @MaCum", connection);

                cmd.Parameters.AddWithValue("@TenCum", tbtencumsua.Text);
                cmd.Parameters.AddWithValue("@DiaChi", tbdiachisua.Text);
                cmd.Parameters.AddWithValue("@MaCum", tbmacumsua.Text);
                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị dữ liệu trên DataGridView của 'FormSetting'
                FormSetting f = (FormSetting)Application.OpenForms["FormSetting"];//Lấy đối tượng của 'FormSetting'
                f.hienthi();//Tải lại dữ liệu vào DataGridView
                this.Close();
            }
        }       
        private void FormSửa_cụm_rạp_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin cần sửa lên các TextBox tương ứng trên form
            tbmacumsua.Text = FormCumRapData.MCValue;   
            tbtencumsua.Text = FormCumRapData.TCValue;
            tbdiachisua.Text = FormCumRapData.DCValue;
        }
    }
}
