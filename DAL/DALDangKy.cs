using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDangKy
    {
        public static void DangKyTaiKhoan(DTONhanVien nv, DTOTaiKhoan tk)
        {
            string themnhanvien = $"insert into tblNhanVien values ('{nv.IDNV}', N'{nv.Name}', N'{nv.GioiTinh}', '{nv.birth}', N'{nv.DiaChi}', '{nv.Email}', '{nv.SDT}')";
            SQLConnect.ThucThi(themnhanvien);
            string themtaikhoan = $"insert into tblTaiKhoan values ('{tk.TenTK}', '{tk.MatKhau}', {tk.Quyen}, '{tk.FK_IDNV}')";
            SQLConnect.ThucThi(themtaikhoan);
        }
    }
}
