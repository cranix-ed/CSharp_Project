using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_CSharp.Forms.Vinh
{
    public partial class ttnguoidung: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;User ID=sa;Password=56tfg7hj8");
        public ttnguoidung()
        {
            InitializeComponent();
        }

        private void ttnguoidung_Load(object sender, EventArgs e)
        {
            load_thongtin();
        }
        private void load_thongtin()
        {
            if(con.State == ConnectionState.Closed)
                con.Open();
            string sql = "SELECT * FROM thongtincanhan";
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

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string hoten = txtht.Text;
            DateTime ngs = date.Value;
            string gt = cbogt.SelectedItem.ToString();
            string diachi = txtdc.Text;
            string sdt = txtsdt.Text;
            string email = txtemail.Text;

            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "INSERT INTO thongtincanhan (idnguoidung, hoten, ngaysinh, gioitinh, diachi, sodienthoai, email) VALUES (@id, @hoten, @ngaysinh, @gioitinh, @diachi, @sdt, @email)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Parameters.AddWithValue("@ngaysinh", ngs);
            cmd.Parameters.AddWithValue("@gioitinh", gt);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Thêm thông tin cá nhân thành công");
            load_thongtin();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "DELETE FROM thongtincanhan WHERE idnguoidung = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Xóa thông tin cá nhân thành công");
            load_thongtin();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string hoten = txtht.Text;
            DateTime ngs = date.Value;
            string gt = cbogt.SelectedItem.ToString();
            string diachi = txtdc.Text;
            string sdt = txtsdt.Text;
            string email = txtemail.Text;
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "UPDATE thongtincanhan SET hoten = @hoten, ngaysinh = @ngaysinh, gioitinh = @gioitinh, diachi = @diachi, sodienthoai = @sdt, email = @email WHERE idnguoidung = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Parameters.AddWithValue("@ngaysinh", ngs);
            cmd.Parameters.AddWithValue("@gioitinh", gt);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@email", email);
            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Sửa thông tin cá nhân thành công");
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin cá nhân để sửa");
            }
            load_thongtin();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtid.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            txtht.Text = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            date.Value = DateTime.Parse(dgv.Rows[rowIndex].Cells[2].Value.ToString());
            cbogt.SelectedItem = dgv.Rows[rowIndex].Cells[3].Value.ToString();
            txtdc.Text = dgv.Rows[rowIndex].Cells[4].Value.ToString();
            txtsdt.Text = dgv.Rows[rowIndex].Cells[5].Value.ToString();
            txtemail.Text = dgv.Rows[rowIndex].Cells[6].Value.ToString();
        }
    }
}
