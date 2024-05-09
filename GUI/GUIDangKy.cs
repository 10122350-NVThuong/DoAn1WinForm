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

namespace GUI
{
    public partial class GUIDangKy : Form
    {
        public GUIDangKy()
        {
            InitializeComponent();
        }
        DTONhanVien nv = new DTONhanVien();
        DTOTaiKhoan tk = new DTOTaiKhoan();

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            tk.TenTK = txtTenTK.Text;
            tk.MatKhau = txtMatKhau.Text;

            tk.Quyen = cbQuyen.SelectedItem != null ? int.Parse(cbQuyen.SelectedItem.ToString()) : -1;
            tk.FK_IDNV = nv.IDNV = txtIDNV.Text;
            nv.Name = txtTenNV.Text;
            nv.GioiTinh = cbGioiTinh.SelectedItem != null ? cbGioiTinh.SelectedItem.ToString() : null;

            nv.birth = DateTime.Parse(DTPNgaySinh.Text);
            nv.DiaChi = txtDiaChi.Text;
            nv.Email = txtEmail.Text;
            nv.SDT = txtSDT.Text;
            try
            {
                if (txtMatKhau.Text != txtXacNhanMK.Text )
                {
                    MessageBox.Show("Mật khẩu chưa khớp nhau");
                }
                else
                {
                    BUSDangKy.DangKyTaiKhoan(nv, tk);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ckHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHienMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
                txtXacNhanMK.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtXacNhanMK.PasswordChar = '*';
            }
        }
    }
}
