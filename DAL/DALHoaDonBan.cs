using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHoaDonBan
    {
        public static int Kiemtrama(DTOHoaDonBan hoaDonBan)
        {
            int i = SQLConnect.Kiemtrama("tblHoaDonBan", "IDHoaDonBan", hoaDonBan.IDHoaDonBan.ToString());
            return i;
        }
        public static DataTable DodulieuPKN(string TenBang)
        {
            return SQLConnect.DodulieuPKN(TenBang);
        }
        public static DataTable LoadComboboxPKN(string TenBang)
        {
            return SQLConnect.LoadComboboxPKN(TenBang);
        }
        public static void TaoHoaDonBan(DTOHoaDonBan hoaDonBan)
        {
            string taohoadon = $"insert into tblHoaDonBan(IDKH,IDNV, NgayBan) values ('{hoaDonBan.IDKH}', '{hoaDonBan.IDNV}', '{hoaDonBan.NgayBan}');";
            SQLConnect.ThucThi(taohoadon);
        }
        public static void XoaHoaDonBan(DTOHoaDonBan hoaDonBan)
        {
            string xoahoadon = $"delete from tblHoaDonBan where IDHoaDonBan = {hoaDonBan.IDHoaDonBan}";
            SQLConnect.ThucThi(xoahoadon);
        }
        public static DataTable TimKiem(string tablename, string columnname, string thonhtintimkiem)
        {
            return SQLConnect.TimKiem(tablename, columnname, thonhtintimkiem);
        }
        public static int XetHoaDon(DTOHoaDonBan hoaDonBan)
        {
            int i = SQLConnect.Kiemtrama("tblChiTietHDBan", "IDHoaDonBan", hoaDonBan.IDHoaDonBan.ToString());
            return i;
        }
    }
}
