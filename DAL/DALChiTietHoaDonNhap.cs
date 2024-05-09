using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALChiTietHoaDonNhap
    {
        public static DataTable DocChiTietHoaDon(DTOChiTietHoaDonNhap chitiet)
        {
            string docdulieu = $"select * from tblChiTietHDNhap where IDHoaDonNhap = {chitiet.IDHoaDonNhap}";
            return SQLConnect.DocChiTietHoaDon(docdulieu);
        }
        public static int Kiemtrahoadon(DTOChiTietHoaDonNhap chitiet)
        {
            string xet = $"select count(*) from tblChiTietHDNhap where IDHoaDonNhap = {chitiet.IDHoaDonNhap} and MaSP = '{chitiet.MaSP}'";
            return SQLConnect.Kiemtrahoadon(xet);
        }
        public static void ThemSanPhamVaoHoaDon(DTOChiTietHoaDonNhap chiTiet)
        {
            string them = $"insert into tblChiTietHDNhap values ({chiTiet.IDHoaDonNhap}, '{chiTiet.MaSP}', {chiTiet.SoLuongNhap}, {chiTiet.GiaNhap})";
            SQLConnect.ThucThi(them);
        }
        public static void SuaChiTietHoaDon(DTOChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            string Sua = $"update tblChiTietHDNhap set Slnhap = {chiTietHoaDonNhap.SoLuongNhap},  Dgnhap = {chiTietHoaDonNhap.GiaNhap} where IDHoaDonNhap = {chiTietHoaDonNhap.IDHoaDonNhap} and MaSP = '{chiTietHoaDonNhap.MaSP}'";
            SQLConnect.ThucThi(Sua);
        }
        public static void XoaSanPham(DTOChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            string Xoa = $"delete from tblChiTietHDNhap where IDHoaDonNhap = {chiTietHoaDonNhap.IDHoaDonNhap} and MaSP = '{chiTietHoaDonNhap.MaSP}'";
            SQLConnect.ThucThi(Xoa);
        }
        public static string LayThongTinNV(DTOChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            string tennhanvien = $"select nv.TenNhanVien from tblChiTietHDNhap ct inner join tblHoaDonNhap hd on ct.IDHoaDonNhap = hd.IDHoaDonNhap inner join tblNhanVien nv on hd.IDNV = nv.IDNV where ct.IDHoaDonNhap = {chiTietHoaDonNhap.IDHoaDonNhap}";
            return SQLConnect.LayThongTin(tennhanvien);
        }
        public static string LayThongTinNCC(DTOChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            string tenncc = $"select ncc.TenNCC from tblChiTietHDNhap ct inner join tblHoaDonNhap hd on ct.IDHoaDonNhap = hd.IDHoaDonNhap inner join tblNCC ncc on hd.IDNCC = ncc.IDNCC where ct.IDHoaDonNhap = {chiTietHoaDonNhap.IDHoaDonNhap}";
            return SQLConnect.LayThongTin(tenncc);
        }
        public static double TinhTien(DTOChiTietHoaDonNhap chitiet)
        {
            string thanhtien = $"select sum(Slnhap * Dgnhap) as tongtien from tblChiTietHDNhap where IDHoaDonNhap = {chitiet.IDHoaDonNhap}";
            return SQLConnect.TinhTien(thanhtien);
        }
        public static void ThanhToanHoaDon(DTOChiTietHoaDonNhap chiTiet)
        {
            string Sua = $"update tblHoaDonNhap set TrangThai = N'Đã thanh toán' where IDHoaDonNhap = {chiTiet.IDHoaDonNhap}";
            SQLConnect.ThucThi(Sua);
        }
    }
}
