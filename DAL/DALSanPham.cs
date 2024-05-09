using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALSanPham
    {
        public static int Kiemtrama(DTOSanPham sp)
        {
            int i = SQLConnect.Kiemtrama("tblMatHang", "MaSP", sp.MaSP);
            return i;
        }

        public static void ThemSanPham(DTOSanPham sp)
        {
            string themsanpham = $"insert into tblMatHang values ('{sp.MaSP}', N'{sp.TenSP}', N'{sp.FK_MaLoai}', {sp.SoLuongTon}, {sp.GiaBan})";
            SQLConnect.ThucThi(themsanpham);
        }

        public static DataTable DodulieuPKN(string TenBang)
        {
            return SQLConnect.DodulieuPKN(TenBang);
        }
        public static DataTable LoadComboboxPKN(string TenBang)
        {
            return SQLConnect.LoadComboboxPKN(TenBang);
        }
        public static void CapNhatThongTinSanPham(DTOSanPham sanPham)
        {
            string capnhat = $"update tblMatHang set TenSP = N'{sanPham.TenSP}', MaDanhMuc = '{sanPham.FK_MaLoai}', SoLuongTon = {sanPham.SoLuongTon}, GiaCa = {sanPham.GiaBan} where MaSP = '{sanPham.MaSP}'";
            SQLConnect.ThucThi(capnhat);
        }
        public static void XoaSanPham(DTOSanPham sanPham)
        {
            string xoasanpham = $"delete from tblMatHang where MaSP = '{sanPham.MaSP}'";
            SQLConnect.ThucThi(xoasanpham);
        }
        public static DataTable TimKiem(string tablename, string columnname, string thonhtintimkiem)
        {
            return SQLConnect.TimKiem(tablename, columnname, thonhtintimkiem);
        }
    }
}
