using BLL;
using DTO;
using Guna.UI2.WinForms;
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
    public partial class GUIThemSanPhamVaoHoaDonNhap : Form
    {
        DTOChiTietHoaDonNhap chiTietHoaDonNhap;
        public GUIThemSanPhamVaoHoaDonNhap()
        {
            InitializeComponent();
            chiTietHoaDonNhap = new DTOChiTietHoaDonNhap();
        }

        DTOHoaDonNhap hdn = new DTOHoaDonNhap();
        private void btThem_Click(object sender, EventArgs e)
        {
            hdn.IDNCC = GUIHoaDonNhapHang.hoaDonNhapHang.IDNCC;
            chiTietHoaDonNhap.IDHoaDonNhap = GUIHoaDonNhapHang.IDHoaDon;
            chiTietHoaDonNhap.MaSP = txtMaSP.Text;
            chiTietHoaDonNhap.SoLuongNhap = Convert.ToInt32(txtSoLuongNhap.Text);
            chiTietHoaDonNhap.GiaNhap = Convert.ToDouble(txtGiaNhap.Text);
            try
            {
                BUSChiTietHoaDonNhap.ThemSanPhamVaoHoaDon(chiTietHoaDonNhap);
                MessageBox.Show($"Nhập thành công sản phảm có mã {chiTietHoaDonNhap.MaSP}");
                dtgvSP.DataSource = BUSHoaDonNhap.ĐoculieuSanPham(hdn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GUIThemSanPhamVaoHoaDonNhap_Load(object sender, EventArgs e)
        {
            hdn.IDNCC = GUIHoaDonNhapHang.hoaDonNhapHang.IDNCC;
            dtgvSP.DataSource = BUSHoaDonNhap.ĐoculieuSanPham(hdn);
        }

        private void btnlm_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is Guna2TextBox)
                {
                    c.Text = "";
                }
            }
            txtMaSP.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang >= 0 && e.ColumnIndex >= 0)
            {
                if (string.IsNullOrWhiteSpace(dtgvSP[e.ColumnIndex, hang].Value?.ToString()))
                {
                    MessageBox.Show("Không có dữ liệu");
                }
                else
                {
                    txtMaSP.Text = dtgvSP[0, hang].Value.ToString();
                    txtMaSP.Enabled = false;
                }
            }

        }
    }
}
