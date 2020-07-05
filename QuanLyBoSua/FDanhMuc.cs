using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBoSua
{
    public partial class FDanhMuc : Form
    {
        public FDanhMuc()
        {
            InitializeComponent();
            loadNv();
            loadNhanVien();
            LoadTkNv();
            loadTenCV();
            loadCongViec();
            loadNvPQ();
        }
        void loadTenCV()
        {
            List<string> listCv = new List<string>();
            listCv.Add("Quản lý chuồng trại");
            listCv.Add("Quản lý hóa đơn");
            listCv.Add("Quản lý sức khỏe");
            listCv.Add("Admin");
            cbTenCv.DataSource = listCv;
        }
        void loadCongViec()
        {
            try
            {
                string query = "Select * from PhanViec";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvPhanQuyen.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void loadNhanVien()
        {
            try
            {
                string query = "select * from NhanVien";
                DataTable Data = KetNoi.Istance.ExcuteQuerry(query);
                cbMaNv.DataSource = Data;
                cbMaNv.DisplayMember = "maNv";
                cbMaNv.ValueMember = "maNv";
                cbMaNv.Text = "";
              

            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void loadNvPQ()
        {
            string query = "select * from NhanVien where maNv not like N'admin'";
            DataTable Data = KetNoi.Istance.ExcuteQuerry(query);
           
            cbmaNvPQ.DataSource = Data;
            cbmaNvPQ.DisplayMember = "maNv";
            cbmaNvPQ.ValueMember = "maNv";
        }
       
        void loadNv()
        {
            try
            {
                string query = "select MaNv,TenNv,convert(nvarchar(30), NgaySinh, 20)as ngaySinh,gioiTinh,convert(nvarchar(30), ngayVaoLam, 20)as ngayVaoLam,eMail,anh from NhanVien ";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvNhanVien.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                txMaNv.Text = dtgvNhanVien.Rows[numrow].Cells[0].Value.ToString();
                txTenNv.Text = dtgvNhanVien.Rows[numrow].Cells[1].Value.ToString();
                DateTime dt = Convert.ToDateTime(dtgvNhanVien.Rows[numrow].Cells[2].Value.ToString());
                dtpkNgaySinh.Value = dt;
                string gt = dtgvNhanVien.Rows[numrow].Cells[3].Value.ToString();
                if (gt == "Nam")
                    rdbNam.Checked = true;
                if (gt == "Nữ")
                    rdbNu.Checked = true;
                DateTime dt1 = Convert.ToDateTime(dtgvNhanVien.Rows[numrow].Cells[4].Value.ToString());
                dtpkNgayVaoLam.Value = dt1;
                txEmail.Text = dtgvNhanVien.Rows[numrow].Cells[5].Value.ToString();
                string fileAnh = dtgvNhanVien.Rows[numrow].Cells[6].Value.ToString();
                fileimage = fileAnh;
                if (fileAnh != "")
                {
                    Bitmap bm = new Bitmap(fileAnh);

                    ptAnh.BackgroundImage = bm;
                    ptAnh.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                    ptAnh.BackgroundImage = null;
                linkLb.Visible = true;
            }
               
                
        }
        private string fileimage="";
        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDiaLog = new OpenFileDialog();

            if (DialogResult.OK == openDiaLog.ShowDialog())
            {

                openDiaLog.Filter = "insert image(*)|*";
                fileimage = openDiaLog.FileName;
                Bitmap bm = new Bitmap(fileimage);
                ptAnh.BackgroundImage = bm;
                ptAnh.BackgroundImageLayout = ImageLayout.Stretch;
            }

        }
        int dem = 0;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            

        }
        bool kiemtraMaNv(string maNv)
        {
            int bien = 0;
            string query = "Select * from nhanVien where maNv='" + maNv + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            foreach(DataRow row in data.Rows)
            {
                bien++;

            }
            if (bien > 0)
                return true;
            return false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "select MaNv,TenNv,convert(nvarchar(30), NgaySinh, 20)as ngaySinh,gioiTinh,convert(nvarchar(30), ngayVaoLam, 20)as ngayVaoLam,eMail,anh from NhanVien where tenNv like N'%" + txTimKiem.Text + "%'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvNhanVien.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        bool kiemtraTkTonTai(string maNv)
        {
            string query = "Select * from account where maNv='" + maNv + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }
        private void linkLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (kiemtraTkTonTai(txMaNv.Text) == true)
            {
                Alert a = new Alert("Mỗi nhân viên chỉ có một tài khoản.", AlertType.error);
                a.Show();
            }
            else
            {
                this.Hide();
                FDangKy fdk = new FDangKy(txMaNv.Text);
                fdk.ShowDialog();
                this.Show();
            }
        }

        private void dtgvPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                cbmaNvPQ.Text = dtgvPhanQuyen.Rows[numrow].Cells[0].Value.ToString();
                txNhap.Text= dtgvPhanQuyen.Rows[numrow].Cells[0].Value.ToString();
                cbTenCv.Text = dtgvPhanQuyen.Rows[numrow].Cells[1].Value.ToString();
            }
        }
        int tam = 0;
        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
           

        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            
        }

        private void txTimKiemPQ_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from PhanViec where maNv like N'%" + txTimKiemPQ.Text + "%'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvPhanQuyen.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void txTongCho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        ///TabTaiKhoan
        
        void LoadTkNv()
        {            
            try
            {
                string querry = "select TenNv, anh, tenDn from NhanVien nv , account acc where acc.maNv = nv.MaNv  ";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                dgvQLTK.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
            panel2.Enabled = false;
            groupBox1.Enabled = false;
            
        }

        private void dgvQLTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            tbTenNv.Text = dgvQLTK.Rows[numrow].Cells[0].Value.ToString();

            string img = dgvQLTK.Rows[numrow].Cells[1].Value.ToString();
            //MessageBox.Show(dgvQLTK.Rows[2].Cells[1].Value.ToString());
            if (img != "")
            {
                Bitmap bm = new Bitmap(img);
                picNv.BackgroundImage = bm;
                picNv.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                picNv.BackgroundImage = null;
            }

            tbTenTk.Text = dgvQLTK.Rows[numrow].Cells[2].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
           
        }
        static string key { get; set; } = "A!9HHhi%XjjYY4YP2@Nob009X";
        public static string Encrypt(string text)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }
        int demTK = 0;
        private void btnChange_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLuuMk_Click(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panelNV.Enabled = true;
            txMaNv.ResetText();
            txTenNv.ResetText();
            txEmail.ResetText();
            txTimKiem.ResetText();
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            fileimage = "";
            dem = 1;
            
            ptAnh.BackgroundImage = null;
            linkLb.Visible = false;
            btnAnh.Visible = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (txMaNv.Text == "")
            {
                Alert a = new Alert("Hãy Chọn Nhân Viên Cần Sửa.", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                dem = 2;
                panelNV.Enabled = true;
                txMaNv.ReadOnly = true;
                linkLb.Visible = false;
                btnAnh.Visible = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txMaNv.Text == "")
                {
                    Alert a = new Alert("Hãy Chọn Nhân Viên Cần Xoa.", AlertType.error);
                    a.ShowDialog();
                }
                else
                {
                    string query = "Delete NhanVien where maNv='" + txMaNv.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Sửa thành công.", AlertType.success);
                    a.ShowDialog();
                    loadNv();
                    txEmail.ResetText();
                    txMaNv.ResetText();
                    txTenNv.ResetText();
                    txTimKiem.ResetText();
                    ptAnh.BackgroundImage = null;
                    fileimage = "";
                    linkLb.Visible = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối", AlertType.error);
                a.ShowDialog();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dem == 1)
                {
                    if (txMaNv.Text == "" || txTenNv.Text == "" || txEmail.Text == "" || (rdbNam.Checked == false && rdbNu.Checked == false))
                    {
                        Alert a = new Alert("Hãy nhập đủ thông tin.", AlertType.error);
                        a.ShowDialog();
                    }
                    else if (kiemtraMaNv(txMaNv.Text))
                    {
                        Alert a = new Alert("Mã nv đã tồn tại.", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        string gt = "";
                        if (rdbNam.Checked == true)
                            gt = "Nam";
                        else
                            gt = "Nữ";
                        string query = "Insert into Nhanvien values('" + txMaNv.Text + "',N'" + txTenNv.Text + "',N'" + txEmail.Text + "',N'" + gt + "',N'" + dtpkNgaySinh.Value + "',N'" + dtpkNgayVaoLam.Value + "','" + fileimage + "')";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert a = new Alert("Thêm thành công.", AlertType.success);
                        a.ShowDialog();
                        loadNv();
                        panelNV.Enabled = false;
                        txEmail.ResetText();
                        txMaNv.ResetText();
                        txTenNv.ResetText();
                        txTimKiem.ResetText();
                        ptAnh.BackgroundImage = null;
                        fileimage = "";
                        btnAnh.Visible = false;
                        dem = 0;
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                }
                if (dem == 2)
                {
                    if (txTenNv.Text == "" || txEmail.Text == "" || (rdbNam.Checked == false && rdbNu.Checked == false))
                    {
                        Alert a = new Alert("Hãy nhập đủ thông tin.", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        string gt = "";
                        if (rdbNam.Checked == true)
                            gt = "Nam";
                        else
                            gt = "Nữ";
                        string query = "Update NhanVien Set tenNv=N'" + txTenNv.Text + "',eMail=N'" + txEmail.Text + "',gioiTinh=N'" + gt + "',ngaySinh=N'" + dtpkNgaySinh.Value + "',ngayVaoLam=N'" + dtpkNgayVaoLam.Value + "',anh='" + fileimage + "' where maNv='" + txMaNv.Text + "'";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert a = new Alert("Sửa thành công.", AlertType.success);
                        a.ShowDialog();
                        loadNv();
                        panelNV.Enabled = false;
                        txEmail.ResetText();
                        txMaNv.ResetText();
                        txTenNv.ResetText();
                        txTimKiem.ResetText();
                        ptAnh.BackgroundImage = null;
                        fileimage = "";
                        dem = 0;
                        txMaNv.ReadOnly = false;
                        btnAnh.Visible = false;
                        linkLb.Visible = false;
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối", AlertType.error);
                a.ShowDialog();
            }
            LoadTkNv();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            txEmail.ResetText();
            txMaNv.ResetText();
            txTenNv.ResetText();
            txTimKiem.ResetText();
            fileimage = "";
            loadNv();
            dtgvNhanVien.ClearSelection();
            dem = 0;
            panelNV.Enabled = false;
            txMaNv.ReadOnly = false;
            ptAnh.BackgroundImage = null;
            linkLb.Visible = false;
            btnAnh.Visible = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThemPQ_Click(object sender, EventArgs e)
        {
            panelPQ.Enabled = true;
            tam = 1;
            btnThemPQ.Enabled = false;
            btnXoaPQ.Enabled = false;
        }

        private void btnXoaPQ_Click(object sender, EventArgs e)
        {
            if (txNhap.Text == "")
            {
                Alert a = new Alert("Hãy chọn nhân viên cần xóa.", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                try
                {
                    string query = "Delete PhanViec where maNv='" + cbMaNv.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Xóa thành công.", AlertType.success);
                    a.ShowDialog();
                    loadCongViec();
                    panelPQ.Enabled = false;
                }
                catch
                {
                    Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                    a.ShowDialog();
                }
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (tam == 1)
                {
                    string query = "Insert into PhanViec values('" + cbmaNvPQ.Text + "',N'" + cbTenCv.Text + "')";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Thêm thành công.", AlertType.success);
                    a.ShowDialog();
                    loadCongViec();
                    panelPQ.Enabled = false;
                    dem = 0;
                    btnThemPQ.Enabled = true;
                    btnXoaPQ.Enabled = true;
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            panelPQ.Enabled = false;
            dtgvPhanQuyen.ClearSelection();
            txTimKiemPQ.ResetText();
            loadCongViec();
            tam = 0;
            btnThemPQ.Enabled = true;
            btnXoaPQ.Enabled = true;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (tbTenNv.Text == "")
            {
                Alert a = new Alert("Chọn tài khoản muốn xóa!", AlertType.info);
                a.ShowDialog();
            }
            else
            {
                try
                {
                    string querry = "delete account where tenDn = '" + tbTenTk.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    Alert a = new Alert("Xóa thành công!", AlertType.success);
                    a.ShowDialog();
                    LoadTkNv();
                }
                catch
                {
                    Alert a = new Alert("Xóa thất bại!", AlertType.success);
                    a.ShowDialog();
                }
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (tbTenNv.Text == "")
            {
                Alert d = new Alert("Hãy chọn tài khoản cần đổi", AlertType.error);
                d.ShowDialog();
            }
            else
            {
                groupBox1.Enabled = true;
                demTK = 1;
                btnDel.Enabled = false;

            }
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {

            string tendangnhap = tbTenTk.Text;
            try
            {
                if (demTK == 1)
                {
                    if (tbMkMoi.Text != tbMkMoiL2.Text)
                    {
                        Alert d = new Alert("Mật khẩu nhập lại không đúng", AlertType.error);
                        d.ShowDialog();
                    }
                    else
                    {
                        string query = "Update account set matKhau='" + Encrypt(tbMkMoi.Text) + "' where tenDn='" + tendangnhap + "'";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert c = new Alert("Đổi mẩu thành công", AlertType.success);
                        c.ShowDialog();
                        btnDel.Enabled = true;
                        tbMkMoi.Text = "";
                        tbMkMoiL2.Text = "";
                    }
                }
            }
            catch
            {
                Alert a = new Alert("Lỗi Kết Nối", AlertType.error);
                a.ShowDialog();
            }
        }

        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            btnDel.Enabled = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
           
            loadNv();
            loadNhanVien();
            LoadTkNv();
            loadTenCV();
            loadCongViec();
            loadNvPQ();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
