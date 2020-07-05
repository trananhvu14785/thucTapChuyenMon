namespace QuanLyBoSua
{
    partial class frmThucAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThucAn));
            this.lbThucAn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvThucAn = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mathucan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthucan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTenThucAn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbMaThucAn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMaThucAn = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbTenThucAn = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.quanLyBoSuaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucAn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBoSuaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThucAn
            // 
            this.lbThucAn.AutoSize = true;
            this.lbThucAn.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold);
            this.lbThucAn.Location = new System.Drawing.Point(203, 30);
            this.lbThucAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThucAn.Name = "lbThucAn";
            this.lbThucAn.Size = new System.Drawing.Size(127, 35);
            this.lbThucAn.TabIndex = 21;
            this.lbThucAn.Text = "Thức Ăn";
            // 
            // dgvThucAn
            // 
            this.dgvThucAn.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvThucAn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThucAn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThucAn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThucAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathucan,
            this.tenthucan});
            this.dgvThucAn.DoubleBuffered = true;
            this.dgvThucAn.EnableHeadersVisualStyles = false;
            this.dgvThucAn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvThucAn.HeaderBgColor = System.Drawing.Color.Cyan;
            this.dgvThucAn.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvThucAn.Location = new System.Drawing.Point(35, 237);
            this.dgvThucAn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThucAn.Name = "dgvThucAn";
            this.dgvThucAn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThucAn.RowHeadersWidth = 51;
            this.dgvThucAn.RowTemplate.Height = 24;
            this.dgvThucAn.Size = new System.Drawing.Size(422, 180);
            this.dgvThucAn.TabIndex = 28;
            this.dgvThucAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucAn_CellClick);
            // 
            // mathucan
            // 
            this.mathucan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mathucan.DataPropertyName = "mathucan";
            this.mathucan.HeaderText = "Mã thức ăn";
            this.mathucan.MinimumWidth = 6;
            this.mathucan.Name = "mathucan";
            // 
            // tenthucan
            // 
            this.tenthucan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenthucan.DataPropertyName = "tenthucan";
            this.tenthucan.HeaderText = "Tên thức ăn";
            this.tenthucan.MinimumWidth = 6;
            this.tenthucan.Name = "tenthucan";
            // 
            // lbTenThucAn
            // 
            this.lbTenThucAn.AutoSize = true;
            this.lbTenThucAn.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.lbTenThucAn.ForeColor = System.Drawing.Color.Black;
            this.lbTenThucAn.Location = new System.Drawing.Point(48, 68);
            this.lbTenThucAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenThucAn.Name = "lbTenThucAn";
            this.lbTenThucAn.Size = new System.Drawing.Size(103, 21);
            this.lbTenThucAn.TabIndex = 0;
            this.lbTenThucAn.Text = "Tên thức ăn:";
            // 
            // lbMaThucAn
            // 
            this.lbMaThucAn.AutoSize = true;
            this.lbMaThucAn.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.lbMaThucAn.ForeColor = System.Drawing.Color.Black;
            this.lbMaThucAn.Location = new System.Drawing.Point(50, 36);
            this.lbMaThucAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaThucAn.Name = "lbMaThucAn";
            this.lbMaThucAn.Size = new System.Drawing.Size(98, 21);
            this.lbMaThucAn.TabIndex = 0;
            this.lbMaThucAn.Text = "Mã thức ăn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaThucAn);
            this.groupBox1.Controls.Add(this.tbTenThucAn);
            this.groupBox1.Controls.Add(this.lbMaThucAn);
            this.groupBox1.Controls.Add(this.lbTenThucAn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(471, 104);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thức ăn";
            // 
            // tbMaThucAn
            // 
            this.tbMaThucAn.BackColor = System.Drawing.Color.White;
            this.tbMaThucAn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbMaThucAn.BackgroundImage")));
            this.tbMaThucAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbMaThucAn.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaThucAn.ForeColor = System.Drawing.Color.Black;
            this.tbMaThucAn.Icon = ((System.Drawing.Image)(resources.GetObject("tbMaThucAn.Icon")));
            this.tbMaThucAn.Location = new System.Drawing.Point(153, 33);
            this.tbMaThucAn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbMaThucAn.Name = "tbMaThucAn";
            this.tbMaThucAn.Size = new System.Drawing.Size(272, 24);
            this.tbMaThucAn.TabIndex = 2;
            this.tbMaThucAn.text = "";
            // 
            // tbTenThucAn
            // 
            this.tbTenThucAn.BackColor = System.Drawing.Color.White;
            this.tbTenThucAn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTenThucAn.BackgroundImage")));
            this.tbTenThucAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTenThucAn.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenThucAn.ForeColor = System.Drawing.Color.Black;
            this.tbTenThucAn.Icon = ((System.Drawing.Image)(resources.GetObject("tbTenThucAn.Icon")));
            this.tbTenThucAn.Location = new System.Drawing.Point(153, 65);
            this.tbTenThucAn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTenThucAn.Name = "tbTenThucAn";
            this.tbTenThucAn.Size = new System.Drawing.Size(272, 24);
            this.tbTenThucAn.TabIndex = 3;
            this.tbTenThucAn.text = "";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BackColor = System.Drawing.Color.White;
            this.tbTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.BackgroundImage")));
            this.tbTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTimKiem.ForeColor = System.Drawing.Color.Black;
            this.tbTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("tbTimKiem.Icon")));
            this.tbTimKiem.Location = new System.Drawing.Point(127, 76);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(264, 37);
            this.tbTimKiem.TabIndex = 22;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(398, 462);
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(310, 462);
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
            this.btnXoa.Location = new System.Drawing.Point(209, 462);
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
            this.btnSua.Location = new System.Drawing.Point(120, 463);
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
            this.btnSua.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
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
            this.btnThem.Location = new System.Drawing.Point(22, 462);
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
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Teal;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(469, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Padding = new System.Windows.Forms.Padding(5);
            this.bunifuImageButton2.Size = new System.Drawing.Size(22, 27);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 9;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 27);
            this.panel1.TabIndex = 77;
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
            // frmThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(491, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbThucAn);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.dgvThucAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThucAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thức Ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucAn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBoSuaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTextbox tbTenThucAn;
        private Bunifu.Framework.UI.BunifuTextbox tbMaThucAn;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTenThucAn;
        private Bunifu.Framework.UI.BunifuCustomLabel lbMaThucAn;
        private Bunifu.Framework.UI.BunifuCustomLabel lbThucAn;
        private Bunifu.Framework.UI.BunifuTextbox tbTimKiem;
        private System.Windows.Forms.BindingSource quanLyBoSuaDataSetBindingSource;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvThucAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathucan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthucan;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}