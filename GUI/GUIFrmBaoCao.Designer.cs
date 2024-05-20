namespace GUI
{
    partial class GUIFrmBaoCao
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
            this.CRreport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRreport
            // 
            this.CRreport.ActiveViewIndex = -1;
            this.CRreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRreport.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRreport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRreport.Location = new System.Drawing.Point(0, 0);
            this.CRreport.Name = "CRreport";
            this.CRreport.Size = new System.Drawing.Size(800, 450);
            this.CRreport.TabIndex = 0;
            // 
            // GUIFrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRreport);
            this.Name = "GUIFrmBaoCao";
            this.Text = "GUIFrmBaoCao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRreport;
    }
}