using BLL;
using DTO;
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
    public partial class GUIInHoaDon : Form
    {
        public GUIInHoaDon()
        {
            InitializeComponent();
        }

        DTOHoaDonNhap hdn = new DTOHoaDonNhap();
        DTOHoaDonBan hdb = new DTOHoaDonBan();
        private void btnInHDN_Click(object sender, EventArgs e)
        {
            if (cbohoadonnhap.SelectedItem != null)
            {
                hdn.IDHoaDonNhap = int.Parse(cbohoadonnhap.SelectedItem.ToString());
                rptInHoaDonNhap report = new rptInHoaDonNhap();
                report.SetDataSource(BUSHoaDonNhap.InHoaDonNhap(hdn));
                GUIFrmBaoCao frm = new GUIFrmBaoCao();
                frm.CRreport.ReportSource = report;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn nhập để in");
            }

        }

        private void GUIInHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = BUSHoaDonNhap.LoadMaHDN();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cbohoadonnhap.Items.Add(row["IDHoaDonNhap"].ToString());
                }
            }

            DataTable dt2 = BUSHoaDonBan.LoadMaHDN();
            if (dt2.Rows.Count > 0)
            {
                foreach (DataRow row in dt2.Rows)
                {
                    cbohoadonban.Items.Add(row["IDHoaDonBan"].ToString());
                }
            }
        }

        private void btnInHDX_Click(object sender, EventArgs e)
        {
            if (cbohoadonban.SelectedItem != null)
            {
                hdb.IDHoaDonBan = int.Parse(cbohoadonban.SelectedItem.ToString());
                rptInHoaDonBan report = new rptInHoaDonBan();
                report.SetDataSource(BUSHoaDonBan.InHoaDonBan(hdb));
                GUIFrmBaoCao frm = new GUIFrmBaoCao();
                frm.CRreport.ReportSource = report;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn bán để in");
            }
        }
    }
}
