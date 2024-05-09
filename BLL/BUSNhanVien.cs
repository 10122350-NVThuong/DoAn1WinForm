using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BUSNhanVien
    {
        public static DataTable DodulieuPKN(string TenBang)
        {
            return DALNhanVien.DodulieuPKN(TenBang);
        }
        public static void CapNhatThongTinNhanVien(DTONhanVien nv)
        {
            if (nv.IDNV == "")
            {
                throw new Exception("Vui lòng chọn nhân viên muốn cập nhật thông tin");
            }  
            else if (DALNhanVien.Kiemtrama(nv) == 0)
            {
                throw new Exception("Mã nhân viên chưa tồn tại");
            }
            else if (nv.Email.Contains("@") is false)
            {
                throw new Exception("Email phải có ký tự @");
            }
            else if (nv.GioiTinh != "Nam" && nv.GioiTinh != "Nữ")
            {
                throw new Exception("Giới tính phải là Nam hoặc Nữ");
            }
            else
            {
                DALNhanVien.CapNhatThongTinNhanVien(nv);
            }
        }
        public static void XoaThongTinNhanVien(DTONhanVien nv)
        {
            if (nv.IDNV == "")
            {
                throw new Exception("Vui lòng chọn nhân viên muốn xóa thông tin");
            }
            else if (DALNhanVien.Kiemtrama(nv) == 0)
            {
                throw new Exception("Mã nhân viên chưa tồn tại");
            }
            else
            {
                DALNhanVien.XoaThongTinNhanVien(nv);
            }
        }
        public static DataTable TimKiemNhanVien(string tablename, string columnname, string thonhtintimkiem)
        {
            return DALNhanVien.TimKiemNhanVien(tablename, columnname, thonhtintimkiem);
        }

    }
}
