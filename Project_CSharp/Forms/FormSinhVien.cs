using Project_CSharp.BusinessLogicLayer;
using Project_CSharp.DataAccessLayer;
using Project_CSharp.Forms.Dialog;
using Project_CSharp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CSharp.Forms
{
    public partial class FormSinhVien : Form
    {
        SinhVienBLL sinhVienBLL = new SinhVienBLL();
        private KhoaBLL khoaBLL = new KhoaBLL();
        private NganhHocBLL nganhHocBLL = new NganhHocBLL();
        private LopHocBLL lopHocBLL = new LopHocBLL();

        public FormSinhVien()
        {
            InitializeComponent();

            LoadComboBoxData();
        }

        private void LoadData()
        {
            dgvSinhVien.DataSource = sinhVienBLL.GetAllSinhVien();
        }

        private void PerformSearch()
        {
            string msv = txtSearchMaSinhVien.Text.Trim();
            string hoten = txtSearchHoTen.Text.Trim();

            // Kiểm tra giá trị của gioitinh, nếu là "-- Chọn Giới Tính --" thì set thành rỗng
            string gioitinh = (cmbSearchGioiTinh.SelectedItem is string gt && gt != "-- Chọn Giới Tính --")
                ? gt
                : "";

            // Kiểm tra giá trị của tenlop, tenkhoa, tennganh, nếu là "-- Chọn ... --" thì set thành rỗng
            string lop = (cmbSearchLop.SelectedItem is DataRowView drvLop &&
                          drvLop["malop"].ToString() != "-- Chọn Lớp --")
                ? drvLop["malop"].ToString()
                : "";

            string khoa = (cmbSearchKhoa.SelectedItem is DataRowView drvKhoa &&
                           drvKhoa["tenkhoa"].ToString() != "-- Chọn Khoa --")
                ? drvKhoa["tenkhoa"].ToString()
                : "";

            string nganh = (cmbSearchNganh.SelectedItem is DataRowView drvNganh &&
                            drvNganh["tennganh"].ToString() != "-- Chọn Ngành --")
                ? drvNganh["tennganh"].ToString()
                : "";


            if (string.IsNullOrEmpty(msv) && string.IsNullOrEmpty(hoten) && string.IsNullOrEmpty(gioitinh)
                && string.IsNullOrEmpty(lop) && string.IsNullOrEmpty(khoa) && string.IsNullOrEmpty(nganh))
            {
                dgvSinhVien.DataSource = sinhVienBLL.GetAllSinhVien(); // Load toàn bộ danh sách sinh viên
            }
            else
            {
                dgvSinhVien.DataSource = sinhVienBLL.SearchSinhVien(msv, hoten, gioitinh, lop, khoa, nganh);
            }
        }

        private void LoadComboBoxData()
        {
            // Load khóa học
            /*cmbKhoaHoc.DataSource = khoaHocBLL.GetKhoaHoc();
            cmbKhoaHoc.DisplayMember = "tenkhoahoc";
            cmbKhoaHoc.ValueMember = "idkhoahoc";
            cmbKhoaHoc.SelectedIndex = -1;*/
            cmbSearchGioiTinh.Text = "-- Chọn Giới Tính --";
            // Load khoa
            DataTable dtKhoa = khoaBLL.GetKhoa();
            DataRow newRow = dtKhoa.NewRow();
            newRow["idkhoa"] = -1; // Giá trị null hoặc -1 để biểu thị tùy chọn mặc định
            newRow["tenkhoa"] = "-- Chọn Khoa --";
            dtKhoa.Rows.InsertAt(newRow, 0); // Thêm vào vị trí đầu tiên

            cmbSearchKhoa.DataSource = dtKhoa;
            cmbSearchKhoa.DisplayMember = "tenkhoa";
            cmbSearchKhoa.ValueMember = "idkhoa";
            cmbSearchKhoa.SelectedIndex = 0;


            DataTable dtLop = lopHocBLL.GetLopHoc();
            DataRow newRowlh = dtLop.NewRow();
            newRowlh["idlop"] = -1; // Giá trị null hoặc -1 để biểu thị tùy chọn mặc định
            newRowlh["malop"] = "-- Chọn Lớp --";
            dtLop.Rows.InsertAt(newRowlh, 0); // Thêm vào vị trí đầu tiên

            cmbSearchLop.DataSource = dtLop;
            cmbSearchLop.DisplayMember = "malop";
            cmbSearchLop.ValueMember = "idlop";
            cmbSearchLop.SelectedIndex = 0;

            // Gán sự kiện khi chọn khoa
            cmbSearchKhoa.SelectedIndexChanged += cmbKhoa_SelectedIndexChanged;

            // Load ngành học ban đầu (không chọn khoa nào)
            LoadNganhHoc(null);
        }

        // Hàm load ngành học theo khoa được chọn
        private void LoadNganhHoc(int? idKhoa)
        {
            DataTable dtNganh = nganhHocBLL.GetNganhHocByKhoa(idKhoa);
            DataRow newRow = dtNganh.NewRow();
            newRow["idnganh"] = DBNull.Value; // Giá trị null hoặc -1 để biểu thị tùy chọn mặc định
            newRow["tennganh"] = "-- Chọn Ngành --";
            dtNganh.Rows.InsertAt(newRow, 0); // Thêm vào vị trí đầu tiên
            if (idKhoa.HasValue)
            {
                cmbSearchNganh.DataSource = dtNganh;
            }
            else
            {
                cmbSearchNganh.DataSource = null; // Không load dữ liệu khi chưa chọn khoa
            }

            cmbSearchNganh.DisplayMember = "tennganh";
            cmbSearchNganh.ValueMember = "idnganh";
            cmbSearchNganh.SelectedIndex = -1;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchKhoa.SelectedValue != null)
            {
                int idKhoa;
                if (!int.TryParse(cmbSearchKhoa.SelectedValue?.ToString(), out idKhoa))
                {
                    idKhoa = 0; // Giá trị mặc định khi không thể chuyển đổi
                }

                LoadNganhHoc(idKhoa);
            }
            else
            {
                LoadNganhHoc(null); // Không chọn khoa -> không load ngành học
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            DialogSinhVien frm = new DialogSinhVien(); // Mở form với dữ liệu trống
            frm.FormBorderStyle = FormBorderStyle.None;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SinhVien svMoi = frm.GetSinhVien(); // Lấy dữ liệu từ dialog

                    // Gửi dữ liệu mới vào DB
                    bool result = sinhVienBLL.AddSinhVien(svMoi);

                    if (result)
                    {
                        MessageBox.Show("Thêm mới sinh viên thành công!");
                        LoadData(); // Load lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thêm mới.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                int idSinhVien = Convert.ToInt32(dgvSinhVien.SelectedRows[0].Cells["idsinhvien"].Value);
                SinhVien sinhVien = sinhVienBLL.GetSinhVienById(idSinhVien);

                DialogSinhVien frm = new DialogSinhVien(sinhVien);
                frm.FormBorderStyle = FormBorderStyle.None;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        SinhVien svMoi = frm.GetSinhVien();
                        svMoi.IdSinhVien = idSinhVien;

                        bool result = sinhVienBLL.UpdateSinhVien(svMoi);

                        if (result)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra khi cập nhật.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID sinh viên từ dòng được chọn
            int idSinhVien = Convert.ToInt32(dgvSinhVien.SelectedRows[0].Cells["idsinhvien"].Value);

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Gọi hàm xóa sinh viên
                bool isDeleted = sinhVienBLL.DeleteSinhVien(idSinhVien);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadData(); // Load lại danh sách sinh viên sau khi xóa
                }
                else
                {
                    MessageBox.Show("Xóa sinh viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearchMaSinhVien_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void txtSearchHoTen_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void cmbSearchGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void cmbSearchLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void cmbSearchKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void cmbSearchNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnNhapFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx;*.csv",
                Title = "Chọn file Excel"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                sinhVienBLL.ImportFromExcel(filePath);
                MessageBox.Show("Nhập dữ liệu từ Excel thành công!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            sinhVienBLL.ExportToExcel(dgvSinhVien);
        }
    }
}