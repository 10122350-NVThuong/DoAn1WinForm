using BLL;
using DTO;
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
    public partial class GUIDoiMatKhau : Form
    {
        public GUIDoiMatKhau()
        {
            InitializeComponent();
        }
        DTOTaiKhoan tk = new DTOTaiKhoan();
        DTOTaiKhoan tkm = new DTOTaiKhoan();

        private void btnCheckTenTK_Click(object sender, EventArgs e)
        {
            tk.TenTK = txtTenTK.Text;
            tk.MatKhau = txtMatKhauCu.Text;
            try
            {
                int i = BUSTaiKhoan.CheckLogin(tk);
                GUIHeThong.code = i;
                if (i == 0 || i == 1)
                {
                    MessageBox.Show("Mời bạn tiếp tục thực hiện");
                    txtMatKhauMoi.Enabled = true;
                    txtXacNhanMatKhauMoi.Enabled = true;
                }
                else if (i == 2)
                {
                    MessageBox.Show("Sai mật khẩu!");
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            tk.TenTK = tkm.TenTK = txtTenTK.Text;
            tkm.MatKhau = txtMatKhauMoi.Text;
            try
            {
                if (tkm.MatKhau != txtXacNhanMatKhauMoi.Text)
                {
                    MessageBox.Show("Mật khẩu mới không khớp nhau!");
                }
                else
                {
                    BUSTaiKhoan.UpDateMatKhau(tk, tkm);
                    MessageBox.Show("Thay đổi mật khẩu thành công. Mời bạn đăng nhập");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GUIDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMatKhauMoi.Enabled = false;
            txtXacNhanMatKhauMoi.Enabled = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
