using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BUSDoanhThu
    {
        public static DataTable ThongKeDoanhThu(int? thang, int? nam)
        {
            return DALDoanhThu.ThongKeDoanhThu(thang, nam);
        }
    }
}
