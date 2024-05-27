namespace GUI
{
    partial class GUIInHoaDon
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInHDX = new System.Windows.Forms.Button();
            this.btnInHDN = new System.Windows.Forms.Button();
            this.cbohoadonnhap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbohoadonban = new Guna.UI2.WinForms.Guna2ComboBox();
            this.hoadonnhap = new Guna.UI2.WinForms.Guna2GroupBox();
            this.hoadonban = new Guna.UI2.WinForms.Guna2GroupBox();
            this.hoadonnhap.SuspendLayout();
            this.hoadonban.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(72, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã hóa đơn bán";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(80, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã hóa đơn nhập";
            // 
            // btnInHDX
            // 
            this.btnInHDX.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHDX.ForeColor = System.Drawing.Color.Black;
            this.btnInHDX.Location = new System.Drawing.Point(75, 191);
            this.btnInHDX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInHDX.Name = "btnInHDX";
            this.btnInHDX.Size = new System.Drawing.Size(212, 56);
            this.btnInHDX.TabIndex = 11;
            this.btnInHDX.Text = "In hóa đơn xuất";
            this.btnInHDX.UseVisualStyleBackColor = true;
            this.btnInHDX.Click += new System.EventHandler(this.btnInHDX_Click);
            // 
            // btnInHDN
            // 
            this.btnInHDN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHDN.ForeColor = System.Drawing.Color.Black;
            this.btnInHDN.Location = new System.Drawing.Point(83, 191);
            this.btnInHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInHDN.Name = "btnInHDN";
            this.btnInHDN.Size = new System.Drawing.Size(194, 56);
            this.btnInHDN.TabIndex = 10;
            this.btnInHDN.Text = "In hóa đơn nhập";
            this.btnInHDN.UseVisualStyleBackColor = true;
            this.btnInHDN.Click += new System.EventHandler(this.btnInHDN_Click);
            // 
            // cbohoadonnhap
            // 
            this.cbohoadonnhap.BackColor = System.Drawing.Color.Transparent;
            this.cbohoadonnhap.BorderColor = System.Drawing.Color.Black;
            this.cbohoadonnhap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbohoadonnhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbohoadonnhap.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbohoadonnhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbohoadonnhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbohoadonnhap.ForeColor = System.Drawing.Color.Black;
            this.cbohoadonnhap.ItemHeight = 30;
            this.cbohoadonnhap.Location = new System.Drawing.Point(84, 136);
            this.cbohoadonnhap.Name = "cbohoadonnhap";
            this.cbohoadonnhap.Size = new System.Drawing.Size(193, 36);
            this.cbohoadonnhap.TabIndex = 16;
            // 
            // cbohoadonban
            // 
            this.cbohoadonban.BackColor = System.Drawing.Color.Transparent;
            this.cbohoadonban.BorderColor = System.Drawing.Color.Black;
            this.cbohoadonban.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbohoadonban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbohoadonban.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbohoadonban.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbohoadonban.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbohoadonban.ForeColor = System.Drawing.Color.Black;
            this.cbohoadonban.ItemHeight = 30;
            this.cbohoadonban.Location = new System.Drawing.Point(76, 136);
            this.cbohoadonban.Name = "cbohoadonban";
            this.cbohoadonban.Size = new System.Drawing.Size(212, 36);
            this.cbohoadonban.TabIndex = 17;
            // 
            // hoadonnhap
            // 
            this.hoadonnhap.Controls.Add(this.label1);
            this.hoadonnhap.Controls.Add(this.btnInHDN);
            this.hoadonnhap.Controls.Add(this.cbohoadonnhap);
            this.hoadonnhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hoadonnhap.ForeColor = System.Drawing.Color.Black;
            this.hoadonnhap.Location = new System.Drawing.Point(2, 3);
            this.hoadonnhap.Name = "hoadonnhap";
            this.hoadonnhap.Size = new System.Drawing.Size(355, 302);
            this.hoadonnhap.TabIndex = 18;
            this.hoadonnhap.Text = "In chi tiết hóa đơn nhập";
            this.hoadonnhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoadonnhap.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // hoadonban
            // 
            this.hoadonban.Controls.Add(this.label2);
            this.hoadonban.Controls.Add(this.btnInHDX);
            this.hoadonban.Controls.Add(this.cbohoadonban);
            this.hoadonban.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hoadonban.ForeColor = System.Drawing.Color.Black;
            this.hoadonban.Location = new System.Drawing.Point(359, 3);
            this.hoadonban.Name = "hoadonban";
            this.hoadonban.Size = new System.Drawing.Size(344, 302);
            this.hoadonban.TabIndex = 19;
            this.hoadonban.Text = "In chi tiết hóa đơn bán";
            this.hoadonban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoadonban.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // GUIInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 307);
            this.Controls.Add(this.hoadonban);
            this.Controls.Add(this.hoadonnhap);
            this.Name = "GUIInHoaDon";
            this.Text = "GUIInHoaDon";
            this.Load += new System.EventHandler(this.GUIInHoaDon_Load);
            this.hoadonnhap.ResumeLayout(false);
            this.hoadonban.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInHDX;
        private System.Windows.Forms.Button btnInHDN;
        private Guna.UI2.WinForms.Guna2ComboBox cbohoadonnhap;
        private Guna.UI2.WinForms.Guna2ComboBox cbohoadonban;
        private Guna.UI2.WinForms.Guna2GroupBox hoadonnhap;
        private Guna.UI2.WinForms.Guna2GroupBox hoadonban;
    }
}