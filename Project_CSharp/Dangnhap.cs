using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_CSharp
{
    public partial class Dangnhap: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;User ID=sa;Password=56tfg7hj8");
        public Dangnhap()
        {
            InitializeComponent();

        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txttdn.Text.Trim();
            string matKhau = txtmk.Text.Trim();

            if (tenDangNhap == "" || matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (con.State == ConnectionState.Closed)
                con.Open();

            string sql = "SELECT * FROM nguoidung WHERE tendangnhap = @tenDangNhap AND matkhau = @matKhau";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
            cmd.Parameters.AddWithValue("@matKhau", matKhau);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string quyen = reader["phanquyen"].ToString();
                reader.Close();
                con.Close();

                MessageBox.Show("Đăng nhập thành công!");

                // Ẩn form đăng nhập, hiện giao diện chính
                this.Hide();
                FormMain main = new FormMain (); // hoặc form chính khác nếu có
                main.Show();
            }
            else
            {
                con.Close();
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }
    }
}
