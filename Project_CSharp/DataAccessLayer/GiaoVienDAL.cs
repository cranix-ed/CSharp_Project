using Project_CSharp.Helpers;
using System.Data;

namespace Project_CSharp.DataAccessLayer
{
    internal class GiaoVienDAL
    {
        public DataTable GetGiaoVien()
        {
            string query = "SELECT idgiaovien, hoten FROM giaovien";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}