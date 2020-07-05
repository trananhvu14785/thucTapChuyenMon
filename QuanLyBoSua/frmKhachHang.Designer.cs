namespace QuanLyBoSua
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.dgvKhachHang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbSdt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbTenKH = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSdt = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbEmail = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbTenKH = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbMaKH = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLuu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnthem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKh,
            this.tenKh,
            this.email,
            this.sdt});
            this.dgvKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvKhachHang.DoubleBuffered = true;
            this.dgvKhachHang.EnableHeadersVisualStyles = false;
            this.dgvKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.HeaderBgColor = System.Drawing.Color.Cyan;
            this.dgvKhachHang.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 269);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(556, 190);
            this.dgvKhachHang.TabIndex = 20;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // maKh
            // 
            this.maKh.DataPropertyName = "makh";
            this.maKh.HeaderText = "Mã Khách hàng";
            this.maKh.MinimumWidth = 6;
            this.maKh.Name = "maKh";
            this.maKh.Width = 125;
            // 
            // tenKh
            // 
            this.tenKh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenKh.DataPropertyName = "tenkh";
            this.tenKh.HeaderText = "Tên khách hàng";
            this.tenKh.MinimumWidth = 6;
            this.tenKh.Name = "tenKh";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sodt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(210, 33);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(176, 35);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Khách Hàng";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdt.ForeColor = System.Drawing.Color.Black;
            this.lbSdt.Location = new System.Drawing.Point(61, 104);
            this.lbSdt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(112, 21);
            this.lbSdt.TabIndex = 0;
            this.lbSdt.Text = "Số điện thoại:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Black;
            this.lbEmail.Location = new System.Drawing.Point(112, 73);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(55, 21);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email:";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.ForeColor = System.Drawing.Color.Black;
            this.lbTenKH.Location = new System.Drawing.Point(40, 36);
            this.lbTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(132, 21);
            this.lbTenKH.TabIndex = 0;
            this.lbTenKH.Text = "Tên khách hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSdt);
            this.groupBox1.Controls.Add(this.lbTenKH);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.tbTenKH);
            this.groupBox1.Controls.Add(this.lbSdt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(467, 148);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // tbSdt
            // 
            this.tbSdt.BackColor = System.Drawing.Color.White;
            this.tbSdt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSdt.BackgroundImage")));
            this.tbSdt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbSdt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSdt.ForeColor = System.Drawing.Color.Black;
            this.tbSdt.Icon = ((System.Drawing.Image)(resources.GetObject("tbSdt.Icon")));
            this.tbSdt.Location = new System.Drawing.Point(178, 104);
            this.tbSdt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(272, 24);
            this.tbSdt.TabIndex = 5;
            this.tbSdt.text = "";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbEmail.BackgroundImage")));
            this.tbEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.Icon = ((System.Drawing.Image)(resources.GetObject("tbEmail.Icon")));
            this.tbEmail.Location = new System.Drawing.Point(178, 73);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(272, 24);
            this.tbEmail.TabIndex = 4;
            this.tbEmail.text = "";
            // 
            // tbTenKH
            // 
            this.tbTenKH.BackColor = System.Drawing.Color.White;
            this.tbTenKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTenKH.BackgroundImage")));
            this.tbTenKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTenKH.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenKH.ForeColor = System.Drawing.Color.Black;
            this.tbTenKH.Icon = ((System.Drawing.Image)(resources.GetObject("tbTenKH.Icon")));
            this.tbTenKH.Location = new System.Drawing.Point(178, 36);
            this.tbTenKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(272, 24);
            this.tbTenKH.TabIndex = 3;
            this.tbTenKH.text = "";
            // 
            // tbMaKH
            // 
            this.tbMaKH.BackColor = System.Drawing.Color.White;
            this.tbMaKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbMaKH.BackgroundImage")));
            this.tbMaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbMaKH.Enabled = false;
            this.tbMaKH.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaKH.ForeColor = System.Drawing.Color.Black;
            this.tbMaKH.Icon = ((System.Drawing.Image)(resources.GetObject("tbMaKH.Icon")));
            this.tbMaKH.Location = new System.Drawing.Point(511, 136);
            this.tbMaKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(47, 24);
            this.tbMaKH.TabIndex = 2;
            this.tbMaKH.text = "";
            this.tbMaKH.Visible = false;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BackColor = System.Drawing.Color.White;
            this.tbTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.BackgroundImage")));
            this.tbTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTimKiem.ForeColor = System.Drawing.Color.Black;
            this.tbTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.Icon")));
            this.tbTimKiem.Location = new System.Drawing.Point(143, 71);
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(433, 465);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(81, 38);
            this.bunifuFlatButton1.TabIndex = 60;
            this.bunifuFlatButton1.Text = "Hủy";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Activecolor = System.Drawing.Color.Teal;
            this.btnLuu.BackColor = System.Drawing.Color.Teal;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.ButtonText = "Lưu";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLuu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLuu.Iconimage = global::QuanLyBoSua.Properties.Resources.save;
            this.btnLuu.Iconimage_right = null;
            this.btnLuu.Iconimage_right_Selected = null;
            this.btnLuu.Iconimage_Selected = null;
            this.btnLuu.IconMarginLeft = 0;
            this.btnLuu.IconMarginRight = 0;
            this.btnLuu.IconRightVisible = true;
            this.btnLuu.IconRightZoom = 0D;
            this.btnLuu.IconVisible = true;
            this.btnLuu.IconZoom = 60D;
            this.btnLuu.IsTab = false;
            this.btnLuu.Location = new System.Drawing.Point(345, 465);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Normalcolor = System.Drawing.Color.Teal;
            this.btnLuu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnLuu.selected = false;
            this.btnLuu.Size = new System.Drawing.Size(82, 38);
            this.btnLuu.TabIndex = 59;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Textcolor = System.Drawing.Color.Black;
            this.btnLuu.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
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
            this.btnXoa.Location = new System.Drawing.Point(244, 465);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.Teal;
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(95, 38);
            this.btnXoa.TabIndex = 58;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Textcolor = System.Drawing.Color.Black;
            this.btnXoa.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Click += new System.EventHandler(this.btnxoa_Click_1);
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
            this.btnSua.Location = new System.Drawing.Point(155, 466);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.Teal;
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(83, 38);
            this.btnSua.TabIndex = 57;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Textcolor = System.Drawing.Color.Black;
            this.btnSua.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.Activecolor = System.Drawing.Color.Teal;
            this.btnthem.BackColor = System.Drawing.Color.Teal;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.BorderRadius = 5;
            this.btnthem.ButtonText = "Thêm";
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnthem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnthem.Iconimage = global::QuanLyBoSua.Properties.Resources.insert1;
            this.btnthem.Iconimage_right = null;
            this.btnthem.Iconimage_right_Selected = null;
            this.btnthem.Iconimage_Selected = null;
            this.btnthem.IconMarginLeft = 0;
            this.btnthem.IconMarginRight = 0;
            this.btnthem.IconRightVisible = true;
            this.btnthem.IconRightZoom = 0D;
            this.btnthem.IconVisible = true;
            this.btnthem.IconZoom = 60D;
            this.btnthem.IsTab = false;
            this.btnthem.Location = new System.Drawing.Point(57, 465);
            this.btnthem.Name = "btnthem";
            this.btnthem.Normalcolor = System.Drawing.Color.Teal;
            this.btnthem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnthem.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnthem.selected = false;
            this.btnthem.Size = new System.Drawing.Size(92, 38);
            this.btnthem.TabIndex = 56;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthem.Textcolor = System.Drawing.Color.Black;
            this.btnthem.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 27);
            this.panel1.TabIndex = 77;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Teal;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(555, 0);
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
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(577, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.tbMaKH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.tbTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHÁCH HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvKhachHang;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox tbSdt;
        private Bunifu.Framework.UI.BunifuTextbox tbEmail;
        private Bunifu.Framework.UI.BunifuTextbox tbTenKH;
        private Bunifu.Framework.UI.BunifuCustomLabel lbSdt;
        private Bunifu.Framework.UI.BunifuCustomLabel lbEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTenKH;
        private Bunifu.Framework.UI.BunifuTextbox tbTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private Bunifu.Framework.UI.BunifuTextbox tbMaKH;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnLuu;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnthem;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}