using Project_CSharp.DataAccessLayer;
using System.Data;

namespace Project_CSharp.BusinessLogicLayer
{
    internal class NganhHocBLL
    {
        private NganhHocDAL nganhHocDAL = new NganhHocDAL();

        public DataTable GetNganhHoc()
        {
            return nganhHocDAL.GetNganhHoc();
        }

        public DataTable GetNganhHocByKhoa(int? idKhoa)
        {
            return nganhHocDAL.GetNganhHocByKhoa(idKhoa);
        }
    }
}