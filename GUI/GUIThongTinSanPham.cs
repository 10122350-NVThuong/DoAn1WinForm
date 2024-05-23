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
    public partial class GUIThongTinSanPham : Form
    {
        public GUIThongTinSanPham()
        {
            InitializeComponent();
            sp = new DTOSanPham();
        }
        DTOSanPham sp;

        private void btThem_Click(object sender, EventArgs e)
        {
            sp.MaSP = txtMaSP.Text;
            sp.TenSP = txtTenSP.Text;
            sp.FK_MaLoai = cboMaDanhMuc.SelectedValue.ToString();
            sp.FK_IDNCC = cboIDNCC.SelectedValue.ToString();
            sp.SoLuongTon = int.Parse(txtSoLuongTon.Text);
            sp.GiaBan = float.Parse(txtGiaSP.Text);
            try
            {
                BUSSanPham.ThemSanPham(sp);
                MessageBox.Show("Thêm thành công");
                dtgvQLSP.DataSource = BUSSanPham.DodulieuPKN("tblMatHang");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GUIThongTinSanPham_Load(object sender, EventArgs e)
        {
            dtgvQLSP.DataSource = BUSSanPham.DodulieuPKN("tblMatHang");
            cboMaDanhMuc.DataSource = BUSSanPham.LoadComboboxPKN("tblDanhMucSanPham");
            cboMaDanhMuc.DisplayMember = "TenDanhMuc";
            cboMaDanhMuc.ValueMember = "MaDanhMuc";

            cboIDNCC.DataSource = BUSSanPham.LoadComboboxPKN("tblNCC");
            cboIDNCC.DisplayMember = "TenNCC";
            cboIDNCC.ValueMember = "IDNCC";
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is Guna2TextBox)
                {
                    c.Text = "";
                }
            }
            txtMaSP.Focus();
            txtMaSP.Enabled = true;
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            sp.MaSP = txtMaSP.Text;
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thông tin sản phẩm này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSSanPham.XoaSanPham(sp);
                    MessageBox.Show($"Xóa thành công thông tin mã sản phẩm là {txtMaSP.Text}");
                    dtgvQLSP.DataSource = BUSSanPham.DodulieuPKN("tblMatHang");
                }
                else
                {
                    MessageBox.Show($"Hủy bỏ xóa thông tin mã sản phẩm: {txtMaSP.Text}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            sp.MaSP = txtMaSP.Text;
            sp.TenSP = txtTenSP.Text;
            sp.FK_MaLoai = cboMaDanhMuc.SelectedValue.ToString();
            sp.FK_IDNCC = cboIDNCC.SelectedValue.ToString();
            sp.SoLuongTon = int.Parse(txtSoLuongTon.Text);
            sp.GiaBan = float.Parse(txtGiaSP.Text);
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSSanPham.CapNhatThongTinSanPham(sp);
                    MessageBox.Show($"Cập nhật thông tin thành công cho mã sản phẩm là {txtMaSP.Text}");
                    dtgvQLSP.DataSource = BUSSanPham.DodulieuPKN("tblMatHang");
                }
                else
                {
                    MessageBox.Show($"Hủy bỏ cập nhật thông tin mã sản phẩm: {txtMaSP.Text}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvQLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaSP.Text = dtgvQLSP[0, hang].Value.ToString();
            txtTenSP.Text = dtgvQLSP[1, hang].Value.ToString();
            cboMaDanhMuc.SelectedValue = dtgvQLSP[2, hang].Value.ToString();
            cboIDNCC.SelectedValue = dtgvQLSP[3, hang].Value.ToString();
            txtSoLuongTon.Text = dtgvQLSP[4, hang].Value.ToString();
            txtGiaSP.Text = dtgvQLSP[5, hang].Value.ToString();
            txtMaSP.Enabled = false;
        }

        private void gtxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbluachontimkiem.SelectedItem != null)
            {
                if (cbluachontimkiem.SelectedItem.ToString() == "Mã sản phẩm")
                {
                    dtgvQLSP.DataSource = BUSSanPham.TimKiem("tblMatHang", "MaSP", gtxtTimKiem.Text);
                }
                else if (cbluachontimkiem.SelectedItem.ToString() == "Tên sản phẩm")
                {
                    dtgvQLSP.DataSource = BUSSanPham.TimKiem("tblMatHang", "TenSP", gtxtTimKiem.Text);

                }
                else if (cbluachontimkiem.SelectedItem.ToString() == "Mã danh mục")
                {
                    dtgvQLSP.DataSource = BUSSanPham.TimKiem("tblMatHang", "MaDanhMuc", gtxtTimKiem.Text);

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 tiêu chí tìm kiếm ở trên");
            }
        }
    }
}
