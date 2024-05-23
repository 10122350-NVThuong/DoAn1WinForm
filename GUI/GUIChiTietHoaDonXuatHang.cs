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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    public partial class GUIChiTietHoaDonXuatHang : Form
    {
        public GUIChiTietHoaDonXuatHang()
        {
            InitializeComponent();
        }
        DTOChiTietHoaDonBan chitiet = new DTOChiTietHoaDonBan();
        private void GUIChiTietHoaDonXuatHang_Load(object sender, EventArgs e)
        {
            chitiet.IDHoaDonBan = GUIHoaDonBanHang.IDHoaDon;
            txtIDNV.Text = GUIHoaDonBanHang.hoaDonBan.IDNV;
            txtTenNhanVien.Text = BUSChiTietHoaDonBan.LayThongTinNV(chitiet);

            txtIDKH.Text = GUIHoaDonBanHang.hoaDonBan.IDKH;
            txtTenKhachHang.Text = BUSChiTietHoaDonBan.LayThongTinKH(chitiet);

            lblTongTien.Text = BUSChiTietHoaDonBan.TinhTien(chitiet).ToString("#,##0");
            dtgvCTHDB.DataSource = BUSChiTietHoaDonBan.DocChiTietHoaDon(chitiet);
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
            dtgvCTHDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dtgvCTHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang >= 0 && e.ColumnIndex >= 0)
            {
                if (string.IsNullOrWhiteSpace(dtgvCTHDB[e.ColumnIndex, hang].Value?.ToString()))
                {
                    MessageBox.Show("Không có dữ liệu");
                }
                else
                {
                    txtIDHoaDonBan.Text = dtgvCTHDB[0, hang].Value.ToString();
                    txtMaSP.Text = dtgvCTHDB[1, hang].Value.ToString();
                    txtSoLuongBan.Text = dtgvCTHDB[2, hang].Value.ToString();
                    txtGiaBan.Text = dtgvCTHDB[3, hang].Value.ToString();
                    txtIDHoaDonBan.Enabled = false;
                    txtMaSP.Enabled = false;
                    txtGiaBan.Enabled = false;
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GUIThemSanPhamVaoHoaDonXuat them = new GUIThemSanPhamVaoHoaDonXuat();
            this.Hide();
            them.ShowDialog();

            this.Show();
            dtgvCTHDB.DataSource = BUSChiTietHoaDonBan.DocChiTietHoaDon(chitiet);
            lblTongTien.Text = BUSChiTietHoaDonBan.TinhTien(chitiet).ToString("#,##0");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            chitiet.IDHoaDonBan = GUIHoaDonBanHang.IDHoaDon;
            chitiet.MaSP = txtMaSP.Text;
            chitiet.SoLuongBan = Convert.ToInt32(txtSoLuongBan.Text);
            chitiet.GiaBan = Convert.ToDouble(txtGiaBan.Text);

            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSChiTietHoaDonBan.SuaChiTietHoaDon(chitiet);
                    MessageBox.Show($"Cập nhật thông tin thành công cho sản phẩm {chitiet.MaSP} của hóa đơn {chitiet.IDHoaDonBan}");
                    dtgvCTHDB.DataSource = BUSChiTietHoaDonBan.DocChiTietHoaDon(chitiet);
                    lblTongTien.Text = BUSChiTietHoaDonBan.TinhTien(chitiet).ToString("#,##0");
                }
                else
                {
                    MessageBox.Show($"Hủy cập nhật thông tin sản phẩm {chitiet.MaSP} của hóa đơn {chitiet.IDHoaDonBan} ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            chitiet.IDHoaDonBan = GUIHoaDonBanHang.IDHoaDon;
            chitiet.MaSP = txtMaSP.Text;
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSChiTietHoaDonBan.XoaSanPham(chitiet);
                    MessageBox.Show($"Xóa thành công sản phẩm {chitiet.MaSP} của hóa đơn {chitiet.IDHoaDonBan}");
                    dtgvCTHDB.DataSource = BUSChiTietHoaDonBan.DocChiTietHoaDon(chitiet);
                    lblTongTien.Text = BUSChiTietHoaDonBan.TinhTien(chitiet).ToString("#,##0");
                }
                else
                {
                    MessageBox.Show($"Hủy xóa thông tin sản phẩm {chitiet.MaSP} của hóa đơn {chitiet.IDHoaDonBan} ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            txtIDHoaDonBan.Enabled = true;
            txtMaSP.Enabled = true;
            txtGiaBan.Enabled = true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            chitiet.IDHoaDonBan = GUIHoaDonBanHang.IDHoaDon;
            DialogResult result = MessageBox.Show("Bạn có muốn thanh toán hóa đơn không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BUSChiTietHoaDonBan.ThanhToanHoaDon(chitiet);
                MessageBox.Show($"Thanh toán thành công hóa đơn {chitiet.IDHoaDonBan}");
            }
            else
            {
                MessageBox.Show($"Hủy thanh toán hóa đơn {chitiet.IDHoaDonBan} ");
            }
        }

    }
}
