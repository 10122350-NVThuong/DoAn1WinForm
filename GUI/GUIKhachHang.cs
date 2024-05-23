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
    public partial class GUIKhachHang : Form
    {
        DTOKhachHang khachHang;
        public GUIKhachHang()
        {
            InitializeComponent();
            khachHang = new DTOKhachHang();
        }

        private void GUIKhachHang_Load(object sender, EventArgs e)
        {
            dtgvKH.DataSource = BUSKhachHang.DodulieuPKN("tblKhachHang");
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cboLuaChon.SelectedItem != null)
            {
                if (cboLuaChon.SelectedItem.ToString() == "Mã khách hàng")
                {
                    dtgvKH.DataSource = BUSKhachHang.TimKiem("tblKhachHang", "IDKH", txtTimKiem.Text);
                }
                else if (cboLuaChon.SelectedItem.ToString() == "Tên khách hàng")
                {
                    dtgvKH.DataSource = BUSKhachHang.TimKiem("tblKhachHang", "TenKhachHang", txtTimKiem.Text);

                }
                else if (cboLuaChon.SelectedItem.ToString() == "Giới tính")
                {
                    dtgvKH.DataSource = BUSKhachHang.TimKiem("tblKhachHang", "GioiTinh", txtTimKiem.Text);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 tiêu chí tìm kiếm ở trên");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            khachHang.IDKH = txtIDKH.Text;
            khachHang.TenKhachHang = txtTenKhachHang.Text;
            khachHang.GioiTinh = txtGioiTinh.Text;
            khachHang.NgaySinh = dtpkNgaySinh.Value;
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.SDT = txtSDT.Text;
            try
            {
                BUSKhachHang.ThemKhachHang(khachHang);
                MessageBox.Show("Thêm thành công khách hàng");
                dtgvKH.DataSource = BUSKhachHang.DodulieuPKN("tblKhachHang");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            khachHang.IDKH = txtIDKH.Text;
            khachHang.TenKhachHang = txtTenKhachHang.Text;
            khachHang.GioiTinh = txtGioiTinh.Text;
            khachHang.NgaySinh = dtpkNgaySinh.Value;
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.SDT = txtSDT.Text;
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSKhachHang.CapNhatThongTinKhachHang(khachHang);
                    MessageBox.Show($"Cập nhật thông tin thành công cho khách hàng có mã là {khachHang.IDKH}");
                    dtgvKH.DataSource = BUSKhachHang.DodulieuPKN("tblKhachHang");

                }
                else
                {
                    MessageBox.Show($"Hủy bỏ cập nhật thông tin khách hàng có mã là: {khachHang.IDKH}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            khachHang.IDKH = txtIDKH.Text.Trim();
            try
            {
                DialogResult result = MessageBox.Show($"Bạn có muốn xóa thông tin khách hàng không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSKhachHang.XoaKhachHang(khachHang);
                    MessageBox.Show($"Xóa thành công thông tin khách hàng có mã là {khachHang.IDKH}");
                    dtgvKH.DataSource = BUSKhachHang.DodulieuPKN("tblKhachHang");
                }
                else
                {
                    MessageBox.Show($"Hủy bỏ xóa thông tin khách hàng có mã là: {khachHang.IDKH}");
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
            }
            txtIDKH.Focus();
            txtIDKH.Enabled = true;
        }

        private void dtgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtIDKH.Text = dtgvKH[0, hang].Value.ToString();
            txtTenKhachHang.Text = dtgvKH[1, hang].Value.ToString();
            txtGioiTinh.Text = dtgvKH[2, hang].Value.ToString();
            dtpkNgaySinh.Value = (DateTime)dtgvKH[3, hang].Value;
            txtDiaChi.Text = dtgvKH[4, hang].Value.ToString();
            txtSDT.Text = dtgvKH[5, hang].Value.ToString();
            txtIDKH.Enabled = false;
        }
    }
}
