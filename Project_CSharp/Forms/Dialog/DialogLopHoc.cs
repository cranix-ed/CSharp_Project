using Project_CSharp.BusinessLogicLayer;
using Project_CSharp.Models;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Project_CSharp.Forms.Dialog
{
    public partial class DialogLopHoc : Form
    {
        public LopHoc LopHoc { get; set; }
        private KhoaHocBLL khoaHocBLL = new KhoaHocBLL();
        private KhoaBLL khoaBLL = new KhoaBLL();
        private NganhHocBLL nganhHocBLL = new NganhHocBLL();
        private GiaoVienBLL giaoVienBll = new GiaoVienBLL();

        private LopHoc lopHoc;

        public DialogLopHoc(LopHoc lh = null)
        {
            InitializeComponent();

            LoadComboBoxData();

            lopHoc = lh;
            if (lopHoc != null)
            {
                cmbGiaoVien.SelectedValue = lopHoc.IdGiaoVien;
                cmbKhoaHoc.SelectedValue = lopHoc.IdKhoaHoc;
                cmbKhoa.SelectedValue = lopHoc.IdKhoa;
                cmbNganh.SelectedValue = lopHoc.IdNganh;
                dtpNgayBatDau.Value = lopHoc.NgayBatDau;
                dtpNgayKetThuc.Value = lopHoc.NgayKetThuc;
            }
        }

        public LopHoc GetLopHoc()
        {
            return new LopHoc
            {
                IdGiaoVien = Convert.ToInt32(cmbGiaoVien.SelectedValue),
                IdKhoaHoc = Convert.ToInt32(cmbKhoaHoc.SelectedValue),
                IdKhoa = Convert.ToInt32(cmbKhoa.SelectedValue),
                IdNganh = Convert.ToInt32(cmbNganh.SelectedValue),
                NgayBatDau = dtpNgayBatDau.Value,
                NgayKetThuc = dtpNgayKetThuc.Value
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

            // Load Giáo viên
            cmbGiaoVien.DataSource = giaoVienBll.GetGiaoVien();
            cmbGiaoVien.DisplayMember = "hoten";
            cmbGiaoVien.ValueMember = "idgiaovien";
            cmbGiaoVien.SelectedIndex = -1;

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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LopHoc = new LopHoc
            {
                IdGiaoVien = (int?)cmbGiaoVien.SelectedValue,
                IdKhoaHoc = (int?)cmbKhoaHoc.SelectedValue,
                IdKhoa = (int?)cmbKhoa.SelectedValue,
                IdNganh = (int?)cmbNganh.SelectedValue,
                NgayBatDau = DateTime.ParseExact(dtpNgayBatDau.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                NgayKetThuc = DateTime.ParseExact(dtpNgayKetThuc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}