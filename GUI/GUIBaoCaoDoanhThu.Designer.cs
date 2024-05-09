namespace GUI
{
    partial class GUIBaoCaoDoanhThu
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
            this.cboluachon = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntktn = new System.Windows.Forms.Button();
            this.txtt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntkn = new System.Windows.Forms.Button();
            this.txtn = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboluachon
            // 
            this.cboluachon.FormattingEnabled = true;
            this.cboluachon.Location = new System.Drawing.Point(3, 12);
            this.cboluachon.Name = "cboluachon";
            this.cboluachon.Size = new System.Drawing.Size(428, 24);
            this.cboluachon.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntktn);
            this.groupBox2.Controls.Add(this.txtt);
            this.groupBox2.Location = new System.Drawing.Point(3, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 117);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê doanh thu theo tháng";
            // 
            // btntktn
            // 
            this.btntktn.Location = new System.Drawing.Point(122, 68);
            this.btntktn.Name = "btntktn";
            this.btntktn.Size = new System.Drawing.Size(179, 39);
            this.btntktn.TabIndex = 3;
            this.btntktn.Text = "Enter";
            this.btntktn.UseVisualStyleBackColor = true;
            // 
            // txtt
            // 
            this.txtt.Location = new System.Drawing.Point(162, 24);
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(100, 22);
            this.txtt.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntkn);
            this.groupBox1.Controls.Add(this.txtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê doanh thu theo năm";
            // 
            // btntkn
            // 
            this.btntkn.Location = new System.Drawing.Point(122, 66);
            this.btntkn.Name = "btntkn";
            this.btntkn.Size = new System.Drawing.Size(179, 39);
            this.btntkn.TabIndex = 1;
            this.btntkn.Text = "Enter";
            this.btntkn.UseVisualStyleBackColor = true;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(162, 24);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 22);
            this.txtn.TabIndex = 0;
            // 
            // GUIBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 281);
            this.Controls.Add(this.cboluachon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUIBaoCaoDoanhThu";
            this.Text = "GUIBaoCaoDoanhThu";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboluachon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntktn;
        private System.Windows.Forms.TextBox txtt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntkn;
        private System.Windows.Forms.TextBox txtn;
    }
}