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
using BLL;
using Guna.UI2.WinForms;


namespace GUI
{
    public partial class GUIChiTietHoaDonNhapHang : Form
    {
        DTOChiTietHoaDonNhap chitiet = new DTOChiTietHoaDonNhap();
        public GUIChiTietHoaDonNhapHang()
        {
            InitializeComponent();
        }

        private void GUIChiTietHoaDonNhapHang_Load(object sender, EventArgs e)
        {
            chitiet.IDHoaDonNhap = GUIHoaDonNhapHang.IDHoaDon;
            txtIDNV.Text = GUIHoaDonNhapHang.hoaDonNhapHang.IDNV;
            txtTenNhanVien.Text = BUSChiTietHoaDonNhap.LayThongTinNV(chitiet);

            txtIDNCC.Text = GUIHoaDonNhapHang.hoaDonNhapHang.IDNCC;
            txtTenNCC.Text = BUSChiTietHoaDonNhap.LayThongTinNCC(chitiet);

            lblTongTien.Text = BUSChiTietHoaDonNhap.TinhTien(chitiet).ToString("#,##0");
            dtgvChitietHDNhap.DataSource = BUSChiTietHoaDonNhap.DocChiTietHoaDon(chitiet);
            dtgvChitietHDNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (Control c in groupBox1.Controls)
            {
                if (c is Guna2TextBox)
                {
                    c.Enabled = false;
                }
            }
            foreach (Control c in groupBox2.Controls)
            {
                if (c is Guna2TextBox)
                {
                    c.Enabled = false;
                }
            }
        }

        private void dtgvChitietHDNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang >= 0 && e.ColumnIndex >= 0)
            {
                if (string.IsNullOrWhiteSpace(dtgvChitietHDNhap[e.ColumnIndex, hang].Value?.ToString()))
                {
                    MessageBox.Show("Không có dữ liệu");
                }
                else
                {
                    txtIDHoaDonNhap.Text = dtgvChitietHDNhap[0, hang].Value.ToString();
                    txtMaSP.Text = dtgvChitietHDNhap[1, hang].Value.ToString();
                    txtSoLuongNhap.Text = dtgvChitietHDNhap[2, hang].Value.ToString();
                    txtGiaCa.Text = dtgvChitietHDNhap[3, hang].Value.ToString();
                    txtIDHoaDonNhap.Enabled = false;
                    txtMaSP.Enabled = false;
                    txtGiaCa.Enabled = false;
                }
            }


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GUIThemSanPhamVaoHoaDonNhap them = new GUIThemSanPhamVaoHoaDonNhap();
            this.Hide();
            them.ShowDialog();

            this.Show();
            dtgvChitietHDNhap.DataSource = BUSChiTietHoaDonNhap.DocChiTietHoaDon(chitiet);
            lblTongTien.Text = BUSChiTietHoaDonNhap.TinhTien(chitiet).ToString("#,##0");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chitiet.IDHoaDonNhap = GUIHoaDonNhapHang.IDHoaDon;
            chitiet.MaSP = txtMaSP.Text;
            chitiet.SoLuongNhap = Convert.ToInt32(txtSoLuongNhap.Text);
            chitiet.GiaNhap = Convert.ToDouble(txtGiaCa.Text);
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSChiTietHoaDonNhap.SuaChiTietHoaDon(chitiet);
                    MessageBox.Show($"Cập nhật thông tin thành công cho sản phẩm {chitiet.MaSP} của hóa đơn {chitiet.IDHoaDonNhap}");
                    dtgvChitietHDNhap.DataSource = BUSChiTietHoaDonNhap.DocChiTietHoaDon(chitiet);
                    lblTongTien.Text = BUSChiTietHoaDonNhap.TinhTien(chitiet).ToString("#,##0");
                }
                else
                {
                    MessageBox.Show($"Hủy cập nhật thông tin sản phẩm {chitiet.MaSP} của hóa đơn {chitiet.IDHoaDonNhap} ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            chitiet.IDHoaDonNhap = GUIHoaDonNhapHang.IDHoaDon;
            chitiet.MaSP = txtMaSP.Text;
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSChiTietHoaDonNhap.XoaSanPham(chitiet);
                    MessageBox.Show($"Xóa thành công sản phẩm {chitiet.MaSP} của hóa đơn {chitiet.IDHoaDonNhap}");
                    dtgvChitietHDNhap.DataSource = BUSChiTietHoaDonNhap.DocChiTietHoaDon(chitiet);
                    lblTongTien.Text = BUSChiTietHoaDonNhap.TinhTien(chitiet).ToString("#,##0");
                }
                else
                {
                    MessageBox.Show($"Hủy xóa thông tin sản phẩm {chitiet.MaSP} của hóa đơn {chitiet.IDHoaDonNhap} ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox3.Controls)
            {
                if (c is Guna2TextBox)
                {
                    c.Text = "";
                }
            }
            txtIDHoaDonNhap.Enabled = true;
            txtMaSP.Enabled = true;
            txtGiaCa.Enabled = true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            chitiet.IDHoaDonNhap = GUIHoaDonNhapHang.IDHoaDon;
            DialogResult result = MessageBox.Show("Bạn có muốn thanh toán hóa đơn không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BUSChiTietHoaDonNhap.ThanhToanHoaDon(chitiet);
                MessageBox.Show($"Thanh toán thành công hóa đơn {chitiet.IDHoaDonNhap}");
            }
            else
            {
                MessageBox.Show($"Hủy thanh toán hóa đơn {chitiet.IDHoaDonNhap} ");
            }
        }
    }
}