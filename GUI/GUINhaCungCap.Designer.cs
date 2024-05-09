namespace GUI
{
    partial class GUINhaCungCap
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
            this.dtgvNCC = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLuaChon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNhaCungCap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNCC)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvNCC
            // 
            this.dtgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNCC.Location = new System.Drawing.Point(1, 247);
            this.dtgvNCC.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvNCC.Name = "dtgvNCC";
            this.dtgvNCC.RowHeadersWidth = 51;
            this.dtgvNCC.RowTemplate.Height = 24;
            this.dtgvNCC.Size = new System.Drawing.Size(683, 227);
            this.dtgvNCC.TabIndex = 25;
            this.dtgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNCC_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Controls.Add(this.cboLuaChon);
            this.groupBox3.Location = new System.Drawing.Point(582, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 236);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm nhà cung cấp";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoRoundedCorners = true;
            this.txtTimKiem.BorderRadius = 17;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(19, 90);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Nhập thông tin cần tìm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(229, 36);
            this.txtTimKiem.TabIndex = 11;
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
            this.cboLuaChon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboLuaChon.ItemHeight = 30;
            this.cboLuaChon.Items.AddRange(new object[] {
            "Mã nhà cung cấp",
            "Tên nhà cung cấp"});
            this.cboLuaChon.Location = new System.Drawing.Point(6, 34);
            this.cboLuaChon.Name = "cboLuaChon";
            this.cboLuaChon.Size = new System.Drawing.Size(255, 36);
            this.cboLuaChon.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenNhaCungCap);
            this.groupBox1.Controls.Add(this.txtIDNCC);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Location = new System.Drawing.Point(1, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 236);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(289, 34);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(280, 36);
            this.txtEmail.TabIndex = 13;
            // 
            // lbl5
            // 
            this.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl5.Location = new System.Drawing.Point(211, 34);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(72, 36);
            this.lbl5.TabIndex = 12;
            this.lbl5.Text = "Email";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSDT
            // 
            this.txtSDT.AutoRoundedCorners = true;
            this.txtSDT.BorderRadius = 17;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(110, 193);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(137, 36);
            this.txtSDT.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoRoundedCorners = true;
            this.txtDiaChi.BorderRadius = 17;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(110, 134);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(229, 36);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.AutoRoundedCorners = true;
            this.txtTenNhaCungCap.BorderRadius = 17;
            this.txtTenNhaCungCap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhaCungCap.DefaultText = "";
            this.txtTenNhaCungCap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNhaCungCap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNhaCungCap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhaCungCap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhaCungCap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNhaCungCap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenNhaCungCap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(110, 90);
            this.txtTenNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.PasswordChar = '\0';
            this.txtTenNhaCungCap.PlaceholderText = "";
            this.txtTenNhaCungCap.SelectedText = "";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(276, 36);
            this.txtTenNhaCungCap.TabIndex = 11;
            // 
            // txtIDNCC
            // 
            this.txtIDNCC.AutoRoundedCorners = true;
            this.txtIDNCC.BorderRadius = 17;
            this.txtIDNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDNCC.DefaultText = "";
            this.txtIDNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDNCC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNCC.Location = new System.Drawing.Point(110, 34);
            this.txtIDNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDNCC.Name = "txtIDNCC";
            this.txtIDNCC.PasswordChar = '\0';
            this.txtIDNCC.PlaceholderText = "";
            this.txtIDNCC.SelectedText = "";
            this.txtIDNCC.Size = new System.Drawing.Size(95, 36);
            this.txtIDNCC.TabIndex = 11;
            // 
            // lbl1
            // 
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl1.Location = new System.Drawing.Point(23, 34);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(72, 36);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Mã NCC";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl2.Location = new System.Drawing.Point(10, 90);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(85, 36);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Tên NCC";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl4.Location = new System.Drawing.Point(26, 193);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(69, 36);
            this.lbl4.TabIndex = 10;
            this.lbl4.Text = "SĐT";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl3.Location = new System.Drawing.Point(33, 143);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(62, 36);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "Địa chỉ";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Location = new System.Drawing.Point(688, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 228);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThem.Location = new System.Drawing.Point(3, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(173, 52);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSua.Location = new System.Drawing.Point(3, 64);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(173, 51);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Cập nhật thông tin";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnXoa.Location = new System.Drawing.Point(3, 115);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(173, 55);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLamMoi.Location = new System.Drawing.Point(3, 170);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(173, 55);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // GUINhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 473);
            this.Controls.Add(this.dtgvNCC);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "GUINhaCungCap";
            this.Text = "GUINhaCungCap";
            this.Load += new System.EventHandler(this.GUINhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNCC)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvNCC;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cboLuaChon;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhaCungCap;
        private Guna.UI2.WinForms.Guna2TextBox txtIDNCC;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lbl5;
    }
}