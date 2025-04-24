using Project_CSharp.DataAccessLayer;
using System.Data;

namespace Project_CSharp.BusinessLogicLayer
{
    internal class KhoaHocBLL
    {
        private KhoaHocDAL khoaHocDAL = new KhoaHocDAL();

        public DataTable GetKhoaHoc()
        {
            return khoaHocDAL.GetKhoaHoc();
        }
    }
}