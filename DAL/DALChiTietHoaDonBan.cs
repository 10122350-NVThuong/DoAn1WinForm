using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALChiTietHoaDonBan
    {
        public static DataTable DocChiTietHoaDon(DTOChiTietHoaDonBan chitiet)
        {
            string docdulieu = $"select * from tblChiTietHDBan where IDHoaDonBan = {chitiet.IDHoaDonBan}";
            return SQLConnect.DocChiTietHoaDon(docdulieu);
        }
        public static int Kiemtrahoadon(DTOChiTietHoaDonBan chitiet)
        {
            string xet = $"select count(*) from tblChiTietHDBan where IDHoaDonBan = {chitiet.IDHoaDonBan} and MaSP = '{chitiet.MaSP}'";
            return SQLConnect.Kiemtrahoadon(xet);
        }
        public static void ThemSanPhamVaoHoaDon(DTOChiTietHoaDonBan chiTiet)
        {
            string them = $"insert into tblChiTietHDBan values ({chiTiet.IDHoaDonBan}, '{chiTiet.MaSP}', {chiTiet.SoLuongBan}, {chiTiet.GiaBan})";
            SQLConnect.ThucThi(them);
        }
        public static void SuaChiTietHoaDon(DTOChiTietHoaDonBan chiTiet)
        {
            string Sua = $"update tblChiTietHDBan set Slban = {chiTiet.SoLuongBan},  Dgban = {chiTiet.GiaBan} where IDHoaDonBan = {chiTiet.IDHoaDonBan} and MaSP = '{chiTiet.MaSP}'";
            SQLConnect.ThucThi(Sua);
        }
        public static void XoaSanPham(DTOChiTietHoaDonBan chiTiet)
        {
            string Xoa = $"delete from tblChiTietHDBan where IDHoaDonBan = {chiTiet.IDHoaDonBan} and MaSP = '{chiTiet.MaSP}'";
            SQLConnect.ThucThi(Xoa);
        }
        public static int LaySoLongTon(DTOChiTietHoaDonBan chiTiet)
        {
            string truyvan = $"select SoLuongTon from tblMatHang where MaSP = '{chiTiet.MaSP}'";
            return SQLConnect.LaySoLuongTon(truyvan);
        }
        public static string LayThongTinNV(DTOChiTietHoaDonBan chiTiet)
        {
            string tennhanvien = $"select nv.TenNhanVien from tblChiTietHDBan ct inner join tblHoaDonBan hd on ct.IDHoaDonBan = hd.IDHoaDonBan inner join tblNhanVien nv on hd.IDNV = nv.IDNV where ct.IDHoaDonBan = {chiTiet.IDHoaDonBan}";
            return SQLConnect.LayThongTin(tennhanvien);
        }
        public static string LayThongTinKH(DTOChiTietHoaDonBan chiTiet)
        {
            string tenncc = $"select kh.TenKhachHang from tblChiTietHDBan ct inner join tblHoaDonBan hd on ct.IDHoaDonBan = hd.IDHoaDonBan inner join tblKhachHang kh on hd.IDKH = kh.IDKH where ct.IDHoaDonBan = {chiTiet.IDHoaDonBan}";
            return SQLConnect.LayThongTin(tenncc);
        }
        public static double TinhTien(DTOChiTietHoaDonBan chitiet)
        {
            string thanhtien = $"select sum(Slban * Dgban) as tongtien from tblChiTietHDBan where IDHoaDonBan = {chitiet.IDHoaDonBan}";
            return SQLConnect.TinhTien(thanhtien);
        }
        public static void ThanhToanHoaDon(DTOChiTietHoaDonBan chiTiet)
        {
            string Sua = $"update tblHoaDonBan set TrangThai = N'Đã thanh toán' where IDHoaDonBan = {chiTiet.IDHoaDonBan}";
            SQLConnect.ThucThi(Sua);
        }
    }
}
