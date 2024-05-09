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
    public class BUSDanhMucSanPham
    {
        public static DataTable DodulieuPKN(string TenBang)
        {
            return SQLConnect.DodulieuPKN(TenBang);
        }

        public static void ThemDanhMucSanPham(DTODanhMucSanPham danhMucSP)
        {
            if (danhMucSP.MaLoai == "")
            {
                throw new Exception("Thông tin mã loại sản phẩm không được bỏ trống!");
            }
            else if (DALDanhMucSanPham.Kiemtrama(danhMucSP) == 1)
            {
                throw new Exception("Mã loại sản phẩm đã tồn tại!");
            }
            else
            {
                DALDanhMucSanPham.ThemDanhMucSanPham(danhMucSP);
            }
        }
        public static void XoaDanhMucSanPham(DTODanhMucSanPham danhMucSanPham)
        {
            if (danhMucSanPham.MaLoai == "")
            {
                throw new Exception("Vui lòng chon mã danh mục muốn xóa thông tin");
            }
            else if (DALDanhMucSanPham.Kiemtrama(danhMucSanPham) == 0)
            {
                throw new Exception("Mã danh mục chưa tồn tại hoặc đã bị xóa");
            }
            else
            {
                DALDanhMucSanPham.XoaDanhMucSanPham(danhMucSanPham);
            }
        }
        public static void SuaDanhMucSanPham(DTODanhMucSanPham danhMucSanPham)
        {
            if (danhMucSanPham.MaLoai == "")
            {
                throw new Exception("Vui lòng chọn mã danh mục muốn cập nhật");
            }
            else if (DALDanhMucSanPham.Kiemtrama(danhMucSanPham) == 0)
            {
                throw new Exception("Mã danh mục chưa tồn tại");
            }
            else
            {
                DALDanhMucSanPham.SuaDanhMucSanPham(danhMucSanPham);
            }
        }
    }
}
