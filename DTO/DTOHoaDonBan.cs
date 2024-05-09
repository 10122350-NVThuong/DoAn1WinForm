using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOHoaDonBan
    {
        public int IDHoaDonBan { get; set; }
        public string IDKH { get; set; }
        public string IDNV { get; set; }
        public DateTime NgayBan { get; set; }
        public string TrangThai { get; set; }
    }
}
