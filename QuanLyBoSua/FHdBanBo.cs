using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;


namespace QuanLyBoSua
{
    public partial class FHdBanBo : Form
    {
        private string maNv;
        public FHdBanBo(string maNv=null)
        {
            this.maNv = maNv;
            InitializeComponent();
            LoadTenKh();
            loadNhanVien();
            LoadHd();
        }
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice CaptureDevice;
        void LoadTenKh()
        {
            try
            {
                string query = "Select * from khachHang";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                cbTenKh.DataSource = data;
                cbTenKh.DisplayMember = "tenKh";
                cbTenKh.ValueMember = "maKh";
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
        void LoadHd()
        {
            try
            {
                string query = "select H.maHD,K.tenKH,H.maNv,convert(nvarchar(30), H.ngayMua, 20)as ngayMua,PARSENAME(CONVERT(varchar, CAST(H.thanhTien AS money), 1), 2)as thanhTien,H.trangThai,H.linkQr from HDBanBo H,KhachHang k where H.maKH=K.maKH";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvHD.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        private int row;
        private void dtgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                lbMaHd.Text = dtgvHD.Rows[numrow].Cells["maHd"].Value.ToString();
                row = numrow;
                lbMaHd.Visible = true;
                label13.Visible = true;
                cbTenKh.Text= dtgvHD.Rows[numrow].Cells["nhacungcap"].Value.ToString();
                cbMaNv.Text= dtgvHD.Rows[numrow].Cells["nhanvien"].Value.ToString();
                DateTime dt = Convert.ToDateTime(dtgvHD.Rows[numrow].Cells["ngaylap"].Value.ToString());
                dtpkNgayLap.Value = dt;
                var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                decimal tien = decimal.Parse(dtgvHD.Rows[numrow].Cells["tt"].Value.ToString());
                txTongTien.Text= String.Format(info, "{0:c}", tien);

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
                    btnLuu.Enabled = false;

                }
                else if (trangThai == "False")
                {
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = true;
                }

            }
        }     
        
        int dem = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }
        void update()
        {
            panelInforHD.Enabled = false;
            dtpkNgayLap.Enabled = false;
            dem = 0;         
            txTongTien.ResetText();
            dtgvHD.ClearSelection();           
            txTongTien.Text = "0";         
        }

      
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        public string MaNv { get => maNv; set => maNv = value; }

       


        private void txTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "select H.maHD,K.tenKH,H.maNv,convert(nvarchar(30), H.ngayMua, 20)as ngayMua,PARSENAME(CONVERT(varchar, CAST(H.thanhTien AS money), 1), 2)as thanhTien,H.trangThai,H.linkQr from HDBanBo H,KhachHang k where H.maKH=K.maKH and maHd like N'%" + txTimKiem.Text + "%'";
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
            //char ch = e.KeyChar;
            //if (ch == 46 && txGiaNhap.Text.IndexOf('.') != -1)
            //{
            //    e.Handled = true;
            //    return;
            //}
            //if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            //    e.Handled = true;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            panelInforHD.Enabled = true;
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
                dtgvHD.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (lbMaHd.Text == "0")
            {
                Alert a = new Alert("Vui Lòng chọn hóa đơn cần Xóa.", AlertType.error);

                a.ShowDialog();

            }
            else
            {
                try
                {
                    string query = "Delete HDBanBo where maHd='" + lbMaHd.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Xóa thành công.", AlertType.success);

                    a.ShowDialog();
                    LoadHd();
                    panelInforHD.Enabled = false;
                    dtpkNgayLap.Enabled = false;
                    label13.Visible = false;
                    lbMaHd.Text = "0";
                    lbMaHd.Visible = false;
                    dem = 0;
                  
                    update();
                }
                catch
                {
                    Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                    a.ShowDialog();
                }
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dem == 1)
                {
                    string querry = "Insert into HDBanBo(ngayMua,maNv,maKh,thanhTien,trangThai,linkQr) Values(  convert(nvarchar(30), getDate(), 20) ,'" + cbMaNv.SelectedValue + "','" + cbTenKh.SelectedValue + "','0','0',null)";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    Alert a = new Alert("Thêm thành công.", AlertType.success);
                    a.ShowDialog();
                    LoadHd();
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
                if (dem == 2)
                {
                    string querry = "Update HDBanBo set maKh='" + cbTenKh.SelectedValue + "',ngayMua=N'" + dtpkNgayLap.Value + "',maNv='" + cbMaNv.SelectedValue + "' where maHd='" + lbMaHd.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    Alert a = new Alert("Sửa thành công.", AlertType.success);
                    a.ShowDialog();
                    LoadHd();
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
            lbMaHd.Visible = false;
            label13.Visible = false;
            btnLuu.Enabled = true;
            dem = 0;
            dtgvHD.ClearSelection();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            dtgvHD.Enabled = true;
            txTimKiem.ResetText();
            LoadHd();
            timer1.Stop();
            picQr.BackgroundImage = null;
            picQr.Image = null;
            if (CaptureDevice.IsRunning)
                CaptureDevice.Stop();

        }

       

      
        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton26_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void dtgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvHD.Columns[e.ColumnIndex].Name == "chitiet")
            {
                this.Hide();
                FCTHDBanBo cTHDBanBo = new FCTHDBanBo(lbMaHd.Text, cbTenKh.SelectedValue.ToString(),cbMaNv.SelectedValue.ToString(),dtpkNgayLap.Text);
                cTHDBanBo.ShowDialog();
                this.Show();
                LoadHd();
                update();
                lbMaHd.Text = "0";
                lbMaHd.Visible = false;
                label13.Visible = false;
                picQr.Image = null;
                picQr.BackgroundImage = null;
                dem = 0;
                dtgvHD.ClearSelection();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
            }
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

        private void FHdBanBo_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            CaptureDevice = new VideoCaptureDevice(FilterInfoCollection[0].MonikerString);
        }
    }
}
