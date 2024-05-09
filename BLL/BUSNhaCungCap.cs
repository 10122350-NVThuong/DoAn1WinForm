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
    public class BUSNhaCungCap
    {
        public static DataTable DodulieuPKN(string TenBang)
        {
            return DALSanPham.DodulieuPKN(TenBang);
        }
        public static void ThemNhaCungCap(DTONhaCungCap nhaCungCap)
        {
            if (nhaCungCap.IDNCC == "")
            {
                throw new Exception("Thông tin nhà cung cấp không được bỏ trống!");
            }
            else if (DALNhaCungCap.Kiemtrama(nhaCungCap) == 1)
            {
                throw new Exception($"Nhà cung cấp có mã {nhaCungCap.IDNCC} đã tồn tại");
            }
            else if (nhaCungCap.Email.Contains("@") is false)
            {
                throw new Exception("Thông tin email cần co ký tự @");
            }
            else
            {
                DALNhaCungCap.ThemNhaCungCap(nhaCungCap);
            }
        }
        public static void CapNhatThongTinNhaCungCap(DTONhaCungCap nhaCungCap) 
        {
            if (nhaCungCap.IDNCC == "")
            {
                throw new Exception("Thông tin nhà cung cấp không được bỏ trống!");
            }
            else if (DALNhaCungCap.Kiemtrama(nhaCungCap) == 0)
            {
                throw new Exception($"Nhà cung cấp có mã {nhaCungCap.IDNCC} chưa tồn tại");
            }
            else if (nhaCungCap.Email.Contains("@") is false)
            {
                throw new Exception("Thông tin email cần co ký tự @");
            }
            else
            {
                DALNhaCungCap.CapNhatThongTinNhaCungCap(nhaCungCap);
            }
        }
        public static void XoaNhaCungCap(DTONhaCungCap nhacungcap)
        {
            if (nhacungcap.IDNCC == "")
            {
                throw new Exception("Vui lòng chọn mã nhà cung cấp muốn xóa");
            }
            else if (DALNhaCungCap.Kiemtrama(nhacungcap) == 0)
            {
                throw new Exception("Mã nhà cung cấp chưa tồn tại hoặc đã bị xóa");
            }
            else
            {
                DALNhaCungCap.XoaNhaCungCap(nhacungcap);
            }
        }
        public static DataTable TimKiem(string tablename, string columnname, string thonhtintimkiem)
        {
            return DALSanPham.TimKiem(tablename, columnname, thonhtintimkiem);
        }
    }
}
