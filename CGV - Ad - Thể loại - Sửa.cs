using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyCGV.Thể_loại;

namespace MyCGV
{
    public partial class FormSuatheloai : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;

        public FormSuatheloai()
        {
            InitializeComponent();  
        }

        //Chọn Hủy thì Form đóng
        private void bthuysuatl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Phương thức khi Chọn nút Xác nhận thì dữ liệu được cập nhật vào datagridview
        private void btxnsuatl_Click(object sender, EventArgs e)
        {
            // Kiểm tra các TextBox rỗng
            if (tbsuatentl.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd = new SqlCommand("update TheLoai set TenTheLoai = @TenTheLoai WHERE MaTheLoai = @MaTheLoai", connection);

                cmd.Parameters.AddWithValue("@TenTheLoai", tbsuatentl.Text);
                cmd.Parameters.AddWithValue("@MaTheLoai", tbsuamtl.Text);
                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị dữ liệu trên DataGridView của 'Thể_loại'
                Thể_loại f = (Thể_loại)Application.OpenForms["Thể_loại"];//Lấy đối tượng của 'Thể_loại'
                f.hienthi();//Tải lại dữ liệu vào DataGridView
                this.Close();
            }
            else this.Close();
        }

        //Gán giá trị textbox vào để Form Thể loại truy cập dl thông qua FormSuatlData
        private void FormSuatheloai_Load_1(object sender, EventArgs e)
        {
            tbsuamtl.Text = FormSuatlData.MTLValue;
            tbsuatentl.Text = FormSuatlData.TTLValue;
        }        
    }
}
