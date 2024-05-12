using DTO;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace DAL
{
    public class DALTaiKhoan
    {
        public static string myemail = "nvthuongcl2004@gmail.com";
        public static string pass = "infk zuro qjcq chkg";

        public static int Kiemtrama(DTOTaiKhoan tk)
        {
            int i = SQLConnect.Kiemtrama("tblTaiKhoan", "TenTK", tk.TenTK);
            return i;
        }
        public static string LayEmailNV(DTOTaiKhoan tk)
        {
            string truyvan = $"select nv.EmailNV from tblTaiKhoan tk inner join tblNhanVien nv on tk.IDNV = nv.IDNV where tk.TenTK = '{tk.TenTK}'";
            return SQLConnect.LayThongTin(truyvan);
        }
        public static void UpDateMatKhau(DTOTaiKhoan tk)
        {
            string update = $"Update tblTaiKhoan set MatKhau = '{tk.MatKhau}' where TenTK = '{tk.TenTK}'";
            SQLConnect.ThucThi(update);
        }
        public static int sendEmail(DTONhanVien nv)
        {
            Random ran = new Random();
            int code = ran.Next(100000, 999999);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(myemail);
            mail.To.Add(nv.Email);
            mail.Subject = "Mã Xác Thực";
            mail.Body = "Mã xác thực của bạn là: " + code;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(myemail, pass);
            smtp.EnableSsl = true;

            smtp.Send(mail);

            return code;
        }
        public static DataTable DocTaiKhoanNguoiDung()
        {
            string truyvan = "select tk.TenTK,tk.MatKhau, tk.Quyen,nv.TenNhanVien from tblTaiKhoan tk inner join tblNhanVien nv on tk.IDNV = nv.IDNV where tk.Quyen = 1";
            return SQLConnect.DocChiTietHoaDon(truyvan);
        }
    }
}
