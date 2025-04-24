using Project_CSharp.Helpers;
using System.Data;

namespace Project_CSharp.DataAccessLayer
{
    internal class KhoaHocDAL
    {
        public DataTable GetKhoaHoc()
        {
            string query = "SELECT idkhoahoc, tenkhoahoc FROM khoahoc";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}