using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_CSharp.Forms.Vinh
{
    public partial class qlymonhoc: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;User ID=sa;Password=56tfg7hj8");
        public qlymonhoc()
        {
            InitializeComponent();
        }
        private void loadmonhoc()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "SELECT * FROM monhoc";
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
        private void btnthem_Click(object sender, EventArgs e)
        {
            string tenmonhoc = txtmh.Text;
            int tinchi = int.Parse(txttc.Text);
            string mota = txtmt.Text;
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "INSERT INTO monhoc (tenmonhoc, sotinchi, mota) VALUES (@tenmonhoc, @tinchi, @mota)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tenmonhoc", tenmonhoc);
            cmd.Parameters.AddWithValue("@sotinchi", tinchi);
            cmd.Parameters.AddWithValue("@mota", mota);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm môn học thành công");
            loadmonhoc();
        }

        private void qlymonhoc_Load(object sender, EventArgs e)
        {
            loadmonhoc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string tenmonhoc = txtmh.Text;
            int tinchi = int.Parse(txttc.Text);
            string mota = txtmt.Text;
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "UPDATE monhoc SET tenmonhoc = @tenmonhoc, tinchi = @tinchi, mota = @mota WHERE tenmonhoc = @tenmonhoc";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tenmonhoc", tenmonhoc);
            cmd.Parameters.AddWithValue("@tinchi", tinchi);
            cmd.Parameters.AddWithValue("@mota", mota);
            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Sửa môn học thành công");
            }
            else
            {
                MessageBox.Show("Không tìm thấy môn học để sửa");
            }
            loadmonhoc();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                txtmh.Text = dgv.Rows[rowIndex].Cells["tenmonhoc"].Value.ToString();
                txttc.Text = dgv.Rows[rowIndex].Cells["tinchi"].Value.ToString();
                txtmt.Text = dgv.Rows[rowIndex].Cells["mota"].Value.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            
                string tenmonhoc = txtmh.Text;
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "DELETE FROM monhoc WHERE tenmonhoc = @tenmonhoc";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@tenmonhoc", tenmonhoc);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Xóa môn học thành công");
                loadmonhoc();
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            string tenmonhoc = txttmtk.Text;
            string tinchi = txttctk.Text;
            string sql = "SELECT * FROM monhoc WHERE tenmonhoc LIKE '%' + @tenmonhoc + '%' AND tinchi LIKE '%' + @tinchi + '%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tenmonhoc", tenmonhoc);
            cmd.Parameters.AddWithValue("@tinchi", tinchi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            cmd.Dispose();
            con.Close();
            dgv.DataSource = dt;
            dgv.Refresh();
        }
    }
}
