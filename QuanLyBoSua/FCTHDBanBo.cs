using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using Application = Microsoft.Office.Interop.Excel.Application;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Drawing.Imaging;

namespace QuanLyBoSua
{
    public partial class FCTHDBanBo : Form
    {
        private string maHd, maKh, maNv, ngayLap;
        public FCTHDBanBo(string mahd, string makh, string manv, string ngaylap)
        {
            this.maHd = mahd;
            this.maKh = makh;
            this.maNv = manv;
            this.ngayLap = ngaylap;
            InitializeComponent();
            cbmaHD.Text = MaHd;
            loadBo();
            LoadCTHD(cbmaHD.Text);
            getTongTien();
            kiemTra(cbmaHD.Text);
        }
        void kiemTra(string maHd)
        {
            string sql = "select * from HDBanBo where trangThai='1' and maHd='" + maHd + "'";
            System.Data.DataTable data = KetNoi.Istance.ExcuteQuerry(sql);
            if (data.Rows.Count > 0)
            {
                btnThemCT.Enabled = false;
                btnSuaCT.Enabled = false;
                btnXoaCT.Enabled = false;
                btnLuuCT.Enabled = false;
            }
        }
        void loadBo()
        {
            try
            {
                string query = "Select * from danBo where ngayXuatChuong is null";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                cbMaBo.DataSource = data;
                cbMaBo.DisplayMember = "maBo";
                cbMaBo.ValueMember = "maBo";
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        int bien = 0;

        public string MaHd { get => maHd; set => maHd = value; }
        public string MaKh { get => maKh; set => maKh = value; }
        public string MaNv { get => maNv; set => maNv = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }

        void LoadCTHD(string maHd)
        {
            try
            {
                string query = "Select maHd,maBo,PARSENAME(CONVERT(varchar, CAST(giaBan AS money), 1), 2)as giaBan from CTHDBanBo where maHd='" + maHd + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvCTHD.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        string getQR()
        {
            string sql = "Select linkQr from HDBanBo where maHd='" + cbmaHD.Text + "'";
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
            string fileName = @"E:\ThucTapChuyenMon\QR\HDBanBo\" + cbmaHD.Text + ".jpg";
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encoder.QRCodeScale = 6;
            Bitmap bitmap = encoder.Encode(cbmaHD.Text);
            bitmap.Save(fileName, ImageFormat.Jpeg);
            string sql = "Update HDBanBo set linkQr='" + fileName + "' where maHd='" + cbmaHD.Text + "'";
            KetNoi.Istance.ExcuteQuerry(sql);
        }

        void exFile(DataGridView data)
        {
            bool fileError = true;
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XLS(*.xls)|*.xls";
                saveFileDialog.FileName = "HoaDonBanBo.xls";
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

                    xlWorkSheet.Cells[7, 1] = "         Hóa Đơn Bán Bò     ";
                    xlWorkSheet.Cells[8, 1] = "Mã Hóa Đơn: " + cbmaHD.Text;
                    xlWorkSheet.Cells[8, 2] = "Ngày Lập: " + NgayLap;
                    xlWorkSheet.Cells[9, 1] = "Mã Nhân Viên: " + MaNv;
                    xlWorkSheet.Cells.Font.Bold = true;
                    int dem = 10;
                    xlWorkSheet.Rows[dem].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    if (dtgvCTHD.RowCount > 0)
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

                    xlWorkSheet.Cells[dem + 1, 1] = "Tổng Tiền " + txTongTien.Text;
                    xlWorkSheet.Rows[dem + 1].Font.Color = Color.Red;
                    xlWorkSheet.Rows[dem + 1].Font.Bold = true;
                    xlWorkSheet.Rows[dem + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    xlWorkBook.SaveAs(saveFileDialog.FileName, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();
                    string sql = "Update HDBanBo set trangThai='1' where maHd='" + cbmaHD.Text + "'";
                    KetNoi.Istance.ExcuteQuerry(sql);
                    Alert a = new Alert("In thành công", AlertType.success);
                    a.ShowDialog();
                    try
                    {
                        string dcmail = "";
                        string querry = "select email from khachhang where maKh = N'" +MaKh + "'";
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
                        message.Body = "Cảm ơn quý khách đã tin tưởng Benri Farm! " + "\n" + "Kính mong quý khách sẽ tiếp tục ủng hộ!" + "\n" +
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
                    kiemTra(cbmaHD.Text);
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();

            }
        }
    



        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            txGiaNhap.ResetText();
            dtgvCTHD.Enabled = true;
            cbMaBo.Enabled = true;
            panelCTHD.Enabled = false;
            bien = 0;
            dtgvCTHD.ClearSelection();
            btnThemCT.Enabled = true;
            btnSuaCT.Enabled = true;
            btnXoaCT.Enabled = true;
            btnLuuCT.Enabled = true;
            kiemTra(cbmaHD.Text);
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
           
                bien = 1;
                txGiaNhap.ResetText();
                panelCTHD.Enabled = true;
                btnThemCT.Enabled = false;
                btnSuaCT.Enabled = false;
                btnXoaCT.Enabled = false;
            dtgvCTHD.Enabled = false;
          
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            if (txGiaNhap.Text == "")
            {
                Alert a = new Alert("Hãy Chọn Chi tiết hóa đơn cần sửa", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                bien = 2;
                cbMaBo.Enabled = false;
                panelCTHD.Enabled = true;
                btnThemCT.Enabled = false;
                btnSuaCT.Enabled = false;
                btnXoaCT.Enabled = false;
                dtgvCTHD.Enabled = false;
            }
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvCTHD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                
                //var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
              
                cbMaBo.Text = dtgvCTHD.Rows[numrow].Cells[1].Value.ToString();
                //  decimal tien=decimal.Parse(dtgvCTHD.Rows[numrow].Cells[2].Value.ToString());
                txGiaNhap.Text = dtgvCTHD.Rows[numrow].Cells[2].Value.ToString();//String.Format(info, "{0:c}", tien);
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (txGiaNhap.Text == "")
            {
                Alert a = new Alert("Hãy Chọn Chi tiết hóa đơn cần Xóa", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                try
                {
                    string query = "Delete CTHDBanBo where maHd='" + cbmaHD.Text + "' and maBo='" + cbMaBo.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Xóa thành công", AlertType.success);
                    a.ShowDialog();
                    LoadCTHD(cbmaHD.Text);
                    loadBo();
                    txGiaNhap.Text = "";
                    getTongTien();
                    panelCTHD.Enabled = false;
                    
                }
                catch
                {
                    Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                    a.ShowDialog();
                }
            }
        }

        private void txGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void getTongTien()
        {
            string sql = "Select thanhtien from HDBanBo where maHd='" + cbmaHD.Text + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(sql);
            foreach (DataRow row in data.Rows)
            {
                var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                decimal tien = decimal.Parse(row["thanhtien"].ToString());
                txTongTien.Text = String.Format(info, "{0:c}", tien);
               // txTongTien.Text = row["thanhtien"].ToString();
            }

        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (bien == 1)
                {
                    if (txGiaNhap.Text == "")
                    {
                        Alert a = new Alert("Bạn hãy nhập đủ thông tin", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        string query = "Insert into CTHDBanBo values('" + cbmaHD.Text + "','" + cbMaBo.Text + "','" + txGiaNhap.Text + "')";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert a = new Alert("Thêm thành công", AlertType.success);
                        a.ShowDialog();
                        LoadCTHD(cbmaHD.Text);
                        loadBo();
                        getTongTien();
                        panelCTHD.Enabled = false;
                        bien = 0;
                        txGiaNhap.ResetText();
                        dtgvCTHD.Enabled = true;
                        btnThemCT.Enabled = true;
                        btnSuaCT.Enabled = true;
                        btnXoaCT.Enabled = true;
                    }
                }
                if (bien == 2)
                {
                    if (txGiaNhap.Text == "")
                    {
                        Alert a = new Alert("Bạn hãy nhập đủ thông tin", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        string query = "Update CTHDBanBo set maBo='" + cbMaBo.Text + "',giaBan='" + txGiaNhap.Text + "' where maHd='" + cbmaHD.Text + "'";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert a = new Alert("Sửa thành công", AlertType.success);
                        a.ShowDialog();
                        LoadCTHD(cbmaHD.Text);                       
                        loadBo();
                        getTongTien();
                        panelCTHD.Enabled = false;
                        bien = 0;
                        cbMaBo.Enabled = true;
                        txGiaNhap.ResetText();
                        dtgvCTHD.Enabled = true;
                        btnThemCT.Enabled = true;
                        btnSuaCT.Enabled = true;
                        btnXoaCT.Enabled = true;
                    }
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {           
                exFile(dtgvCTHD);           
        }
    }
}
