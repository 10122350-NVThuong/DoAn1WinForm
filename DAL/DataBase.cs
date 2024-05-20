using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SQLConnect
    {
        public static SqlConnection connect;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static SqlDataReader dr;
        public static DataTable dt;
        public static string chuoikn = @"Data Source=LAPTOP-HG23EHP9\SQLEXPRESS;Initial Catalog=DoAn1DoDienGiaDung;Integrated Security=True";
        public static void KetNoi()
        {
            connect = new SqlConnection(chuoikn);
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }
        public static void ngatketnoi()
        {
            connect = new SqlConnection((chuoikn));
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }
        public static DataTable DodulieuPKN(string TenBang)
        {
            KetNoi();
            da = new SqlDataAdapter($"select * from {TenBang}", connect);
            dt = new DataTable();
            da.Fill(dt);
            ngatketnoi();
            return dt;
        }
        public static DataTable DocChiTietHoaDon(string truyvan)
        {
            KetNoi();
            da = new SqlDataAdapter(truyvan, connect);
            dt = new DataTable();
            da.Fill(dt);
            ngatketnoi();
            return dt;
        }
        public static void ThucThi(string Sql)
        {
            KetNoi();
            cmd = new SqlCommand(Sql, connect);
            cmd.ExecuteNonQuery();
            ngatketnoi();
        }
        public static int Kiemtrama(string TenBang, string TenCot, string ma)
        {
            KetNoi();
            int i;
            cmd = new SqlCommand($"Select count(*) from {TenBang} Where {TenCot} = '{ma}'", connect);
            i = (int)cmd.ExecuteScalar();
            ngatketnoi();
            return i;
        }
        public static int Kiemtrahoadon(string truyvan)
        {
            KetNoi();
            int i;
            cmd = new SqlCommand(truyvan , connect);
            i = (int)cmd.ExecuteScalar();
            ngatketnoi();
            return i;
        }
        public static string LayThongTin(string truyvan)
        {
            KetNoi();
            string thongtin = "";
            cmd = new SqlCommand(truyvan, connect);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                thongtin = dr.GetString(0).ToString();
            }
            dr.Close();
            ngatketnoi();
            return thongtin;
        }
        public static DataTable LoadComboboxPKN(string TenBang)
        {
            KetNoi();
            da = new SqlDataAdapter($"select * from {TenBang}", chuoikn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            ngatketnoi();
            return dt;
        }
        public static DataTable LoadComboboxPKN2(string TenBang, string Ma)
        {
            KetNoi();
            da = new SqlDataAdapter($"select {Ma} from {TenBang}", chuoikn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            ngatketnoi();
            return dt;
        }
        public static DataTable TimKiem(string tablename, string columnname, string thonhtintimkiem)
        {
            KetNoi();
            da = new SqlDataAdapter($"select * from {tablename} where {columnname} like '%{thonhtintimkiem}%'", connect);
            dt = new DataTable();
            da.Fill(dt);
            ngatketnoi();
            return dt;
        }
        public static int LaySoLuongTon(string truyvan)
        {
            KetNoi();
            int i = 0;
            cmd = new SqlCommand(truyvan, connect);
            object result = cmd.ExecuteScalar();
            i = Convert.ToInt32(result);
            ngatketnoi();
            return i;
        }

        public static double TinhTien(string truyvan)
        {
            double result =0;
            KetNoi();
            cmd = new SqlCommand(truyvan, connect);
            object queryResult = cmd.ExecuteScalar();
            if (queryResult != null && queryResult != DBNull.Value)
            {
                result = Convert.ToDouble(queryResult);
            }
            ngatketnoi();
            return result;
        }

    }

    public class DataBase
    {
        public static int KtrDN(DTOTaiKhoan tk)
        {
            SQLConnect.KetNoi();
            int i;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "AuthorLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", tk.TenTK);
            cmd.Parameters.AddWithValue("@Password", tk.MatKhau);
            cmd.Connection = SQLConnect.connect;
            i = (int)cmd.ExecuteScalar();
            SQLConnect.ngatketnoi();
            return i;
        }
    }
}
