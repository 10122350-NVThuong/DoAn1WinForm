using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace BLL
{
    public class BUSTaiKhoan
    {
        public static int CheckLogin(DTOTaiKhoan tk)
        {
            if (tk.TenTK == "" || tk.MatKhau == "")
            {
                throw new Exception("Tai khoan va mat khau khong duoc bo trong");
            }
            else
            {
                int i = DataBase.KtrDN(tk);
                return i;
            }
        }
        public static void UpDateMatKhau(DTOTaiKhoan tkc, DTOTaiKhoan tkm)
        {
            if (tkc.MatKhau == tkm.MatKhau)
            {
                throw new Exception("Mật khẩu mới không được trùng với mật khẩu cũ");
            }
            else
            {
                DALTaiKhoan.UpDateMatKhau(tkm);
            }
        }
        public static void QuenMatKhau(DTOTaiKhoan tk)
        {
            if (tk.MatKhau == "")
            {
                throw new Exception("Mật khẩu không được bỏ trống");
            }
            else
            {
                DALTaiKhoan.UpDateMatKhau(tk);
            }
        }
        public static int sendEmail(DTONhanVien nv, DTOTaiKhoan tk)
        {
            if (nv.Email == "")
            {
                throw new Exception("Email không được bỏ trống");
            }
            else if(nv.Email.Contains('@') is false)
            {
                throw new Exception("Email chưa đúng định dạng");
            }
            else if (nv.Email.Trim() != DALTaiKhoan.LayEmailNV(tk).Trim())
            {
                throw new Exception("Email đăng ký tài khoản chưa chính xác");

            }
            else
            {
                return DALTaiKhoan.sendEmail(nv);
            }
        }
        public static DataTable DocTaiKhoanNguoiDung()
        {
            return DALTaiKhoan.DocTaiKhoanNguoiDung();
        }
    }
}
