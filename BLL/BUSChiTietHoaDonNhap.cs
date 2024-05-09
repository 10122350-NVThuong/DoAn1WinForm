using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BUSChiTietHoaDonNhap
    {
        public static DataTable DocChiTietHoaDon(DTOChiTietHoaDonNhap chitiet)
        {
            return DALChiTietHoaDonNhap.DocChiTietHoaDon(chitiet);
        }
        public static void ThemSanPhamVaoHoaDon(DTOChiTietHoaDonNhap chiTiet)
        {
            if (chiTiet.MaSP == "")
            {
                throw new Exception("Vui lòng chọn sản phẩm muốn nhâp");
            }
            else if (chiTiet.SoLuongNhap <= 0)
            {
                throw new Exception("Số lượng nhập phải lớn hơn 0");
            }
            else if (chiTiet.GiaNhap <= 0)
            {
                throw new Exception("Giá nhập phải lớn hơn 0");
            }
            else if (DALChiTietHoaDonNhap.Kiemtrahoadon(chiTiet) == 1)
            {
                throw new Exception($"Mã sản phẩm {chiTiet.MaSP} đã có trong hóa đơn {chiTiet.IDHoaDonNhap}");
            }
            else
            {
                DALChiTietHoaDonNhap.ThemSanPhamVaoHoaDon(chiTiet);
            }
        }
        public static void SuaChiTietHoaDon(DTOChiTietHoaDonNhap chiTiet)
        {
            if (chiTiet.MaSP == "")
            {
                throw new Exception("Vui lòng chọn sản phẩm muốn cập nhật");
            }
            else if (chiTiet.SoLuongNhap <= 0)
            {
                throw new Exception("Số lượng nhập phải lớn hơn 0");
            }
            else if (DALChiTietHoaDonNhap.Kiemtrahoadon(chiTiet) == 0)
            {
                throw new Exception($"Mã sản phẩm {chiTiet.MaSP} chưa có trong hóa đơn {chiTiet.IDHoaDonNhap}");
            }
            else
            {
                DALChiTietHoaDonNhap.SuaChiTietHoaDon(chiTiet);
            }
        }
        public static void XoaSanPham(DTOChiTietHoaDonNhap chiTiet)
        {
            if (chiTiet.MaSP == "")
            {
                throw new Exception("Vui lòng chọn sản phẩm muốn cập nhật");
            }
            else if (DALChiTietHoaDonNhap.Kiemtrahoadon(chiTiet) == 0)
            {
                throw new Exception($"Mã sản phẩm {chiTiet.MaSP} chưa có trong hóa đơn {chiTiet.IDHoaDonNhap}");
            }
            else
            {
                DALChiTietHoaDonNhap.XoaSanPham(chiTiet);
            }
        }
        public static string LayThongTinNV(DTOChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            return DALChiTietHoaDonNhap.LayThongTinNV(chiTietHoaDonNhap);
        }
        public static string LayThongTinNCC(DTOChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            return DALChiTietHoaDonNhap.LayThongTinNCC(chiTietHoaDonNhap);
        }
        public static double TinhTien(DTOChiTietHoaDonNhap chitiet)
        {
            return DALChiTietHoaDonNhap.TinhTien(chitiet);
        }
        public static void ThanhToanHoaDon(DTOChiTietHoaDonNhap chiTiet)
        {
            DALChiTietHoaDonNhap.ThanhToanHoaDon(chiTiet);
        }
    }
}
