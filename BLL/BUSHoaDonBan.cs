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
    public class BUSHoaDonBan
    {
        public static DataTable DodulieuPKN(string TenBang)
        {
            return SQLConnect.DodulieuPKN(TenBang);
        }
        public static DataTable LoadComboboxPKN(string TenBang)
        {
            return SQLConnect.LoadComboboxPKN(TenBang);
        }
        public static void TaoHoaDonBan(DTOHoaDonBan hoaDonBan)
        {
            if (hoaDonBan.IDKH == "")
            {
                throw new Exception("Mã khách hàng không được để trống");
            }
            else if (hoaDonBan.IDNV == "")
            {
                throw new Exception("Mã nhân viên không được để trống");
            }
            else
            {
                DALHoaDonBan.TaoHoaDonBan(hoaDonBan);
            }
        }
        public static void XoaHoaDonBan(DTOHoaDonBan hoaDonBan)
        {
            if (hoaDonBan.IDHoaDonBan == 0)
            {
                throw new Exception("Vui lòng chon mã hóa đơn muốn xóa thông tin");
            }
            else if (DALHoaDonBan.Kiemtrama(hoaDonBan) == 0)
            {
                throw new Exception($"Mã hóa đơn {hoaDonBan.IDHoaDonBan} chưa tồn tại hoặc đã bị xóa");
            }
            else
            {
                DALHoaDonBan.XoaHoaDonBan(hoaDonBan);
            }
        }
        public static DataTable TimKiem(string tablename, string columnname, string thonhtintimkiem)
        {
            return DALHoaDonNhapHang.TimKiem(tablename, columnname, thonhtintimkiem);
        }
        public static int XetHoaDon(DTOHoaDonBan hoaDonBan)
        {
            return DALHoaDonBan.XetHoaDon(hoaDonBan);
        }
    }
}
