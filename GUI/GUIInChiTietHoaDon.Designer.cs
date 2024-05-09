namespace GUI
{
    partial class GUIInChiTietHoaDon
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
            this.cbohdx = new System.Windows.Forms.ComboBox();
            this.cbohdn = new System.Windows.Forms.ComboBox();
            this.btnInHDX = new System.Windows.Forms.Button();
            this.btnInHDN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(324, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã hóa đơn xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã hóa đơn nhập";
            // 
            // cbohdx
            // 
            this.cbohdx.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbohdx.FormattingEnabled = true;
            this.cbohdx.Location = new System.Drawing.Point(291, 50);
            this.cbohdx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbohdx.Name = "cbohdx";
            this.cbohdx.Size = new System.Drawing.Size(211, 27);
            this.cbohdx.TabIndex = 13;
            // 
            // cbohdn
            // 
            this.cbohdn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbohdn.FormattingEnabled = true;
            this.cbohdn.Location = new System.Drawing.Point(9, 50);
            this.cbohdn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbohdn.Name = "cbohdn";
            this.cbohdn.Size = new System.Drawing.Size(193, 27);
            this.cbohdn.TabIndex = 12;
            // 
            // btnInHDX
            // 
            this.btnInHDX.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHDX.Location = new System.Drawing.Point(291, 106);
            this.btnInHDX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInHDX.Name = "btnInHDX";
            this.btnInHDX.Size = new System.Drawing.Size(212, 56);
            this.btnInHDX.TabIndex = 11;
            this.btnInHDX.Text = "In hóa đơn xuất";
            this.btnInHDX.UseVisualStyleBackColor = true;
            // 
            // btnInHDN
            // 
            this.btnInHDN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHDN.Location = new System.Drawing.Point(9, 106);
            this.btnInHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInHDN.Name = "btnInHDN";
            this.btnInHDN.Size = new System.Drawing.Size(194, 56);
            this.btnInHDN.TabIndex = 10;
            this.btnInHDN.Text = "In hóa đơn nhập";
            this.btnInHDN.UseVisualStyleBackColor = true;
            // 
            // GUIInChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 168);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbohdx);
            this.Controls.Add(this.cbohdn);
            this.Controls.Add(this.btnInHDX);
            this.Controls.Add(this.btnInHDN);
            this.Name = "GUIInChiTietHoaDon";
            this.Text = "GUIInChiTietHoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbohdx;
        private System.Windows.Forms.ComboBox cbohdn;
        private System.Windows.Forms.Button btnInHDX;
        private System.Windows.Forms.Button btnInHDN;
    }
}