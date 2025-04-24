using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{
    public class LopHoc
    {
        public int IdLop { get; set; }
        public string MaLop { get; set; }
        public int? IdGiaoVien { get; set; }
        public int? IdKhoaHoc { get; set; }
        public int? IdKhoa { get; set; }
        public int? IdNganh { get; set; }
        public int SoSinhVien { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
    }
}
