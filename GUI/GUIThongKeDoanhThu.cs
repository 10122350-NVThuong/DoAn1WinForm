using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUIThongKeDoanhThu : Form
    {
        public GUIThongKeDoanhThu()
        {
            InitializeComponent();
        }
        public static int? thang = null, nam = null;

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // Kiểm tra và phân tích tháng nếu được cung cấp
            if (!string.IsNullOrWhiteSpace(txtThang.Text) && int.TryParse(txtThang.Text, out int parsedThang))
            {
                thang = parsedThang;
            }

            // Kiểm tra và phân tích năm nếu được cung cấp
            if (!string.IsNullOrWhiteSpace(txtNam.Text) && int.TryParse(txtNam.Text, out int parsedNam))
            {
                nam = parsedNam;
            }

            rptThongKeDoanhThu report = new rptThongKeDoanhThu();
            report.SetDataSource(BUSDoanhThu.ThongKeDoanhThu(thang, nam));
            GUIFrmBaoCao frm = new GUIFrmBaoCao();
            frm.CRreport.ReportSource = report;
            frm.ShowDialog();

        }
    }
}
