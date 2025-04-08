using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_CSharp.BusinessLogicLayer;
using Project_CSharp.DataAccessLayer;
using Project_CSharp.Forms.Dialog;
using Project_CSharp.Models;

namespace Project_CSharp.Forms
{
    public partial class FormLopHoc : Form
    {
        private LopHocBLL lopHocBll = new LopHocBLL();
        private KhoaHocBLL khoaHocBLL= new KhoaHocBLL();
        private KhoaBLL khoaBLL = new KhoaBLL();
        private NganhHocBLL nganhHocBLL = new NganhHocBLL();
        private LopHocBLL lopHocBLL = new LopHocBLL();
        public FormLopHoc()
        {
            InitializeComponent();
            LoadData();
            LoadComboBoxData();
        }

        public void LoadData()
        {
            dgvLopHoc.DataSource = lopHocBll.GetAllLopHoc();
        }

        private void PerformSearch()
        {
            string msv = txtSearchMaLop.Text.Trim();
            string hoten = txtSearchHoTen.Text.Trim();

            // Kiểm tra giá trị của khoahoc, nếu là "-- Chọn Khóa học --" thì set thành rỗng
            string khoahoc = cmbSearchKhoaHoc.SelectedItem is DataRowView kh
                               && kh["tenkhoahoc"].ToString() != "-- Chọn Khóa học --"
                ? kh["tenkhoahoc"].ToString()
                : "";

            // Kiểm tra giá trị của tenlop, tenkhoa, tennganh, nếu là "-- Chọn ... --" thì set thành rỗng

            string khoa = (cmbSearchKhoa.SelectedItem is DataRowView drvKhoa &&
                           drvKhoa["tenkhoa"].ToString() != "-- Chọn Khoa --")
                ? drvKhoa["tenkhoa"].ToString()
                : "";

            string nganh = (cmbSearchNganh.SelectedItem is DataRowView drvNganh &&
                            drvNganh["tennganh"].ToString() != "-- Chọn Ngành --")
                ? drvNganh["tennganh"].ToString()
                : "";


            if (string.IsNullOrEmpty(msv) && string.IsNullOrEmpty(hoten) && string.IsNullOrEmpty(khoahoc)
                && string.IsNullOrEmpty(khoa) && string.IsNullOrEmpty(nganh))
            {
                dgvLopHoc.DataSource = lopHocBLL.GetAllLopHoc(); // Load toàn bộ danh sách lớp học
            }
            else
            {
                dgvLopHoc.DataSource = lopHocBLL.SearchLopHoc(msv, hoten, khoahoc, khoa, nganh);
            }
        }

        private void LoadComboBoxData()
        {
            // Load khóa học
            /*cmbKhoaHoc.DataSource = khoaHocBLL.GetKhoaHoc();
            cmbKhoaHoc.DisplayMember = "tenkhoahoc";
            cmbKhoaHoc.ValueMember = "idkhoahoc";
            cmbKhoaHoc.SelectedIndex = -1;*/

            // Load khóa học
            DataTable dtKhoaHoc = khoaHocBLL.GetKhoaHoc();
            DataRow newRowkh = dtKhoaHoc.NewRow();
            newRowkh["idkhoahoc"] = -1; // Giá trị null hoặc -1 để biểu thị tùy chọn mặc định
            newRowkh["tenkhoahoc"] = "-- Chọn Khóa học --";
            dtKhoaHoc.Rows.InsertAt(newRowkh, 0); // Thêm vào vị trí đầu tiên

            cmbSearchKhoaHoc.DataSource = dtKhoaHoc;
            cmbSearchKhoaHoc.DisplayMember = "tenkhoahoc";
            cmbSearchKhoaHoc.ValueMember = "idkhoahoc";
            cmbSearchKhoaHoc.SelectedIndex = 0;

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
            DialogLopHoc dialog = new DialogLopHoc();
            dialog.FormBorderStyle = FormBorderStyle.None;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LopHoc lh = dialog.LopHoc;

                bool success = lopHocBll.AddLopHoc(lh);

                if (success)
                {
                    MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();  // Hàm load lại danh sách sinh viên lên DataGridView
                }
                else
                {
                    MessageBox.Show("Thêm lớp học thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLopHoc.SelectedRows.Count > 0) // Kiểm tra xem có dòng nào được chọn không
            {
                // int i = dgvSinhVien.CurrentRow.Index;
                int idlop = Convert.ToInt32(dgvLopHoc.SelectedRows[0].Cells["idlop"].Value);

                // Lấy dữ liệu sinh viên từ BLL
                LopHoc lopHoc = lopHocBll.GetLopHocById(idlop);

                // Mở Dialog và truyền dữ liệu vào
                DialogLopHoc frm = new DialogLopHoc(lopHoc);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Lấy dữ liệu đã sửa từ Dialog
                        LopHoc lhMoi = frm.LopHoc;
                        lhMoi.IdLop = idlop;

                        // Cập nhật vào DB qua BLL
                        bool result = lopHocBll.UpdateLopHoc(lhMoi);

                        if (result)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                            LoadData(); // Load lại danh sách
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
                MessageBox.Show("Vui lòng chọn lớp học cần sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLopHoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một lớp học để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID sinh viên từ dòng được chọn
            int idlop = Convert.ToInt32(dgvLopHoc.SelectedRows[0].Cells["idlop"].Value);

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Gọi hàm xóa sinh viên
                bool isDeleted = lopHocBll.DeleteLopHoc(idlop);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Load lại danh sách sinh viên sau khi xóa
                }
                else
                {
                    MessageBox.Show("Xóa lớp học thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearchMaLop_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void txtSearchHoTen_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void cmbSearchKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
