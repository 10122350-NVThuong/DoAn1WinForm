using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    public partial class GUINhaCungCap : Form
    {
        DTONhaCungCap nhaCungCap;
        public GUINhaCungCap()
        {
            InitializeComponent();
            nhaCungCap = new DTONhaCungCap();
        }

        private void dtgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang >= 0 && e.ColumnIndex >= 0)
            {
                if (string.IsNullOrWhiteSpace(dtgvNCC[e.ColumnIndex, hang].Value?.ToString()))
                {
                    MessageBox.Show("Không có dữ liệu");
                }
                else
                {
                    txtIDNCC.Text = dtgvNCC[0, hang].Value.ToString();
                    txtTenNhaCungCap.Text = dtgvNCC[1, hang].Value.ToString();
                    txtDiaChi.Text = dtgvNCC[2, hang].Value.ToString();
                    txtSDT.Text = dtgvNCC[3, hang].Value.ToString();
                    txtEmail.Text = dtgvNCC[4, hang].Value.ToString();
                    txtIDNCC.Enabled = false;
                }
            }
        }

        private void GUINhaCungCap_Load(object sender, EventArgs e)
        {
            dtgvNCC.DataSource = BUSNhaCungCap.DodulieuPKN("tblNCC");
            dtgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            nhaCungCap.IDNCC = txtIDNCC.Text;
            nhaCungCap.TenNhaCungCap = txtTenNhaCungCap.Text;
            nhaCungCap.DiaChi = txtDiaChi.Text;
            nhaCungCap.SDT = txtSDT.Text;
            nhaCungCap.Email = txtEmail.Text;
            try
            {
                BUSNhaCungCap.ThemNhaCungCap(nhaCungCap);
                MessageBox.Show("Thêm thành công");
                dtgvNCC.DataSource = BUSNhaCungCap.DodulieuPKN("tblNCC");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nhaCungCap.IDNCC = txtIDNCC.Text;
            nhaCungCap.TenNhaCungCap = txtTenNhaCungCap.Text;
            nhaCungCap.DiaChi = txtDiaChi.Text;
            nhaCungCap.SDT = txtSDT.Text;
            nhaCungCap.Email = txtEmail.Text;
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSNhaCungCap.CapNhatThongTinNhaCungCap(nhaCungCap);
                    MessageBox.Show($"Cập nhật thông tin thành công cho nhà cung cấp có mã là {txtIDNCC.Text}");
                    dtgvNCC.DataSource = BUSNhaCungCap.DodulieuPKN("tblNCC");
                }
                else
                {
                    MessageBox.Show($"Hủy bỏ cập nhật thông tin nhà cung câó có mã: {txtIDNCC.Text}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nhaCungCap.IDNCC = txtIDNCC.Text;
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thông tin nhà cung cấp này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSNhaCungCap.XoaNhaCungCap(nhaCungCap);
                    MessageBox.Show($"Xóa thành công thông tin nhà cung cấp có mã là {txtIDNCC.Text}");
                    dtgvNCC.DataSource = BUSNhaCungCap.DodulieuPKN("tblNCC");
                }
                else
                {
                    MessageBox.Show($"Hủy bỏ xóa thông tin nhà cung cấp có mã: {txtIDNCC.Text}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is Guna2TextBox)
                {
                    c.Text = "";
                }
            }
            txtIDNCC.Focus();
            txtIDNCC.Enabled = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cboLuaChon.SelectedItem.ToString() == "Mã nhà cung cấp")
            {
                dtgvNCC.DataSource = BUSNhaCungCap.TimKiem("tblNCC", "IDNCC", txtTimKiem.Text);
            }
            else if (cboLuaChon.SelectedItem.ToString() == "Tên nhà cung cấp")
            {
                dtgvNCC.DataSource = BUSNhaCungCap.TimKiem("tblNCC", "TenNCC", txtTimKiem.Text);

            }
        }
    }
}
