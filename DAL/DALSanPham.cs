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
            string themsanpham = $"insert into tblMatHang values ('{sp.MaSP}', N'{sp.TenSP}', N'{sp.FK_MaLoai}', '{sp.FK_IDNCC}',{sp.SoLuongTon}, {sp.GiaBan})";
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
            string capnhat = $"update tblMatHang set TenSP = N'{sanPham.TenSP}', MaDanhMuc = '{sanPham.FK_MaLoai}', IDNCC = '{sanPham.FK_IDNCC}' ,SoLuongTon = {sanPham.SoLuongTon}, GiaCa = {sanPham.GiaBan} where MaSP = '{sanPham.MaSP}'";
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

        public static DataTable ThongKeSanPhamTon()
        {
            string truyvan = "select MaSP, TenSP, TenDanhMuc, SoLuongTon, CASE WHEN SoLuongTon > 0 THEN N'Còn Hàng' ELSE N'Hết Hàng' END AS TinhTrang from tblMatHang mh inner join tblDanhMucSanPham dm on mh.MaDanhMuc = dm.MaDanhMuc";
            return SQLConnect.DocChiTietHoaDon(truyvan);
        }
        public static DataTable ThongKeSPbanchay()
        {
            string hanghoa = $"select top 5 with ties mh.MaSP, TenSP, TenDanhMuc, sum(Slban) as SoLuong from tblMatHang mh inner join tblChiTietHDBan ct on mh.MaSP = ct.MaSP inner join tblDanhMucSanPham lh on mh.MaDanhMuc = lh.MaDanhMuc group by mh.MaSP, TenSP, TenDanhMuc, Slban order by SoLuong desc";
            return SQLConnect.DocChiTietHoaDon(hanghoa);
        }
    }
}
