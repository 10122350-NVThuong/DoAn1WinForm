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
    public class BUSKhachHang
    {
        public static DataTable DodulieuPKN(string TenBang)
        {
            return SQLConnect.DodulieuPKN(TenBang);
        }
        public static void ThemKhachHang(DTOKhachHang khachHang)
        {
            if (khachHang.IDKH == "")
            {
                throw new Exception("Thông tin khách hàng không được bỏ trống!");
            }
            else if (DALKhachHang.Kiemtrama(khachHang) == 1)
            {
                throw new Exception($"Khách hàng có mã {khachHang.IDKH} đã tồn tại");
            }
            else
            {
                DALKhachHang.ThemKhachHang(khachHang);
            }
        }
        public static void CapNhatThongTinKhachHang(DTOKhachHang khachHang)
        {
            if (khachHang.IDKH == "")
            {
                throw new Exception("Vui lòng chọn khách hàng muốn cập nhật thông tin");
            }
            else if (DALKhachHang.Kiemtrama(khachHang) == 0)
            {
                throw new Exception($"Khách hàng có mã {khachHang.IDKH} chưa tồn tại");
            }
            else
            {
                DALKhachHang.CapNhatThongTinKhachHang(khachHang);
            }
        }
        public static void XoaKhachHang(DTOKhachHang khachHang)
        {
            if (khachHang.IDKH == "")
            {
                throw new Exception("Vui lòng chọn mã khách hàng muốn xóa");
            }
            else if (DALKhachHang.Kiemtrama(khachHang) == 0)
            {
                throw new Exception($"Khách hàng có mã {khachHang.IDKH} chưa tồn tại");
            }
            else
            {
                DALKhachHang.XoaKhachHang(khachHang);
            }
        }
        public static DataTable TimKiem(string tablename, string columnname, string thonhtintimkiem)
        {
            return SQLConnect.TimKiem(tablename, columnname, thonhtintimkiem);
        }
    }
}
