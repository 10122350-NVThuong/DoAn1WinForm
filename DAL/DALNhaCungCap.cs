using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALNhaCungCap
    {
        public static int Kiemtrama(DTONhaCungCap nhaCungCap)
        {
            int i = SQLConnect.Kiemtrama("tblNCC", "IDNCC", nhaCungCap.IDNCC);
            return i;
        }

        public static DataTable DodulieuPKN(string TenBang)
        {
            return SQLConnect.DodulieuPKN(TenBang);
        }
        public static void ThemNhaCungCap(DTONhaCungCap nhaCungCap)
        {
            string themnhacungcap = $"insert into tblNCC values ('{nhaCungCap.IDNCC}', N'{nhaCungCap.TenNhaCungCap}', N'{nhaCungCap.DiaChi}', '{nhaCungCap.SDT}', '{nhaCungCap.Email}')";
            SQLConnect.ThucThi(themnhacungcap);
        }
        public static void CapNhatThongTinNhaCungCap(DTONhaCungCap nhaCungCap)
        {
            string capnhatthongtin = $"update tblNCC set TenNCC = N'{nhaCungCap.TenNhaCungCap}', diachiNCC = N'{nhaCungCap.DiaChi}', SdtNCC = '{nhaCungCap.SDT}', Email = '{nhaCungCap.Email}' where IDNCC = '{nhaCungCap.IDNCC}'";
            SQLConnect.ThucThi(capnhatthongtin);
        }
        public static void XoaNhaCungCap(DTONhaCungCap nhaCungCap)
        {
            string xoanhacungcap = $"delete from tblNCC where IDNCC = '{nhaCungCap.IDNCC}'";
            SQLConnect.ThucThi(xoanhacungcap);
        }
        public static DataTable TimKiem(string tablename, string columnname, string thonhtintimkiem)
        {
            return SQLConnect.TimKiem(tablename, columnname, thonhtintimkiem);
        }
    }
}
