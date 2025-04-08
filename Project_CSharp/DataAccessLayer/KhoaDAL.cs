using Project_CSharp.Helpers;
using System.Data;

namespace Project_CSharp.DataAccessLayer
{
    internal class KhoaDAL
    {
        public DataTable GetKhoa()
        {
            string query = "SELECT idkhoa, tenkhoa FROM khoa";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}