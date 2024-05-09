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
    public partial class GUIHoaDonNhapHang : Form
    {
        public static DTOHoaDonNhap hoaDonNhapHang = new DTOHoaDonNhap();
        public GUIHoaDonNhapHang()
        {
            InitializeComponent();
        }

        private void GUIHoaDonNhapHang_Load(object sender, EventArgs e)
        {
            dtgvHDN.DataSource = BUSHoaDonNhap.DodulieuPKN("tblHoaDonNhap");
            cboIDNCC.DataSource = BUSHoaDonNhap.LoadComboboxPKN("tblNCC");
            cboIDNCC.DisplayMember = "TenNCC";
            cboIDNCC.ValueMember = "IDNCC";
            cboIDNV.DataSource = BUSHoaDonNhap.LoadComboboxPKN("tblNhanVien");
            cboIDNV.DisplayMember = "TenNhanVien";
            cboIDNV.ValueMember = "IDNV";
            txtIDHoaDonNhap.Enabled = false;
            txtTrangThai.Enabled = false;
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            hoaDonNhapHang.IDNCC = cboIDNCC.SelectedValue.ToString();
            hoaDonNhapHang.IDNV = cboIDNV.SelectedValue.ToString();
            hoaDonNhapHang.NgayNhap = dtpkNgayNhap.Value;
            try
            {
                BUSHoaDonNhap.TaoHoaDonNhap(hoaDonNhapHang);
                MessageBox.Show("Tạo thành công hóa đơn");
                dtgvHDN.DataSource = BUSHoaDonNhap.DodulieuPKN("tblHoaDonNhap");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            hoaDonNhapHang.IDHoaDonNhap = int.Parse(txtIDHoaDonNhap.Text);
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thông tin hóa đơn này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSHoaDonNhap.XoaHoaDonNhap(hoaDonNhapHang);
                    MessageBox.Show($"Xóa thành công thông tin hóa đơn có mã là {hoaDonNhapHang.IDHoaDonNhap}");
                    dtgvHDN.DataSource = BUSHoaDonNhap.DodulieuPKN("tblHoaDonNhap");
                }
                else
                {
                    MessageBox.Show($"Hủy bỏ xóa thông tin hóa đơn có mã là  {hoaDonNhapHang.IDHoaDonNhap}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is Guna2TextBox)
                {
                    c.Text = "";
                }
                if (c is Guna2ComboBox)
                {
                    c.Text = "";
                }
            }
            txtIDHoaDonNhap.Enabled = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cboLuaChon.SelectedItem.ToString() == "Mã Hóa Đơn")
            {
                dtgvHDN.DataSource = BUSHoaDonNhap.TimKiem("tblHoaDonNhap", "IDHoaDonNhap", txtTimKiem.Text);
            }
            else if (cboLuaChon.SelectedItem.ToString() == "Mã Nhà Cung Cấp")
            {
                dtgvHDN.DataSource = BUSHoaDonNhap.TimKiem("tblHoaDonNhap", "IDNCC", txtTimKiem.Text);
            }
            else if (cboLuaChon.SelectedItem.ToString() == "Mã Nhân Viên")
            {
                dtgvHDN.DataSource = BUSHoaDonNhap.TimKiem("tblHoaDonNhap", "IDNV", txtTimKiem.Text);
            }
            else if (cboLuaChon.SelectedItem.ToString() == "Trạng Thái")
            {
                dtgvHDN.DataSource = BUSHoaDonNhap.TimKiem("tblHoaDonNhap", "TrangThai", txtTimKiem.Text);
            }
        }
        public static int IDHoaDon;
        private void dtgvHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtIDHoaDonNhap.Text = dtgvHDN[0, hang].Value.ToString();
            IDHoaDon = int.Parse(txtIDHoaDonNhap.Text);
            cboIDNCC.SelectedValue = hoaDonNhapHang.IDNCC = dtgvHDN[1, hang].Value.ToString();
            cboIDNV.SelectedValue = hoaDonNhapHang.IDNV = dtgvHDN[2, hang].Value.ToString();
            dtpkNgayNhap.Value = (DateTime)dtgvHDN[3, hang].Value;
            txtTrangThai.Text = dtgvHDN[4, hang].Value.ToString();
            txtIDHoaDonNhap.Enabled = false;
        }

        private void dtgvHDN_DoubleClick(object sender, EventArgs e)
        {
            hoaDonNhapHang.IDHoaDonNhap = int.Parse(txtIDHoaDonNhap.Text);
            if(BUSHoaDonNhap.XetHoaDon(hoaDonNhapHang) == 0 )
            {
                GUIThemSanPhamVaoHoaDonNhap themsanpham = new GUIThemSanPhamVaoHoaDonNhap();
                this.Hide();
                themsanpham.ShowDialog();

                this.Show();
            }
            else
            {
                GUIChiTietHoaDonNhapHang chitiethdn = new GUIChiTietHoaDonNhapHang();
                this.Hide();
                chitiethdn.ShowDialog();

                this.Show();
                btnreset_Click(sender, e);
                dtgvHDN.DataSource = BUSHoaDonNhap.DodulieuPKN("tblHoaDonNhap");
            }
        }
    }
}
