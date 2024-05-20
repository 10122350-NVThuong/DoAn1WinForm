using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class DALHoaDonNhapHang
    {
        public static int Kiemtrama(DTOHoaDonNhap hoaDonNhap)
        {
            int i = SQLConnect.Kiemtrama("tblHoaDonNhap", "IDHoaDonNhap", hoaDonNhap.IDHoaDonNhap.ToString());
            return i;
        }
        public static DataTable DodulieuPKN(string TenBang)
        {
            return SQLConnect.DodulieuPKN(TenBang);
        }
        public static DataTable ĐoculieuSanPham(DTOHoaDonNhap hoaDonNhap)
        {
            string truyvan = $"select * from tblMatHang where IDNCC = '{hoaDonNhap.IDNCC}'";
            return SQLConnect.DocChiTietHoaDon(truyvan);
        }
        public static DataTable LoadComboboxPKN(string TenBang)
        {
            return SQLConnect.LoadComboboxPKN(TenBang);
        }
        public static DataTable LoadMaHDN()
        {
            return SQLConnect.LoadComboboxPKN2("tblHoaDonNhap", "IDHoaDonNhap");
        }
        public static void TaoHoaDonNhap(DTOHoaDonNhap hoaDonNhap)
        {
            string taohoadon = $"insert into tblHoaDonNhap(IDNCC,IDNV, NgayNhap) values ('{hoaDonNhap.IDNCC}', '{hoaDonNhap.IDNV}', '{hoaDonNhap.NgayNhap}');";
            SQLConnect.ThucThi(taohoadon);
        }
        public static void XoaHoaDonNhap(DTOHoaDonNhap hoaDonNhap)
        {
            string xoahoadon = $"delete from tblHoaDonNhap where IDHoaDonNhap = {hoaDonNhap.IDHoaDonNhap}";
            SQLConnect.ThucThi(xoahoadon);
        }
        public static DataTable TimKiem(string tablename, string columnname, string thonhtintimkiem)
        {
            return SQLConnect.TimKiem(tablename, columnname, thonhtintimkiem);
        }
        public static int XetHoaDon(DTOHoaDonNhap hoaDonNhap)
        {
            int i = SQLConnect.Kiemtrama("tblChiTietHDNhap", "IDHoaDonNhap", hoaDonNhap.IDHoaDonNhap.ToString());
            return i;
        }
        public static DataTable InHoaDonNhap(DTOHoaDonNhap hdn)
        {
            SQLConnect.KetNoi();
            SQLConnect.da = new SqlDataAdapter();
            SQLConnect.cmd = new SqlCommand();
            SQLConnect.cmd = new SqlCommand("ProCInHoaDonNhap", SQLConnect.connect);
            SQLConnect.cmd.CommandType = CommandType.StoredProcedure;
            SQLConnect.cmd.Parameters.Clear();
            SQLConnect.cmd.Parameters.AddWithValue("@IDHoaDonNhap", hdn.IDHoaDonNhap);
            SQLConnect.da.SelectCommand = SQLConnect.cmd;
            SQLConnect.dt = new DataTable();
            SQLConnect.da.Fill(SQLConnect.dt);
            SQLConnect.ngatketnoi();
            return SQLConnect.dt;
        }
    }
}
