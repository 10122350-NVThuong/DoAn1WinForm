using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALKhachHang
    {
        public static int Kiemtrama(DTOKhachHang khachHang)
        {
            int i = SQLConnect.Kiemtrama("tblKhachHang", "IDKH", khachHang.IDKH);
            return i;
        }

        public static DataTable DodulieuPKN(string TenBang)
        {
            return SQLConnect.DodulieuPKN(TenBang);
        }
        public static void ThemKhachHang(DTOKhachHang khachHang)
        {
            string themkhachhang = $"insert into tblKhachHang values('{khachHang.IDKH}', N'{khachHang.TenKhachHang}',N'{khachHang.GioiTinh}', '{khachHang.NgaySinh}', N'{khachHang.DiaChi}', '{khachHang.SDT}')";
            SQLConnect.ThucThi(themkhachhang);
        }
        public static void CapNhatThongTinKhachHang(DTOKhachHang khachHang)
        {
            string capnhat = $"update tblKhachHang set TenKhachHang = N'{khachHang.TenKhachHang}', GioiTinh = N'{khachHang.GioiTinh}', Ngaysinh = '{khachHang.NgaySinh}', Diachi = N'{khachHang.DiaChi}', SDT = '{khachHang.SDT}' where IDKH = '{khachHang.IDKH}'";
            SQLConnect.ThucThi(capnhat);
        }
        public static void XoaKhachHang(DTOKhachHang khachHang)
        {
            string xoakhachhang = $"delete from tblKhachHang where IDKH = '{khachHang.IDKH}'";
            SQLConnect.ThucThi(xoakhachhang);
        }
        public static DataTable TimKiem(string tablename, string columnname, string thonhtintimkiem)
        {
            return SQLConnect.TimKiem(tablename, columnname, thonhtintimkiem);
        }
    }
}
