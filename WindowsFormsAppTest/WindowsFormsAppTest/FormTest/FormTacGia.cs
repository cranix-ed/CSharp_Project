using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsAppTest.FormTest
{
    public partial class FormTacGia : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=tacgia;User ID=sa;Password=56tfg7hj8");
        public FormTacGia()
        {
            InitializeComponent();
        }

        private bool checkMaTacGia(String mtg)
        {
            if(con.State != ConnectionState.Open)
            {
                con.Open(); 
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(ma_tac_gia) FROM thongtintacgia WHERE ma_tac_gia = @ma_tac_gia";
            cmd.Parameters.AddWithValue("@ma_tac_gia", mtg);
            int count = (int)cmd.ExecuteScalar();

            if(count != 0)
            {
                return false;
            }
            return true;
        }
        private void LoadData(string mtg="", string hoten="", string gioitinh="", string dienthoai="")
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                String query = "SELECT * FROM thongtintacgia WHERE 1=1";

                if (!string.IsNullOrEmpty(mtg))
                {
                    query += " AND ma_tac_gia LIKE @ma_tac_gia";
                }
                if (!string.IsNullOrEmpty(hoten))
                {
                    query += " AND ho_ten LIKE @ho_ten";
                }
                if (!string.IsNullOrEmpty(gioitinh))
                {
                    query += " AND gioi_tinh LIKE @gioi_tinh";
                }
                if (!string.IsNullOrEmpty(dienthoai))
                {
                    query += " AND dien_thoai LIKE @dien_thoai";
                }

                SqlCommand command = new SqlCommand(query, con);

                if (!string.IsNullOrEmpty(mtg))
                {
                    command.Parameters.AddWithValue("@ma_tac_gia", "%" + mtg + "%");
                }
                if (!string.IsNullOrEmpty(hoten))
                {
                    command.Parameters.AddWithValue("@ho_ten", "%" + hoten + "%");
                }
                if (!string.IsNullOrEmpty(gioitinh))
                {
                    command.Parameters.AddWithValue("@gioi_tinh", "%" + gioitinh + "%");
                }
                if (!string.IsNullOrEmpty(dienthoai))
                {
                    command.Parameters.AddWithValue("@dien_thoai", "%" + dienthoai + "%");
                }

                SqlDataAdapter adapter= new SqlDataAdapter(command);
                DataTable dataTable= new DataTable();
                adapter.Fill(dataTable);

                dtgTableTacGia.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void FormTacGia_Load(object sender, EventArgs e)
        {
           LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string mtg = txtMaTacGia.Text;
                string hoten = txtHoTen.Text;
                String gioitinh;
                if (cbGioiTinh.SelectedItem == null)
                {
                    gioitinh = "";
                }
                else
                {
                    gioitinh = cbGioiTinh.SelectedItem.ToString();
                }
                DateTime ngs = dtpNgaySinh.Value;
                string dt = txtDienThoai.Text;
                string email = txtEmail.Text;
                string dc = txtDiaChi.Text;

                // Kiểm tra nếu bất kỳ trường nào bị bỏ trống
                if (string.IsNullOrWhiteSpace(mtg) || string.IsNullOrWhiteSpace(hoten) || string.IsNullOrWhiteSpace(dt) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(dc) || gioitinh == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(!checkMaTacGia(mtg))
                {
                    MessageBox.Show("Mã tác gải đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaTacGia.Focus();
                }

                // Kiểm tra số điện thoại (chỉ chứa 10 chữ số)
                if (!Regex.IsMatch(dt, @"^\d{10}$"))
                {
                    MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra email đúng định dạng
                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "INSERT thongtintacgia VALUES (@ma_tac_gia, @ho_ten, @gioi_tinh, @ngay_sinh, @dien_thoai, @email, @dia_chi)";

                command.Parameters.AddWithValue("@ma_tac_gia", mtg);
                command.Parameters.AddWithValue("@ho_ten", hoten);
                command.Parameters.AddWithValue("@gioi_tinh", gioitinh);
                command.Parameters.AddWithValue("@ngay_sinh", ngs);
                command.Parameters.AddWithValue("@dien_thoai", dt);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@dia_chi", dc);

                int rowsAffected = command.ExecuteNonQuery(); // Sử dụng ExecuteNonQuery() 

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại, không có dữ liệu được lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String mtg = txtSearchMaTacGia.Text;
            String hoten = txtSearchHoTen.Text;
            String gioitinh;
            if(cbSearchGioiTinh.SelectedItem == null)
            {
                gioitinh = "";
            } else
            {
                gioitinh = cbSearchGioiTinh.SelectedItem.ToString();
            }
            String dienthoai = txtSearchSoDienThoai.Text;

            LoadData(mtg, hoten, gioitinh, dienthoai);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mtg = txtMaTacGia.Text;
            string hoten = txtHoTen.Text;
            string gt = cbGioiTinh.SelectedItem.ToString();
            DateTime ngs = dtpNgaySinh.Value;
            string dt = txtDienThoai.Text;
            string email = txtEmail.Text;
            string dc = txtDiaChi.Text;

            if (string.IsNullOrWhiteSpace(mtg) || string.IsNullOrWhiteSpace(hoten) || string.IsNullOrWhiteSpace(dt) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(dc) || gt == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số điện thoại (chỉ chứa 10 chữ số)
            if (!Regex.IsMatch(dt, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra email đúng định dạng
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "UPDATE thongtintacgia SET ho_ten = @ho_ten, gioi_tinh = @gioi_tinh, ngay_sinh = @ngay_sinh, dien_thoai = @dien_thoai, email = @email, dia_chi = @dia_chi WHERE ma_tac_gia = @ma_tac_gia";

            command.Parameters.AddWithValue("@ma_tac_gia", mtg);
            command.Parameters.AddWithValue("@ho_ten", hoten);
            command.Parameters.AddWithValue("@gioi_tinh", gt);
            command.Parameters.AddWithValue("@ngay_sinh", ngs);
            command.Parameters.AddWithValue("@dien_thoai", dt);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@dia_chi", dc);

            int rowsAffected = command.ExecuteNonQuery(); // Sử dụng ExecuteNonQuery() 

            if (rowsAffected > 0)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa thất bại, không có dữ liệu được lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void dtgTableTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaTacGia.Enabled = false;
            txtMaTacGia.Text = dtgTableTacGia.Rows[i].Cells["ma_tac_gia"].Value.ToString();
            txtHoTen.Text = dtgTableTacGia.Rows[i].Cells["ho_ten"].Value.ToString();
            cbGioiTinh.SelectedItem = dtgTableTacGia.Rows[i].Cells["gioi_tinh"].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dtgTableTacGia.Rows[i].Cells["ngay_sinh"].Value.ToString());
            txtDienThoai.Text = dtgTableTacGia.Rows[i].Cells["dien_thoai"].Value.ToString();
            txtEmail.Text = dtgTableTacGia.Rows[i].Cells["email"].Value.ToString();
            txtDiaChi.Text = dtgTableTacGia.Rows[i].Cells["dia_chi"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = dtgTableTacGia.CurrentRow.Index;
            String mtg = dtgTableTacGia.Rows[i].Cells["ma_tac_gia"].Value.ToString();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "DELETE FROM thongtintacgia WHERE ma_tac_gia = @ma_tac_gia";

            command.Parameters.AddWithValue("@ma_tac_gia", mtg);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại, không có dữ liệu được lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearchMaTacGia_TextChanged(object sender, EventArgs e)
        {
            string mtg = txtSearchMaTacGia.Text;
            string hoten = txtSearchHoTen.Text;
            String gioitinh;
            if (cbSearchGioiTinh.SelectedItem == null)
            {
                gioitinh = "";
            }
            else
            {
                gioitinh = cbSearchGioiTinh.SelectedItem.ToString();
            }
            string dienthoai = txtSearchSoDienThoai.Text;
            LoadData(mtg, hoten, gioitinh, dienthoai);
        }

        private void txtSearchHoTen_TextChanged(object sender, EventArgs e)
        {
            string mtg = txtSearchMaTacGia.Text;
            string hoten = txtSearchHoTen.Text;
            String gioitinh;
            if (cbSearchGioiTinh.SelectedItem == null)
            {
                gioitinh = "";
            }
            else
            {
                gioitinh = cbSearchGioiTinh.SelectedItem.ToString();
            }
            string dienthoai = txtSearchSoDienThoai.Text;
            LoadData(mtg, hoten, gioitinh, dienthoai);
        }

        private void cbSearchGioiTinh_SelectedValueChanged(object sender, EventArgs e)
        {
            string mtg = txtSearchMaTacGia.Text;
            string hoten = txtSearchHoTen.Text;
            String gioitinh;
            if (cbSearchGioiTinh.SelectedItem == null)
            {
                gioitinh = "";
            }
            else
            {
                gioitinh = cbSearchGioiTinh.SelectedItem.ToString();
            }
            string dienthoai = txtSearchSoDienThoai.Text;
            LoadData(mtg, hoten, gioitinh, dienthoai);
        }

        private void txtSearchSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            string mtg = txtSearchMaTacGia.Text;
            string hoten = txtSearchHoTen.Text;
            String gioitinh;
            if (cbSearchGioiTinh.SelectedItem == null)
            {
                gioitinh = "";
            }
            else
            {
                gioitinh = cbSearchGioiTinh.SelectedItem.ToString();
            }
            string dienthoai = txtSearchSoDienThoai.Text;
            LoadData(mtg, hoten, gioitinh, dienthoai);
        }
    }
}
