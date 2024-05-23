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
    public partial class GUIQuenMatKhau : Form
    {
        public GUIQuenMatKhau()
        {
            InitializeComponent();
        }

        private void GUIQuenMatKhau_Load(object sender, EventArgs e)
        {
            label4.Enabled = false;
            label5.Enabled = false;
            txtMatKhau.Enabled = false;
            txtXacNhanMatKhau.Enabled=false;
            btnDoiMatKhau.Enabled = false;
        }
        DTONhanVien nv = new DTONhanVien();
        DTOTaiKhoan tk = new DTOTaiKhoan();
        public static int code;
        private void btnLayma_Click(object sender, EventArgs e)
        {
            tk.TenTK = txtTenTK.Text;
            nv.Email = txtEmail.Text;
            try
            {
                code = BUSTaiKhoan.sendEmail(nv, tk);
                MessageBox.Show($"Mã xác nhận đã được gửi đến gmail {nv.Email}. Vui lòng kiểm tra tin nhắn.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            tk.TenTK = txtTenTK.Text;
            tk.MatKhau = txtMatKhau.Text;
            try
            {
                if (txtXacNhanMatKhau.Text != tk.MatKhau)
                {
                    MessageBox.Show("Mật khẩu chưa trùng khớp", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    BUSTaiKhoan.QuenMatKhau(tk);
                    MessageBox.Show("Mật khẩu đã thay đổi thành công");
                    txtMatKhau.Text = "";
                    txtXacNhanMatKhau.Text = "";
                    label4.Enabled = false;
                    label5.Enabled = false;
                    txtMatKhau.Enabled = false;
                    txtXacNhanMatKhau.Enabled = false;
                    code = 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text.Length == 6)
            {
                if (code != int.Parse(txtCode.Text))
                {
                    MessageBox.Show("Mã xác nhận chưa chính xác", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    label4.Enabled = false;
                    label5.Enabled = false;
                    txtMatKhau.Enabled = false;
                    txtXacNhanMatKhau.Enabled = false;
                    btnDoiMatKhau.Enabled = false;
                }
                else
                {
                    label4.Enabled = true;
                    label5.Enabled = true;
                    txtMatKhau.Enabled = true;
                    txtXacNhanMatKhau.Enabled = true;
                    btnDoiMatKhau.Enabled = true;
                }
            }
        }
    }
}
