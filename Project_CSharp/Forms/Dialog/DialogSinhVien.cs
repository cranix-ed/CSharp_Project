using Project_CSharp.BusinessLogicLayer;
using Project_CSharp.DataAccessLayer;
using Project_CSharp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CSharp.Forms.Dialog
{
    public partial class DialogSinhVien : Form
    {
        public SinhVien SinhVien { get; private set; }
        private KhoaHocBLL khoaHocBLL = new KhoaHocBLL();
        private KhoaBLL khoaBLL = new KhoaBLL();
        private NganhHocBLL nganhHocBLL = new NganhHocBLL();

        private SinhVien sinhVien;
        public DialogSinhVien(SinhVien sv = null)
        {
            InitializeComponent();

            LoadComboBoxData();

            sinhVien = sv;

            if (sinhVien != null) // Nếu có dữ liệu, hiển thị lên form
            {
                txtHoTen.Text = sinhVien.HoTen;
                dtpNgaySinh.Value = sinhVien.NgaySinh;
                cmbGioiTinh.SelectedItem = sinhVien.GioiTinh;
                txtDiaChi.Text = sinhVien.DiaChi;
                txtSoDienThoai.Text = sinhVien.SoDienThoai;
                txtEmail.Text = sinhVien.Email;
                cmbKhoaHoc.SelectedValue = sinhVien.IdKhoaHoc;
                cmbKhoa.SelectedValue = sinhVien.IdKhoa;
                cmbNganh.SelectedValue = sinhVien.IdNganh;
                dtpNgayNhapHoc.Value = sinhVien.NgayNhapHoc;
            }
        }

        public SinhVien GetSinhVien()
        {
            return new SinhVien
            {
                IdSinhVien = (int)(sinhVien?.IdSinhVien), // Giữ nguyên ID khi sửa
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cmbGioiTinh.SelectedItem.ToString(),
                DiaChi = txtDiaChi.Text,
                SoDienThoai = txtSoDienThoai.Text,
                Email = txtEmail.Text,
                IdKhoaHoc = Convert.ToInt32(cmbKhoaHoc.SelectedValue),
                IdKhoa = Convert.ToInt32(cmbKhoa.SelectedValue),
                IdNganh = Convert.ToInt32(cmbNganh.SelectedValue),
                NgayNhapHoc = dtpNgayNhapHoc.Value
            };
        }

        private void LoadComboBoxData()
        {
            // Load khóa học
            cmbKhoaHoc.DataSource = khoaHocBLL.GetKhoaHoc();
            cmbKhoaHoc.DisplayMember = "tenkhoahoc";
            cmbKhoaHoc.ValueMember = "idkhoahoc";
            cmbKhoaHoc.SelectedIndex = -1;

            // Load khoa
            cmbKhoa.DataSource = khoaBLL.GetKhoa();
            cmbKhoa.DisplayMember = "tenkhoa";
            cmbKhoa.ValueMember = "idkhoa";
            cmbKhoa.SelectedIndex = -1;

            // Gán sự kiện khi chọn khoa
            cmbKhoa.SelectedIndexChanged += cmbKhoa_SelectedIndexChanged;

            // Load ngành học ban đầu (không chọn khoa nào)
            LoadNganhHoc(null);
        }

        // Hàm load ngành học theo khoa được chọn
        private void LoadNganhHoc(int? idKhoa)
        {
            if (idKhoa.HasValue)
            {
                DataTable dt = nganhHocBLL.GetNganhHocByKhoa(idKhoa);
                cmbNganh.DataSource = dt;
            }
            else
            {
                cmbNganh.DataSource = null; // Không load dữ liệu khi chưa chọn khoa
            }
            cmbNganh.DisplayMember = "tennganh";
            cmbNganh.ValueMember = "idnganh";
            cmbNganh.SelectedIndex = -1;
        }

        // Sự kiện khi thay đổi khoa -> load ngành học tương ứng
        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
            {
                int idKhoa = Convert.ToInt32(cmbKhoa.SelectedValue);
                LoadNganhHoc(idKhoa);
            }
            else
            {
                LoadNganhHoc(null); // Không chọn khoa -> không load ngành học
            }
        }


        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateTime.TryParseExact(dtpNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ! Định dạng đúng: dd/MM/yyyy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtSoDienThoai.Text) && !Regex.IsMatch(txtSoDienThoai.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            if (sinhVien == null) // Nếu là thêm mới
            {
                sinhVien = new SinhVien();
            }

            // Gán giá trị từ form vào đối tượng sinhVien
            sinhVien.HoTen = txtHoTen.Text;
            sinhVien.NgaySinh = DateTime.ParseExact(dtpNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            sinhVien.GioiTinh = cmbGioiTinh.SelectedItem?.ToString();
            sinhVien.DiaChi = txtDiaChi.Text;
            sinhVien.SoDienThoai = txtSoDienThoai.Text;
            sinhVien.Email = txtEmail.Text;
            sinhVien.IdKhoaHoc = cmbKhoaHoc.SelectedValue != null ? (int)cmbKhoaHoc.SelectedValue : (int?)null;
            sinhVien.IdKhoa = cmbKhoa.SelectedValue != null ? (int)cmbKhoa.SelectedValue : (int?)null;
            sinhVien.IdNganh = cmbNganh.SelectedValue != null ? (int)cmbNganh.SelectedValue : (int?)null;
            sinhVien.NgayNhapHoc = dtpNgayNhapHoc.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DialogSinhVien_Load(object sender, EventArgs e)
        {
        }
    }
}
