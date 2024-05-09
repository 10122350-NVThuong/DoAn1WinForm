namespace GUI
{
    partial class GUIChiTietHoaDonXuatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnlm = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoLuongBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDHoaDonBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dtgvCTHDB = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnlm);
            this.groupBox4.Controls.Add(this.btXoa);
            this.groupBox4.Controls.Add(this.btSua);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Location = new System.Drawing.Point(482, 112);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(188, 137);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnlm
            // 
            this.btnlm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnlm.Location = new System.Drawing.Point(2, 107);
            this.btnlm.Margin = new System.Windows.Forms.Padding(2);
            this.btnlm.Name = "btnlm";
            this.btnlm.Size = new System.Drawing.Size(184, 30);
            this.btnlm.TabIndex = 3;
            this.btnlm.Text = "Làm mới";
            this.btnlm.UseVisualStyleBackColor = true;
            this.btnlm.Click += new System.EventHandler(this.btnlm_Click);
            // 
            // btXoa
            // 
            this.btXoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btXoa.Location = new System.Drawing.Point(2, 77);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(184, 30);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSua.Location = new System.Drawing.Point(2, 47);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(184, 30);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThem.Location = new System.Drawing.Point(2, 17);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(184, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMaSP);
            this.groupBox3.Controls.Add(this.txtGiaBan);
            this.groupBox3.Controls.Add(this.txtSoLuongBan);
            this.groupBox3.Controls.Add(this.txtIDHoaDonBan);
            this.groupBox3.Controls.Add(this.lbl5);
            this.groupBox3.Controls.Add(this.lbl6);
            this.groupBox3.Controls.Add(this.lbl7);
            this.groupBox3.Controls.Add(this.lbl8);
            this.groupBox3.Location = new System.Drawing.Point(0, 112);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(478, 121);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin mặt hàng";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSP.DefaultText = "";
            this.txtMaSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSP.Location = new System.Drawing.Point(117, 77);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.PasswordChar = '\0';
            this.txtMaSP.PlaceholderText = "";
            this.txtMaSP.SelectedText = "";
            this.txtMaSP.Size = new System.Drawing.Size(106, 36);
            this.txtMaSP.TabIndex = 15;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBan.DefaultText = "";
            this.txtGiaBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.Location = new System.Drawing.Point(359, 77);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.PlaceholderText = "";
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.Size = new System.Drawing.Size(114, 36);
            this.txtGiaBan.TabIndex = 14;
            // 
            // txtSoLuongBan
            // 
            this.txtSoLuongBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuongBan.DefaultText = "";
            this.txtSoLuongBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuongBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuongBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuongBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongBan.Location = new System.Drawing.Point(359, 26);
            this.txtSoLuongBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongBan.Name = "txtSoLuongBan";
            this.txtSoLuongBan.PasswordChar = '\0';
            this.txtSoLuongBan.PlaceholderText = "";
            this.txtSoLuongBan.SelectedText = "";
            this.txtSoLuongBan.Size = new System.Drawing.Size(103, 32);
            this.txtSoLuongBan.TabIndex = 13;
            // 
            // txtIDHoaDonBan
            // 
            this.txtIDHoaDonBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDHoaDonBan.DefaultText = "";
            this.txtIDHoaDonBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDHoaDonBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDHoaDonBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDHoaDonBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDHoaDonBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDHoaDonBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDHoaDonBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDHoaDonBan.Location = new System.Drawing.Point(117, 26);
            this.txtIDHoaDonBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDHoaDonBan.Name = "txtIDHoaDonBan";
            this.txtIDHoaDonBan.PasswordChar = '\0';
            this.txtIDHoaDonBan.PlaceholderText = "";
            this.txtIDHoaDonBan.SelectedText = "";
            this.txtIDHoaDonBan.Size = new System.Drawing.Size(144, 32);
            this.txtIDHoaDonBan.TabIndex = 12;
            // 
            // lbl5
            // 
            this.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5.Location = new System.Drawing.Point(4, 26);
            this.lbl5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(108, 32);
            this.lbl5.TabIndex = 8;
            this.lbl5.Text = "Mã hóa đơn";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6
            // 
            this.lbl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl6.Location = new System.Drawing.Point(27, 77);
            this.lbl6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(85, 36);
            this.lbl6.TabIndex = 9;
            this.lbl6.Text = "Mã SP";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl7
            // 
            this.lbl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl7.Location = new System.Drawing.Point(266, 26);
            this.lbl7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(88, 32);
            this.lbl7.TabIndex = 10;
            this.lbl7.Text = "Số lượng";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl8
            // 
            this.lbl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl8.Location = new System.Drawing.Point(246, 77);
            this.lbl8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(108, 36);
            this.lbl8.TabIndex = 11;
            this.lbl8.Text = "Giá cả";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenKhachHang);
            this.groupBox2.Controls.Add(this.txtIDKH);
            this.groupBox2.Controls.Add(this.lbl3);
            this.groupBox2.Controls.Add(this.lbl4);
            this.groupBox2.Location = new System.Drawing.Point(326, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(344, 104);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhachHang.DefaultText = "";
            this.txtTenKhachHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhachHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKhachHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhachHang.Location = new System.Drawing.Point(116, 59);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.PasswordChar = '\0';
            this.txtTenKhachHang.PlaceholderText = "";
            this.txtTenKhachHang.SelectedText = "";
            this.txtTenKhachHang.Size = new System.Drawing.Size(176, 29);
            this.txtTenKhachHang.TabIndex = 3;
            // 
            // txtIDKH
            // 
            this.txtIDKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDKH.DefaultText = "";
            this.txtIDKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDKH.Location = new System.Drawing.Point(116, 20);
            this.txtIDKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDKH.Name = "txtIDKH";
            this.txtIDKH.PasswordChar = '\0';
            this.txtIDKH.PlaceholderText = "";
            this.txtIDKH.SelectedText = "";
            this.txtIDKH.Size = new System.Drawing.Size(176, 29);
            this.txtIDKH.TabIndex = 2;
            // 
            // lbl3
            // 
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3.Location = new System.Drawing.Point(10, 20);
            this.lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(100, 29);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "Mã khách hàng";
            // 
            // lbl4
            // 
            this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4.Location = new System.Drawing.Point(6, 59);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(105, 29);
            this.lbl4.TabIndex = 1;
            this.lbl4.Text = "Tên khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.txtIDNV);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(323, 106);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhanVien.DefaultText = "";
            this.txtTenNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhanVien.Location = new System.Drawing.Point(127, 61);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.PasswordChar = '\0';
            this.txtTenNhanVien.PlaceholderText = "";
            this.txtTenNhanVien.SelectedText = "";
            this.txtTenNhanVien.Size = new System.Drawing.Size(169, 29);
            this.txtTenNhanVien.TabIndex = 2;
            // 
            // txtIDNV
            // 
            this.txtIDNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDNV.DefaultText = "";
            this.txtIDNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNV.Location = new System.Drawing.Point(127, 22);
            this.txtIDNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDNV.Name = "txtIDNV";
            this.txtIDNV.PasswordChar = '\0';
            this.txtIDNV.PlaceholderText = "";
            this.txtIDNV.SelectedText = "";
            this.txtIDNV.Size = new System.Drawing.Size(169, 29);
            this.txtIDNV.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2.Location = new System.Drawing.Point(7, 61);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(105, 29);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Tên nhân viên";
            // 
            // lbl1
            // 
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Location = new System.Drawing.Point(11, 22);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(101, 29);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Mã nhân viên";
            // 
            // lbl9
            // 
            this.lbl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl9.Location = new System.Drawing.Point(9, 235);
            this.lbl9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(89, 28);
            this.lbl9.TabIndex = 32;
            this.lbl9.Text = "Tổng tiền:";
            this.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTongTien
            // 
            this.lblTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTongTien.Location = new System.Drawing.Point(102, 235);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(159, 28);
            this.lblTongTien.TabIndex = 31;
            this.lblTongTien.Text = "label5";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgvCTHDB
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCTHDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvCTHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCTHDB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvCTHDB.Location = new System.Drawing.Point(-3, 274);
            this.dtgvCTHDB.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvCTHDB.Name = "dtgvCTHDB";
            this.dtgvCTHDB.RowHeadersWidth = 51;
            this.dtgvCTHDB.RowTemplate.Height = 24;
            this.dtgvCTHDB.Size = new System.Drawing.Size(604, 136);
            this.dtgvCTHDB.TabIndex = 30;
            this.dtgvCTHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCTHDB_CellClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(601, 271);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(69, 139);
            this.btnThanhToan.TabIndex = 48;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // GUIChiTietHoaDonXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 416);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.dtgvCTHDB);
            this.Name = "GUIChiTietHoaDonXuatHang";
            this.Text = "GUIChiTietHoaDonBanHang";
            this.Load += new System.EventHandler(this.GUIChiTietHoaDonXuatHang_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTHDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnlm;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView dtgvCTHDB;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtIDNV;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaBan;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuongBan;
        private Guna.UI2.WinForms.Guna2TextBox txtIDHoaDonBan;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKhachHang;
        private Guna.UI2.WinForms.Guna2TextBox txtIDKH;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSP;
        private System.Windows.Forms.Button btnThanhToan;
    }
}