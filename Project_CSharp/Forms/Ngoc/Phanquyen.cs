using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_CSharp.Forms.Ngoc
{
    public partial class Phanquyen : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;User ID=sa;Password=56tfg7hj8");
        public Phanquyen()
        {
            InitializeComponent();
            Load_phanquyen();
        }
        public bool checktrungten(String ten)
        {
            //Ket noi den DB
            if (con.State == ConnectionState.Closed)
                con.Open();
            //Tao doi tuong command de thuc hien den cac ban ghi co Matacgia
            String sql = "Select count(*) from nguoidung Where tendangnhap ='" + ten + "'";
            SqlCommand cmd = new SqlCommand(sql, con);

            int kq = (int)cmd.ExecuteScalar();
            if (kq > 0)
            {
                return true;//Trung ma tac gia
            }
            else
            {
                return false;//Khong trung Ma tac gia
            }
        }
        private void Load_phanquyen()
        {
            //B1:Ket noi Database 
            if (con.State == ConnectionState.Closed) ;
            con.Open();
            //B2: Tao doi tuong Command
            String sql = "Select * From nguoidung";
            SqlCommand cmd = new SqlCommand(sql, con);
            //B3: Tao doi tuong DataAdapter 
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //B4: Tao doi tg Datatable
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            //B5: Hien thi tb len DataGri
            Capnhatphanquyen.DataSource = tb;
            Capnhatphanquyen.Refresh();
        }

        private void Phanquyen_Load(object sender, EventArgs e)
        {
            Load_phanquyen();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //b1:Lay giu liệu từ các control đưa vào biến

            string ten = txttdn.Text.Trim();
            String mk = txtmk.Text.Trim();
            String pq = txtpq.Text.Trim();
            DateTime ngt = date.Value;
            DateTime ngcn = date1.Value;
            //b2: Kết nối với database
            if (con.State == ConnectionState.Closed)
                con.Open();
            //b3.1: Tạo câu lệnh truy vấn để lưu giữ liệu vào bảng
            //String sql = "Insert SinhVien Values(N'"+mtg+"',N'"+ht+"',N'"+gt+"','"+ngs+"','"+dt+"',N'"+mail+"',N'"+dc+"')";

            String sql = "Insert nguoidung Values (@tennguoidung,@matkhau,@phanquyen,@ngaytao,@ngaycapnhat)";

            //b3.2: Tạo đối tượng command

            SqlCommand cmd = new SqlCommand(sql, con);


            cmd.Parameters.Add("@tennguoidung", SqlDbType.NVarChar, 100).Value = ten;

            cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar, 10).Value = mk;

            cmd.Parameters.Add("@phanquyen", SqlDbType.NVarChar, 50).Value = pq;

            cmd.Parameters.Add("@ngaytao", SqlDbType.DateTime, 50).Value = ngt;

            cmd.Parameters.Add("@ngaycapnhat", SqlDbType.DateTime, 50).Value = ngcn;

            if (ten == "")
            {
                MessageBox.Show("Yêu cầu nhập tên đăng nhập");
                txtid.Focus();
                return;
            }
            if (checktrungten(ten))
            {
                MessageBox.Show("Trùng tên đăng nhập");
                txtid.Focus();
                return;
            }

            cmd.ExecuteNonQuery();
            cmd.Dispose(); //Giai phóng cmd
            con.Close();//Đóng kết nối
            Load_phanquyen();
            MessageBox.Show("Thêm mới thành công!");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            {
                String id = txtid.Text.Trim();
                string ten = txttdn.Text.Trim();
                String mk = txtmk.Text.Trim();
                String pq = txtpq.Text.Trim();
                DateTime ngt = date.Value;
                DateTime ngcn = date1.Value;

                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "UPDATE nguoidung SET tendangnhap=@tendangnhap, matkhau=@matkhau, phanquyen=@phanquyen, ngaytao=@ngaytao, ngaycapnhat=@ngaycapnhat WHERE idnguoidung=@idnguoidung";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idnguoidung", id);
                cmd.Parameters.AddWithValue("@tendangnhap", ten);
                cmd.Parameters.AddWithValue("@matkhau", mk);
                cmd.Parameters.AddWithValue("@phanquyen", pq);
                cmd.Parameters.AddWithValue("@ngaytao", ngt);
                cmd.Parameters.AddWithValue("@ngaycapnhat", ngcn);

                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    Load_phanquyen(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
        }

        private void Capnhatphanquyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = e.RowIndex;
            txtid.Text = Capnhatphanquyen.Rows[i].Cells[0].Value.ToString();
            txttdn.Text = Capnhatphanquyen.Rows[i].Cells[1].Value.ToString();
            txtmk.Text = Capnhatphanquyen.Rows[i].Cells[2].Value.ToString();
            txtpq.Text = Capnhatphanquyen.Rows[i].Cells[3].Value.ToString();
            date.Value = DateTime.Parse(Capnhatphanquyen.Rows[i].Cells[4].Value.ToString());
            date1.Value = DateTime.Parse(Capnhatphanquyen.Rows[i].Cells[5].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtid.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "DELETE FROM nguoidung WHERE idnguoidung=@idnguoidung";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idnguoidung", id);

                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    Load_phanquyen(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnTimKien_Click(object sender, EventArgs e)
        {
            String tdn = txttktdn.Text.Trim();   // mã ngành
            

            if (con.State == ConnectionState.Closed)
                con.Open();

            String sql = "Select * From nguoidung Where tendangnhap like '%" + tdn + "%' ";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            Capnhatphanquyen.DataSource = tb;
            Capnhatphanquyen.Refresh();
        }
    }
}
