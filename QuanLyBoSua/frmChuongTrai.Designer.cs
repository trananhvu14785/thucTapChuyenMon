namespace QuanLyBoSua
{
    partial class frmChuongTrai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuongTrai));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMaNv = new Bunifu.Framework.UI.BunifuTextbox();
            this.lbTenKH = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbTongCho = new Bunifu.Framework.UI.BunifuTextbox();
            this.lbEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbTenChuong = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvChuongTrai = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.machuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongsocho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sochocontrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.txmachuong = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongTrai)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaNv);
            this.groupBox1.Controls.Add(this.lbTenKH);
            this.groupBox1.Controls.Add(this.tbTongCho);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.tbTenChuong);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 170);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(499, 153);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chuồng trại";
            // 
            // tbMaNv
            // 
            this.tbMaNv.BackColor = System.Drawing.Color.White;
            this.tbMaNv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbMaNv.BackgroundImage")));
            this.tbMaNv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbMaNv.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNv.ForeColor = System.Drawing.Color.Black;
            this.tbMaNv.Icon = ((System.Drawing.Image)(resources.GetObject("tbMaNv.Icon")));
            this.tbMaNv.Location = new System.Drawing.Point(178, 112);
            this.tbMaNv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbMaNv.Name = "tbMaNv";
            this.tbMaNv.Size = new System.Drawing.Size(272, 24);
            this.tbMaNv.TabIndex = 5;
            this.tbMaNv.text = "";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.ForeColor = System.Drawing.Color.Black;
            this.lbTenKH.Location = new System.Drawing.Point(58, 34);
            this.lbTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(103, 21);
            this.lbTenKH.TabIndex = 0;
            this.lbTenKH.Text = "Tên chuồng:";
            // 
            // tbTongCho
            // 
            this.tbTongCho.BackColor = System.Drawing.Color.White;
            this.tbTongCho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTongCho.BackgroundImage")));
            this.tbTongCho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTongCho.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongCho.ForeColor = System.Drawing.Color.Black;
            this.tbTongCho.Icon = ((System.Drawing.Image)(resources.GetObject("tbTongCho.Icon")));
            this.tbTongCho.Location = new System.Drawing.Point(178, 71);
            this.tbTongCho.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTongCho.Name = "tbTongCho";
            this.tbTongCho.Size = new System.Drawing.Size(272, 24);
            this.tbTongCho.TabIndex = 4;
            this.tbTongCho.text = "";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Black;
            this.lbEmail.Location = new System.Drawing.Point(55, 71);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(110, 21);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Tổng số chỗ:";
            // 
            // tbTenChuong
            // 
            this.tbTenChuong.BackColor = System.Drawing.Color.White;
            this.tbTenChuong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTenChuong.BackgroundImage")));
            this.tbTenChuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTenChuong.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenChuong.ForeColor = System.Drawing.Color.Black;
            this.tbTenChuong.Icon = ((System.Drawing.Image)(resources.GetObject("tbTenChuong.Icon")));
            this.tbTenChuong.Location = new System.Drawing.Point(178, 34);
            this.tbTenChuong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTenChuong.Name = "tbTenChuong";
            this.tbTenChuong.Size = new System.Drawing.Size(272, 24);
            this.tbTenChuong.TabIndex = 3;
            this.tbTenChuong.text = "";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(44, 112);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(113, 21);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Mã nhân viên:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(216, 44);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(174, 35);
            this.bunifuCustomLabel1.TabIndex = 22;
            this.bunifuCustomLabel1.Text = "Chuồng Trại";
            // 
            // dgvChuongTrai
            // 
            this.dgvChuongTrai.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvChuongTrai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvChuongTrai.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvChuongTrai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChuongTrai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChuongTrai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChuongTrai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuongTrai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machuong,
            this.tenchuong,
            this.tongsocho,
            this.sochocontrong});
            this.dgvChuongTrai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvChuongTrai.DoubleBuffered = true;
            this.dgvChuongTrai.EnableHeadersVisualStyles = false;
            this.dgvChuongTrai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvChuongTrai.HeaderBgColor = System.Drawing.Color.Cyan;
            this.dgvChuongTrai.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvChuongTrai.Location = new System.Drawing.Point(21, 341);
            this.dgvChuongTrai.Name = "dgvChuongTrai";
            this.dgvChuongTrai.ReadOnly = true;
            this.dgvChuongTrai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvChuongTrai.RowHeadersWidth = 51;
            this.dgvChuongTrai.RowTemplate.Height = 24;
            this.dgvChuongTrai.Size = new System.Drawing.Size(553, 219);
            this.dgvChuongTrai.TabIndex = 28;
            this.dgvChuongTrai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuongTrai_CellClick);
            // 
            // machuong
            // 
            this.machuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.machuong.DataPropertyName = "machuong";
            this.machuong.HeaderText = "Mã chuồng";
            this.machuong.MinimumWidth = 6;
            this.machuong.Name = "machuong";
            this.machuong.ReadOnly = true;
            // 
            // tenchuong
            // 
            this.tenchuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenchuong.DataPropertyName = "tenchuong";
            this.tenchuong.HeaderText = "Tên chuồng";
            this.tenchuong.MinimumWidth = 6;
            this.tenchuong.Name = "tenchuong";
            this.tenchuong.ReadOnly = true;
            // 
            // tongsocho
            // 
            this.tongsocho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongsocho.DataPropertyName = "tongsocho";
            this.tongsocho.HeaderText = "Tổng số chỗ";
            this.tongsocho.MinimumWidth = 6;
            this.tongsocho.Name = "tongsocho";
            this.tongsocho.ReadOnly = true;
            // 
            // sochocontrong
            // 
            this.sochocontrong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sochocontrong.DataPropertyName = "sochocontrong";
            this.sochocontrong.HeaderText = "Chỗ còn trống";
            this.sochocontrong.MinimumWidth = 6;
            this.sochocontrong.Name = "sochocontrong";
            this.sochocontrong.ReadOnly = true;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BackColor = System.Drawing.Color.MintCream;
            this.tbTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.BackgroundImage")));
            this.tbTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTimKiem.ForeColor = System.Drawing.Color.Black;
            this.tbTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.Icon")));
            this.tbTimKiem.Location = new System.Drawing.Point(156, 119);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(309, 28);
            this.tbTimKiem.TabIndex = 23;
            this.tbTimKiem.text = "";
            this.tbTimKiem.OnTextChange += new System.EventHandler(this.tbTimKiem_OnTextChange);
            // 
            // txmachuong
            // 
            this.txmachuong.Location = new System.Drawing.Point(1, 221);
            this.txmachuong.Name = "txmachuong";
            this.txmachuong.Size = new System.Drawing.Size(38, 20);
            this.txmachuong.TabIndex = 32;
            this.txmachuong.Visible = false;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(434, 578);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(81, 38);
            this.bunifuFlatButton1.TabIndex = 65;
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(346, 578);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(82, 38);
            this.bunifuFlatButton2.TabIndex = 64;
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
            this.btnXoa.Location = new System.Drawing.Point(245, 578);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.Teal;
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(95, 38);
            this.btnXoa.TabIndex = 63;
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
            this.btnSua.Location = new System.Drawing.Point(156, 579);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.Teal;
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(83, 38);
            this.btnSua.TabIndex = 62;
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
            this.btnThem.Location = new System.Drawing.Point(58, 578);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.Teal;
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(92, 38);
            this.btnThem.TabIndex = 61;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.Black;
            this.btnThem.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = null;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 27);
            this.panel1.TabIndex = 66;
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
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Teal;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(575, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(22, 27);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 8;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // frmChuongTrai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(597, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txmachuong);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dgvChuongTrai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChuongTrai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuồng Trại";
            this.Load += new System.EventHandler(this.frmChuongTrai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongTrai)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTextbox tbTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTenKH;
        private Bunifu.Framework.UI.BunifuTextbox tbTongCho;
        private Bunifu.Framework.UI.BunifuCustomLabel lbEmail;
        private Bunifu.Framework.UI.BunifuTextbox tbTenChuong;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvChuongTrai;
        private Bunifu.Framework.UI.BunifuTextbox tbMaNv;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn machuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongsocho;
        private System.Windows.Forms.DataGridViewTextBoxColumn sochocontrong;
        private System.Windows.Forms.TextBox txmachuong;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}