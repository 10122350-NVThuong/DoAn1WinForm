namespace GUI
{
    partial class GUIHoaDonNhapHang
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
            this.dtgvHDN = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLuaChon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboIDNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboIDNCC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTrangThai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDHoaDonNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpkNgayNhap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHDN)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvHDN
            // 
            this.dtgvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHDN.Location = new System.Drawing.Point(3, 231);
            this.dtgvHDN.Name = "dtgvHDN";
            this.dtgvHDN.RowHeadersWidth = 51;
            this.dtgvHDN.RowTemplate.Height = 24;
            this.dtgvHDN.Size = new System.Drawing.Size(721, 275);
            this.dtgvHDN.TabIndex = 33;
            this.dtgvHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHDN_CellClick);
            this.dtgvHDN.DoubleClick += new System.EventHandler(this.dtgvHDN_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Controls.Add(this.cboLuaChon);
            this.groupBox3.Location = new System.Drawing.Point(727, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 121);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(24, 64);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTimKiem.PlaceholderText = "Nhập thông tin tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(225, 44);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cboLuaChon
            // 
            this.cboLuaChon.BackColor = System.Drawing.Color.Transparent;
            this.cboLuaChon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLuaChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLuaChon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLuaChon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLuaChon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLuaChon.ForeColor = System.Drawing.Color.Black;
            this.cboLuaChon.ItemHeight = 30;
            this.cboLuaChon.Items.AddRange(new object[] {
            "Mã Hóa Đơn",
            "Mã Nhà Cung Cấp",
            "Mã Nhân Viên",
            "Trạng Thái"});
            this.cboLuaChon.Location = new System.Drawing.Point(24, 21);
            this.cboLuaChon.Name = "cboLuaChon";
            this.cboLuaChon.Size = new System.Drawing.Size(225, 36);
            this.cboLuaChon.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnreset);
            this.groupBox2.Controls.Add(this.btnXoaHoaDon);
            this.groupBox2.Controls.Add(this.btnTaoHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(727, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 161);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnreset
            // 
            this.btnreset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnreset.Location = new System.Drawing.Point(3, 102);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(268, 42);
            this.btnreset.TabIndex = 11;
            this.btnreset.Text = "Làm Mới";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXoaHoaDon.Location = new System.Drawing.Point(3, 60);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(268, 42);
            this.btnXoaHoaDon.TabIndex = 9;
            this.btnXoaHoaDon.Text = "Xóa hóa đơn";
            this.btnXoaHoaDon.UseVisualStyleBackColor = true;
            this.btnXoaHoaDon.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaoHoaDon.Location = new System.Drawing.Point(3, 18);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(268, 42);
            this.btnTaoHoaDon.TabIndex = 10;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn";
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cboIDNV);
            this.groupBox1.Controls.Add(this.cboIDNCC);
            this.groupBox1.Controls.Add(this.txtTrangThai);
            this.groupBox1.Controls.Add(this.txtIDHoaDonNhap);
            this.groupBox1.Controls.Add(this.dtpkNgayNhap);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Location = new System.Drawing.Point(-2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 228);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cboIDNV
            // 
            this.cboIDNV.BackColor = System.Drawing.Color.Transparent;
            this.cboIDNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIDNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboIDNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboIDNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboIDNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboIDNV.ItemHeight = 30;
            this.cboIDNV.Location = new System.Drawing.Point(596, 84);
            this.cboIDNV.Name = "cboIDNV";
            this.cboIDNV.Size = new System.Drawing.Size(238, 36);
            this.cboIDNV.TabIndex = 39;
            // 
            // cboIDNCC
            // 
            this.cboIDNCC.BackColor = System.Drawing.Color.Transparent;
            this.cboIDNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIDNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDNCC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboIDNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboIDNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboIDNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboIDNCC.ItemHeight = 30;
            this.cboIDNCC.Location = new System.Drawing.Point(596, 27);
            this.cboIDNCC.Name = "cboIDNCC";
            this.cboIDNCC.Size = new System.Drawing.Size(238, 36);
            this.cboIDNCC.TabIndex = 38;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrangThai.DefaultText = "";
            this.txtTrangThai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTrangThai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTrangThai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrangThai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTrangThai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrangThai.Location = new System.Drawing.Point(596, 139);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.PasswordChar = '\0';
            this.txtTrangThai.PlaceholderText = "";
            this.txtTrangThai.SelectedText = "";
            this.txtTrangThai.Size = new System.Drawing.Size(264, 51);
            this.txtTrangThai.TabIndex = 37;
            // 
            // txtIDHoaDonNhap
            // 
            this.txtIDHoaDonNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDHoaDonNhap.DefaultText = "0";
            this.txtIDHoaDonNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDHoaDonNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDHoaDonNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDHoaDonNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDHoaDonNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDHoaDonNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDHoaDonNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDHoaDonNhap.Location = new System.Drawing.Point(146, 48);
            this.txtIDHoaDonNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDHoaDonNhap.Name = "txtIDHoaDonNhap";
            this.txtIDHoaDonNhap.PasswordChar = '\0';
            this.txtIDHoaDonNhap.PlaceholderText = "";
            this.txtIDHoaDonNhap.SelectedText = "";
            this.txtIDHoaDonNhap.Size = new System.Drawing.Size(116, 49);
            this.txtIDHoaDonNhap.TabIndex = 37;
            // 
            // dtpkNgayNhap
            // 
            this.dtpkNgayNhap.Checked = true;
            this.dtpkNgayNhap.FillColor = System.Drawing.Color.White;
            this.dtpkNgayNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.dtpkNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayNhap.Location = new System.Drawing.Point(146, 118);
            this.dtpkNgayNhap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkNgayNhap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkNgayNhap.Name = "dtpkNgayNhap";
            this.dtpkNgayNhap.Size = new System.Drawing.Size(192, 52);
            this.dtpkNgayNhap.TabIndex = 36;
            this.dtpkNgayNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpkNgayNhap.Value = new System.DateTime(2024, 5, 20, 14, 0, 28, 0);
            // 
            // lbl1
            // 
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Location = new System.Drawing.Point(14, 48);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(114, 49);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Mã Hóa Đơn\r\n";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2.Location = new System.Drawing.Point(440, 27);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(131, 36);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Mã Nhà Cung Cấp";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            this.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5.Location = new System.Drawing.Point(440, 139);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(131, 51);
            this.lbl5.TabIndex = 2;
            this.lbl5.Text = "Trạng Thái";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3.Location = new System.Drawing.Point(440, 83);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(131, 38);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Mã Nhân Viên";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4.Location = new System.Drawing.Point(20, 117);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(108, 53);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Ngày Nhập";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GUIHoaDonNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 511);
            this.Controls.Add(this.dtgvHDN);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUIHoaDonNhapHang";
            this.Text = "GUIHoaDonNhapHang";
            this.Load += new System.EventHandler(this.GUIHoaDonNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHDN)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHDN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkNgayNhap;
        private Guna.UI2.WinForms.Guna2ComboBox cboIDNV;
        private Guna.UI2.WinForms.Guna2ComboBox cboIDNCC;
        private Guna.UI2.WinForms.Guna2TextBox txtIDHoaDonNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cboLuaChon;
        private Guna.UI2.WinForms.Guna2TextBox txtTrangThai;
        private System.Windows.Forms.Label lbl5;
    }
}