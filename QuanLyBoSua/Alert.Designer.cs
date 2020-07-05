namespace QuanLyBoSua
{
    partial class Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbMess = new System.Windows.Forms.Label();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TimeOut = new System.Windows.Forms.Timer(this.components);
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "hand.png");
            this.imageList1.Images.SetKeyName(1, "info.png");
            this.imageList1.Images.SetKeyName(2, "Cancel.png");
            this.imageList1.Images.SetKeyName(3, "warning.png");
            // 
            // lbMess
            // 
            this.lbMess.AutoSize = true;
            this.lbMess.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMess.Location = new System.Drawing.Point(169, 19);
            this.lbMess.Name = "lbMess";
            this.lbMess.Size = new System.Drawing.Size(107, 22);
            this.lbMess.TabIndex = 1;
            this.lbMess.Text = "Thành Công";
            // 
            // ptbIcon
            // 
            this.ptbIcon.BackColor = System.Drawing.Color.Transparent;
            this.ptbIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbIcon.BackgroundImage")));
            this.ptbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbIcon.Location = new System.Drawing.Point(103, 5);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(60, 45);
            this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbIcon.TabIndex = 0;
            this.ptbIcon.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TimeOut
            // 
            this.TimeOut.Interval = 2000;
            this.TimeOut.Tick += new System.EventHandler(this.TimeOut_Tick_1);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 1;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Yellow;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "OK";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 2;
            this.bunifuThinButton21.IdleCornerRadius = 11;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.Location = new System.Drawing.Point(234, 67);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(62, 35);
            this.bunifuThinButton21.TabIndex = 2;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(541, 105);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.lbMess);
            this.Controls.Add(this.ptbIcon);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alert";
            this.Load += new System.EventHandler(this.Alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox ptbIcon;
        private System.Windows.Forms.Label lbMess;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer TimeOut;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}