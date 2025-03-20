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
using WindowsFormsAppTest.Helpers;

namespace WindowsFormsAppTest.FormTest
{
    public partial class FormKiemTra : Form
    {
        private static string con = "Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=tacgia;User ID=sa;Password=56tfg7hj8";
        DatabaseHelper dbHelper = new DatabaseHelper(con);
        CheckInputHelper CheckInputHelper = new CheckInputHelper();
        private static string tableSanPham = "sanpham";
        private static string tableNCC = "nhacungcap";


        public FormKiemTra()
        {
            InitializeComponent();
        }

        private void ClearInputs()
        {
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtGia.Text = "";
            txtSoLuong.Text = "";
        }

        private void Load_NhaCungCap()
        {
            dbHelper.LoadComboBox(cbNhaCungCap, tableNCC, "ten_nha_cung_cap", "ma_nha_cung_cap");
        }

        private void Load_SearchNhaCungCap()
        {
            dbHelper.LoadComboBox(cbSearchNhaCungCap, tableNCC, "ten_nha_cung_cap", "ma_nha_cung_cap");
        }

        private void LoadData()
        {
            string joinQuery = "LEFT JOIN nhacungcap ncc ON sp.ma_nha_cung_cap = ncc.ma_nha_cung_cap";

            dbHelper.LoadDataToDataGridView(dtgTableSanPham, "sanpham sp", "sp.* , ncc.ten_nha_cung_cap", joinQuery);
        }

        private void SearchChange()
        {
            Dictionary<string, string> filters = new Dictionary<string, string>
            {
                { "ma_san_pham", txtSearchMaSanPham.Text },
                { "ten_san_pham", txtSearchTenSanPham.Text },
                { "ma_nha_cung_cap", cbSearchNhaCungCap.SelectedValue?.ToString() ?? "" },
                { "so_luong", txtSearchSoLuong.Text },
                
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
            string joinQuery = "LEFT JOIN nhacungcap ncc ON sp.ma_nha_cung_cap = ncc.ma_nha_cung_cap";

            dbHelper.LoadDataToDataGridView(dtgTableSanPham, "sanpham sp", "sp.* , ncc.ten_nha_cung_cap", joinQuery, whereClause, parameters.ToArray());
        }

        private void FormKiemTra_Load(object sender, EventArgs e)
        {
            Load_NhaCungCap();
            Load_SearchNhaCungCap();
            LoadData();
            btnLuu.Enabled= false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string msp = txtMaSanPham.Text;
            string tensp = txtTenSanPham.Text;
            string gia = txtGia.Text;
            int soluong = int.Parse(txtSoLuong.Text);
            string mancc = cbNhaCungCap.SelectedValue.ToString();

            Dictionary<string, object> condition = new Dictionary<string, object>
            {
                { "ma_san_pham", msp }
            };

            if (CheckInputHelper.IsEmpty(msp, "Mã sản phẩm") ||
                CheckInputHelper.IsEmpty(tensp, "Tên sản phẩm") ||
                soluong > 100 ||
                dbHelper.CheckExists(tableSanPham, condition, "Mã sản phẩm"))
            {
                return;
            }

            Dictionary<string, object> data = new Dictionary<string, object>
            {
                { "ma_san_pham", msp },
                { "ten_san_pham", tensp },
                { "gia", gia },
                { "so_luong", soluong },
                { "ma_nha_cung_cap", mancc }
            };

            if (dbHelper.InsertData(tableSanPham, data))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
            }

            ClearInputs();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string msp = txtMaSanPham.Text;
            string tensp = txtTenSanPham.Text;
            string gia = txtGia.Text;
            int soluong = int.Parse(txtSoLuong.Text);
            string mancc = cbNhaCungCap.SelectedValue.ToString();

            Dictionary<string, object> condition = new Dictionary<string, object>
            {
                { "ma_san_pham", msp }
            };

            if (CheckInputHelper.IsEmpty(tensp, "Tên sản phẩm") ||
                soluong > 100
                )
            {
                return;
            }

            Dictionary<string, object> data = new Dictionary<string, object>
            { 
                { "ten_san_pham", tensp },
                { "gia", gia },
                { "so_luong", soluong },
                { "ma_nha_cung_cap", mancc }
            };

            string whereClause = "ma_san_pham = @ma_san_pham";
            SqlParameter param = new SqlParameter("@ma_san_pham", msp);

            if (dbHelper.UpdateData(tableSanPham, data, whereClause, param))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }

            ClearInputs();
            txtMaSanPham.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgTableSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int i = dtgTableSanPham.CurrentRow.Index;
            String msp = dtgTableSanPham.Rows[i].Cells["ma_san_pham"].Value.ToString();

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string whereClause = "ma_san_pham = @ma_san_pham";
                SqlParameter param = new SqlParameter("@ma_san_pham", msp);

                if (dbHelper.DeleteData(tableSanPham, whereClause, param))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }

                ClearInputs();
            }
        }

        private void dtgTableSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            txtMaSanPham.Text = dtgTableSanPham.Rows[i].Cells["ma_san_pham"].Value.ToString();
            txtTenSanPham.Text = dtgTableSanPham.Rows[i].Cells["ten_san_pham"].Value.ToString();
            cbNhaCungCap.SelectedValue = dtgTableSanPham.Rows[i].Cells["ma_nha_cung_cap"].Value.ToString();
            txtGia.Text = dtgTableSanPham.Rows[i].Cells["gia"].Value.ToString();
            txtSoLuong.Text = dtgTableSanPham.Rows[i].Cells["so_luong"].Value.ToString();

            txtMaSanPham.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void txtSearchMaSanPham_TextChanged(object sender, EventArgs e)
        {
            SearchChange();
        }

        private void txtSearchTenSanPham_TextChanged(object sender, EventArgs e)
        {
            SearchChange();
        }

        private void txtSearchSoLuong_TextChanged(object sender, EventArgs e)
        {
            SearchChange();
        }

        private void cbSearchNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchChange();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaSanPham.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
