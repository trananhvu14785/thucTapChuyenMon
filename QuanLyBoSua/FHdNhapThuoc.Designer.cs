namespace QuanLyBoSua
{
    partial class FHdNhapThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHdNhapThuoc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picQr = new System.Windows.Forms.PictureBox();
            this.dtgvHD = new Guna.UI.WinForms.GunaDataGridView();
            this.maHd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkQr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chitiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnL = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label13 = new System.Windows.Forms.Label();
            this.lbMaHd = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.txTimKiem = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelInforHD = new System.Windows.Forms.Panel();
            this.cbNcc = new System.Windows.Forms.ComboBox();
            this.txTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMaNv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHD)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panelInforHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 25);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Teal;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(797, -1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(19, 23);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.picQr);
            this.groupBox1.Controls.Add(this.dtgvHD);
            this.groupBox1.Controls.Add(this.bunifuFlatButton1);
            this.groupBox1.Controls.Add(this.btnL);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbMaHd);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.panelInforHD);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 461);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(675, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "QR Code";
            // 
            // picQr
            // 
            this.picQr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQr.Location = new System.Drawing.Point(618, 10);
            this.picQr.Name = "picQr";
            this.picQr.Size = new System.Drawing.Size(171, 162);
            this.picQr.TabIndex = 61;
            this.picQr.TabStop = false;
            // 
            // dtgvHD
            // 
            this.dtgvHD.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHD.BackgroundColor = System.Drawing.Color.White;
            this.dtgvHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvHD.ColumnHeadersHeight = 25;
            this.dtgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHd,
            this.nv,
            this.ngayLap,
            this.nhacungcap,
            this.tongtien,
            this.trangThai,
            this.linkQr,
            this.chitiet});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvHD.EnableHeadersVisualStyles = false;
            this.dtgvHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvHD.Location = new System.Drawing.Point(9, 197);
            this.dtgvHD.Name = "dtgvHD";
            this.dtgvHD.RowHeadersVisible = false;
            this.dtgvHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHD.Size = new System.Drawing.Size(780, 258);
            this.dtgvHD.TabIndex = 48;
            this.dtgvHD.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtgvHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvHD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvHD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvHD.ThemeStyle.HeaderStyle.Height = 25;
            this.dtgvHD.ThemeStyle.ReadOnly = false;
            this.dtgvHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Teal;
            this.dtgvHD.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellClick);
            this.dtgvHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHD_CellContentClick);
            // 
            // maHd
            // 
            this.maHd.DataPropertyName = "maHd";
            this.maHd.HeaderText = "Mã HĐ";
            this.maHd.Name = "maHd";
            // 
            // nv
            // 
            this.nv.DataPropertyName = "maNv";
            this.nv.HeaderText = "Mã NV";
            this.nv.Name = "nv";
            // 
            // ngayLap
            // 
            this.ngayLap.DataPropertyName = "ngayLap";
            this.ngayLap.HeaderText = "Ngày Lập";
            this.ngayLap.Name = "ngayLap";
            // 
            // nhacungcap
            // 
            this.nhacungcap.DataPropertyName = "tenNcc";
            this.nhacungcap.HeaderText = "Nhà Cung Cấp";
            this.nhacungcap.Name = "nhacungcap";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng Tiền";
            this.tongtien.Name = "tongtien";
            // 
            // trangThai
            // 
            this.trangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.Name = "trangThai";
            // 
            // linkQr
            // 
            this.linkQr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.linkQr.DataPropertyName = "linkQr";
            this.linkQr.HeaderText = "Link QR";
            this.linkQr.Name = "linkQr";
            // 
            // chitiet
            // 
            this.chitiet.HeaderText = "Chi Tiết";
            this.chitiet.Name = "chitiet";
            this.chitiet.Text = "Chi Tiết";
            this.chitiet.UseColumnTextForButtonValue = true;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(514, 148);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(80, 38);
            this.bunifuFlatButton1.TabIndex = 47;
            this.bunifuFlatButton1.Text = "Hủy";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnL
            // 
            this.btnL.Activecolor = System.Drawing.Color.Teal;
            this.btnL.BackColor = System.Drawing.Color.Teal;
            this.btnL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnL.BorderRadius = 5;
            this.btnL.ButtonText = "Lưu";
            this.btnL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnL.Iconcolor = System.Drawing.Color.Transparent;
            this.btnL.Iconimage = global::QuanLyBoSua.Properties.Resources.save;
            this.btnL.Iconimage_right = null;
            this.btnL.Iconimage_right_Selected = null;
            this.btnL.Iconimage_Selected = null;
            this.btnL.IconMarginLeft = 0;
            this.btnL.IconMarginRight = 0;
            this.btnL.IconRightVisible = true;
            this.btnL.IconRightZoom = 0D;
            this.btnL.IconVisible = true;
            this.btnL.IconZoom = 60D;
            this.btnL.IsTab = false;
            this.btnL.Location = new System.Drawing.Point(407, 148);
            this.btnL.Name = "btnL";
            this.btnL.Normalcolor = System.Drawing.Color.Teal;
            this.btnL.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnL.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnL.selected = false;
            this.btnL.Size = new System.Drawing.Size(82, 38);
            this.btnL.TabIndex = 46;
            this.btnL.Text = "Lưu";
            this.btnL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnL.Textcolor = System.Drawing.Color.Black;
            this.btnL.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(288, 148);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.Teal;
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(94, 38);
            this.btnXoa.TabIndex = 45;
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
            this.btnSua.Location = new System.Drawing.Point(181, 148);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.Teal;
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(83, 38);
            this.btnSua.TabIndex = 44;
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
            this.btnThem.Location = new System.Drawing.Point(71, 148);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.Teal;
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(92, 38);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.Black;
            this.btnThem.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(45, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Mã hóa đơn:";
            this.label13.Visible = false;
            // 
            // lbMaHd
            // 
            this.lbMaHd.AutoSize = true;
            this.lbMaHd.ForeColor = System.Drawing.Color.Black;
            this.lbMaHd.Location = new System.Drawing.Point(126, 49);
            this.lbMaHd.Name = "lbMaHd";
            this.lbMaHd.Size = new System.Drawing.Size(14, 13);
            this.lbMaHd.TabIndex = 34;
            this.lbMaHd.Text = "0";
            this.lbMaHd.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gunaImageButton1);
            this.groupBox3.Controls.Add(this.txTimKiem);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Teal;
            this.groupBox3.Location = new System.Drawing.Point(191, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 49);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackgroundImage = global::QuanLyBoSua.Properties.Resources.qr;
            this.gunaImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageButton1.Image = null;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(300, 14);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(31, 29);
            this.gunaImageButton1.TabIndex = 3;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // txTimKiem
            // 
            this.txTimKiem.Location = new System.Drawing.Point(97, 16);
            this.txTimKiem.Name = "txTimKiem";
            this.txTimKiem.Size = new System.Drawing.Size(197, 21);
            this.txTimKiem.TabIndex = 1;
            this.txTimKiem.TextChanged += new System.EventHandler(this.txTimKiem_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(19, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã hóa đơn";
            // 
            // panelInforHD
            // 
            this.panelInforHD.Controls.Add(this.cbNcc);
            this.panelInforHD.Controls.Add(this.txTongTien);
            this.panelInforHD.Controls.Add(this.label4);
            this.panelInforHD.Controls.Add(this.dtpkNgayLap);
            this.panelInforHD.Controls.Add(this.label3);
            this.panelInforHD.Controls.Add(this.label2);
            this.panelInforHD.Controls.Add(this.cbMaNv);
            this.panelInforHD.Controls.Add(this.label1);
            this.panelInforHD.Enabled = false;
            this.panelInforHD.Location = new System.Drawing.Point(30, 68);
            this.panelInforHD.Name = "panelInforHD";
            this.panelInforHD.Size = new System.Drawing.Size(578, 77);
            this.panelInforHD.TabIndex = 32;
            // 
            // cbNcc
            // 
            this.cbNcc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNcc.FormattingEnabled = true;
            this.cbNcc.Location = new System.Drawing.Point(139, 15);
            this.cbNcc.Name = "cbNcc";
            this.cbNcc.Size = new System.Drawing.Size(167, 21);
            this.cbNcc.TabIndex = 33;
            // 
            // txTongTien
            // 
            this.txTongTien.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTongTien.ForeColor = System.Drawing.Color.Maroon;
            this.txTongTien.Location = new System.Drawing.Point(400, 48);
            this.txTongTien.Name = "txTongTien";
            this.txTongTien.ReadOnly = true;
            this.txTongTien.Size = new System.Drawing.Size(164, 21);
            this.txTongTien.TabIndex = 32;
            this.txTongTien.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(312, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tổng tiền";
            // 
            // dtpkNgayLap
            // 
            this.dtpkNgayLap.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpkNgayLap.Enabled = false;
            this.dtpkNgayLap.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayLap.Location = new System.Drawing.Point(139, 48);
            this.dtpkNgayLap.Name = "dtpkNgayLap";
            this.dtpkNgayLap.Size = new System.Drawing.Size(167, 21);
            this.dtpkNgayLap.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ngày Lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(312, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã nhân viên";
            // 
            // cbMaNv
            // 
            this.cbMaNv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNv.FormattingEnabled = true;
            this.cbMaNv.Location = new System.Drawing.Point(400, 14);
            this.cbMaNv.Name = "cbMaNv";
            this.cbMaNv.Size = new System.Drawing.Size(164, 21);
            this.cbMaNv.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nhà cung cấp";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FHdNhapThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FHdNhapThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHdNhapThuoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FHdNhapThuoc_FormClosing);
            this.Load += new System.EventHandler(this.FHdNhapThuoc_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHD)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelInforHD.ResumeLayout(false);
            this.panelInforHD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbMaHd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txTimKiem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelInforHD;
        private System.Windows.Forms.ComboBox cbNcc;
        private System.Windows.Forms.TextBox txTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkNgayLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaNv;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnL;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private Guna.UI.WinForms.GunaDataGridView dtgvHD;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picQr;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkQr;
        private System.Windows.Forms.DataGridViewButtonColumn chitiet;
        private System.Windows.Forms.Timer timer1;
    }
}