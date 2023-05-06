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
    public partial class FormSửa_rạp_quận_1 : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;

        public FormSửa_rạp_quận_1()
        {
            InitializeComponent();
        }

        //Phương thức khi Chọn nút Xác nhận thì dữ liệu được cập nhật vào datagridview
        private void btxacnhansrq1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn chắn chắn muốn sửa thông tin rạp?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Kết nối CSDL
                connection = new SqlConnection(strc);
                connection.Open();

                //Update dữ liệu sửa
                cmd = new SqlCommand("update dbo.Rap set TongGhe = @TongGhe WHERE MaRap = @MaRap", connection);

                cmd.Parameters.AddWithValue("@TongGhe", nudsogheq1.Value);
                cmd.Parameters.AddWithValue("@MaRap", tbmarapq1.Text);
                cmd.Parameters.AddWithValue("@MaCum", tbsuamcq1.Text);
                cmd.ExecuteNonQuery();

                //Đóng kết nối
                connection.Close();
                
                MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị dữ liệu trên DataGridView của 'FormCGV_Quận_1'
                FormCGV_Quận_1 f = (FormCGV_Quận_1)Application.OpenForms["FormCGV_Quận_1"];//Lấy đối tượng của 'FormCGV_Quận_1'
                f.hienthi();//Tải lại dữ liệu vào DataGridView
                this.Close();                
            }
        }

        //Chọn nút Hủy thì 'FormSửa_rạp_quận_1' đóng
        private void bthuysrq1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSửa_rạp_quận_1_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin cần sửa lên các TextBox tương ứng trên form
          tbmarapq1.Text = Formrapq1Data.MRValue;
          nudsogheq1.Value = Formrapq1Data.TGValue;
          tbsuamcq1.Text = Formrapq1Data.MCValue;
        }        
    }
}
