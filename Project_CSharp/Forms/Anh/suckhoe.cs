using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_CSharp.Forms.Anh
{
    public partial class suckhoe: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;User ID=sa;Password=56tfg7hj8");
        public suckhoe()
        {
            InitializeComponent();
            loadsinhvien();
            loadhososuckhoe();
        }
        private void loadsinhvien()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            String sql = "select idsinhvien, hoten from sinhvien"; // chọn rõ ràng
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            // Tạo dòng trống để làm dòng "Chọn sinh viên"
            DataRow r = tb.NewRow();
            r["idsinhvien"] = 0; // hoặc DBNull.Value
            r["hoten"] = "<-- Chọn id -->";
            tb.Rows.InsertAt(r, 0);

            // Gán dữ liệu cho ComboBox
            cbmasv.DataSource = tb;
            cbmasv.ValueMember = "idsinhvien";
            cbmasv.DisplayMember = "hoten";

            searchmsv.DataSource = tb;
            searchmsv.ValueMember = "idsinhvien";
            searchmsv.DisplayMember = "hoten";
        }
        private void loadhososuckhoe()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            String sql = "Select hs.idhosuckhoe, hs.idsinhvien, hs.vande, hs.dieutri, hs.ngay " +
                "from hososuckhoe hs " +
                "Join sinhvien sv on hs.idsinhvien = sv.idsinhvien";
            // lay them lop
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            cmd.Dispose();
            con.Close();
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();

        }
        public bool checktrungmahs(string mahs)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            String sql = "Select count (*) from hososuckhoe Where idhosuckhoe= '" + mahs + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            if (kq > 0)
                return true; //trung ma 
            else
                return false;//khong trung 
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void suckhoe_Load(object sender, EventArgs e)
        {
            loadhososuckhoe();
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            string mahs = txtmahs.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            string vande = txtvande.Text.Trim();
            string dieutri = txtdieutri.Text.Trim();
            DateTime ngay = txtngay.Value;

            if (checktrungmahs(mahs))
            {
                MessageBox.Show("Trùng mã hồ sơ.");
                txtmahs.Focus();
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "INSERT INTO hocbong VALUES (@mhs, @msv, @vande, @dieutri, @ngay)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mhs", mahs);
                com.Parameters.AddWithValue("@msv", msv);
                com.Parameters.AddWithValue("@vande", vande);
                com.Parameters.AddWithValue("@dieutri", dieutri);
                com.Parameters.AddWithValue("@ngay", ngay);

                com.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
                loadhososuckhoe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string mahs = txtmahs.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            string vande = txtvande.Text.Trim();
            string dieutri = txtdieutri.Text.Trim();
            DateTime ngay = txtngay.Value;

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "UPDATE hososuckhoe SET idsinhvien = @msv, vande = @vande, dieutri = @dieutri, ngay = @ngay WHERE idhosuckhoe = @mhs";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mhs", mahs);
                com.Parameters.AddWithValue("@msv", msv);
                com.Parameters.AddWithValue("@vande", vande);
                com.Parameters.AddWithValue("@dieutri", dieutri);
                com.Parameters.AddWithValue("@ngay", ngay);

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    loadhososuckhoe();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã hồ sơ cần cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            string mahs = txtmahs.Text.Trim();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "DELETE FROM hososuckhoe WHERE idhosuckhoe = @mhs";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mhs", mahs);

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Xoá thành công!");
                    loadhososuckhoe();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hồ sơ để xoá.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Timkiem_Click(object sender, EventArgs e)
        {
            string mahs = searchmahs.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            string vande = searchvande.Text.Trim();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "SELECT * FROM hososuckhoe WHERE idhosuckhoe LIKE @mahs AND idsinhvien LIKE @msv AND vande LIKE @vande";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mahs", "%" + mahs + "%");
                cmd.Parameters.AddWithValue("@msv", "%" + msv + "%");
                cmd.Parameters.AddWithValue("@vande", "%" + vande + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                dataGridView1.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                txtmahs.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
               cbmasv.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtvande.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtdieutri.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtngay.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            }
        }
    }
}
