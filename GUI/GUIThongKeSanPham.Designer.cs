namespace GUI
{
    partial class GUIThongKeSanPham
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
            this.btnThongKe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(67, 51);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(249, 73);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê sản phẩm tồn kho";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // GUIThongKeSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 207);
            this.Controls.Add(this.btnThongKe);
            this.Name = "GUIThongKeSanPham";
            this.Text = "GUIThongKeSanPham";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThongKe;
    }
}