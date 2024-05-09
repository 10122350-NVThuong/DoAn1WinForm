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
    public partial class GUIDanhMucSanPham : Form
    {
        public GUIDanhMucSanPham()
        {
            InitializeComponent();
        }

        private void GUIDanhMucSanPham_Load(object sender, EventArgs e)
        {
            dtgvDMSP.DataSource = BUSDanhMucSanPham.DodulieuPKN("tblDanhMucSanPham");
        }
        DTODanhMucSanPham danhMucSP = new DTODanhMucSanPham();

        private void btThem_Click(object sender, EventArgs e)
        {
            danhMucSP.MaLoai = txtMaLoaiSP.Text;
            danhMucSP.TenLoai = txtTenLoaiSP.Text;
            try
            {
                BUSDanhMucSanPham.ThemDanhMucSanPham(danhMucSP);
                MessageBox.Show("Thêm thành công");
                dtgvDMSP.DataSource = BUSDanhMucSanPham.DodulieuPKN("tblDanhMucSanPham");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvDMSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaLoaiSP.Text = dtgvDMSP[0, hang].Value.ToString();
            txtTenLoaiSP.Text = dtgvDMSP[1, hang].Value.ToString();
            txtMaLoaiSP.Enabled = false;
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
            txtMaLoaiSP.Focus();
            txtMaLoaiSP.Enabled = true;
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            danhMucSP.MaLoai = txtMaLoaiSP.Text;
            danhMucSP.TenLoai = txtTenLoaiSP.Text;
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSDanhMucSanPham.SuaDanhMucSanPham(danhMucSP);
                    MessageBox.Show($"Cập nhật thông tin thành công cho mã danh mục là {txtMaLoaiSP.Text}");
                    dtgvDMSP.DataSource = BUSDanhMucSanPham.DodulieuPKN("tblDanhMucSanPham");
                }
                else
                {
                    MessageBox.Show($"Hủy bỏ cập nhật thông tin mã danh muc: {txtMaLoaiSP.Text}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            danhMucSP.MaLoai = txtMaLoaiSP.Text;
            danhMucSP.TenLoai = txtTenLoaiSP.Text;
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSDanhMucSanPham.XoaDanhMucSanPham(danhMucSP);
                }
                else
                {
                    MessageBox.Show($"Hủy bỏ xóa thông tin mã danh muc: {txtMaLoaiSP.Text}");
                }
                MessageBox.Show($"Xóa thành công mã danh mục là {txtMaLoaiSP.Text}");
                dtgvDMSP.DataSource = BUSDanhMucSanPham.DodulieuPKN("tblDanhMucSanPham");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
