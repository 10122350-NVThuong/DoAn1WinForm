using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BUSDangKy
    {
        public static void DangKyTaiKhoan(DTONhanVien nv, DTOTaiKhoan tk)
        {
            if (nv.IDNV == "" || nv.Name == "" || tk.TenTK == "" || tk.MatKhau == "")
            {
                throw new Exception("Thông tin không được bỏ trống");
            }
            else if (DALNhanVien.Kiemtrama(nv) == 1)
            {
                throw new Exception("Mã nhân viên đã tồn tại");
            }
            else if (DALTaiKhoan.Kiemtrama(tk) == 1)
            {
                throw new Exception("Tên tài khoản đã tồn tại");
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
                DALDangKy.DangKyTaiKhoan(nv, tk);
            }
        }
    }
}
