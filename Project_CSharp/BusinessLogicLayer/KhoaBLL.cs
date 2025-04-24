using Project_CSharp.DataAccessLayer;
using System.Data;

namespace Project_CSharp.BusinessLogicLayer
{
    internal class KhoaBLL
    {
        private KhoaDAL khoaDAL = new KhoaDAL();

        public DataTable GetKhoa()
        {
            return khoaDAL.GetKhoa();
        }
    }
}