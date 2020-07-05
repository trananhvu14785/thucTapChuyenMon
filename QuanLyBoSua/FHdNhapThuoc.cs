using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace QuanLyBoSua
{
    public partial class FHdNhapThuoc : Form
    {
        private string maNv;
        public FHdNhapThuoc(string maNv = null)
        {
            this.maNv = maNv;
            InitializeComponent();
            Bunifu.Framework.UI.BunifuDragControl a = new Bunifu.Framework.UI.BunifuDragControl();
            a.TargetControl = this.panel1;
            a.Vertical = true;
            loadNhaCungCap();
            loadNhanVien();
            LoadHoaDon();
        }
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice CaptureDevice;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadNhaCungCap()
        {
            try
            {
                string query = "select * from nhaCungCap";
                DataTable Data = KetNoi.Istance.ExcuteQuerry(query);
                cbNcc.DataSource = Data;
                cbNcc.DisplayMember = "tenNCC";
                cbNcc.ValueMember = "maNCC";
                cbNcc.Text = "";
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
                if (MaNv != "")
                {
                    cbMaNv.Text = MaNv;
                    cbMaNv.Enabled = false;
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void LoadHoaDon()
        {
            try
            {
                string query = "select H.maHD,H.maNv,convert(nvarchar(30), H.ngayLap, 20)as ngayLap,N.tenNCC,PARSENAME(CONVERT(varchar, CAST(H.tongTien AS money), 1), 2) as tongTien,trangThai,linkQr from HoaDonNhapThuoc H,NhaCungCap N where H.maNCC=N.maNCC";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvHD.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        void update()
        {
            panelInforHD.Enabled = false;
            dtpkNgayLap.Enabled = false;


            dem = 0;
            //bien = 0;
            txTongTien.ResetText();
            dtgvHD.ClearSelection();
           



           
            txTongTien.Text = "0";

           
        }
        int dem = 0;
       
       

       
       //private int bien = 0;

        public string MaNv { get => maNv; set => maNv = value; }

        private void txTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "select H.maHD,H.maNv,convert(nvarchar(30), H.ngayLap, 20)as ngayLap,N.tenNCC,PARSENAME(CONVERT(varchar, CAST(H.tongTien AS money), 1), 2) as tongTien,trangThai,linkQr from HoaDonNhapThuoc H,NhaCungCap N where H.maNCC=N.maNCC and maHd like N'%" + txTimKiem.Text + "%'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvHD.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void txGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            dem = 1;
            panelInforHD.Enabled = true;
            txTongTien.Text = "0";
            lbMaHd.Text = "0";
            lbMaHd.Visible = false;
            label13.Visible = false;
           
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dtgvHD.Enabled = false;
            if (MaNv != "")
            {
                cbMaNv.Text = MaNv;
                cbMaNv.Enabled = false;
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (lbMaHd.Text == "0")
            {
                Alert a = new Alert("Vui Lòng chọn hóa đơn cần sửa.", AlertType.error);

                a.ShowDialog();
                dem = 0;
                panelInforHD.Enabled = false;
            }
            else
            {
                dem = 2;
                panelInforHD.Enabled = true;
                dtpkNgayLap.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                dtgvHD.Enabled = false;

            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (lbMaHd.Text == "0")
                {
                    Alert a = new Alert("Vui Lòng chọn hóa đơn cần Xóa.", AlertType.error);

                    a.ShowDialog();

                }
                else
                {
                    string query = "Delete HoaDonNhapThuoc where maHd='" + lbMaHd.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Xóa thành công.", AlertType.success);

                    a.ShowDialog();
                    LoadHoaDon();

                    panelInforHD.Enabled = false;
                    dtpkNgayLap.Enabled = false;
                    label13.Visible = false;
                    lbMaHd.Text = "0";
                    lbMaHd.Visible = false;
                    dem = 0;
                   
                    update();
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dem == 1)
                {
                    string querry = "Insert into HoaDonNhapThuoc(maNcc,maNv,ngayLap,TongTien,trangThai,linkQr) Values('" + cbNcc.SelectedValue + "','" + cbMaNv.SelectedValue + "',convert(nvarchar(30), getDate(), 20),'0','0',null)";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    Alert a = new Alert("Thêm thành công.", AlertType.success);
                    a.ShowDialog();
                    LoadHoaDon();
                    panelInforHD.Enabled = false;
                    update();
                    lbMaHd.Text = "0";
                    lbMaHd.Visible = false;
                    label13.Visible = false;
                    dtgvHD.Enabled = true;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                }
                else if (dem == 2)
                {
                    string query = "update HoaDonNhapThuoc set maNCC='" + cbNcc.SelectedValue + "',maNv='" + cbMaNv.SelectedValue + "',ngayLap=N'" + dtpkNgayLap.Value + "' where maHd='" + lbMaHd.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Sửa thành công.", AlertType.success);
                    a.ShowDialog();
                    LoadHoaDon();
                    panelInforHD.Enabled = false;
                    dtpkNgayLap.Enabled = false;
                    label13.Visible = false;
                    lbMaHd.Text = "0";
                    txTongTien.ResetText();
                    lbMaHd.Visible = false;
                    dem = 0;
                    dtgvHD.Enabled = true;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            update();
            lbMaHd.Text = "0";
            txTimKiem.ResetText();
            LoadHoaDon();
            lbMaHd.Visible = false;
            btnL.Enabled = true;
            label13.Visible = false;
            dtgvHD.Enabled = true;
            dtgvHD.ClearSelection();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            picQr.BackgroundImage = null;
            picQr.Image = null;
            if (CaptureDevice.IsRunning)
                CaptureDevice.Stop();
        }

       

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {

                lbMaHd.Text = dtgvHD.Rows[numrow].Cells["maHd"].Value.ToString();

                lbMaHd.Visible = true;
                label13.Visible = true;
                cbNcc.Text = dtgvHD.Rows[numrow].Cells["nhacungcap"].Value.ToString();
                cbMaNv.Text = dtgvHD.Rows[numrow].Cells["nv"].Value.ToString();
                DateTime dt = Convert.ToDateTime(dtgvHD.Rows[numrow].Cells["ngayLap"].Value.ToString());
                dtpkNgayLap.Value = dt;
               // txTongTien.Text = dtgvHD.Rows[numrow].Cells["tongtien"].Value.ToString();
                var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                decimal tien = decimal.Parse(dtgvHD.Rows[numrow].Cells["tongtien"].Value.ToString());
                txTongTien.Text = String.Format(info, "{0:c}", tien);
                string img = dtgvHD.Rows[numrow].Cells["linkQr"].Value.ToString();
                if (img != "")
                {
                 
                    Bitmap bitmap = new Bitmap(img);
                    picQr.Image = null;
                    picQr.BackgroundImage = bitmap;
                    picQr.BackgroundImageLayout = ImageLayout.Center;
                }
                else
                {
                    picQr.BackgroundImage = null;
                }

                string trangThai = dtgvHD.Rows[numrow].Cells["trangThai"].Value.ToString();
                if (trangThai == "True")
                {
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnL.Enabled = false;

                }
                else if (trangThai == "False")
                {
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnL.Enabled = true;
                }
                
            }
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            CaptureDevice.NewFrame += CaptureDevice_NewFrame;
            CaptureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picQr.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FHdNhapThuoc_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            CaptureDevice = new VideoCaptureDevice(FilterInfoCollection[0].MonikerString);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picQr.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)picQr.Image);
                if (result != null)
                {
                    txTimKiem.Text = result.ToString();
                    timer1.Stop();
                    if (CaptureDevice.IsRunning)
                        CaptureDevice.Stop();

                }
            }
        }

        private void FHdNhapThuoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            if (CaptureDevice.IsRunning)
                CaptureDevice.Stop();
        }

        private void dtgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvHD.Columns[e.ColumnIndex].Name == "chitiet")
            {
                FormCTHDNhapThuoc thuoc = new FormCTHDNhapThuoc(lbMaHd.Text, cbMaNv.Text, dtpkNgayLap.Text);
                this.Hide();
                thuoc.ShowDialog();
                this.Show();
                LoadHoaDon();
            }
        }
    }
}
