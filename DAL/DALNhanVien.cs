using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALNhanVien
    {
        public static int Kiemtrama(DTONhanVien nv)
        {
            int i = SQLConnect.Kiemtrama("tblNhanVien", "IDNV", nv.IDNV);
            return i;
        }
        public static DataTable DodulieuPKN(string TenBang)
        {
            return SQLConnect.DodulieuPKN(TenBang);
        }
        public static void CapNhatThongTinNhanVien(DTONhanVien nv)
        {
            string capnhat = $"update tblNhanVien set TenNhanVien = N'{nv.Name}', GioiTinhNV = N'{nv.GioiTinh}', NgaysinhNV = '{nv.birth}', DiachiNV = N'{nv.DiaChi}', EmailNV = '{nv.Email}', SDTNV = '{nv.SDT}' where IDNV = '{nv.IDNV}'";
            SQLConnect.ThucThi(capnhat);
        }
        public static void XoaThongTinNhanVien(DTONhanVien nv)
        {
            string xoathongtin = $"delete from tblNhanVien where IDNV = '{nv.IDNV}'";
            SQLConnect.ThucThi(xoathongtin);
        }
        public static DataTable TimKiemNhanVien(string tablename, string columnname, string thonhtintimkiem)
        {
            return SQLConnect.TimKiem(tablename, columnname, thonhtintimkiem);
        }
    }
}
