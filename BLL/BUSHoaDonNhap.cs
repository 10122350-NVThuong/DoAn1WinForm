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
    public class BUSHoaDonNhap
    {

        public static DataTable DodulieuPKN(string TenBang)
        {
            return SQLConnect.DodulieuPKN(TenBang);
        }
        public static DataTable LoadComboboxPKN(string TenBang)
        {
            return SQLConnect.LoadComboboxPKN(TenBang);
        }
        public static void TaoHoaDonNhap(DTOHoaDonNhap hoaDonNhap)
        {
            if (hoaDonNhap.IDNCC == "")
            {
                throw new Exception("Mã nhà cung cấp không được để trống");
            }
            else if (hoaDonNhap.IDNV == "")
            {
                throw new Exception("Mã nhân viên không được để trống");
            }
            else
            {
                DALHoaDonNhapHang.TaoHoaDonNhap(hoaDonNhap);
            }
        }
        public static void XoaHoaDonNhap(DTOHoaDonNhap hoaDonNhap)
        {
            if (hoaDonNhap.IDHoaDonNhap == 0)
            {
                throw new Exception("Vui lòng chon mã hóa đơn muốn xóa thông tin");
            }
            else if (DALHoaDonNhapHang.Kiemtrama(hoaDonNhap) == 0)
            {
                throw new Exception($"Mã hóa đơn {hoaDonNhap.IDHoaDonNhap} chưa tồn tại hoặc đã bị xóa");
            }
            else
            {
                DALHoaDonNhapHang.XoaHoaDonNhap(hoaDonNhap);
            }
        }
        public static DataTable TimKiem(string tablename, string columnname, string thonhtintimkiem)
        {
            return DALHoaDonNhapHang.TimKiem(tablename, columnname, thonhtintimkiem);
        }
        public static int XetHoaDon(DTOHoaDonNhap hoaDonNhap)
        {
            return DALHoaDonNhapHang.XetHoaDon(hoaDonNhap);
        }
    }
}
