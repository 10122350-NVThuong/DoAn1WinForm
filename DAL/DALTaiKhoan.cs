using DTO;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTaiKhoan
    {
        public static int Kiemtrama(DTOTaiKhoan tk)
        {
            int i = SQLConnect.Kiemtrama("tblTaiKhoan", "TenTK", tk.TenTK);
            return i;
        }
        public static void UpDateMatKhau(DTOTaiKhoan tk)
        {
            string update = $"Update tblTaiKhoan set MatKhau = '{tk.MatKhau}' where TenTK = '{tk.TenTK}'";
            SQLConnect.ThucThi(update);

        }
        public static DataTable DocTaiKhoanNguoiDung()
        {
            string truyvan = "select tk.TenTK,tk.MatKhau, tk.Quyen,nv.TenNhanVien from tblTaiKhoan tk inner join tblNhanVien nv on tk.IDNV = nv.IDNV where tk.Quyen = 1";
            return SQLConnect.DocChiTietHoaDon(truyvan);
        }
    }
}
