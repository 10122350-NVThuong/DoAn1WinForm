using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDoanhThu
    {
        public static DataTable ThongKeDoanhThu(int? thang, int? nam)
        {
            SQLConnect.KetNoi();
            SQLConnect.da = new SqlDataAdapter();
            SQLConnect.cmd = new SqlCommand();
            SQLConnect.cmd = new SqlCommand("ProcDoanhThu", SQLConnect.connect);
            SQLConnect.cmd.CommandType = CommandType.StoredProcedure;
            SQLConnect.cmd.Parameters.Clear();
            SQLConnect.cmd.Parameters.AddWithValue("@Month", thang ?? (object)DBNull.Value);
            SQLConnect.cmd.Parameters.AddWithValue("@Year", nam ?? (object)DBNull.Value);
            SQLConnect.da.SelectCommand = SQLConnect.cmd;
            SQLConnect.dt = new DataTable();
            SQLConnect.da.Fill(SQLConnect.dt);
            SQLConnect.ngatketnoi();
            return SQLConnect.dt;
        }
    }
}
