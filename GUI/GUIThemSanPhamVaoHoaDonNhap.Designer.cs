namespace GUI
{
    partial class GUIThemSanPhamVaoHoaDonNhap
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
            this.dtgvSP = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuongNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnlm = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvSP
            // 
            this.dtgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSP.Location = new System.Drawing.Point(3, 3);
            this.dtgvSP.Name = "dtgvSP";
            this.dtgvSP.RowHeadersWidth = 51;
            this.dtgvSP.RowTemplate.Height = 24;
            this.dtgvSP.Size = new System.Drawing.Size(455, 150);
            this.dtgvSP.TabIndex = 20;
            this.dtgvSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSP_CellClick);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoLuongNhap);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Location = new System.Drawing.Point(3, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 190);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
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
            // txtGiaNhap
            // 
            this.txtGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaNhap.DefaultText = "";
            this.txtGiaNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaNhap.Location = new System.Drawing.Point(114, 132);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.PasswordChar = '\0';
            this.txtGiaNhap.PlaceholderText = "";
            this.txtGiaNhap.SelectedText = "";
            this.txtGiaNhap.Size = new System.Drawing.Size(143, 32);
            this.txtGiaNhap.TabIndex = 23;
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
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuongNhap.DefaultText = "";
            this.txtSoLuongNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuongNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuongNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuongNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongNhap.Location = new System.Drawing.Point(114, 78);
            this.txtSoLuongNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.PasswordChar = '\0';
            this.txtSoLuongNhap.PlaceholderText = "";
            this.txtSoLuongNhap.SelectedText = "";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(143, 32);
            this.txtSoLuongNhap.TabIndex = 22;
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
            // btnlm
            // 
            this.btnlm.Location = new System.Drawing.Point(14, 78);
            this.btnlm.Name = "btnlm";
            this.btnlm.Size = new System.Drawing.Size(145, 42);
            this.btnlm.TabIndex = 1;
            this.btnlm.Text = "Làm mới";
            this.btnlm.UseVisualStyleBackColor = true;
            this.btnlm.Click += new System.EventHandler(this.btnlm_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(14, 20);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(145, 43);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(14, 129);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 45);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnlm);
            this.groupBox2.Location = new System.Drawing.Point(295, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 180);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // GUIThemSanPhamVaoHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtgvSP);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUIThemSanPhamVaoHoaDonNhap";
            this.Text = "GUIThemSanPhamVaoHoaDonNhap";
            this.Load += new System.EventHandler(this.GUIThemSanPhamVaoHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlm;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSP;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuongNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}