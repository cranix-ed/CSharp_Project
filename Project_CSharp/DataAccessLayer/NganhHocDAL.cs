using Project_CSharp.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace Project_CSharp.DataAccessLayer
{
    internal class NganhHocDAL
    {
        public DataTable GetNganhHoc()
        {
            string query = "SELECT idnganh, tennganh FROM nganhhoc";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable GetNganhHocByKhoa(int? idKhoa)
        {
            string query = "SELECT idnganh, tennganh FROM nganhhoc";
            SqlParameter[] parameters = null;

            if (idKhoa.HasValue)
            {
                query += " WHERE idkhoa = @idKhoa";
                parameters = new SqlParameter[]
                {
            new SqlParameter("@idKhoa", idKhoa.Value)
                };
            }

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
    }
}