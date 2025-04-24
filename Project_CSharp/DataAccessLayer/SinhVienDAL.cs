using Project_CSharp.Helpers;
using Project_CSharp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Project_CSharp.DataAccessLayer
{
    internal class SinhVienDAL
    {
        // Load danh sách sinh viên
        public DataTable GetAllSinhVien()
        {
            string query = "SELECT * FROM v_sinhvien";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public SinhVien GetSinhVienById(int idSinhVien)
        {
            string query = "SELECT * FROM sinhvien WHERE idsinhvien = @IdSinhVien";
            SqlParameter[] parameters = { new SqlParameter("@IdSinhVien", idSinhVien) };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new SinhVien
                {
                    IdSinhVien = Convert.ToInt32(row["idsinhvien"]),
                    HoTen = row["hoten"].ToString(),
                    NgaySinh = Convert.ToDateTime(row["ngaysinh"]),
                    GioiTinh = row["gioitinh"].ToString(),
                    DiaChi = row["diachi"].ToString(),
                    SoDienThoai = row["sodienthoai"].ToString(),
                    Email = row["email"].ToString(),
                    IdKhoaHoc = Convert.ToInt32(row["idkhoahoc"]),
                    IdKhoa = Convert.ToInt32(row["idkhoa"]),
                    IdNganh = Convert.ToInt32(row["idnganh"]),
                    NgayNhapHoc = Convert.ToDateTime(row["ngaynhaphoc"])
                };
            }

            return null;
        }

        // Thêm sinh viên
        public bool InsertSinhVien(SinhVien sv)
        {
            string query =
                @"INSERT INTO sinhvien (hoten, ngaysinh, gioitinh, diachi, sodienthoai, email, idkhoahoc, idkhoa, idnganh, ngaynhaphoc)
                            VALUES (@HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai, @Email, @IdKhoaHoc, @IdKhoa, @IdNganh, @NgayNhapHoc)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@HoTen", sv.HoTen),
                new SqlParameter("@NgaySinh", sv.NgaySinh),
                new SqlParameter("@GioiTinh", sv.GioiTinh),
                new SqlParameter("@DiaChi", sv.DiaChi),
                new SqlParameter("@SoDienThoai", sv.SoDienThoai),
                new SqlParameter("@Email", sv.Email),
                new SqlParameter("@IdKhoaHoc", sv.IdKhoaHoc),
                new SqlParameter("@IdKhoa", sv.IdKhoa),
                new SqlParameter("@IdNganh", sv.IdNganh),
                new SqlParameter("@NgayNhapHoc", sv.NgayNhapHoc)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Cập nhật sinh viên
        public bool UpdateSinhVien(SinhVien sv)
        {
            try
            {
                string query =
                    @"UPDATE sinhvien SET hoten = @HoTen, ngaysinh = @NgaySinh, gioitinh = @GioiTinh, diachi = @DiaChi,
                            sodienthoai = @SoDienThoai, email = @Email, idkhoahoc = @IdKhoaHoc, idkhoa = @IdKhoa,
                            idnganh = @IdNganh, ngaynhaphoc = @NgayNhapHoc WHERE idsinhvien = @IdSinhVien";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@IdSinhVien", sv.IdSinhVien),
                    new SqlParameter("@HoTen", sv.HoTen),
                    new SqlParameter("@NgaySinh", sv.NgaySinh),
                    new SqlParameter("@GioiTinh", sv.GioiTinh),
                    new SqlParameter("@DiaChi", sv.DiaChi),
                    new SqlParameter("@SoDienThoai", sv.SoDienThoai),
                    new SqlParameter("@Email", sv.Email),
                    new SqlParameter("@IdKhoaHoc", sv.IdKhoaHoc),
                    new SqlParameter("@IdKhoa", sv.IdKhoa),
                    new SqlParameter("@IdNganh", sv.IdNganh),
                    new SqlParameter("@NgayNhapHoc", sv.NgayNhapHoc)
                };

                return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
            }
            catch (SqlException ex)
            {
                // Ném lỗi về tầng trên (BLL)
                throw new Exception("Lỗi DAL: " + ex.Message);
            }
        }

        // Xóa sinh viên
        public bool DeleteSinhVien(int maSV)
        {
            string query = "DELETE FROM sinhvien WHERE idsinhvien = @IdSinhVien";
            SqlParameter[] parameters = { new SqlParameter("@IdSinhVien", maSV) };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Tìm kiếm sinh viên
        public DataTable SearchSinhVien(string masinhvien, string hoten, string gioitinh, string lop, string khoa,
            string nganh)
        {
            string query = "SELECT * FROM v_sinhvien WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(masinhvien))
            {
                query += " AND masinhvien LIKE @MaSinhVien";
                parameters.Add(new SqlParameter("@MaSinhVien", "%" + masinhvien + "%"));
            }

            if (!string.IsNullOrEmpty(hoten))
            {
                query += " AND hoten LIKE @HoTen"; // Dùng LIKE thay vì =
                parameters.Add(new SqlParameter("@HoTen", "%" + hoten + "%"));
            }

            if (!string.IsNullOrEmpty(gioitinh))
            {
                query += " AND gioitinh = @GioiTinh";
                parameters.Add(new SqlParameter("@GioiTinh", gioitinh));
            }

            if (!string.IsNullOrEmpty(lop))
            {
                query += " AND malop = @MaLop"; // Sử dụng tên lớp thay vì idlop
                parameters.Add(new SqlParameter("@MaLop", lop));
            }

            if (!string.IsNullOrEmpty(khoa))
            {
                query += " AND tenkhoa = @TenKhoa"; // Sử dụng tên khoa thay vì idkhoa
                parameters.Add(new SqlParameter("@TenKhoa", khoa));
            }

            if (!string.IsNullOrEmpty(nganh))
            {
                query += " AND tennganh = @TenNganh"; // Sử dụng tên ngành thay vì idnganh
                parameters.Add(new SqlParameter("@TenNganh", nganh));
            }

            return DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
        }

        // Kiểm tra số điện thoại trùng lặp
        public bool CheckDuplicatePhone(string phone)
        {
            string query = "SELECT COUNT(*) FROM sinhvien WHERE sodienthoai = @Phone";
            SqlParameter[] parameters = { new SqlParameter("@Phone", phone) };
            int count = (int)DatabaseHelper.ExecuteScalar(query, parameters);
            return count > 0;
        }

        // Lấy sinh viên chưa có lớp theo điều kiện
        public DataTable GetSinhVienChuaCoLop(string KhoaHoc, string Khoa, string Nganh)
        {
            string query = @"
            SELECT * FROM v_sinhvien
            WHERE (malop IS NULL OR malop LIKE '')
            AND tenkhoahoc = @TenKhoaHoc AND tenkhoa = @TenKhoa AND tennganh = @TenNganh";

            SqlParameter[] parameters =
            {
                new SqlParameter("@TenKhoaHoc", KhoaHoc),
                new SqlParameter("@TenKhoa", Khoa),
                new SqlParameter("@TenNganh", Nganh)
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetSinhVienChuaCoLopById(string KhoaHoc, string Khoa, string Nganh)
        {
            string query = @"
            SELECT * FROM sinhvien
            WHERE (idlop IS NULL OR idlop = '')
            AND idkhoahoc = @IdKhoaHoc AND idkhoa = @IdKhoa AND idnganh = @IdNganh";

            SqlParameter[] parameters =
            {
                new SqlParameter("@IdKhoaHoc", KhoaHoc),
                new SqlParameter("@IdKhoa", Khoa),
                new SqlParameter("@IdNganh", Nganh)
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        // Lấy danh sách lớp còn chỗ trống (< 60 SV)
        public DataTable GetLopConCho(string idKhoaHoc, string idKhoa, string idNganh)
        {
            string query = @"
            SELECT * FROM lophoc
            WHERE idkhoahoc = @IdKhoaHoc AND idkhoa = @IdKhoa AND idnganh = @IdNganh
            AND sosinhvien < 60";

            SqlParameter[] parameters =
            {
                new SqlParameter("@IdKhoaHoc", idKhoaHoc),
                new SqlParameter("@IdKhoa", idKhoa),
                new SqlParameter("@IdNganh", idNganh)
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        // Gán sinh viên vào lớp
        public bool CapNhatLopSinhVien(int idSinhVien, int idLop)
        {
            string query = "UPDATE sinhvien SET idlop = @IdLop WHERE idsinhvien = @IdSinhVien";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdLop", idLop),
                new SqlParameter("@IdSinhVien", idSinhVien)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Cập nhật lại số sinh viên của lớp
        public void TangSoSinhVien(int idLop)
        {
            string query = "UPDATE lophoc SET sosinhvien = sosinhvien + 1 WHERE idlop = @IdLop";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdLop", idLop)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        // DAL sử dụng trong thống kê
        public int DemTongSinhVien()
        {
            string query = "SELECT COUNT(*) FROM sinhvien";
            return (int)DatabaseHelper.ExecuteScalar(query);
        }

        public int DemSinhVienTheoGioiTinh(string gioitinh)
        {
            string query = "SELECT COUNT(*) FROM sinhvien WHERE gioitinh = @GioiTinh";
            SqlParameter[] parameters = {
            new SqlParameter("@GioiTinh", gioitinh)
        };
            return (int)DatabaseHelper.ExecuteScalar(query, parameters);
        }

        public DataTable DemSinhVienTheoKhoa()
        {
            string query = @"
            SELECT k.tenkhoa, COUNT(*) AS soluongk
            FROM sinhvien sv
            JOIN khoa k ON sv.idkhoa = k.idkhoa
            GROUP BY k.tenkhoa";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable DemSinhVienTheoNganh()
        {
            string query = @"
            SELECT nh.tennganh, COUNT(*) AS soluongn
            FROM sinhvien sv
            JOIN nganhhoc nh ON sv.idnganh = nh.idnganh
            GROUP BY nh.tennganh";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable DemSinhVienTheoKhoaHoc()
        {
            string query = @"
            SELECT kh.tenkhoahoc, COUNT(*) AS soluongkh
            FROM sinhvien sv
            JOIN khoahoc kh ON sv.idkhoahoc = kh.idkhoahoc
            GROUP BY kh.tenkhoahoc";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}