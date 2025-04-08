using Project_CSharp.DataAccessLayer;
using Project_CSharp.Helpers;
using Project_CSharp.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_CSharp.BusinessLogicLayer
{
    public class SinhVienBLL
    {
        private SinhVienDAL sinhVienDAL = new SinhVienDAL();

        public DataTable GetAllSinhVien()
        {
            return sinhVienDAL.GetAllSinhVien();
        }

        public SinhVien GetSinhVienById(int idSinhVien)
        {
            return sinhVienDAL.GetSinhVienById(idSinhVien);
        }

        public bool AddSinhVien(SinhVien sv)
        {
            if (sinhVienDAL.CheckDuplicatePhone(sv.SoDienThoai))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return sinhVienDAL.InsertSinhVien(sv);
        }

        public bool UpdateSinhVien(SinhVien sinhVien)
        {
            try
            {
                return sinhVienDAL.UpdateSinhVien(sinhVien);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("malop is NULL for the given idlop"))
                {
                    throw new Exception("Sinh viên chưa có lớp, không thể cập nhật.");
                }
                throw;
            }
        }

        public bool DeleteSinhVien(int idSinhVien)
        {
            return sinhVienDAL.DeleteSinhVien(idSinhVien);
        }

        public DataTable SearchSinhVien(string masinhvien, string hoten, string gioitinh, string lop, string khoa, string nganh)
        {
            return sinhVienDAL.SearchSinhVien(masinhvien, hoten, gioitinh, lop, khoa, nganh);
        }

        public void ImportFromExcel(string filePath)
        {
            DataTable dt = ExcelHelper.ReadExcel(filePath);
            foreach (DataRow row in dt.Rows)
            {
                SinhVien sv = new SinhVien
                {
                    HoTen = row["Họ tên"].ToString(),
                    NgaySinh = Convert.ToDateTime(row["Ngày sinh"]),
                    GioiTinh = row["Giới tính"].ToString(),
                    DiaChi = row["Địa chỉ"].ToString(),
                    SoDienThoai = row["Điện thoại"].ToString(),
                    Email = row["Email"].ToString(),
                    IdKhoaHoc = Convert.ToInt32(row["Khóa học"]),
                    IdKhoa = Convert.ToInt32(row["Khoa"]),
                    IdNganh = Convert.ToInt32(row["Ngành"]),
                    NgayNhapHoc = Convert.ToDateTime(row["Ngày Nhập Học"])
                };
                sinhVienDAL.InsertSinhVien(sv);
            }
        }

        public void ExportToExcel(DataGridView dgv)
        {
            ExcelHelper.ExportDataGridViewToExcel(dgv);
        }

        // Tìm sinh viên chưa có lớp theo điều kiện
        public DataTable TimSinhVienChuaCoLop(string KhoaHoc, string Khoa, string Nganh)
        {
            return sinhVienDAL.GetSinhVienChuaCoLop(KhoaHoc, Khoa, Nganh);
        }

        // Tự động xếp lớp cho sinh viên chưa có lớp
        public string XepLopTuDong(string idKhoaHoc, string idKhoa, string idNganh)
        {
            var svChuaCoLop = sinhVienDAL.GetSinhVienChuaCoLopById(idKhoaHoc, idKhoa, idNganh);
            var lopConCho = sinhVienDAL.GetLopConCho(idKhoaHoc, idKhoa, idNganh);

            if (svChuaCoLop.Rows.Count == 0)
                return "Không có sinh viên chưa có lớp.";

            if (lopConCho.Rows.Count == 0)
                return "Không còn lớp trống. Cần tạo lớp mới.";

            int svIndex = 0;
            foreach (DataRow lop in lopConCho.Rows)
            {
                int idLop = Convert.ToInt32(lop["idlop"]);
                int soSinhVienHienTai = Convert.ToInt32(lop["sosinhvien"]);
                int slotConLai = 60 - soSinhVienHienTai;

                for (int i = 0; i < slotConLai && svIndex < svChuaCoLop.Rows.Count; i++, svIndex++)
                {
                    int idSinhVien = Convert.ToInt32(svChuaCoLop.Rows[svIndex]["idsinhvien"]);
                    sinhVienDAL.CapNhatLopSinhVien(idSinhVien, idLop);
                    sinhVienDAL.TangSoSinhVien(idLop);
                }

                if (svIndex >= svChuaCoLop.Rows.Count)
                    break;
            }

            if (svIndex < svChuaCoLop.Rows.Count)
                return "Đã xếp một phần. Cần tạo thêm lớp cho các sinh viên còn lại.";
            else
                return "Đã xếp lớp thành công cho tất cả sinh viên.";
        }
    }
}