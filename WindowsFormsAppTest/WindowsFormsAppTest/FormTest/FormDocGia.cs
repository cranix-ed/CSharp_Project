using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest.FormTest
{
    public partial class FormDocGia : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=tacgia;User ID=sa;Password=56tfg7hj8");
        
        public FormDocGia()
        {
            InitializeComponent();
        }

        private void SearchChange()
        {
            string mdg = txtSearchMaDocGia.Text;
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
            LoadData(mdg, hoten, gioitinh, dienthoai);
        }

        private bool checkMaDocGia(String mdg)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(ma_doc_gia) FROM thongtindocgia WHERE ma_doc_gia = @ma_doc_gia";
            cmd.Parameters.AddWithValue("@ma_doc_gia", mdg);
            int count = (int)cmd.ExecuteScalar();

            if (count != 0)
            {
                return false;
            }
            return true;
        }

        private void LoadData(string mdg = "", string hoten = "", string gioitinh = "", string dienthoai = "")
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                String query = "SELECT * FROM thongtindocgia WHERE 1=1";

                if (!string.IsNullOrEmpty(mdg))
                {
                    query += " AND ma_doc_gia LIKE @ma_doc_gia";
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

                if (!string.IsNullOrEmpty(mdg))
                {
                    command.Parameters.AddWithValue("@ma_doc_gia", "%" + mdg + "%");
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

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dtgTableDocGia.DataSource = dataTable;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mdg = txtMaDocGia.Text;
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
            string dc = txtDiaChi.Text;

            // Kiểm tra nếu bất kỳ trường nào bị bỏ trống
            if (string.IsNullOrWhiteSpace(mdg) || string.IsNullOrWhiteSpace(hoten) || string.IsNullOrWhiteSpace(dt) ||
                string.IsNullOrWhiteSpace(dc) || gioitinh == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!checkMaDocGia(mdg))
            {
                MessageBox.Show("Mã tác gải đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDocGia.Focus();
                return;
            }

            // Kiểm tra số điện thoại (chỉ chứa 10 chữ số)
            if (!Regex.IsMatch(dt, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "INSERT thongtindocgia VALUES (@ma_doc_gia, @ho_ten, @gioi_tinh, @ngay_sinh, @dien_thoai, @dia_chi)";

            command.Parameters.AddWithValue("@ma_doc_gia", mdg);
            command.Parameters.AddWithValue("@ho_ten", hoten);
            command.Parameters.AddWithValue("@gioi_tinh", gioitinh);
            command.Parameters.AddWithValue("@ngay_sinh", ngs);
            command.Parameters.AddWithValue("@dien_thoai", dt);
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

            txtMaDocGia.Text = "";
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            cbGioiTinh.SelectedItem = "";
            dtpNgaySinh.Text = "";


            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void FormDocGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mdg = txtMaDocGia.Text;
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
            string dc = txtDiaChi.Text;

            // Kiểm tra nếu bất kỳ trường nào bị bỏ trống
            if (string.IsNullOrWhiteSpace(mdg) || string.IsNullOrWhiteSpace(hoten) || string.IsNullOrWhiteSpace(dt) ||
                string.IsNullOrWhiteSpace(dc) || gioitinh == null)
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


            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "UPDATE thongtindocgia SET ho_ten = @ho_ten, gioi_tinh = @gioi_tinh, ngay_sinh = @ngay_sinh, dien_thoai = @dien_thoai, dia_chi = @dia_chi WHERE ma_doc_gia = @ma_doc_gia";

            command.Parameters.AddWithValue("@ma_doc_gia", mdg);
            command.Parameters.AddWithValue("@ho_ten", hoten);
            command.Parameters.AddWithValue("@gioi_tinh", gioitinh);
            command.Parameters.AddWithValue("@ngay_sinh", ngs);
            command.Parameters.AddWithValue("@dien_thoai", dt);
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

            txtMaDocGia.Text = "";
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            cbGioiTinh.SelectedItem = "";
            dtpNgaySinh.Text = "";

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = dtgTableDocGia.CurrentRow.Index;
            String mdg = dtgTableDocGia.Rows[i].Cells["ma_doc_gia"].Value.ToString();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "DELETE FROM thongtindocgia WHERE ma_doc_gia = @ma_doc_gia";

            command.Parameters.AddWithValue("@ma_doc_gia", mdg);
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

        private void dtgTableDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaDocGia.Enabled = false;
            txtMaDocGia.Text = dtgTableDocGia.Rows[i].Cells["ma_doc_gia"].Value.ToString();
            txtHoTen.Text = dtgTableDocGia.Rows[i].Cells["ho_ten"].Value.ToString();
            cbGioiTinh.SelectedItem = dtgTableDocGia.Rows[i].Cells["gioi_tinh"].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dtgTableDocGia.Rows[i].Cells["ngay_sinh"].Value.ToString());
            txtDienThoai.Text = dtgTableDocGia.Rows[i].Cells["dien_thoai"].Value.ToString();
            txtDiaChi.Text = dtgTableDocGia.Rows[i].Cells["dia_chi"].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearchMaDocGia_TextChanged(object sender, EventArgs e)
        {
            SearchChange();
        }

        private void cbSearchGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchChange();
        }

        private void txtSearchHoTen_TextChanged(object sender, EventArgs e)
        {
            SearchChange();
        }

        private void txtSearchSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            SearchChange();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchChange();
        }
    }
}
