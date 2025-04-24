using Project_CSharp.DataAccessLayer;
using System.Data;

namespace Project_CSharp.BusinessLogicLayer
{
    internal class GiaoVienBLL
    {
        private GiaoVienDAL GiaoVienDAL = new GiaoVienDAL();

        public DataTable GetGiaoVien()
        {
            return GiaoVienDAL.GetGiaoVien();
        }
    }
}