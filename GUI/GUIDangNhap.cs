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
using BLL;

namespace GUI
{
    public partial class GUIDangNhap : Form
    {
        public GUIDangNhap()
        {
            InitializeComponent();
        }

        DTOTaiKhoan tk = new DTOTaiKhoan();


        private void ckHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHienMatKhau.Checked)
            {
                gtxtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                gtxtMatKhau.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tk.TenTK = gtxtTaiKhoan.Text;
            tk.MatKhau = gtxtMatKhau.Text;
            try
            {
                int i = BUSTaiKhoan.CheckLogin(tk);
                GUIHeThong.code = i;
                if (i == 0)
                {
                    MessageBox.Show("Chào mừng admin đăng nhập!");
                    GUIHeThong ht = new GUIHeThong();
                    this.Hide();
                    ht.ShowDialog();

                    this.Show();
                }
                else if (i == 1)
                {
                    MessageBox.Show("Chào mừng nhân viên đăng nhập!");
                    GUIHeThong ht = new GUIHeThong();
                    this.Hide();
                    ht.ShowDialog();

                    this.Show();
                }
                else if (i == 2)
                {
                    MessageBox.Show("Sai mật khẩu!", "Sai mật khẩu", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Tài khoản chưa tồn tại", "Tài khoản chưa chính xác", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            GUIDoiMatKhau doiMatKhau = new GUIDoiMatKhau();
            this.Hide();
            doiMatKhau.ShowDialog();

            this.Show();
        }


        private void llbforgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUIQuenMatKhau quenMatKhau = new GUIQuenMatKhau();
            this.Hide();
            quenMatKhau.ShowDialog();

            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
