namespace GUI
{
    partial class GUIDanhMucSanPham
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
            this.dtgvDMSP = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenLoaiSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaLoaiSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDMSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDMSP
            // 
            this.dtgvDMSP.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvDMSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDMSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDMSP.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgvDMSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvDMSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDMSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDMSP.ColumnHeadersHeight = 18;
            this.dtgvDMSP.EnableHeadersVisualStyles = false;
            this.dtgvDMSP.GridColor = System.Drawing.Color.DimGray;
            this.dtgvDMSP.Location = new System.Drawing.Point(3, 211);
            this.dtgvDMSP.Name = "dtgvDMSP";
            this.dtgvDMSP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDMSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDMSP.RowHeadersWidth = 51;
            this.dtgvDMSP.RowTemplate.Height = 24;
            this.dtgvDMSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDMSP.Size = new System.Drawing.Size(659, 273);
            this.dtgvDMSP.TabIndex = 23;
            this.dtgvDMSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDMSP_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.btdelete);
            this.groupBox2.Controls.Add(this.btupdate);
            this.groupBox2.Controls.Add(this.btreset);
            this.groupBox2.Location = new System.Drawing.Point(436, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 210);
            this.groupBox2.TabIndex = 21;
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
            this.btThem.Text = "Thêm Danh Mục";
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
            this.btdelete.Text = "Xóa Danh Mục";
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
            this.btupdate.Text = "Sửa Danh Mục";
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
            this.groupBox1.Controls.Add(this.txtTenLoaiSP);
            this.groupBox1.Controls.Add(this.txtMaLoaiSP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 203);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại sản phẩm";
            // 
            // txtTenLoaiSP
            // 
            this.txtTenLoaiSP.AutoRoundedCorners = true;
            this.txtTenLoaiSP.BorderRadius = 28;
            this.txtTenLoaiSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLoaiSP.DefaultText = "";
            this.txtTenLoaiSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenLoaiSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenLoaiSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoaiSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoaiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoaiSP.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txtTenLoaiSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoaiSP.Location = new System.Drawing.Point(157, 115);
            this.txtTenLoaiSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLoaiSP.Name = "txtTenLoaiSP";
            this.txtTenLoaiSP.PasswordChar = '\0';
            this.txtTenLoaiSP.PlaceholderText = "";
            this.txtTenLoaiSP.SelectedText = "";
            this.txtTenLoaiSP.Size = new System.Drawing.Size(252, 58);
            this.txtTenLoaiSP.TabIndex = 13;
            // 
            // txtMaLoaiSP
            // 
            this.txtMaLoaiSP.AutoRoundedCorners = true;
            this.txtMaLoaiSP.BorderRadius = 24;
            this.txtMaLoaiSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLoaiSP.DefaultText = "";
            this.txtMaLoaiSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaLoaiSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaLoaiSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLoaiSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLoaiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLoaiSP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLoaiSP.Location = new System.Drawing.Point(157, 28);
            this.txtMaLoaiSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLoaiSP.Name = "txtMaLoaiSP";
            this.txtMaLoaiSP.PasswordChar = '\0';
            this.txtMaLoaiSP.PlaceholderText = "";
            this.txtMaLoaiSP.SelectedText = "";
            this.txtMaLoaiSP.Size = new System.Drawing.Size(159, 50);
            this.txtMaLoaiSP.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã loại sản phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 53);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại sản phẩm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GUIDanhMucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 485);
            this.Controls.Add(this.dtgvDMSP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUIDanhMucSanPham";
            this.Text = "GUIDanhMucSanPham";
            this.Load += new System.EventHandler(this.GUIDanhMucSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDMSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDMSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLoaiSP;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLoaiSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}