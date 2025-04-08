using Project_CSharp.Helpers;
using Project_CSharp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Project_CSharp.DataAccessLayer
{
    internal class LopHocDAL
    {
        public DataTable GetAllLopHoc()
        {
            string query = "SELECT * FROM v_lophoc";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable GetLopHoc()
        {
            string query = "SELECT idlop, malop FROM lophoc";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public LopHoc GetLopHocById(int idlop)
        {
            string query = "SELECT * FROM lophoc WHERE idlop = @IdLop";
            SqlParameter[] parameters = { new SqlParameter("@IdLop", idlop) };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new LopHoc
                {
                    IdLop = Convert.ToInt32(row["idlop"]),
                    IdGiaoVien = Convert.ToInt32(row["idgiaovien"]),
                    IdKhoaHoc = Convert.ToInt32(row["idkhoahoc"]),
                    IdKhoa = Convert.ToInt32(row["idkhoa"]),
                    IdNganh = Convert.ToInt32(row["idnganh"]),
                    NgayBatDau = Convert.ToDateTime(row["ngaybatdau"]),
                    NgayKetThuc = Convert.ToDateTime(row["ngayketthuc"])
                };
            }
            return null;
        }

        public bool InsertLopHoc(LopHoc lop)
        {
            string query = @"INSERT INTO lophoc (idgiaovien, idkhoahoc, idkhoa, idnganh, ngaybatdau, ngayketthuc)
                         VALUES (@IdGiaoVien, @IdKhoaHoc, @IdKhoa, @IdNganh, @NgayBatDau, @NgayKetThuc)";
            SqlParameter[] parameters =
            {
            new SqlParameter("@IdGiaoVien", lop.IdGiaoVien ?? (object)DBNull.Value),
            new SqlParameter("@IdKhoaHoc", lop.IdKhoaHoc ?? (object)DBNull.Value),
            new SqlParameter("@IdKhoa", lop.IdKhoa ?? (object)DBNull.Value),
            new SqlParameter("@IdNganh", lop.IdNganh ?? (object)DBNull.Value),
            new SqlParameter("@NgayBatDau", lop.NgayBatDau),
            new SqlParameter("@NgayKetThuc", lop.NgayKetThuc)
        };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateLopHoc(LopHoc lop)
        {
            string query = @"UPDATE lophoc SET idgiaovien = @IdGiaoVien, idkhoahoc = @IdKhoaHoc,
                         idkhoa = @IdKhoa, idnganh = @IdNganh, ngaybatdau = @NgayBatDau,
                         ngayketthuc = @NgayKetThuc WHERE idlop = @IdLop";
            SqlParameter[] parameters =
            {
            new SqlParameter("@IdLop", lop.IdLop),
            new SqlParameter("@IdGiaoVien", lop.IdGiaoVien ?? (object)DBNull.Value),
            new SqlParameter("@IdKhoaHoc", lop.IdKhoaHoc ?? (object)DBNull.Value),
            new SqlParameter("@IdKhoa", lop.IdKhoa ?? (object)DBNull.Value),
            new SqlParameter("@IdNganh", lop.IdNganh ?? (object)DBNull.Value),
            new SqlParameter("@NgayBatDau", lop.NgayBatDau),
            new SqlParameter("@NgayKetThuc", lop.NgayKetThuc)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteLopHoc(int idLop)
        {
            string query = "DELETE FROM lophoc WHERE idlop = @IdLop";
            SqlParameter[] parameters = { new SqlParameter("@IdLop", idLop) };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable SearchLopHoc(string malop, string giaovien, string khoahoc, string khoa, string nganh)
        {
            string query = "SELECT * FROM v_lophoc WHERE 1=1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(malop))
            {
                query += " AND malop LIKE @MaLop";
                parameters.Add(new SqlParameter("@MaLop", "%" + malop + "%"));
            }

            if (!string.IsNullOrEmpty(giaovien))
            {
                query += " AND giaovien LIKE @GiaoVien";
                parameters.Add(new SqlParameter("@GiaoVien", "%" + giaovien + "%"));
            }

            if (!string.IsNullOrEmpty(khoahoc))
            {
                query += " AND tenkhoahoc = @KhoaHoc";
                parameters.Add(new SqlParameter("@KhoaHoc", khoahoc));
            }

            if (!string.IsNullOrEmpty(khoa))
            {
                query += " AND tenkhoa = @TenKhoa";
                parameters.Add(new SqlParameter("@TenKhoa", khoa));
            }

            if (!string.IsNullOrEmpty(nganh))
            {
                query += " AND tennganh = @TenNganh";
                parameters.Add(new SqlParameter("@TenNganh", nganh));
            }

            return DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
        }
    }
}