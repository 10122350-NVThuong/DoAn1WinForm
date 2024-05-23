namespace GUI
{
    partial class GUIDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIDangNhap));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.llbforgotpass = new System.Windows.Forms.LinkLabel();
            this.btnChangePass = new Guna.UI2.WinForms.Guna2Button();
            this.ckHienMatKhau = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gtxtTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(530, 556);
            this.guna2Panel1.TabIndex = 3;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2GroupBox1);
            this.guna2Panel2.Location = new System.Drawing.Point(532, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(544, 556);
            this.guna2Panel2.TabIndex = 4;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.btnExit);
            this.guna2GroupBox1.Controls.Add(this.llbforgotpass);
            this.guna2GroupBox1.Controls.Add(this.btnChangePass);
            this.guna2GroupBox1.Controls.Add(this.ckHienMatKhau);
            this.guna2GroupBox1.Controls.Add(this.gtxtTaiKhoan);
            this.guna2GroupBox1.Controls.Add(this.gtxtMatKhau);
            this.guna2GroupBox1.Controls.Add(this.btnLogin);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(4, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(537, 550);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Đăng nhập hệ thống";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(350, 495);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 52);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // llbforgotpass
            // 
            this.llbforgotpass.Location = new System.Drawing.Point(264, 415);
            this.llbforgotpass.Name = "llbforgotpass";
            this.llbforgotpass.Size = new System.Drawing.Size(172, 58);
            this.llbforgotpass.TabIndex = 8;
            this.llbforgotpass.TabStop = true;
            this.llbforgotpass.Text = "Quên mật khẩu";
            this.llbforgotpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbforgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbforgotpass_LinkClicked);
            // 
            // btnChangePass
            // 
            this.btnChangePass.AutoRoundedCorners = true;
            this.btnChangePass.BorderRadius = 28;
            this.btnChangePass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnChangePass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangePass.ForeColor = System.Drawing.Color.Black;
            this.btnChangePass.Location = new System.Drawing.Point(34, 415);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(192, 58);
            this.btnChangePass.TabIndex = 7;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // ckHienMatKhau
            // 
            this.ckHienMatKhau.AutoSize = true;
            this.ckHienMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ckHienMatKhau.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckHienMatKhau.CheckedState.BorderRadius = 0;
            this.ckHienMatKhau.CheckedState.BorderThickness = 0;
            this.ckHienMatKhau.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckHienMatKhau.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ckHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.ckHienMatKhau.ForeColor = System.Drawing.Color.Black;
            this.ckHienMatKhau.Location = new System.Drawing.Point(172, 261);
            this.ckHienMatKhau.Name = "ckHienMatKhau";
            this.ckHienMatKhau.Size = new System.Drawing.Size(149, 29);
            this.ckHienMatKhau.TabIndex = 6;
            this.ckHienMatKhau.Text = "Xem mật khẩu";
            this.ckHienMatKhau.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.ckHienMatKhau.UncheckedState.BorderRadius = 0;
            this.ckHienMatKhau.UncheckedState.BorderThickness = 0;
            this.ckHienMatKhau.UncheckedState.FillColor = System.Drawing.Color.White;
            this.ckHienMatKhau.UseVisualStyleBackColor = false;
            this.ckHienMatKhau.CheckedChanged += new System.EventHandler(this.ckHienMatKhau_CheckedChanged);
            // 
            // gtxtTaiKhoan
            // 
            this.gtxtTaiKhoan.AutoRoundedCorners = true;
            this.gtxtTaiKhoan.BorderColor = System.Drawing.Color.Gray;
            this.gtxtTaiKhoan.BorderRadius = 29;
            this.gtxtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtTaiKhoan.DefaultText = "";
            this.gtxtTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.gtxtTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtTaiKhoan.Location = new System.Drawing.Point(82, 78);
            this.gtxtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtTaiKhoan.Name = "gtxtTaiKhoan";
            this.gtxtTaiKhoan.PasswordChar = '\0';
            this.gtxtTaiKhoan.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gtxtTaiKhoan.PlaceholderText = "Nhập tài khoản";
            this.gtxtTaiKhoan.SelectedText = "";
            this.gtxtTaiKhoan.Size = new System.Drawing.Size(332, 61);
            this.gtxtTaiKhoan.TabIndex = 2;
            // 
            // gtxtMatKhau
            // 
            this.gtxtMatKhau.AutoRoundedCorners = true;
            this.gtxtMatKhau.BorderColor = System.Drawing.Color.Gray;
            this.gtxtMatKhau.BorderRadius = 27;
            this.gtxtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtMatKhau.DefaultText = "";
            this.gtxtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.gtxtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtMatKhau.Location = new System.Drawing.Point(82, 177);
            this.gtxtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtMatKhau.Name = "gtxtMatKhau";
            this.gtxtMatKhau.PasswordChar = '*';
            this.gtxtMatKhau.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gtxtMatKhau.PlaceholderText = "Nhập mật khẩu";
            this.gtxtMatKhau.SelectedText = "";
            this.gtxtMatKhau.Size = new System.Drawing.Size(332, 56);
            this.gtxtMatKhau.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BorderRadius = 31;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(82, 320);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(332, 65);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // GUIDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 556);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "GUIDangNhap";
            this.Text = "GUIDangNhap";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnChangePass;
        private Guna.UI2.WinForms.Guna2CheckBox ckHienMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox gtxtTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox gtxtMatKhau;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.LinkLabel llbforgotpass;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}