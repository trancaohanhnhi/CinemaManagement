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
    public partial class FormSửa_phim : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public FormSửa_phim()
        {
            InitializeComponent();
        }

        //Chọn nút Hủy thì 'FormSửa_cụm_rạp' đóng
        private void bthuysuaphim_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Phương thức khi Chọn nút Xác nhận thì dữ liệu được cập nhật vào datagridview
        private void btxnsuaphim_Click(object sender, EventArgs e)
        {
            // Kiểm tra các TextBox rỗng
            if (tbtenphimsua.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result;
            result = MessageBox.Show("Bạn chắn chắn muốn sửa thông tin?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                update();   //Gọi phương thức 'update' để hiển thị dữ liệu lên DataGridView  
            }            
        }

        //Phương thức để cập nhật dữ liệu
        private void update()
        {
            //Kết nối CSDL
            connection = new SqlConnection(strc);

            connection.Open();
            //Thêm dữ liệu vào bảng trong CSDL bằng cách sử dụng SqlCommand thực hiện truy vấn SQL
            cmd = new SqlCommand();
            cmd.CommandText = "sp_SuaPhim";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaPhim", SqlDbType.VarChar, 5).Value = tbmaphimsua.Text;
            cmd.Parameters.Add("@TenPhim", SqlDbType.NVarChar, 50).Value = tbtenphimsua.Text;
            cmd.Parameters.Add("@MaTheLoaiChinh", SqlDbType.VarChar, 5).Value = cbsuatlc.Text;
            cmd.Parameters.Add("@ThoiLuong", SqlDbType.Int, 4).Value = nudthoiluongsua.Value;
            cmd.Parameters.Add("@CoLa3D", SqlDbType.Bit, 1).Value = cbsuaphim3d.Checked;
            cmd.Parameters.Add("@CoLongTieng", SqlDbType.Bit, 1).Value = cbsuaphimlongtieng.Checked;
            cmd.Parameters.Add("@MaTheLoai", SqlDbType.VarChar, 10).Value = cbsuatlp.Text;
            cmd.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Hiển thị dữ liệu trên DataGridView của 'FormPhim'
            FormPhim f = (FormPhim)Application.OpenForms["FormPhim"];//Lấy đối tượng của 'FormPhim'
            f.hienthi();//Tải lại dữ liệu vào DataGridView
            this.Close();
        }


        private void FormSửa_phim_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin cần sửa lên các TextBox tương ứng trên form
            tbmaphimsua.Text = FormPhimData.MPValue;
            tbtenphimsua.Text = FormPhimData.TPValue;
            nudthoiluongsua.Value = FormPhimData.TLValue;
            cbsuaphim3d.Checked = FormPhimData.DValue;
            cbsuaphimlongtieng.Checked = FormPhimData.LTValue;
           
            cbtlc(); //Gọi phương thức 'cbtlc' để hiển thị dữ liệu vào combobox    
            cbtlp(); //Gọi phương thức 'cbtlp' để hiển thị dữ liệu vào combobox    
        }

        //Phương thức cbtlc() được sử dụng để hiển thị danh sách các thể loại trong ComboBox 'cbsuatlc'
        private void cbtlc()
        {
            connection = new SqlConnection(strc);

            connection.Open();
            cmd = new SqlCommand("select * from TheLoai", connection);
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.Fill(dt);
            connection.Close();

            // Gán DataTable cho DataSource của ComboBox cbsuatlc, để hiển thị danh sách Mã thể loại chính
            cbsuatlc.DataSource = dt;
            cbsuatlc.DisplayMember = "MaTheLoai";
            cbsuatlc.ValueMember = "MaTheLoai";

            // set giá trị hiện tại cho ComboBox Sửa mã thể loại chính
            cbsuatlc.SelectedValue = FormPhimData.MTLCValue;
        }      
        
        private void cbsuatlc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbtlp();  // Gọi phương thức 'cbtlp' để lấy danh sách Mã thể loại phụ mới cho ComboBox 'cbsuatlp', dựa trên Mã thể loại chính được chọn trên 'cbsuatlc'
        }

        //Phương thức cbtlp() được sử dụng để hiển thị danh sách các thể loại trong ComboBox 'cbsuatlp'
        private void cbtlp()
        {
            connection = new SqlConnection(strc);

            connection.Open();

            // Tạo đối tượng SqlCommand để truy vấn CSDL, lấy danh sách Mã thể loại phụ mới, loại trừ Mã thể loại chính được chọn trên 'cbsuatlc'
            cmd = new SqlCommand("select MaTheLoai from TheLoai where MaTheLoai <> @MaTheLoaiChinh", connection);
            cmd.Parameters.AddWithValue("@MaTheLoaiChinh", cbsuatlc.SelectedValue.ToString());

            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.Fill(dt);
            connection.Close();

            // gán danh sách thể loại phụ mới cho ComboBox cbsuatlp
            cbsuatlp.DataSource = dt;
            cbsuatlp.DisplayMember = "MaTheLoai";
            cbsuatlp.ValueMember = "MaTheLoai";

            // set giá trị hiện tại cho ComboBox Sửa mã thể loại phụ
            cbsuatlp.SelectedValue= FormPhimData.MTLPValue;
        }

    }
}