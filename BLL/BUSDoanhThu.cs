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
            if (thang < 1 || thang > 12)
            {
                throw new Exception("Thang nhap vao khong hop le");
            }
            else if (nam < 2020 || nam > DateTime.Now.Year)
            {
                throw new Exception("Nam nhap vao khong hop le");
            }
            else
            {
                return DALDoanhThu.ThongKeDoanhThu(thang, nam);
            }
        }
    }
}
