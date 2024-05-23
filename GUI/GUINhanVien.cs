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
    public partial class GUINhanVien : Form
    {
        public GUINhanVien()
        {
            InitializeComponent();
        }

        private void GUINhanVien_Load(object sender, EventArgs e)
        {
            dtgvnv.DataSource = BUSNhanVien.DodulieuPKN("tblNhanVien");
        }
        DTONhanVien nv = new DTONhanVien();


        private void btSua_Click(object sender, EventArgs e)
        {
            nv.IDNV = txtMaNV.Text;
            nv.Name = txtTenNV.Text;
            nv.GioiTinh = txtGioitinh.Text;
            nv.birth = datepickNS.Value;
            nv.DiaChi = txtDiaChi.Text;
            nv.Email = txtEmail.Text;
            nv.SDT = txtSDT.Text;
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSNhanVien.CapNhatThongTinNhanVien(nv);
                    MessageBox.Show($"Cập nhật thông tin thành công cho nhân viên có mã là {txtMaNV.Text}");
                    dtgvnv.DataSource = BUSSanPham.DodulieuPKN("tblNhanVien");
                }
                else
                {
                    MessageBox.Show($"Hủy bỏ cập nhật thông tin nhân viên có mã là: {txtMaNV.Text}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            nv.IDNV = txtMaNV.Text.Trim();
            try
            {
                DialogResult result = MessageBox.Show($"Bạn có muốn xóa thông tin nhân viên không?\n(Lưu ý: Thông tin đăng nhập của nhân viên có mã {txtMaNV.Text} cũng sẽ bị xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BUSNhanVien.XoaThongTinNhanVien(nv);
                    MessageBox.Show($"Xóa thành công thông tin nhân viên có mã là {txtMaNV.Text}");
                    dtgvnv.DataSource = BUSSanPham.DodulieuPKN("tblNhanVien");
                }
                else
                {
                    MessageBox.Show($"Hủy bỏ xóa thông tin nhân viên có mã là: {txtMaNV.Text}");
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
            txtMaNV.Focus();
            txtMaNV.Enabled = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cboLuaChon.SelectedItem != null)
            {
                if (cboLuaChon.SelectedItem.ToString() == "Mã nhân viên")
                {
                    dtgvnv.DataSource = BUSNhanVien.TimKiemNhanVien("tblNhanVien", "IDNV", txtTimKiem.Text);
                }
                else if (cboLuaChon.SelectedItem.ToString() == "Tên nhân viên")
                {
                    dtgvnv.DataSource = BUSNhanVien.TimKiemNhanVien("tblNhanVien", "TenNhanVien", txtTimKiem.Text);

                }
                else if (cboLuaChon.SelectedItem.ToString() == "Giới tính")
                {
                    dtgvnv.DataSource = BUSNhanVien.TimKiemNhanVien("tblNhanVien", "GioitinhNV", txtTimKiem.Text);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 tiêu chí tìm kiếm ở trên");
            }
        }

        private void dtgvnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaNV.Text = dtgvnv[0, hang].Value.ToString();
            txtTenNV.Text = dtgvnv[1, hang].Value.ToString();
            txtGioitinh.Text = dtgvnv[2, hang].Value.ToString();
            datepickNS.Value = (DateTime)dtgvnv[3, hang].Value;
            txtDiaChi.Text = dtgvnv[4, hang].Value.ToString();
            txtEmail.Text = dtgvnv[5, hang].Value.ToString();
            txtSDT.Text = dtgvnv[6, hang].Value.ToString();
            txtMaNV.Enabled = false;
        }
    }
}
