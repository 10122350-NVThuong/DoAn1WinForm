using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOHoaDonNhap
    {
        public int IDHoaDonNhap {  get; set; }
        public string IDNCC {  get; set; }
        public string IDNV { get; set; }
        public DateTime NgayNhap { get; set; }
        public string TrangThai { get; set; }
    }
}
