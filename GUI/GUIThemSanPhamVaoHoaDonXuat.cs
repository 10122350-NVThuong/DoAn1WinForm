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
using DTO;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class GUIThemSanPhamVaoHoaDonXuat : Form
    {
        DTOChiTietHoaDonBan chiTiet;
        public GUIThemSanPhamVaoHoaDonXuat()
        {
            InitializeComponent();
            chiTiet = new DTOChiTietHoaDonBan();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            chiTiet.IDHoaDonBan = GUIHoaDonBanHang.IDHoaDon;
            chiTiet.MaSP = txtMaSP.Text;
            chiTiet.SoLuongBan = Convert.ToInt32(txtSoLuongBan.Text);
            chiTiet.GiaBan = Convert.ToDouble(txtGiaBan.Text);
            try
            {
                BUSChiTietHoaDonBan.ThemSanPhamVaoHoaDon(chiTiet);
                MessageBox.Show($"Nhập thành công sản phảm có mã {chiTiet.MaSP}");
                dtgvSanPham.DataSource = BUSSanPham.DodulieuPKN("tblMatHang");
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
            txtMaSP.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang >= 0 && e.ColumnIndex >= 0)
            {
                if (string.IsNullOrWhiteSpace(dtgvSanPham[e.ColumnIndex, hang].Value?.ToString()))
                {
                    MessageBox.Show("Không có dữ liệu");
                }
                else
                {
                    txtMaSP.Text = dtgvSanPham[0, hang].Value.ToString();
                    txtGiaBan.Text = dtgvSanPham[5, hang].Value.ToString();
                    txtMaSP.Enabled = false;
                    txtGiaBan.Enabled = false;
                }
            }
        }

        private void GUIThemSanPhamVaoHoaDonXuat_Load(object sender, EventArgs e)
        {
            dtgvSanPham.DataSource = BUSSanPham.DodulieuPKN("tblMatHang");
        }
    }
}
