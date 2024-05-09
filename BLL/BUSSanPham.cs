using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BUSSanPham
    {
        public static DataTable DodulieuPKN(string TenBang)
        {
            return DALSanPham.DodulieuPKN(TenBang);
        }
        public static void ThemSanPham(DTOSanPham SP)
        {
            if (SP.MaSP == "")
            {
                throw new Exception("Thông tin mã sản phẩm không được bỏ trống!");
            }
            else if (DALSanPham.Kiemtrama(SP) == 1)
            {
                throw new Exception("Mã sản phẩm đã tồn tại!");
            }
            else if (SP.TenSP.Length > 50)
            {
                throw new Exception("Tên sản phẩm quá độ dài cho phép");
            }
            else
            {
                DALSanPham.ThemSanPham(SP);
            }
        }
        public static void CapNhatThongTinSanPham(DTOSanPham sanPham)
        {
            if (sanPham.MaSP == "")
            {
                throw new Exception("Vui lòng chọn mã sản phẩm muốn cập nhật thông tin");
            }
            else if (sanPham.TenSP.Length > 50)
            {
                throw new Exception("Tên sản phẩm quá độ dài cho phép");
            }
            else if (DALSanPham.Kiemtrama(sanPham) == 0)
            {
                throw new Exception("Mã sản phẩm chưa tồn tại");
            }
            else
            {
                DALSanPham.CapNhatThongTinSanPham(sanPham);
            }
        }
        public static void XoaSanPham(DTOSanPham sanPham)
        {
            if (sanPham.MaSP == "")
            {
                throw new Exception("Vui lòng chọn mã sản phẩm muốn xóa");
            }
            else if (DALSanPham.Kiemtrama(sanPham) == 0)
            {
                throw new Exception("Mã sản phẩm chưa tồn tại hoặc đã bị xóa");
            }
            else
            {
                DALSanPham.XoaSanPham(sanPham);
            }
        }
        public static DataTable TimKiem(string tablename, string columnname, string thonhtintimkiem)
        {
            return DALSanPham.TimKiem(tablename, columnname, thonhtintimkiem);
        }
        public static DataTable LoadComboboxPKN(string TenBang)
        {
            return DALSanPham.LoadComboboxPKN(TenBang);
        }
    }
}
