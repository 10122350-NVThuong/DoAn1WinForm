using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOSanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string FK_MaLoai { get; set; }
        public int SoLuongTon { get; set; }
        public float GiaBan { get; set; }
    }
}
