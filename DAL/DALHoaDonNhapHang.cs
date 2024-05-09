using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHoaDonNhapHang
    {
        public static int Kiemtrama(DTOHoaDonNhap hoaDonNhap)
        {
            int i = SQLConnect.Kiemtrama("tblHoaDonNhap", "IDHoaDonNhap", hoaDonNhap.IDHoaDonNhap.ToString());
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
        public static void TaoHoaDonNhap(DTOHoaDonNhap hoaDonNhap)
        {
            string taohoadon = $"insert into tblHoaDonNhap(IDNCC,IDNV, NgayNhap) values ('{hoaDonNhap.IDNCC}', '{hoaDonNhap.IDNV}', '{hoaDonNhap.NgayNhap}');";
            SQLConnect.ThucThi(taohoadon);
        }
        public static void XoaHoaDonNhap(DTOHoaDonNhap hoaDonNhap)
        {
            string xoahoadon = $"delete from tblHoaDonNhap where IDHoaDonNhap = {hoaDonNhap.IDHoaDonNhap}";
            SQLConnect.ThucThi(xoahoadon);
        }
        public static DataTable TimKiem(string tablename, string columnname, string thonhtintimkiem)
        {
            return SQLConnect.TimKiem(tablename, columnname, thonhtintimkiem);
        }
        public static int XetHoaDon(DTOHoaDonNhap hoaDonNhap)
        {
            int i = SQLConnect.Kiemtrama("tblChiTietHDNhap", "IDHoaDonNhap", hoaDonNhap.IDHoaDonNhap.ToString());
            return i;
        }
    }
}
