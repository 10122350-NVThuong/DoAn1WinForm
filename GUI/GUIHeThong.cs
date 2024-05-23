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
    public partial class GUIHeThong : Form
    {
        public GUIHeThong()
        {
            InitializeComponent();
        }

        public static int code;

        private void GUIHeThong_Load(object sender, EventArgs e)
        {
            if (code == 1)
            {
                BCTKToolStrip.Enabled = false;
                QLNVToolStrip.Enabled = false;
                DangKyToolStrip.Enabled = false;
                QLNDToolStrip.Enabled = false;
            }
        }

        private void DangKyToolStrip_Click(object sender, EventArgs e)
        {
            GUIDangKy dangKy = new GUIDangKy();
            this.Hide();
            dangKy.ShowDialog();

            this.Show();
        }

        private void DangXuatTollStrip_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void QLDMSPToolStrip_Click(object sender, EventArgs e)
        {
            GUIDanhMucSanPham danhMucSP = new GUIDanhMucSanPham();
            this.Hide();
            danhMucSP.ShowDialog();
            this.Show();
        }

        private void QLTTSPToolStrip_Click(object sender, EventArgs e)
        {
            GUIThongTinSanPham sanPham = new GUIThongTinSanPham();
            this.Hide();
            sanPham.ShowDialog();

            this.Show();
        }

        private void QLNVToolStrip_Click(object sender, EventArgs e)
        {
            GUINhanVien nhanVien = new GUINhanVien();
            this.Hide();
            nhanVien.ShowDialog();

            this.Show();
        }

        private void QLNCCTool_Click(object sender, EventArgs e)
        {
            GUINhaCungCap nhaCungCap = new GUINhaCungCap();
            this.Hide();
            nhaCungCap.ShowDialog();

            this.Show();
        }

        private void QLKHTool_Click(object sender, EventArgs e)
        {
            GUIKhachHang khachHang = new GUIKhachHang();
            this.Hide();
            khachHang.ShowDialog();

            this.Show();
        }

        private void TimKiemSPTool_Click(object sender, EventArgs e)
        {
            GUIThongTinSanPham sanPham = new GUIThongTinSanPham();
            this.Hide();
            sanPham.ShowDialog();

            this.Show();
        }

        private void TimKiemNhanVienTool_Click(object sender, EventArgs e)
        {
            GUINhanVien nhanVien = new GUINhanVien();
            this.Hide();
            nhanVien.ShowDialog();

            this.Show();
        }

        private void TimKiemKhachHangTool_Click(object sender, EventArgs e)
        {
            GUIKhachHang khachHang = new GUIKhachHang();
            this.Hide();
            khachHang.ShowDialog();

            this.Show();
        }

        private void TimKiemNCCTool_Click(object sender, EventArgs e)
        {
            GUINhaCungCap nhaCungCap = new GUINhaCungCap();
            this.Hide();
            nhaCungCap.ShowDialog();

            this.Show();
        }

        private void HoaDonNhapTool_Click(object sender, EventArgs e)
        {
            GUIHoaDonNhapHang hoaDonNhapHang = new GUIHoaDonNhapHang();
            this.Hide();
            hoaDonNhapHang.ShowDialog();

            this.Show();
        }

        private void HoaDonBanTool_Click(object sender, EventArgs e)
        {
            GUIHoaDonBanHang hoaDonBanHang = new GUIHoaDonBanHang();
            this.Hide();
            hoaDonBanHang.ShowDialog();

            this.Show();
        }

        private void ThoatToolStrip_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void QLNDToolStrip_Click(object sender, EventArgs e)
        {
            GUIQuanLyNguoiDung quanLyNguoiDung = new GUIQuanLyNguoiDung();
            this.Hide();
            quanLyNguoiDung.ShowDialog();

            this.Show();
        }

        private void InAnToolStrip_Click(object sender, EventArgs e)
        {
            GUIInHoaDon inHoaDon = new GUIInHoaDon();
            this.Hide();
            inHoaDon.ShowDialog();

            this.Show();
        }

        private void SanPhamTonKhoTollStrip_Click(object sender, EventArgs e)
        {
            rptThongKeSPTon report = new rptThongKeSPTon();
            report.SetDataSource(BUSSanPham.ThongKeSanPhamTon());
            GUIFrmBaoCao frm = new GUIFrmBaoCao();
            frm.CRreport.ReportSource = report;
            this.Hide();
            frm.ShowDialog();

            this.Show();
        }

        private void ThongKeDoanhThuToolStrip_Click(object sender, EventArgs e)
        {
            GUIThongKeDoanhThu dt = new GUIThongKeDoanhThu();
            this.Hide();
            dt.ShowDialog();

            this.Show();
        }

        private void ThongKeSPbanchayToolStrip_Click(object sender, EventArgs e)
        {
            rptThongKeSPBanChay report = new rptThongKeSPBanChay();
            report.SetDataSource(BUSSanPham.ThongKeSanPhamBanChay());
            GUIFrmBaoCao frm = new GUIFrmBaoCao();
            frm.CRreport.ReportSource = report;
            this.Hide();
            frm.ShowDialog();

            this.Show();
        }

        private void HelpToolStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Khi cần giúp đỡ hãy gọi điện đến số điện thoại: 0366424014\nhoặc nhắn tin qua gmail: nvthuongcl2004@gmail.com");
        }
    }
}
