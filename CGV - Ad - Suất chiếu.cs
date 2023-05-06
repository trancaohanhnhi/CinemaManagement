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
    public partial class FormSuất_chiếu : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public FormSuất_chiếu()
        {
            InitializeComponent();
        }

        //Chọn nút Thêm để hiển thị Form 'Thêm_suất_chiếu'
        private void btthemsc_Click(object sender, EventArgs e)
        {
            Thêm_suất_chiếu f = new Thêm_suất_chiếu();
            f.ShowDialog();
        }

        //Phương thức được gọi khi 'FormSuất_chiếu' được tải lên
        private void FormSuất_chiếu_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        // Phương thức hiển thị dữ liệu lên DataGridView
        public void hienthi()
        {
            connection = new SqlConnection(strc);

            connection.Open();
            cmd = new SqlCommand("select * from SuatChieu", connection);
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();

            dgvsuatchieu.DataSource = dt;
            dgvsuatchieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Tìm kiếm thông tin theo mã suất
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaSuat", "*" + tbSearch.Text + "*");
            (dgvsuatchieu.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void btxoasc_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Dữ liệu bị xóa sẽ không thể khôi phục. Bạn có chắc chắn muốn xoá không?", "Xóa suất chiếu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    XoaDuLieu();
                }
                catch (Exception ex)
                {
                    // Hiển thị dữ liệu trên DataGridView của 'FormQuản_lý_kế_hoạch'
                    FormSuất_chiếu f = (FormSuất_chiếu)Application.OpenForms["FormSuất_chiếu"];//Lấy đối tượng của 'FormQuản_lý_kế_hoạch'
                    f.hienthi();//Tải lại dữ liệu vào DataGridView
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Vị trí
        int vt = -1;

        // Phương thức xóa dữ liệu
        private void XoaDuLieu()
        {
            vt = dgvsuatchieu.CurrentCell.RowIndex;
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!");
                return;
            }

            DataRow row = dt.Rows[vt];
            row.Delete();

            int kq = adapter.Update(dt);
            if (kq > 0)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
