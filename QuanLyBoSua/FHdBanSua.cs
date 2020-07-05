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
using Microsoft.Office.Core;
using Application = Microsoft.Office.Interop.Excel.Application;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Drawing.Imaging;

namespace QuanLyBoSua
{
    public partial class FHdBanSua : Form
    {
        private string maNv;
        public FHdBanSua(string maNv=null)
        {
            this.maNv = maNv;
            InitializeComponent();
            LoadTenKh();
            loadNhanVien();
            loadLuongSua();
            loadHD();
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
        void loadLuongSua()
        {
            try
            {
                string query = "Select soLuongSua from khosua";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                foreach (DataRow item in data.Rows)
                {
                    lbLuongSua.Text = item["soluongsua"].ToString();
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
                
        }
        void loadHD()
        {
            try
            {
                string query = "select H.maHD,convert(nvarchar(30), H.ngayMua, 20)as ngayMua,H.maNv,K.tenKH,H.SlSuaBan,PARSENAME(CONVERT(varchar, CAST(H.tienSua1lit AS money), 1), 2)as tienSua1lit,PARSENAME(CONVERT(varchar, CAST(H.thanhTien AS money), 1), 2)as thanhTien,trangThai,linkQr from HDBanSua H,KhachHang K where H.maKH=K.maKH";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvHd.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }

        }

        private void dtgvHd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                lbMaHd.Text = dtgvHd.Rows[numrow].Cells[0].Value.ToString();
                lbMaHd.Visible = true;
                label13.Visible = true;
                DateTime dt = Convert.ToDateTime(dtgvHd.Rows[numrow].Cells[1].Value.ToString());
                dtpkNgayMua.Value = dt;
                cbMaNv.Text= dtgvHd.Rows[numrow].Cells[2].Value.ToString();
                cbTenKh.Text= dtgvHd.Rows[numrow].Cells[3].Value.ToString();
                numSoLuong.Value= int.Parse(dtgvHd.Rows[numrow].Cells[4].Value.ToString());
                txDonGia.Text= dtgvHd.Rows[numrow].Cells[5].Value.ToString();
               // txThanhTien.Text= dtgvHd.Rows[numrow].Cells[6].Value.ToString();
                var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                decimal tien = decimal.Parse(dtgvHd.Rows[numrow].Cells[6].Value.ToString());
                txThanhTien.Text = String.Format(info, "{0:c}", tien);
                string img = dtgvHd.Rows[numrow].Cells["linkQr"].Value.ToString();
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

                string trangThai = dtgvHd.Rows[numrow].Cells["trangThai"].Value.ToString();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void txDonGia_TextChanged(object sender, EventArgs e)
        {
            if (numSoLuong.Value != 0)
            {
                if (txDonGia.Text != "")
                {
                    txThanhTien.Text = float.Parse(numSoLuong.Value.ToString()) * float.Parse(txDonGia.Text) + "";
                }
                if (txDonGia.Text == "" )
                {
                    txThanhTien.Text = "0";
                }
            }
            if( numSoLuong.Value == 0)
                txThanhTien.Text = "0";
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (numSoLuong.Value != 0)
            {
                if (txDonGia.Text != "")
                {
                    txThanhTien.Text = float.Parse(numSoLuong.Value.ToString()) * float.Parse(txDonGia.Text) + "";
                }
                if (txDonGia.Text == "" )
                {
                    txThanhTien.Text = "0";
                }
            }
            if (numSoLuong.Value == 0)
                txThanhTien.Text = "0";
        }
        decimal slCu = 0;

        public string MaNv { get => maNv; set => maNv = value; }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

       
        private void txTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "select H.maHD,convert(nvarchar(30), H.ngayMua, 20)as ngayMua,H.maNv,K.tenKH,H.SlSuaBan,H.tienSua1lit,H.thanhTien from HDBanSua H,KhachHang K where H.maKH=K.maKH and maHd like N'%" + txTimKiem.Text + "%'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvHd.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
        }
        string getQR()
        {
            string sql = "Select linkQr from HDBanSua where maHd='" + lbMaHd.Text + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(sql);
            if (data.Rows.Count == 0)
                return "";
            else
            {
                DataRow row = data.Rows[0];
                return row["linkQr"].ToString();
            }
        }
        void createQR()
        {
            string fileName = @"E:\ThucTapChuyenMon\QR\HDBanBo\" + lbMaHd.Text + ".jpg";
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encoder.QRCodeScale = 6;
            Bitmap bitmap = encoder.Encode(lbMaHd.Text);
            bitmap.Save(fileName, ImageFormat.Jpeg);
            string sql = "Update HDBanSua set linkQr='" + fileName + "' where maHd='" + lbMaHd.Text + "'";
            KetNoi.Istance.ExcuteQuerry(sql);
        }
        void exFile(DataGridView data)
        {
            bool fileError = true;
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XLS(*.xls)|*.xls";
                saveFileDialog.FileName = "HoaDonBanSua.xls";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileError = false;
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        try
                        {
                            fileError = false;
                            File.Delete(saveFileDialog.FileName);

                        }
                        catch
                        {
                            fileError = true;
                        }
                    }
                }
                if (!fileError)
                {
                    Application xlApp;
                    Workbook xlWorkBook;
                    Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;
                    xlApp = new Application();
                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    xlWorkSheet.Columns.ColumnWidth = 25;
                    string qrcode = "";
                    if (getQR() == "")
                    {
                        createQR();
                        qrcode = getQR();
                    }
                    else
                    {
                        qrcode = getQR();
                    }
                    xlWorkSheet.Shapes.AddPicture(qrcode, MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 50, 5, 100, 100);

                    //add some text 

                    xlWorkSheet.Cells[7, 1] = "         Hóa Đơn Bán Bò    ";
                    xlWorkSheet.Cells[8, 1] = "Mã Hóa Đơn: " + lbMaHd.Text;
                    xlWorkSheet.Cells[8, 2] = "Ngày Lập: " + dtpkNgayMua.Text;
                    xlWorkSheet.Cells[9, 1] = "Mã Nhân Viên: " + cbMaNv.Text;
                    xlWorkSheet.Cells.Font.Bold = true;
                    int dem = 10;
                    xlWorkSheet.Rows[dem].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    if (dtgvHd.RowCount > 0)
                    {

                        for (int i = 1; i < data.Columns.Count + 1; i++)
                        {

                            xlWorkSheet.Cells[10, i] = data.Columns[i - 1].HeaderText;

                        }
                        for (int i = 0; i < data.Rows.Count; i++)
                        {
                            dem += 1;
                            xlWorkSheet.Rows[dem].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            for (int j = 0; j < data.Columns.Count; j++)
                            {
                                if (data.Rows[i].Cells[j].Value != null)
                                {
                                    xlWorkSheet.Cells[i + 11, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                                }
                                else
                                {
                                    xlWorkSheet.Cells[i + 11, j + 1] = "";
                                }
                            }
                        }
                    }

                    xlWorkSheet.Cells[dem + 1, 1] = "Tổng Tiền " + txThanhTien.Text;
                    xlWorkSheet.Rows[dem + 1].Font.Color = Color.Red;
                    xlWorkSheet.Rows[dem + 1].Font.Bold = true;
                    xlWorkSheet.Rows[dem + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    xlWorkBook.SaveAs(saveFileDialog.FileName, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();
                    string sql = "Update HDBanSua set trangThai='1' where maHd='" + lbMaHd.Text + "'";
                    KetNoi.Istance.ExcuteQuerry(sql);
                    Alert a = new Alert("In thành công", AlertType.success);
                    a.ShowDialog();
                    try
                    {
                        string dcmail = "";
                        string querry = "select email from khachhang where tenkh = N'" + cbTenKh.Text + "'";
                        DataTable DL = KetNoi.Istance.ExcuteQuerry(querry);
                        foreach (DataRow row in DL.Rows)
                        {
                            dcmail = row["email"].ToString();
                        }
                        SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                        mailclient.EnableSsl = true;
                        mailclient.Credentials = new NetworkCredential("trananhvu10121999@gmail.com", "01884767166");

                        MailMessage message = new MailMessage("trananhvu10121999@gmail.com", dcmail);
                        message.Subject = "THƯ CẢM ƠN KHÁCH HÀNG CỦA BENRI FARM";
                        message.Body = "Cảm ơn quý khách hàng " + cbTenKh.Text + " đã tin tưởng Benri Farm! " + "\n" + "Kính mong quý khách sẽ tiếp tục ủng hộ!" + "\n" +
                            "Thân ái!";

                        mailclient.Send(message);
                        message = null;
                        Alert b = new Alert("Mail đã được gửi đi!", AlertType.success);
                        b.ShowDialog();
                    }
                    catch
                    {
                        Alert b = new Alert("Báo cáo chưa được gửi do lỗi mạng!", AlertType.info);
                        b.ShowDialog();
                    }
                    loadHD();
                    panelHDBS.Enabled = false;
                    dtgvHd.ClearSelection();
                    txDonGia.ResetText();
                    loadHD();
                    txTimKiem.Text = "";
                    numSoLuong.Value = 0;
                    lbMaHd.Text = "0";
                    lbMaHd.Visible = false;
                    label13.Visible = false;
                    dtpkNgayMua.Enabled = true;
                    dem = 0;
                    btnThem.Enabled = true;
                    dtgvHd.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    timer1.Stop();
                    btnLuu.Enabled = true;
                    picQr.BackgroundImage = null;
                    picQr.Image = null;
                    if (CaptureDevice.IsRunning)
                        CaptureDevice.Stop();
                }
            
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            panelHDBS.Enabled = true;
            dem = 1;
            numSoLuong.Value = 0;
            txThanhTien.Text = "0";
            txDonGia.Text = "0";
            lbMaHd.Text = "0";
            lbMaHd.Visible = false;
            label13.Visible = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
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
            }
            else
            {
                dem = 2;
                panelHDBS.Enabled = true;
                dtpkNgayMua.Enabled = true;
                slCu = numSoLuong.Value;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
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
                    string query = "Delete HDBanSua where maHd='" + lbMaHd.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Xóa thành công.", AlertType.success);
                    a.ShowDialog();
                    loadHD();
                    loadLuongSua();
                    panelHDBS.Enabled = false;
                    lbMaHd.Visible = false;
                    label13.Visible = false;
                    txDonGia.Text = "";
                    numSoLuong.Value = 0;
                    txThanhTien.Text = "0";
                    dem = 0;
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
                    if (txDonGia.Text == "" || numSoLuong.Value == 0)
                    {
                        Alert a = new Alert("Vui nhập đủ thông tin.", AlertType.error);

                        a.ShowDialog();
                    }
                    else if (double.Parse(lbLuongSua.Text) < double.Parse(numSoLuong.Value.ToString()))
                    {
                        Alert a = new Alert("Lượng sữa trong kho không đủ.", AlertType.error);

                        a.ShowDialog();
                    }
                    else
                    {
                        string query = "insert into HDBanSua(ngayMua,maNv,maKH,SlSuaBan,tienSua1lit,thanhTien,trangThai,linkQR) values(N'" + dtpkNgayMua.Value + "','" + cbMaNv.Text + "','" + cbTenKh.SelectedValue + "','" + numSoLuong.Value + "','" + txDonGia.Text + "','" + txThanhTien.Text + "','0',null)";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert a = new Alert("Thêm thành công.", AlertType.success);
                        a.ShowDialog();
                        loadHD();
                        loadLuongSua();
                        panelHDBS.Enabled = false;
                        txDonGia.Text = "";
                        numSoLuong.Value = 0;
                        txThanhTien.Text = "0";
                        dem = 0;
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                }
                if (dem == 2)
                {
                    if (txDonGia.Text == "" || numSoLuong.Value == 0)
                    {
                        Alert a = new Alert("Vui nhập đủ thông tin.", AlertType.error);

                        a.ShowDialog();
                    }
                    else if (slCu < numSoLuong.Value && numSoLuong.Value - slCu > decimal.Parse(lbLuongSua.Text))
                    {
                        Alert a = new Alert("Lượng sữa trong kho không đủ.", AlertType.error);

                        a.ShowDialog();
                    }
                    else
                    {
                        string query = "Update HDBanSua set ngayMua=N'" + dtpkNgayMua.Value + "',maNv='" + cbMaNv.Text + "',maKh='" + cbTenKh.SelectedValue + "',slSuaBan='" + numSoLuong.Value + "',tiensua1lit='" + txDonGia.Text + "',thanhTien='" + txThanhTien.Text + "' where maHd='" + lbMaHd.Text + "'";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert a = new Alert("Sửa thành công.", AlertType.success);
                        a.ShowDialog();
                        loadHD();
                        loadLuongSua();
                        panelHDBS.Enabled = false;
                        lbMaHd.Visible = false;
                        label13.Visible = false;
                        txDonGia.Text = "";
                        numSoLuong.Value = 0;
                        txThanhTien.Text = "0";
                        dtpkNgayMua.Enabled = false;
                        dem = 0;
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
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
            panelHDBS.Enabled = false;
            dtgvHd.ClearSelection();
            txDonGia.ResetText();
            loadHD();
            txTimKiem.Text = "";
            numSoLuong.Value = 0;
            lbMaHd.Text = "0";
            lbMaHd.Visible = false;
            label13.Visible = false;
            dtpkNgayMua.Enabled = true;
            dem = 0;
            btnThem.Enabled = true;
            dtgvHd.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            timer1.Stop();
            picQr.BackgroundImage = null;
            picQr.Image = null;
            if (CaptureDevice.IsRunning)
                CaptureDevice.Stop();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (lbMaHd.Text == "0")
            {
                Alert a = new Alert("Vui Lòng Chọn Hóa Đơn", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                exFile(dtgvHd);
            }
        }

        private void FHdBanSua_Load(object sender, EventArgs e)
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
    }
}
