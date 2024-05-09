using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDanhMucSanPham
    {
        public static DataTable DodulieuPKN(string TenBang)
        {
            return SQLConnect.DodulieuPKN(TenBang);
        }

        public static void ThemDanhMucSanPham(DTODanhMucSanPham danhMucSP)
        {
            string themdanhMuc = $"insert into tblDanhMucSanPham values ('{danhMucSP.MaLoai}', N'{danhMucSP.TenLoai}')";
            SQLConnect.ThucThi(themdanhMuc);
        }

        public static int Kiemtrama(DTODanhMucSanPham danhMucSP)
        {
            int i = SQLConnect.Kiemtrama("tblDanhMucSanPham", "MaDanhMuc", danhMucSP.MaLoai);
            return i;
        }
        public static void XoaDanhMucSanPham(DTODanhMucSanPham danhMucSP)
        {
            string xoadanhmuc = $"delete from tblDanhMucSanPham where MaDanhMuc = '{danhMucSP.MaLoai}'";
            SQLConnect.ThucThi(xoadanhmuc);
        }
        public static void SuaDanhMucSanPham(DTODanhMucSanPham danhMucSP)
        {
            string suadanhmuc = $"update tblDanhMucSanPham set TenDanhMuc = N'{danhMucSP.TenLoai}' where MaDanhMuc = '{danhMucSP.MaLoai}'";
            SQLConnect.ThucThi(suadanhmuc);
        }
    }
}
