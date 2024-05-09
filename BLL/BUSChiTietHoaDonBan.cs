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
    public class BUSChiTietHoaDonBan
    {
        public static DataTable DocChiTietHoaDon(DTOChiTietHoaDonBan chitiet)
        {
            return DALChiTietHoaDonBan.DocChiTietHoaDon(chitiet);
        }
        public static void ThemSanPhamVaoHoaDon(DTOChiTietHoaDonBan chiTiet)
        {
            if (chiTiet.MaSP == "")
            {
                throw new Exception("Vui lòng chọn sản phẩm muốn nhâp");
            }
            else if (chiTiet.SoLuongBan <= 0)
            {
                throw new Exception("Số lượng bán phải lớn hơn 0");
            }
            else if (chiTiet.SoLuongBan > DALChiTietHoaDonBan.LaySoLongTon(chiTiet))
            {
                throw new Exception($"Số lượng tồn không đủ (cửa hàng còn {DALChiTietHoaDonBan.LaySoLongTon(chiTiet)} sản phẩm)");
            }
            else if (chiTiet.GiaBan <= 0)
            {
                throw new Exception("Giá bán phải lớn hơn 0");
            }
            else if (DALChiTietHoaDonBan.Kiemtrahoadon(chiTiet) == 1)
            {
                throw new Exception($"Mã sản phẩm {chiTiet.MaSP} đã có trong hóa đơn {chiTiet.IDHoaDonBan}");
            }
            else
            {
                DALChiTietHoaDonBan.ThemSanPhamVaoHoaDon(chiTiet);
            }
        }
        public static void SuaChiTietHoaDon(DTOChiTietHoaDonBan chiTiet)
        {
            if (chiTiet.MaSP == "")
            {
                throw new Exception("Vui lòng chọn sản phẩm muốn cập nhật");
            }
            else if (chiTiet.SoLuongBan <= 0)
            {
                throw new Exception("Số lượng bán phải lớn hơn 0");
            }
            else if (chiTiet.SoLuongBan > DALChiTietHoaDonBan.LaySoLongTon(chiTiet))
            {
                throw new Exception("Số lượng tồn không đủ");
            }
            else if (DALChiTietHoaDonBan.Kiemtrahoadon(chiTiet) == 0)
            {
                throw new Exception($"Mã sản phẩm {chiTiet.MaSP} chưa có trong hóa đơn {chiTiet.IDHoaDonBan}");
            }
            else
            {
                DALChiTietHoaDonBan.SuaChiTietHoaDon(chiTiet);
            }
        }
        public static void XoaSanPham(DTOChiTietHoaDonBan chiTiet)
        {
            if (chiTiet.MaSP == "")
            {
                throw new Exception("Vui lòng chọn sản phẩm muốn xóa khỏi hóa đơn");
            }
            else if (DALChiTietHoaDonBan.Kiemtrahoadon(chiTiet) == 0)
            {
                throw new Exception($"Mã sản phẩm {chiTiet.MaSP} chưa có trong hóa đơn {chiTiet.IDHoaDonBan}");
            }
            else
            {
                DALChiTietHoaDonBan.XoaSanPham(chiTiet);
            }
        }
        public static string LayThongTinNV(DTOChiTietHoaDonBan chiTiet)
        {
            return DALChiTietHoaDonBan.LayThongTinNV(chiTiet);
        }
        public static string LayThongTinKH(DTOChiTietHoaDonBan chiTiet)
        {
            return DALChiTietHoaDonBan.LayThongTinKH(chiTiet);
        }
        public static double TinhTien(DTOChiTietHoaDonBan chitiet)
        {
            return DALChiTietHoaDonBan.TinhTien(chitiet);
        }
        public static void ThanhToanHoaDon(DTOChiTietHoaDonBan chiTiet)
        {
            DALChiTietHoaDonBan.ThanhToanHoaDon(chiTiet);
        }
    }
}
