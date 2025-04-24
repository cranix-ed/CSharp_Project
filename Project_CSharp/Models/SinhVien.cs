using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{
    public class SinhVien
    {
        public int IdSinhVien { get; set; }
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public int? IdKhoaHoc { get; set; }
        public int? IdLop { get; set; }
        public int? IdKhoa { get; set; }
        public int? IdNganh { get; set; }
        public DateTime NgayNhapHoc { get; set; }
    }
}
