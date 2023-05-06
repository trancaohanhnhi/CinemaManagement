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
using System.Xml.Linq;


namespace MyCGV
{
    public partial class FormThemtheloai : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public FormThemtheloai()
        {
            InitializeComponent();
        }

        //Button Thêm thể loại
        private void btxnthemtl_Click(object sender, EventArgs e)
        {

            try
            {
                // Kiểm tra các TextBox rỗng
                if (tbthemmtl.Text == "" || tbthemtentl.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Kết nối CSDL
                connection = new SqlConnection(strc);
                connection.Open();

                //Thêm dữ liệu vào bảng trong CSDL bằng cách sử dụng SqlCommand thực hiện truy vấn SQL
                cmd = new SqlCommand("insert into TheLoai values (@MaTheLoai, @TenTheLoai)", connection);
                DataTable tb = new DataTable();
                adapter = new SqlDataAdapter(cmd);

                //Thực hiện truy vấn SQL với SQLParameter
                SqlParameter matl = new SqlParameter("@MaTheLoai", SqlDbType.VarChar, 5);
                matl.Value = tbthemmtl.Text;
                SqlParameter tentl = new SqlParameter("@TenTheLoai", SqlDbType.NVarChar, 50);
                tentl.Value = tbthemtentl.Text;

                cmd.Parameters.Add(matl);
                cmd.Parameters.Add(tentl);
                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Hiển thị dữ liệu trên DataGridView của form Thể Loại
                Thể_loại f = (Thể_loại)Application.OpenForms["Thể_loại"];//Lấy đối tượng của form thể loại
                f.hienthi();//Tải lại dữ liệu vào DataGridView
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Mã thể loại bị trùng, vui lòng xem lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            //Button Hủy
            private void bthuythemtl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


