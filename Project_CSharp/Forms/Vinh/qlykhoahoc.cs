using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_CSharp.Forms.Vinh
{
    public partial class qlykhoahoc: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;User ID=sa;Password=56tfg7hj8");
        public qlykhoahoc()
        {
            InitializeComponent();
        }
        private void loadkhoahoc()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "SELECT * FROM khoahoc";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            cmd.Dispose();
            con.Close();
            dgv.DataSource = dt;
            dgv.Refresh();
        }
        private void qlykhoahoc_Load(object sender, EventArgs e)
        {
            loadkhoahoc();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string tenkhoahoc = txttenkhoa.Text;
            DateTime nbd = datebd.Value;
            DateTime nkt = datekt.Value;

            if (con.State == ConnectionState.Closed)
                con.Open();

            string sql = "INSERT INTO khoahoc (tenkhoahoc, ngaybatdau, ngayketthuc) VALUES ( @tenkhoahoc, @ngaybatdau, @ngayketthuc)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tenkhoahoc", tenkhoahoc);
            cmd.Parameters.AddWithValue("@ngaybatdau", nbd);
            cmd.Parameters.AddWithValue("@ngayketthuc", nkt);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            MessageBox.Show("Thêm khóa học thành công");
            loadkhoahoc();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string tenkhoahoc = txttenkhoa.Text;
            DateTime nbd = datebd.Value;
            DateTime nkt = datekt.Value;

            if (con.State == ConnectionState.Closed)
                con.Open();

            string sql = "UPDATE khoahoc SET tenkhoahoc = @tenkhoahoc, ngaybatdau = @ngaybatdau, ngayketthuc = @ngayketthuc WHERE tenkhoahoc = @tenkhoahoc";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tenkhoahoc", tenkhoahoc);
            cmd.Parameters.AddWithValue("@ngaybatdau", nbd);
            cmd.Parameters.AddWithValue("@ngayketthuc", nkt);

            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Sửa khóa học thành công");
            }
            else
            {
                MessageBox.Show("Không tìm thấy khóa học để sửa");
            }
            loadkhoahoc();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                txttenkhoa.Text = dgv.Rows[rowIndex].Cells["tenkhoahoc"].Value.ToString();
                datebd.Value = DateTime.Parse(dgv.Rows[rowIndex].Cells["ngaybatdau"].Value.ToString());
                datekt.Value = DateTime.Parse(dgv.Rows[rowIndex].Cells["ngayketthuc"].Value.ToString());
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khóa học này không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) {
                return;
            }

            string tenkhoahoc = txttenkhoa.Text;
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "DELETE FROM khoahoc WHERE tenkhoahoc = @tenkhoahoc";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tenkhoahoc", tenkhoahoc);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Xóa khóa học thành công");
            loadkhoahoc();
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            string tenkhoahoc = txttk.Text;
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "SELECT * FROM khoahoc WHERE tenkhoahoc LIKE '%' + @tenkhoahoc + '%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tenkhoahoc", tenkhoahoc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();
            dgv.DataSource = dt;
            dgv.Refresh();
        }
    }
}
