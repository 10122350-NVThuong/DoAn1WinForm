using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

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
        public static DataTable DocTaiKhoanNguoiDung()
        {
            return DALTaiKhoan.DocTaiKhoanNguoiDung();
        }
    }
}
