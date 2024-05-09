using BLL;
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
    public partial class GUIQuanLyNguoiDung : Form
    {
        public GUIQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void GUIQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            dtgvND.DataSource = BUSTaiKhoan.DocTaiKhoanNguoiDung();
        }

        private void dtgvND_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtTenDangNhap.Text = dtgvND[0, hang].Value.ToString();
            txtMatKhau.Text = dtgvND[1, hang].Value.ToString();
            txtQuyen.Text = dtgvND[2, hang].Value.ToString();
            txtTenNhanVien.Text = dtgvND[3, hang].Value.ToString();
            foreach (Control c in groupBox1.Controls)
            {
                if(c is Guna2TextBox)
                {
                    c.Enabled = false;
                }
            }
        }
    }
}
