namespace GUI
{
    partial class GUIThemSanPhamVaoHoaDonXuat
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
            this.dtgvSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnlm = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuongBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaSP = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvSanPham
            // 
            this.dtgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPham.Location = new System.Drawing.Point(3, 3);
            this.dtgvSanPham.Name = "dtgvSanPham";
            this.dtgvSanPham.RowHeadersWidth = 51;
            this.dtgvSanPham.RowTemplate.Height = 24;
            this.dtgvSanPham.Size = new System.Drawing.Size(455, 150);
            this.dtgvSanPham.TabIndex = 28;
            this.dtgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSanPham_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnlm);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Location = new System.Drawing.Point(266, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 174);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(26, 124);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 37);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnlm
            // 
            this.btnlm.Location = new System.Drawing.Point(26, 68);
            this.btnlm.Name = "btnlm";
            this.btnlm.Size = new System.Drawing.Size(145, 41);
            this.btnlm.TabIndex = 1;
            this.btnlm.Text = "Làm mới";
            this.btnlm.UseVisualStyleBackColor = true;
            this.btnlm.Click += new System.EventHandler(this.btnlm_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(26, 21);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(145, 33);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtGiaBan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSoLuongBan);
            this.groupBox2.Controls.Add(this.txtMaSP);
            this.groupBox2.Location = new System.Drawing.Point(3, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 180);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtGiaBan.Location = new System.Drawing.Point(114, 132);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.PlaceholderText = "";
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.Size = new System.Drawing.Size(143, 32);
            this.txtGiaBan.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Số lượng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "Giá cả";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtSoLuongBan.Location = new System.Drawing.Point(114, 78);
            this.txtSoLuongBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongBan.Name = "txtSoLuongBan";
            this.txtSoLuongBan.PasswordChar = '\0';
            this.txtSoLuongBan.PlaceholderText = "";
            this.txtSoLuongBan.SelectedText = "";
            this.txtSoLuongBan.Size = new System.Drawing.Size(143, 32);
            this.txtSoLuongBan.TabIndex = 22;
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
            this.txtMaSP.Location = new System.Drawing.Point(114, 30);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.PasswordChar = '\0';
            this.txtMaSP.PlaceholderText = "";
            this.txtMaSP.SelectedText = "";
            this.txtMaSP.Size = new System.Drawing.Size(143, 33);
            this.txtMaSP.TabIndex = 21;
            // 
            // GUIThemSanPhamVaoHoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtgvSanPham);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUIThemSanPhamVaoHoaDonXuat";
            this.Text = "GUIThemSanPhamVaoHoaDonBan";
            this.Load += new System.EventHandler(this.GUIThemSanPhamVaoHoaDonXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlm;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuongBan;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSP;
    }
}