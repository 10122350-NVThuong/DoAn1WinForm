namespace GUI
{
    partial class GUIThongTinSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvQLSP = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gtxtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbluachontimkiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLuongTon = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboMaDanhMuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtGiaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLSP)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvQLSP
            // 
            this.dtgvQLSP.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvQLSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvQLSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvQLSP.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgvQLSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvQLSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQLSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvQLSP.ColumnHeadersHeight = 18;
            this.dtgvQLSP.EnableHeadersVisualStyles = false;
            this.dtgvQLSP.GridColor = System.Drawing.Color.DimGray;
            this.dtgvQLSP.Location = new System.Drawing.Point(3, 211);
            this.dtgvQLSP.Name = "dtgvQLSP";
            this.dtgvQLSP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQLSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvQLSP.RowHeadersWidth = 51;
            this.dtgvQLSP.RowTemplate.Height = 24;
            this.dtgvQLSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQLSP.Size = new System.Drawing.Size(614, 210);
            this.dtgvQLSP.TabIndex = 19;
            this.dtgvQLSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvQLSP_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.gtxtTimKiem);
            this.groupBox3.Controls.Add(this.cbluachontimkiem);
            this.groupBox3.Location = new System.Drawing.Point(523, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 203);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm hàng hóa";
            // 
            // gtxtTimKiem
            // 
            this.gtxtTimKiem.AutoRoundedCorners = true;
            this.gtxtTimKiem.BorderRadius = 19;
            this.gtxtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtTimKiem.DefaultText = "";
            this.gtxtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.gtxtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtTimKiem.Location = new System.Drawing.Point(11, 73);
            this.gtxtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtTimKiem.Name = "gtxtTimKiem";
            this.gtxtTimKiem.PasswordChar = '\0';
            this.gtxtTimKiem.PlaceholderText = "Nhập thông tin muốn tìm kiếm";
            this.gtxtTimKiem.SelectedText = "";
            this.gtxtTimKiem.Size = new System.Drawing.Size(312, 40);
            this.gtxtTimKiem.TabIndex = 1;
            this.gtxtTimKiem.TextChanged += new System.EventHandler(this.gtxtTimKiem_TextChanged);
            // 
            // cbluachontimkiem
            // 
            this.cbluachontimkiem.AutoRoundedCorners = true;
            this.cbluachontimkiem.BackColor = System.Drawing.Color.Transparent;
            this.cbluachontimkiem.BorderRadius = 17;
            this.cbluachontimkiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbluachontimkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbluachontimkiem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbluachontimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbluachontimkiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbluachontimkiem.ForeColor = System.Drawing.Color.Black;
            this.cbluachontimkiem.ItemHeight = 30;
            this.cbluachontimkiem.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Tên sản phẩm",
            "Mã danh mục"});
            this.cbluachontimkiem.Location = new System.Drawing.Point(7, 28);
            this.cbluachontimkiem.Name = "cbluachontimkiem";
            this.cbluachontimkiem.Size = new System.Drawing.Size(311, 36);
            this.cbluachontimkiem.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.btdelete);
            this.groupBox2.Controls.Add(this.btupdate);
            this.groupBox2.Controls.Add(this.btreset);
            this.groupBox2.Location = new System.Drawing.Point(623, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 210);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btThem
            // 
            this.btThem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(3, 23);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(220, 47);
            this.btThem.TabIndex = 14;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btdelete
            // 
            this.btdelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdelete.Location = new System.Drawing.Point(3, 70);
            this.btdelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(220, 45);
            this.btdelete.TabIndex = 12;
            this.btdelete.Text = "Xóa";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btupdate
            // 
            this.btupdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btupdate.Location = new System.Drawing.Point(3, 115);
            this.btupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(220, 47);
            this.btupdate.TabIndex = 11;
            this.btupdate.Text = "Sửa";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btreset
            // 
            this.btreset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btreset.Location = new System.Drawing.Point(3, 162);
            this.btreset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(220, 45);
            this.btreset.TabIndex = 9;
            this.btreset.Text = "Làm mới";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtSoLuongTon);
            this.groupBox1.Controls.Add(this.cboMaDanhMuc);
            this.groupBox1.Controls.Add(this.txtGiaSP);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 203);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.AutoRoundedCorners = true;
            this.txtSoLuongTon.BorderRadius = 17;
            this.txtSoLuongTon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuongTon.DefaultText = "0";
            this.txtSoLuongTon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuongTon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuongTon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongTon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongTon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongTon.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoLuongTon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongTon.Location = new System.Drawing.Point(394, 28);
            this.txtSoLuongTon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.PasswordChar = '\0';
            this.txtSoLuongTon.PlaceholderText = "";
            this.txtSoLuongTon.SelectedText = "";
            this.txtSoLuongTon.Size = new System.Drawing.Size(114, 36);
            this.txtSoLuongTon.TabIndex = 13;
            // 
            // cboMaDanhMuc
            // 
            this.cboMaDanhMuc.AutoRoundedCorners = true;
            this.cboMaDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.cboMaDanhMuc.BorderRadius = 17;
            this.cboMaDanhMuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaDanhMuc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaDanhMuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaDanhMuc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaDanhMuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboMaDanhMuc.ItemHeight = 30;
            this.cboMaDanhMuc.Location = new System.Drawing.Point(148, 143);
            this.cboMaDanhMuc.Name = "cboMaDanhMuc";
            this.cboMaDanhMuc.Size = new System.Drawing.Size(164, 36);
            this.cboMaDanhMuc.TabIndex = 0;
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.AutoRoundedCorners = true;
            this.txtGiaSP.BorderRadius = 17;
            this.txtGiaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaSP.DefaultText = "0";
            this.txtGiaSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaSP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGiaSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaSP.Location = new System.Drawing.Point(394, 87);
            this.txtGiaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.PasswordChar = '\0';
            this.txtGiaSP.PlaceholderText = "";
            this.txtGiaSP.SelectedText = "";
            this.txtGiaSP.Size = new System.Drawing.Size(114, 36);
            this.txtGiaSP.TabIndex = 13;
            // 
            // txtTenSP
            // 
            this.txtTenSP.AutoRoundedCorners = true;
            this.txtTenSP.BorderRadius = 17;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.DefaultText = "";
            this.txtTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Location = new System.Drawing.Point(148, 87);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '\0';
            this.txtTenSP.PlaceholderText = "";
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.Size = new System.Drawing.Size(132, 36);
            this.txtTenSP.TabIndex = 13;
            // 
            // txtMaSP
            // 
            this.txtMaSP.AutoRoundedCorners = true;
            this.txtMaSP.BorderRadius = 17;
            this.txtMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSP.DefaultText = "";
            this.txtMaSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSP.Location = new System.Drawing.Point(148, 28);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.PasswordChar = '\0';
            this.txtMaSP.PlaceholderText = "";
            this.txtMaSP.SelectedText = "";
            this.txtMaSP.Size = new System.Drawing.Size(132, 36);
            this.txtMaSP.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã SP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên SP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ma Danh Muc";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(300, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giá SP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(300, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GUIThongTinSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(854, 427);
            this.Controls.Add(this.dtgvQLSP);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUIThongTinSanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.GUIThongTinSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLSP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvQLSP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox gtxtTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbluachontimkiem;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuongTon;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaDanhMuc;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaSP;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSP;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSP;
    }
}