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

namespace _73DCHT23_Test1
{
    public partial class Tacgia : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VFCDADH\\SQLEXPRESS;Initial Catalog=SinhVien;User ID=sa;Password=123456");
        public Tacgia()
        {
            InitializeComponent();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Load_tacgia()
        {
            //B1:Ket noi Database 
            if (conn.State == ConnectionState.Closed) ;
            conn.Open();
            //B2: Tao doi tuong Command
            String sql = "Select * From SinhVien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //B3: Tao doi tuong DataAdapter 
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //B4: Tao doi tg Datatable
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            conn.Close();
            //B5: Hien thi tb len DataGri
            Capnhattacgia.DataSource = tb;
            Capnhattacgia.Refresh();
        }

        public bool checktrungMatg(String mtg)
        {
            //Ket noi den DB
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //Tao doi tuong command de thuc hien den cac ban ghi co Matacgia
            String sql = "Select count(*) from SinhVien Where Matacgia ='" + mtg + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);

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
        private void btLuu_Click(object sender, EventArgs e)
        {
            //b1:Lay giu liệu từ các control đưa vào biến
            string mtg = txtmatg.Text.Trim();
            string ht = txthoten.Text.Trim();
            String gt = cbgioitinh.SelectedItem.ToString();
            String dt = txtsdt.Text.Trim();
            DateTime ngs = date.Value;
            String mail = txtemail.Text.Trim();
            String dc = txtdiachi.Text.Trim();
            //b2: Kết nối với database
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //b3.1: Tạo câu lệnh truy vấn để lưu giữ liệu vào bảng
            //String sql = "Insert SinhVien Values(N'"+mtg+"',N'"+ht+"',N'"+gt+"','"+ngs+"','"+dt+"',N'"+mail+"',N'"+dc+"')";

            String sql = "Insert SinhVien Values (@mtg,@ht,@gt,@ngs,@sdt,@mail,@diachi)";

            //b3.2: Tạo đối tượng command

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@mtg", SqlDbType.NVarChar, 50).Value = mtg;

            cmd.Parameters.Add("@ht", SqlDbType.NVarChar, 100).Value = ht;

            cmd.Parameters.Add("@gt", SqlDbType.NVarChar, 10).Value = gt;

            cmd.Parameters.Add("@ngs", SqlDbType.DateTime, 50).Value = ngs;

            cmd.Parameters.Add("@sdt", SqlDbType.Text, 50).Value = dt;

            cmd.Parameters.Add("@mail", SqlDbType.NVarChar, 50).Value = mail;

            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 100).Value = dc;

            if (mtg == "")
            {
                MessageBox.Show("Yeu cau nhap ma tac gia");
                txtmatg.Focus();
                return;
            }

            if (checktrungMatg(mtg))
            {
                MessageBox.Show("Trung ma tac gia");
                txtmatg.Focus();
                return;
            }

            cmd.ExecuteNonQuery();
            cmd.Dispose(); //Giai phóng cmd
            conn.Close();//Đóng kết nối
            Load_tacgia();
            MessageBox.Show("Thêm mới thành công!");
        }

        private void Capnhattacgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmatg.Text = Capnhattacgia.Rows[i].Cells[0].Value.ToString();
            txthoten.Text = Capnhattacgia.Rows[i].Cells[1].Value.ToString();
            cbgioitinh.SelectedItem = Capnhattacgia.Rows[i].Cells[2].Value.ToString();
            date.Value = DateTime.Parse(Capnhattacgia.Rows[i].Cells[3].Value.ToString());
            txtsdt.Text = Capnhattacgia.Rows[i].Cells[4].Value.ToString();
            txtemail.Text = Capnhattacgia.Rows[i].Cells[5].Value.ToString();
            txtdiachi.Text = Capnhattacgia.Rows[i].Cells[6].Value.ToString();
        }

        private void Tacgia_Load(object sender, EventArgs e)
        {
            Load_tacgia();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            String mtg = txtmatk.Text.Trim();
            String ht = txthotentk.Text.Trim();
            String gt;
            if (cbgioitinhtk.SelectedItem == null)
                gt = "";
            else
                gt = cbgioitinhtk.SelectedItem.ToString();
            String dt = txtdienthoaitk.Text.Trim();
            //kET NOI DB
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //Tao doi tuong command de tien hanh tim kiem dk
            String sql = "Select * From SinhVien Where Matacgia like '%" + mtg + "%' and Hovaten like N'%" + ht + "%' and Gioitinh like '%" + gt + "%' and Sodienthoai like '%" + dt + "%' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //Tao doi tg Dataadapter de lay kq tu cmd
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //Tao doi tg Datatable de lay du lieu tu da
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            conn.Close();
            //Hien thi tb len dataGribview
            Capnhattacgia.DataSource = tb;
            Capnhattacgia.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                string mtg = txtmatg.Text.Trim();
                if (string.IsNullOrEmpty(mtg))
                {
                    MessageBox.Show("Vui lòng chọn tác giả cần xóa!");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    string sql = "DELETE FROM SinhVien WHERE Matacgia=@mtg";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@mtg", mtg);

                    int result = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        Load_tacgia(); // Cập nhật lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            {
                string mtg = txtmatg.Text.Trim();
                string ht = txthoten.Text.Trim();
                string gt = cbgioitinh.SelectedItem.ToString();
                DateTime ngs = date.Value;
                string dt = txtsdt.Text.Trim();
                string mail = txtemail.Text.Trim();
                string dc = txtdiachi.Text.Trim();

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string sql = "UPDATE SinhVien SET Hovaten=@ht, Gioitinh=@gt, Ngaysinh=@ngs, Sodienthoai=@dt, Email=@mail, Điachi=@dc WHERE Matacgia=@mtg";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@mtg", mtg);
                cmd.Parameters.AddWithValue("@ht", ht);
                cmd.Parameters.AddWithValue("@gt", gt);
                cmd.Parameters.AddWithValue("@ngs", ngs);
                cmd.Parameters.AddWithValue("@dt", dt);
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@dc", dc);

                int result = cmd.ExecuteNonQuery();
                conn.Close();

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    Load_tacgia(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
        }
    }
  }
