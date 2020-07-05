namespace QuanLyBoSua
{
    partial class FDoanhThuBanSua
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDoanhThuBanSua));
            this.HDBanSuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.dtpkTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtpkDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMail = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.HDBanSuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // HDBanSuaBindingSource
            // 
            this.HDBanSuaBindingSource.DataMember = "HDBanSua";
            // 
            // KhachHangBindingSource
            // 
            this.KhachHangBindingSource.DataMember = "KhachHang";
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Teal;
            this.reportViewer1.ForeColor = System.Drawing.Color.Black;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HDBanSuaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.KhachHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBoSua.RPDoanhThuBanSua.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(844, 500);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.dtpkTuNgay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 28);
            this.panel1.TabIndex = 3;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Teal;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(818, 1);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(23, 28);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // dtpkTuNgay
            // 
            this.dtpkTuNgay.CalendarMonthBackground = System.Drawing.Color.Teal;
            this.dtpkTuNgay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpkTuNgay.CustomFormat = "yyyy-MM-dd ";
            this.dtpkTuNgay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTuNgay.Location = new System.Drawing.Point(362, 8);
            this.dtpkTuNgay.Name = "dtpkTuNgay";
            this.dtpkTuNgay.Size = new System.Drawing.Size(106, 21);
            this.dtpkTuNgay.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(283, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Từ ngày";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Teal;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Xuất File";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 4;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Teal;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.Location = new System.Drawing.Point(349, 570);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(66, 43);
            this.bunifuThinButton22.TabIndex = 59;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // dtpkDenNgay
            // 
            this.dtpkDenNgay.CalendarMonthBackground = System.Drawing.Color.Teal;
            this.dtpkDenNgay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpkDenNgay.CustomFormat = "yyyy-MM-dd ";
            this.dtpkDenNgay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDenNgay.Location = new System.Drawing.Point(362, 34);
            this.dtpkDenNgay.Name = "dtpkDenNgay";
            this.dtpkDenNgay.Size = new System.Drawing.Size(106, 21);
            this.dtpkDenNgay.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(283, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Đến ngày";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Xem";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 4;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.Location = new System.Drawing.Point(475, 12);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(66, 43);
            this.bunifuThinButton21.TabIndex = 60;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_2);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuThinButton23.BackColor = System.Drawing.Color.Teal;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Biểu Đồ";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 4;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Teal;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton23.Location = new System.Drawing.Point(434, 570);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(66, 43);
            this.bunifuThinButton23.TabIndex = 65;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // btnMail
            // 
            this.btnMail.ActiveBorderThickness = 1;
            this.btnMail.ActiveCornerRadius = 20;
            this.btnMail.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMail.ActiveForecolor = System.Drawing.Color.Black;
            this.btnMail.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMail.BackColor = System.Drawing.Color.Teal;
            this.btnMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMail.BackgroundImage")));
            this.btnMail.ButtonText = "Mail";
            this.btnMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMail.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnMail.IdleBorderThickness = 1;
            this.btnMail.IdleCornerRadius = 3;
            this.btnMail.IdleFillColor = System.Drawing.Color.Teal;
            this.btnMail.IdleForecolor = System.Drawing.Color.Black;
            this.btnMail.IdleLineColor = System.Drawing.Color.Black;
            this.btnMail.Location = new System.Drawing.Point(528, 570);
            this.btnMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(66, 43);
            this.btnMail.TabIndex = 68;
            this.btnMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // FDoanhThuBanSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(844, 616);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.dtpkDenNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FDoanhThuBanSua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDoanhThuBanSua";
            this.Load += new System.EventHandler(this.FDoanhThuBanSua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HDBanSuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HDBanSuaBindingSource;
     
        private System.Windows.Forms.BindingSource KhachHangBindingSource;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DateTimePicker dtpkDenNgay;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.DateTimePicker dtpkTuNgay;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMail;
    }
}