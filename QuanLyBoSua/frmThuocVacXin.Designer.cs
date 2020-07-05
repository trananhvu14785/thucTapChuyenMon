namespace QuanLyBoSua
{
    partial class frmThuocVacXin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuocVacXin));
            this.dgvThuoc = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbThuoc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbDVT = new System.Windows.Forms.ComboBox();
            this.lbSoLuongCon = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbDVT = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbTenNcc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTenThuoc = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbSoLuongCon = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbMaThuoc = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.quanLyBoSuaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBoSuaDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvThuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThuoc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThuoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThuoc,
            this.tenThuoc,
            this.DVT,
            this.SoLuongCon});
            this.dgvThuoc.DoubleBuffered = true;
            this.dgvThuoc.EnableHeadersVisualStyles = false;
            this.dgvThuoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvThuoc.HeaderBgColor = System.Drawing.Color.Cyan;
            this.dgvThuoc.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvThuoc.Location = new System.Drawing.Point(11, 293);
            this.dgvThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.RowTemplate.Height = 24;
            this.dgvThuoc.Size = new System.Drawing.Size(546, 208);
            this.dgvThuoc.TabIndex = 20;
            this.dgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellClick);
            // 
            // maThuoc
            // 
            this.maThuoc.DataPropertyName = "mathuoc";
            this.maThuoc.HeaderText = "Mã thuốc";
            this.maThuoc.MinimumWidth = 6;
            this.maThuoc.Name = "maThuoc";
            this.maThuoc.Width = 125;
            // 
            // tenThuoc
            // 
            this.tenThuoc.DataPropertyName = "tenthuoc";
            this.tenThuoc.HeaderText = "Tên thuốc";
            this.tenThuoc.MinimumWidth = 6;
            this.tenThuoc.Name = "tenThuoc";
            this.tenThuoc.Width = 125;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "donvitinh";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.Width = 125;
            // 
            // SoLuongCon
            // 
            this.SoLuongCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongCon.DataPropertyName = "slcon";
            this.SoLuongCon.HeaderText = "Số lượng còn";
            this.SoLuongCon.MinimumWidth = 6;
            this.SoLuongCon.Name = "SoLuongCon";
            // 
            // lbThuoc
            // 
            this.lbThuoc.AutoSize = true;
            this.lbThuoc.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuoc.Location = new System.Drawing.Point(208, 23);
            this.lbThuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThuoc.Name = "lbThuoc";
            this.lbThuoc.Size = new System.Drawing.Size(203, 35);
            this.lbThuoc.TabIndex = 13;
            this.lbThuoc.Text = "Thuốc - Vacxin";
            // 
            // cbDVT
            // 
            this.cbDVT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDVT.FormattingEnabled = true;
            this.cbDVT.Location = new System.Drawing.Point(185, 69);
            this.cbDVT.Margin = new System.Windows.Forms.Padding(2);
            this.cbDVT.Name = "cbDVT";
            this.cbDVT.Size = new System.Drawing.Size(272, 28);
            this.cbDVT.TabIndex = 6;
            // 
            // lbSoLuongCon
            // 
            this.lbSoLuongCon.AutoSize = true;
            this.lbSoLuongCon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongCon.ForeColor = System.Drawing.Color.Black;
            this.lbSoLuongCon.Location = new System.Drawing.Point(66, 107);
            this.lbSoLuongCon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoLuongCon.Name = "lbSoLuongCon";
            this.lbSoLuongCon.Size = new System.Drawing.Size(115, 21);
            this.lbSoLuongCon.TabIndex = 0;
            this.lbSoLuongCon.Text = "Số lượng còn:";
            // 
            // lbDVT
            // 
            this.lbDVT.AutoSize = true;
            this.lbDVT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDVT.ForeColor = System.Drawing.Color.Black;
            this.lbDVT.Location = new System.Drawing.Point(77, 69);
            this.lbDVT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(99, 21);
            this.lbDVT.TabIndex = 0;
            this.lbDVT.Text = "Đơn vị tính:";
            // 
            // lbTenNcc
            // 
            this.lbTenNcc.AutoSize = true;
            this.lbTenNcc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNcc.ForeColor = System.Drawing.Color.Black;
            this.lbTenNcc.Location = new System.Drawing.Point(22, 35);
            this.lbTenNcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenNcc.Name = "lbTenNcc";
            this.lbTenNcc.Size = new System.Drawing.Size(154, 21);
            this.lbTenNcc.TabIndex = 0;
            this.lbTenNcc.Text = "Tên thuốc - vacxin:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTenThuoc);
            this.groupBox1.Controls.Add(this.cbDVT);
            this.groupBox1.Controls.Add(this.lbTenNcc);
            this.groupBox1.Controls.Add(this.tbSoLuongCon);
            this.groupBox1.Controls.Add(this.lbDVT);
            this.groupBox1.Controls.Add(this.lbSoLuongCon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(478, 151);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Thuốc-Vacxin";
            // 
            // tbTenThuoc
            // 
            this.tbTenThuoc.BackColor = System.Drawing.Color.White;
            this.tbTenThuoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTenThuoc.BackgroundImage")));
            this.tbTenThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTenThuoc.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenThuoc.ForeColor = System.Drawing.Color.Black;
            this.tbTenThuoc.Icon = ((System.Drawing.Image)(resources.GetObject("tbTenThuoc.Icon")));
            this.tbTenThuoc.Location = new System.Drawing.Point(185, 35);
            this.tbTenThuoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTenThuoc.Name = "tbTenThuoc";
            this.tbTenThuoc.Size = new System.Drawing.Size(272, 24);
            this.tbTenThuoc.TabIndex = 3;
            this.tbTenThuoc.text = "";
            // 
            // tbSoLuongCon
            // 
            this.tbSoLuongCon.BackColor = System.Drawing.Color.White;
            this.tbSoLuongCon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSoLuongCon.BackgroundImage")));
            this.tbSoLuongCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbSoLuongCon.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuongCon.ForeColor = System.Drawing.Color.Black;
            this.tbSoLuongCon.Icon = ((System.Drawing.Image)(resources.GetObject("tbSoLuongCon.Icon")));
            this.tbSoLuongCon.Location = new System.Drawing.Point(185, 107);
            this.tbSoLuongCon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbSoLuongCon.Name = "tbSoLuongCon";
            this.tbSoLuongCon.Size = new System.Drawing.Size(272, 24);
            this.tbSoLuongCon.TabIndex = 5;
            this.tbSoLuongCon.text = "";
            // 
            // tbMaThuoc
            // 
            this.tbMaThuoc.BackColor = System.Drawing.Color.White;
            this.tbMaThuoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbMaThuoc.BackgroundImage")));
            this.tbMaThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbMaThuoc.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaThuoc.ForeColor = System.Drawing.Color.Black;
            this.tbMaThuoc.Icon = ((System.Drawing.Image)(resources.GetObject("tbMaThuoc.Icon")));
            this.tbMaThuoc.Location = new System.Drawing.Point(505, 81);
            this.tbMaThuoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbMaThuoc.Name = "tbMaThuoc";
            this.tbMaThuoc.Size = new System.Drawing.Size(36, 24);
            this.tbMaThuoc.TabIndex = 2;
            this.tbMaThuoc.text = "";
            this.tbMaThuoc.Visible = false;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BackColor = System.Drawing.Color.MintCream;
            this.tbTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.BackgroundImage")));
            this.tbTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTimKiem.ForeColor = System.Drawing.Color.Black;
            this.tbTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.Icon")));
            this.tbTimKiem.Location = new System.Drawing.Point(168, 77);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(309, 28);
            this.tbTimKiem.TabIndex = 14;
            this.tbTimKiem.text = "";
            this.tbTimKiem.OnTextChange += new System.EventHandler(this.tbTimKiem_OnTextChange);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "Hủy";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::QuanLyBoSua.Properties.Resources.huy1;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(427, 506);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(81, 38);
            this.bunifuFlatButton1.TabIndex = 75;
            this.bunifuFlatButton1.Text = "Hủy";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Teal;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 5;
            this.bunifuFlatButton2.ButtonText = "Lưu";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::QuanLyBoSua.Properties.Resources.save;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 60D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(339, 506);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(82, 38);
            this.bunifuFlatButton2.TabIndex = 74;
            this.bunifuFlatButton2.Text = "Lưu";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Activecolor = System.Drawing.Color.Teal;
            this.btnXoa.BackColor = System.Drawing.Color.Teal;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.BorderRadius = 5;
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXoa.Iconimage = global::QuanLyBoSua.Properties.Resources.delete;
            this.btnXoa.Iconimage_right = null;
            this.btnXoa.Iconimage_right_Selected = null;
            this.btnXoa.Iconimage_Selected = null;
            this.btnXoa.IconMarginLeft = 0;
            this.btnXoa.IconMarginRight = 0;
            this.btnXoa.IconRightVisible = true;
            this.btnXoa.IconRightZoom = 0D;
            this.btnXoa.IconVisible = true;
            this.btnXoa.IconZoom = 60D;
            this.btnXoa.IsTab = false;
            this.btnXoa.Location = new System.Drawing.Point(238, 506);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.Teal;
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(95, 38);
            this.btnXoa.TabIndex = 73;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Textcolor = System.Drawing.Color.Black;
            this.btnXoa.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Activecolor = System.Drawing.Color.Teal;
            this.btnSua.BackColor = System.Drawing.Color.Teal;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.BorderRadius = 5;
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSua.Iconimage = global::QuanLyBoSua.Properties.Resources.sua2;
            this.btnSua.Iconimage_right = null;
            this.btnSua.Iconimage_right_Selected = null;
            this.btnSua.Iconimage_Selected = null;
            this.btnSua.IconMarginLeft = 0;
            this.btnSua.IconMarginRight = 0;
            this.btnSua.IconRightVisible = true;
            this.btnSua.IconRightZoom = 0D;
            this.btnSua.IconVisible = true;
            this.btnSua.IconZoom = 60D;
            this.btnSua.IsTab = false;
            this.btnSua.Location = new System.Drawing.Point(149, 507);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.Teal;
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(83, 38);
            this.btnSua.TabIndex = 72;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Textcolor = System.Drawing.Color.Black;
            this.btnSua.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Activecolor = System.Drawing.Color.Teal;
            this.btnThem.BackColor = System.Drawing.Color.Teal;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 5;
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThem.Iconimage = global::QuanLyBoSua.Properties.Resources.insert1;
            this.btnThem.Iconimage_right = null;
            this.btnThem.Iconimage_right_Selected = null;
            this.btnThem.Iconimage_Selected = null;
            this.btnThem.IconMarginLeft = 0;
            this.btnThem.IconMarginRight = 0;
            this.btnThem.IconRightVisible = true;
            this.btnThem.IconRightZoom = 0D;
            this.btnThem.IconVisible = true;
            this.btnThem.IconZoom = 60D;
            this.btnThem.IsTab = false;
            this.btnThem.Location = new System.Drawing.Point(51, 506);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.Teal;
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(92, 38);
            this.btnThem.TabIndex = 71;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.Black;
            this.btnThem.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 27);
            this.panel1.TabIndex = 76;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Teal;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(549, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Padding = new System.Windows.Forms.Padding(5);
            this.bunifuImageButton2.Size = new System.Drawing.Size(22, 27);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 9;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Teal;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(657, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(22, 22);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panel1;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this;
            // 
            // frmThuocVacXin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(571, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbMaThuoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.lbThuoc);
            this.Controls.Add(this.tbTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThuocVacXin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THUỐC - VACXIN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBoSuaDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvThuoc;
        private Bunifu.Framework.UI.BunifuCustomLabel lbThuoc;
        private System.Windows.Forms.ComboBox cbDVT;
        private Bunifu.Framework.UI.BunifuTextbox tbSoLuongCon;
        private Bunifu.Framework.UI.BunifuTextbox tbTenThuoc;
        private Bunifu.Framework.UI.BunifuTextbox tbMaThuoc;
        private Bunifu.Framework.UI.BunifuCustomLabel lbSoLuongCon;
        private Bunifu.Framework.UI.BunifuCustomLabel lbDVT;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTenNcc;
        private Bunifu.Framework.UI.BunifuTextbox tbTimKiem;
        private System.Windows.Forms.BindingSource quanLyBoSuaDataSetBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongCon;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}