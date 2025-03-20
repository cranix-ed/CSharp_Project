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
using WindowsFormsAppTest.Helpers;

namespace WindowsFormsAppTest.FormTest
{
    public partial class FormCBSinhVien : Form
    {
        private static string con = "Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=tacgia;User ID=sa;Password=56tfg7hj8";
        DatabaseHelper dbHelper = new DatabaseHelper(con);
        CheckInputHelper CheckInputHelper = new CheckInputHelper();
        private static string tableName = "sinhvien";

        public FormCBSinhVien()
        {
            InitializeComponent();
        }

        private void ClearInputs()
        {
            txtMaSinhVien.Text = "";
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            cbGioiTinh.SelectedItem = "";
            dtpNgaySinh.Value = DateTime.Today;
        }


        private void SearchChange()
        {
            Dictionary<string, string> filters = new Dictionary<string, string>
            {
                { "ma_sinh_vien", txtSearchMaSinhVien.Text },
                { "ten_sinh_vien", txtSearchTenSinhVien.Text },
                { "gioi_tinh", cbSearchGioiTinh.SelectedItem?.ToString() ?? "" },
                { "dien_thoai", txtSearchSoDienThoai.Text },
                { "ma_lop", cbSearchLophoc.SelectedValue?.ToString() ?? "" }
            };

            string whereClause = "1=1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            foreach (var filter in filters)
            {
                if (!string.IsNullOrEmpty(filter.Value))
                {
                    whereClause += $" AND {filter.Key} LIKE @{filter.Key}";
                    parameters.Add(new SqlParameter($"@{filter.Key}", "%" + filter.Value + "%"));
                }
            }

            dbHelper.LoadDataToDataGridView(dtgTableDocGia, tableName, "*", "", whereClause, parameters.ToArray());
        }

        private void Load_LopHoc()
        {
            dbHelper.LoadComboBox(cbLophoc, "lophoc", "ten_lop", "ma_lop");
        }

        private void Load_SearchLopHoc()
        {
            dbHelper.LoadComboBox(cbSearchLophoc, "lophoc", "ten_lop", "ma_lop");
        }

        private void LoadData()
        {
            string joinQuery = "LEFT JOIN lophoc l ON sv.ma_lop = l.ma_lop";

            dbHelper.LoadDataToDataGridView(dtgTableDocGia, "sinhvien sv", "sv.* , l.ten_lop", joinQuery);
        }

        private void FormCBSinhVien_Load(object sender, EventArgs e)
        {
            Load_LopHoc();
            Load_SearchLopHoc();
            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string msv = txtMaSinhVien.Text;
            string hoten = txtHoTen.Text;
            string gioitinh = cbGioiTinh.SelectedItem?.ToString() ?? "";
            DateTime ngs = dtpNgaySinh.Value;
            string dt = txtDienThoai.Text;
            string dc = txtDiaChi.Text;
            string malop = cbLophoc.SelectedValue?.ToString() ?? "";

            Dictionary<string, object> condition = new Dictionary<string, object>
            {
                { "ma_sinh_vien", msv },
                { "dien_thoai", dt }

            };

            if (CheckInputHelper.IsEmpty(msv, "Mã sinh viên") ||
                CheckInputHelper.IsEmpty(hoten, "Tên sinh viên") ||
                !CheckInputHelper.CheckPhoneNumber(dt) ||
                dbHelper.CheckExists(tableName, condition, "Mã sinh viên hoặc Số điện thoại"))
            {
                return;
            }
            
            

            Dictionary<string, object> data = new Dictionary<string, object>
            {
                { "ma_sinh_vien", msv },
                { "ten_sinh_vien", hoten },
                { "gioi_tinh", gioitinh },
                { "ngay_sinh", ngs },
                { "dien_thoai", dt },
                { "dia_chi", dc },
                { "ma_lop", malop },
            };

            if (dbHelper.InsertData(tableName, data))
            {
                MessageBox.Show("Thêm thành công!");
                dbHelper.LoadDataToDataGridView(dtgTableDocGia, tableName);
            }

            ClearInputs();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string msv = txtMaSinhVien.Text;
            string hoten = txtHoTen.Text;
            string gioitinh = cbGioiTinh.SelectedItem?.ToString() ?? "";
            DateTime ngs = dtpNgaySinh.Value;
            string dt = txtDienThoai.Text;
            string dc = txtDiaChi.Text;
            string malop = cbLophoc.SelectedValue?.ToString() ?? "";

            if (CheckInputHelper.IsEmpty(hoten, "Tên sinh viên") ||
                !CheckInputHelper.CheckPhoneNumber(dt))
            {
                return;
            }

            Dictionary<string, object> data = new Dictionary<string, object>
            {
                { "ten_sinh_vien", hoten },
                { "gioi_tinh", gioitinh },
                { "ngay_sinh", ngs },
                { "dien_thoai", dt },
                { "dia_chi", dc },
                { "ma_lop", malop },
            };

            string whereClause = "ma_sinh_vien = @ma_sinh_vien";
            SqlParameter param = new SqlParameter("@ma_sinh_vien", msv);

            if (dbHelper.UpdateData(tableName, data, whereClause, param))
            {
                MessageBox.Show("Cập nhật thành công!");
                dbHelper.LoadDataToDataGridView(dtgTableDocGia, tableName);
            }

            ClearInputs();
            txtMaSinhVien.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgTableDocGia.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int i = dtgTableDocGia.CurrentRow.Index;
            String msv = dtgTableDocGia.Rows[i].Cells["ma_sinh_vien"].Value.ToString();

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string whereClause = "ma_sinh_vien = @ma_sinh_vien";
                SqlParameter param = new SqlParameter("@ma_sinh_vien", msv);

                if (dbHelper.DeleteData(tableName, whereClause, param))
                {
                    MessageBox.Show("Xóa thành công!");
                    dbHelper.LoadDataToDataGridView(dtgTableDocGia, tableName);
                }

            ClearInputs();
            }
        }

        private void dtgTableDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == 0) return;
            txtMaSinhVien.Enabled = false;
            txtMaSinhVien.Text = dtgTableDocGia.Rows[i].Cells["ma_sinh_vien"].Value.ToString();
            txtHoTen.Text = dtgTableDocGia.Rows[i].Cells["ten_sinh_vien"].Value.ToString();
            cbGioiTinh.SelectedItem = dtgTableDocGia.Rows[i].Cells["gioi_tinh"].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dtgTableDocGia.Rows[i].Cells["ngay_sinh"].Value.ToString());
            txtDienThoai.Text = dtgTableDocGia.Rows[i].Cells["dien_thoai"].Value.ToString();
            txtDiaChi.Text = dtgTableDocGia.Rows[i].Cells["dia_chi"].Value.ToString();
            cbLophoc.SelectedValue = dtgTableDocGia.Rows[i].Cells["ma_lop"].Value.ToString();
        }

        private void txtSearchtxtMaSinhVien_TextChanged(object sender, EventArgs e)
        {
            SearchChange();
        }

        private void txtSearchTenSinhVien_TextChanged(object sender, EventArgs e)
        {
            SearchChange();
        }

        private void cbSearchGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchChange();
        }

        private void txtSearchSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            SearchChange();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbSearchLophoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchChange();
        }
    }
}
