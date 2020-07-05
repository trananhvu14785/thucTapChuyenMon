namespace QuanLyBoSua
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            this.dgvNhaCungCap = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maNcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSdt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbDiaChi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbTenNcc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSdt = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbDiaChi = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbTenNcc = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbMaNcc = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.quanLyBoSuaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBoSuaDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhaCungCap
            // 
            this.dgvNhaCungCap.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNhaCungCap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhaCungCap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNhaCungCap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNcc,
            this.tenNcc,
            this.diaChi,
            this.sdt});
            this.dgvNhaCungCap.DoubleBuffered = true;
            this.dgvNhaCungCap.EnableHeadersVisualStyles = false;
            this.dgvNhaCungCap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvNhaCungCap.HeaderBgColor = System.Drawing.Color.Cyan;
            this.dgvNhaCungCap.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvNhaCungCap.Location = new System.Drawing.Point(11, 314);
            this.dgvNhaCungCap.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhaCungCap.Name = "dgvNhaCungCap";
            this.dgvNhaCungCap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhaCungCap.RowHeadersWidth = 51;
            this.dgvNhaCungCap.RowTemplate.Height = 24;
            this.dgvNhaCungCap.Size = new System.Drawing.Size(572, 225);
            this.dgvNhaCungCap.TabIndex = 12;
            this.dgvNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCungCap_CellClick);
            // 
            // maNcc
            // 
            this.maNcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNcc.DataPropertyName = "maNcc";
            this.maNcc.HeaderText = "Mã NCC";
            this.maNcc.MinimumWidth = 6;
            this.maNcc.Name = "maNcc";
            this.maNcc.ReadOnly = true;
            // 
            // tenNcc
            // 
            this.tenNcc.DataPropertyName = "tenNcc";
            this.tenNcc.HeaderText = "Tên nhà cung cấp";
            this.tenNcc.MinimumWidth = 6;
            this.tenNcc.Name = "tenNcc";
            this.tenNcc.ReadOnly = true;
            this.tenNcc.Width = 150;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diachi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            this.diaChi.Width = 150;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sodt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 125;
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.BackColor = System.Drawing.Color.Transparent;
            this.lbSdt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdt.ForeColor = System.Drawing.Color.Black;
            this.lbSdt.Location = new System.Drawing.Point(42, 105);
            this.lbSdt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(112, 21);
            this.lbSdt.TabIndex = 0;
            this.lbSdt.Text = "Số điện thoại:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lbDiaChi.Location = new System.Drawing.Point(84, 73);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(67, 21);
            this.lbDiaChi.TabIndex = 0;
            this.lbDiaChi.Text = "Địa chi:";
            // 
            // lbTenNcc
            // 
            this.lbTenNcc.AutoSize = true;
            this.lbTenNcc.BackColor = System.Drawing.Color.Transparent;
            this.lbTenNcc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNcc.ForeColor = System.Drawing.Color.Black;
            this.lbTenNcc.Location = new System.Drawing.Point(8, 37);
            this.lbTenNcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenNcc.Name = "lbTenNcc";
            this.lbTenNcc.Size = new System.Drawing.Size(147, 21);
            this.lbTenNcc.TabIndex = 0;
            this.lbTenNcc.Text = "Tên nhà cung cấp:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(222, 30);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(206, 35);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Nhà Cung Cấp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSdt);
            this.groupBox1.Controls.Add(this.lbTenNcc);
            this.groupBox1.Controls.Add(this.tbDiaChi);
            this.groupBox1.Controls.Add(this.lbDiaChi);
            this.groupBox1.Controls.Add(this.lbSdt);
            this.groupBox1.Controls.Add(this.tbTenNcc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(68, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(462, 154);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbSdt
            // 
            this.tbSdt.BackColor = System.Drawing.Color.White;
            this.tbSdt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSdt.BackgroundImage")));
            this.tbSdt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbSdt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSdt.ForeColor = System.Drawing.Color.Black;
            this.tbSdt.Icon = ((System.Drawing.Image)(resources.GetObject("tbSdt.Icon")));
            this.tbSdt.Location = new System.Drawing.Point(168, 105);
            this.tbSdt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(272, 24);
            this.tbSdt.TabIndex = 5;
            this.tbSdt.text = "";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.BackColor = System.Drawing.Color.White;
            this.tbDiaChi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbDiaChi.BackgroundImage")));
            this.tbDiaChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbDiaChi.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.ForeColor = System.Drawing.Color.Black;
            this.tbDiaChi.Icon = ((System.Drawing.Image)(resources.GetObject("tbDiaChi.Icon")));
            this.tbDiaChi.Location = new System.Drawing.Point(168, 73);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(272, 24);
            this.tbDiaChi.TabIndex = 4;
            this.tbDiaChi.text = "";
            // 
            // tbTenNcc
            // 
            this.tbTenNcc.BackColor = System.Drawing.Color.White;
            this.tbTenNcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTenNcc.BackgroundImage")));
            this.tbTenNcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTenNcc.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNcc.ForeColor = System.Drawing.Color.Black;
            this.tbTenNcc.Icon = ((System.Drawing.Image)(resources.GetObject("tbTenNcc.Icon")));
            this.tbTenNcc.Location = new System.Drawing.Point(168, 37);
            this.tbTenNcc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTenNcc.Name = "tbTenNcc";
            this.tbTenNcc.Size = new System.Drawing.Size(272, 24);
            this.tbTenNcc.TabIndex = 3;
            this.tbTenNcc.text = "";
            // 
            // tbMaNcc
            // 
            this.tbMaNcc.BackColor = System.Drawing.Color.White;
            this.tbMaNcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbMaNcc.BackgroundImage")));
            this.tbMaNcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbMaNcc.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNcc.ForeColor = System.Drawing.Color.Black;
            this.tbMaNcc.Icon = ((System.Drawing.Image)(resources.GetObject("tbMaNcc.Icon")));
            this.tbMaNcc.Location = new System.Drawing.Point(534, 162);
            this.tbMaNcc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbMaNcc.Name = "tbMaNcc";
            this.tbMaNcc.Size = new System.Drawing.Size(44, 24);
            this.tbMaNcc.TabIndex = 2;
            this.tbMaNcc.text = "";
            this.tbMaNcc.Visible = false;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BackColor = System.Drawing.Color.White;
            this.tbTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.BackgroundImage")));
            this.tbTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTimKiem.ForeColor = System.Drawing.Color.Black;
            this.tbTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.Icon")));
            this.tbTimKiem.Location = new System.Drawing.Point(170, 85);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(309, 28);
            this.tbTimKiem.TabIndex = 6;
            this.tbTimKiem.text = "";
            this.tbTimKiem.OnTextChange += new System.EventHandler(this.tbTimKiem_OnTextChange);
            // 
            // quanLyBoSuaDataSetBindingSource
            // 
            this.quanLyBoSuaDataSetBindingSource.CurrentChanged += new System.EventHandler(this.quanLyBoSuaDataSetBindingSource_CurrentChanged);
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(436, 556);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(81, 38);
            this.bunifuFlatButton1.TabIndex = 70;
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(348, 556);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(82, 38);
            this.bunifuFlatButton2.TabIndex = 69;
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
            this.btnXoa.Location = new System.Drawing.Point(247, 556);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.Teal;
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(95, 38);
            this.btnXoa.TabIndex = 68;
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
            this.btnSua.Location = new System.Drawing.Point(158, 557);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.Teal;
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(83, 38);
            this.btnSua.TabIndex = 67;
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
            this.btnThem.Location = new System.Drawing.Point(60, 556);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.Teal;
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(92, 38);
            this.btnThem.TabIndex = 66;
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
            this.panel1.Size = new System.Drawing.Size(589, 27);
            this.panel1.TabIndex = 71;
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
            this.bunifuImageButton2.Location = new System.Drawing.Point(567, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(22, 27);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 9;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panel1;
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(589, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbMaNcc);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNhaCungCap);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHÀ CUNG CẤP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBoSuaDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource quanLyBoSuaDataSetBindingSource;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvNhaCungCap;
        private Bunifu.Framework.UI.BunifuTextbox tbTimKiem;
        private Bunifu.Framework.UI.BunifuTextbox tbSdt;
        private Bunifu.Framework.UI.BunifuTextbox tbDiaChi;
        private Bunifu.Framework.UI.BunifuTextbox tbTenNcc;
        private Bunifu.Framework.UI.BunifuTextbox tbMaNcc;
        private Bunifu.Framework.UI.BunifuCustomLabel lbSdt;
        private Bunifu.Framework.UI.BunifuCustomLabel lbDiaChi;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTenNcc;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}