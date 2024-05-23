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
            dtgvND.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dtgvND_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang >= 0 && e.ColumnIndex >= 0)
            {
                if (string.IsNullOrWhiteSpace(dtgvND[e.ColumnIndex, hang].Value?.ToString()))
                {
                    MessageBox.Show("Không có dữ liệu");
                }
                else
                {
                    txtTenDangNhap.Text = dtgvND[0, hang].Value.ToString();
                    txtMatKhau.Text = dtgvND[1, hang].Value.ToString();
                    txtQuyen.Text = dtgvND[2, hang].Value.ToString();
                    txtTenNhanVien.Text = dtgvND[3, hang].Value.ToString();

                }
            }
        }
    }
}
