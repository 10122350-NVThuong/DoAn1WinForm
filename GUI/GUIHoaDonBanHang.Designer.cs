namespace GUI
{
    partial class GUIHoaDonBanHang
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
            this.dtgvHDB = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLuaChon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboIDNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboIDKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTrangThai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDHoaDonBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpkNgayBan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHDB)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvHDB
            // 
            this.dtgvHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHDB.Location = new System.Drawing.Point(2, 236);
            this.dtgvHDB.Name = "dtgvHDB";
            this.dtgvHDB.RowHeadersWidth = 51;
            this.dtgvHDB.RowTemplate.Height = 24;
            this.dtgvHDB.Size = new System.Drawing.Size(741, 259);
            this.dtgvHDB.TabIndex = 37;
            this.dtgvHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHDB_CellClick);
            this.dtgvHDB.DoubleClick += new System.EventHandler(this.dtgvHDB_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Controls.Add(this.cboLuaChon);
            this.groupBox3.Location = new System.Drawing.Point(749, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 127);
            this.groupBox3.TabIndex = 36;
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
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(18, 64);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(278, 45);
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
            this.cboLuaChon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLuaChon.ItemHeight = 30;
            this.cboLuaChon.Items.AddRange(new object[] {
            "Mã Hóa Đơn",
            "Mã Khách Hàng",
            "Mã Nhân Viên",
            "Trạng Thái"});
            this.cboLuaChon.Location = new System.Drawing.Point(18, 21);
            this.cboLuaChon.Name = "cboLuaChon";
            this.cboLuaChon.Size = new System.Drawing.Size(278, 36);
            this.cboLuaChon.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnreset);
            this.groupBox2.Controls.Add(this.btnXoaHoaDon);
            this.groupBox2.Controls.Add(this.btnTaoHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(752, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 155);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnreset
            // 
            this.btnreset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnreset.Location = new System.Drawing.Point(3, 104);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(299, 43);
            this.btnreset.TabIndex = 11;
            this.btnreset.Text = "Làm Mới";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXoaHoaDon.Location = new System.Drawing.Point(3, 61);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(299, 43);
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
            this.btnTaoHoaDon.Size = new System.Drawing.Size(299, 43);
            this.btnTaoHoaDon.TabIndex = 10;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn";
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboIDNV);
            this.groupBox1.Controls.Add(this.cboIDKH);
            this.groupBox1.Controls.Add(this.txtTrangThai);
            this.groupBox1.Controls.Add(this.txtIDHoaDonBan);
            this.groupBox1.Controls.Add(this.dtpkNgayBan);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 216);
            this.groupBox1.TabIndex = 34;
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
            this.cboIDNV.Location = new System.Drawing.Point(640, 75);
            this.cboIDNV.Name = "cboIDNV";
            this.cboIDNV.Size = new System.Drawing.Size(233, 36);
            this.cboIDNV.TabIndex = 39;
            // 
            // cboIDKH
            // 
            this.cboIDKH.BackColor = System.Drawing.Color.Transparent;
            this.cboIDKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIDKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboIDKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboIDKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboIDKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboIDKH.ItemHeight = 30;
            this.cboIDKH.Location = new System.Drawing.Point(640, 18);
            this.cboIDKH.Name = "cboIDKH";
            this.cboIDKH.Size = new System.Drawing.Size(233, 36);
            this.cboIDKH.TabIndex = 38;
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
            this.txtTrangThai.Location = new System.Drawing.Point(640, 140);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.PasswordChar = '\0';
            this.txtTrangThai.PlaceholderText = "";
            this.txtTrangThai.SelectedText = "";
            this.txtTrangThai.Size = new System.Drawing.Size(331, 51);
            this.txtTrangThai.TabIndex = 37;
            // 
            // txtIDHoaDonBan
            // 
            this.txtIDHoaDonBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDHoaDonBan.DefaultText = "0";
            this.txtIDHoaDonBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDHoaDonBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDHoaDonBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDHoaDonBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDHoaDonBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDHoaDonBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDHoaDonBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDHoaDonBan.Location = new System.Drawing.Point(171, 42);
            this.txtIDHoaDonBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDHoaDonBan.Name = "txtIDHoaDonBan";
            this.txtIDHoaDonBan.PasswordChar = '\0';
            this.txtIDHoaDonBan.PlaceholderText = "";
            this.txtIDHoaDonBan.SelectedText = "";
            this.txtIDHoaDonBan.Size = new System.Drawing.Size(145, 44);
            this.txtIDHoaDonBan.TabIndex = 37;
            // 
            // dtpkNgayBan
            // 
            this.dtpkNgayBan.Checked = true;
            this.dtpkNgayBan.FillColor = System.Drawing.Color.White;
            this.dtpkNgayBan.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.dtpkNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayBan.Location = new System.Drawing.Point(171, 121);
            this.dtpkNgayBan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkNgayBan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkNgayBan.Name = "dtpkNgayBan";
            this.dtpkNgayBan.Size = new System.Drawing.Size(225, 59);
            this.dtpkNgayBan.TabIndex = 36;
            this.dtpkNgayBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpkNgayBan.Value = new System.DateTime(2024, 5, 20, 0, 0, 0, 0);
            // 
            // lbl1
            // 
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Location = new System.Drawing.Point(28, 42);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(114, 44);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Mã Hóa Đơn\r\n";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2.Location = new System.Drawing.Point(497, 18);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(126, 36);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Mã Khách Hàng";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            this.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5.Location = new System.Drawing.Point(497, 140);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(126, 51);
            this.lbl5.TabIndex = 2;
            this.lbl5.Text = "Trạng Thái";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3.Location = new System.Drawing.Point(497, 74);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(126, 38);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Mã Nhân Viên";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4.Location = new System.Drawing.Point(16, 121);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(126, 59);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Ngày Bán";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GUIHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 507);
            this.Controls.Add(this.dtgvHDB);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUIHoaDonBanHang";
            this.Text = "GUIHoaDonBanHang";
            this.Load += new System.EventHandler(this.GUIHoaDonBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHDB)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHDB;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cboLuaChon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cboIDNV;
        private Guna.UI2.WinForms.Guna2ComboBox cboIDKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTrangThai;
        private Guna.UI2.WinForms.Guna2TextBox txtIDHoaDonBan;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkNgayBan;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
    }
}