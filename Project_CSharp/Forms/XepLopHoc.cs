using Project_CSharp.BusinessLogicLayer;
using Project_CSharp.DataAccessLayer;
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
    public partial class XepLopHoc : Form
    {
        private KhoaBLL khoaBLL = new KhoaBLL();
        private NganhHocBLL nganhHocBLL = new NganhHocBLL();
        private LopHocBLL lopHocBLL = new LopHocBLL();
        private KhoaHocBLL khoaHocBLL = new KhoaHocBLL();
        private SinhVienBLL sinhVienBLL = new SinhVienBLL();

        public XepLopHoc()
        {
            InitializeComponent();

            LoadComboBoxData();
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

        private void btnSVChuaCoLop_Click(object sender, EventArgs e)
        {
            string KhoaHoc = cmbSearchKhoaHoc.SelectedItem is DataRowView kh
                               && kh["tenkhoahoc"].ToString() != "-- Chọn Khóa học --"
                ? kh["tenkhoahoc"].ToString()
                : "";

            string Khoa = cmbSearchKhoa.SelectedItem is DataRowView k
                            && k["tenkhoa"].ToString() != "-- Chọn Khoa --"
                ? k["tenkhoa"].ToString()
                : "";

            string Nganh = cmbSearchNganh.SelectedItem is DataRowView n
                             && n["tennganh"].ToString() != "-- Chọn Ngành --"
                ? n["tennganh"].ToString()
                : "";


            dgvXepLopSinhVien.DataSource = sinhVienBLL.TimSinhVienChuaCoLop(KhoaHoc, Khoa, Nganh);
        }

        private void btnXepLop_Click(object sender, EventArgs e)
        {
            string idKhoaHoc = cmbSearchKhoaHoc.SelectedValue != null &&
                               cmbSearchKhoaHoc.SelectedValue.ToString() != "-- Chọn Khóa học --"
                ? cmbSearchKhoaHoc.SelectedValue.ToString()
                : "";

            string idKhoa = cmbSearchKhoa.SelectedValue != null &&
                            cmbSearchKhoa.SelectedValue.ToString() != "-- Chọn Khoa --"
                ? cmbSearchKhoa.SelectedValue.ToString()
                : "";

            string idNganh = cmbSearchNganh.SelectedValue != null &&
                             cmbSearchNganh.SelectedValue.ToString() != "-- Chọn Ngành --"
                ? cmbSearchNganh.SelectedValue.ToString()
                : "";

            string result = sinhVienBLL.XepLopTuDong(idKhoaHoc, idKhoa, idNganh);
            MessageBox.Show(result);

            // Reload danh sách
            dgvXepLopSinhVien.DataSource = sinhVienBLL.TimSinhVienChuaCoLop(idKhoaHoc, idKhoa, idNganh);
        }
    }
}