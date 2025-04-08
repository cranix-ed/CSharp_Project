using Project_CSharp.DataAccessLayer;
using Project_CSharp.Models;
using System.Data;

namespace Project_CSharp.BusinessLogicLayer
{
    internal class LopHocBLL
    {
        private LopHocDAL lopHocDAL = new LopHocDAL();

        public bool AddLopHoc(LopHoc lop)
        {
            return lopHocDAL.InsertLopHoc(lop);
        }

        public bool UpdateLopHoc(LopHoc lop)
        {
            return lopHocDAL.UpdateLopHoc(lop);
        }

        public bool DeleteLopHoc(int idLop)
        {
            return lopHocDAL.DeleteLopHoc(idLop);
        }

        public DataTable GetAllLopHoc()
        {
            return lopHocDAL.GetAllLopHoc();
        }

        public LopHoc GetLopHocById(int idlop)
        {
            return lopHocDAL.GetLopHocById(idlop);
        }

        public DataTable GetLopHoc()
        {
            return lopHocDAL.GetLopHoc();
        }

        public DataTable SearchLopHoc(string malop, string giaovien, string khoahoc, string khoa, string nganh)
        {
            return lopHocDAL.SearchLopHoc(malop, giaovien, khoahoc, khoa, nganh);
        }
    }
}