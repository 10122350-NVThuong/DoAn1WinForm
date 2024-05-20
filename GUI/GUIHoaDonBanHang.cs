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
    public partial class GUIHoaDonBanHang : Form
    {
        public GUIHoaDonBanHang()
        {
            InitializeComponent();
        }

        public static DTOHoaDonBan hoaDonBan = new DTOHoaDonBan();
        private void GUIHoaDonBanHang_Load(object sender, EventArgs e)
        {
            dtpkNgayBan.Value = DateTime.Now;
            dtgvHDB.DataSource = BUSHoaDonBan.DodulieuPKN("tblHoaDonBan");
            cboIDKH.DataSource = BUSHoaDonBan.LoadComboboxPKN("tblKhachHang");
            cboIDKH.DisplayMember = "TenKhachHang";
            cboIDKH.ValueMember = "IDKH";
            cboIDNV.DataSource = BUSHoaDonBan.LoadComboboxPKN("tblNhanVien");
            cboIDNV.DisplayMember = "TenNhanVien";
            cboIDNV.ValueMember = "IDNV";
            txtIDHoaDonBan.Enabled = false;
            txtTrangThai.Enabled = false;
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            hoaDonBan.IDKH = cboIDKH.SelectedValue.ToString();
            hoaDonBan.IDNV = cboIDNV.SelectedValue.ToString();
            hoaDonBan.NgayBan = dtpkNgayBan.Value;
            try
            {
                BUSHoaDonBan.TaoHoaDonBan(hoaDonBan);
                MessageBox.Show("Tạo thành công hóa đơn");
                dtgvHDB.DataSource = BUSHoaDonBan.DodulieuPKN("tblHoaDonBan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            hoaDonBan.IDHoaDonBan = int.Parse(txtIDHoaDonBan.Text);
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thông tin hóa đơn này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSHoaDonBan.XoaHoaDonBan(hoaDonBan);
                    MessageBox.Show($"Xóa thành công thông tin hóa đơn có mã là {hoaDonBan.IDHoaDonBan}");
                    dtgvHDB.DataSource = BUSHoaDonBan.DodulieuPKN("tblHoaDonBan");
                }
                else
                {
                    MessageBox.Show($"Hủy bỏ xóa thông tin hóa đơn có mã là  {hoaDonBan.IDHoaDonBan}");
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
            txtIDHoaDonBan.Enabled = true;
        }
        public static int IDHoaDon;
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cboLuaChon.SelectedItem.ToString() == "Mã Hóa Đơn")
            {
                dtgvHDB.DataSource = BUSHoaDonBan.TimKiem("tblHoaDonBan", "IDHoaDonBan", txtTimKiem.Text);
            }
            else if (cboLuaChon.SelectedItem.ToString() == "Mã Khách Hàng")
            {
                dtgvHDB.DataSource = BUSHoaDonBan.TimKiem("tblHoaDonBan", "IDKH", txtTimKiem.Text);
            }
            else if (cboLuaChon.SelectedItem.ToString() == "Mã Nhân Viên")
            {
                dtgvHDB.DataSource = BUSHoaDonBan.TimKiem("tblHoaDonBan", "IDNV", txtTimKiem.Text);
            }
            else if (cboLuaChon.SelectedItem.ToString() == "Trạng Thái")
            {
                dtgvHDB.DataSource = BUSHoaDonBan.TimKiem("tblHoaDonBan", "TrangThai", txtTimKiem.Text);
            }
        }

        private void dtgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtIDHoaDonBan.Text = dtgvHDB[0, hang].Value.ToString();
            IDHoaDon = int.Parse(txtIDHoaDonBan.Text);
            cboIDKH.SelectedValue = hoaDonBan.IDKH = dtgvHDB[1, hang].Value.ToString();
            cboIDNV.SelectedValue = hoaDonBan.IDNV = dtgvHDB[2, hang].Value.ToString();
            dtpkNgayBan.Value = (DateTime)dtgvHDB[3, hang].Value;
            txtTrangThai.Text = dtgvHDB[4, hang].Value.ToString();
            txtIDHoaDonBan.Enabled = false;
        }

        private void dtgvHDB_DoubleClick(object sender, EventArgs e)
        {
            hoaDonBan.IDHoaDonBan = int.Parse(txtIDHoaDonBan.Text);
            if (BUSHoaDonBan.XetHoaDon(hoaDonBan) == 0)
            {
                GUIThemSanPhamVaoHoaDonXuat themsanpham = new GUIThemSanPhamVaoHoaDonXuat();
                this.Hide();
                themsanpham.ShowDialog();

                this.Show();
            }
            else
            {
                GUIChiTietHoaDonXuatHang chitiethdn = new GUIChiTietHoaDonXuatHang();
                this.Hide();
                chitiethdn.ShowDialog();

                this.Show();
                btnreset_Click(sender, e);
                dtgvHDB.DataSource = BUSHoaDonBan.DodulieuPKN("tblHoaDonBan");
            }
        }
    }
}
