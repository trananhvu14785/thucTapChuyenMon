using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Application = Microsoft.Office.Interop.Excel.Application;
using Microsoft.Office.Interop.Excel;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using DataTable = System.Data.DataTable;


namespace QuanLyBoSua
{
    public partial class FormCTHDNhapThuoc : Form
    {
        private string maHd;
        private string maNv;
        private string ngayLap;
        public string MaHd { get => maHd; set => maHd = value; }
        public string MaNv { get => maNv; set => maNv = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public FormCTHDNhapThuoc(string mahd,string manv,string ngaylap)
        {
            this.maHd = mahd;
            this.maNv = manv;
            this.ngayLap = ngaylap;
            InitializeComponent();
            cbmaHD.Text = MaHd;
            LoadThuoc();
            LoadDVT();
            LoadCTHD(MaHd);
            getTongTien();
            kiemTra(cbmaHD.Text);
           
        }
        void kiemTra(string maHd)
        {
            string sql = "select * from HoaDonNhapThuoc where trangThai='1' and maHd='" + maHd + "'";
            System.Data.DataTable data = KetNoi.Istance.ExcuteQuerry(sql);
            if (data.Rows.Count > 0)
            {
                btnThemCT.Enabled = false;
                btnSuaCT.Enabled = false;
                btnXoaCT.Enabled = false;
                btnLuuCT.Enabled = false;
            }
        }

        void LoadThuoc()
        {
            try
            {
                string querry = "Select * from ThuocVacXin";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                cbTenThuoc.DataSource = data;
                cbTenThuoc.DisplayMember = "tenThuoc";
                cbTenThuoc.ValueMember = "maThuoc";
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void getTongTien()
        {
            string sql = "Select tongTien from HoaDonNhapThuoc where maHd='"+cbmaHD.Text+"'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(sql);
            foreach(DataRow row in data.Rows)
            {
                var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                decimal tien = decimal.Parse(row["tongTien"].ToString());
                txTongTien.Text = String.Format(info, "{0:c}", tien);
               
            }
            
        }
        void LoadDVT()
        {
            try
            {
                string[] DVT = { "Hộp", "Vỉ", "Chai", "Thùng", "Ống" };
                cbDonViTinh.DataSource = DVT;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void dtgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                cbTenThuoc.Text = dtgvCTHD.Rows[numrow].Cells[0].Value.ToString();
                numericUpDown1.Value = decimal.Parse(dtgvCTHD.Rows[numrow].Cells[1].Value.ToString());
                cbDonViTinh.Text = dtgvCTHD.Rows[numrow].Cells[2].Value.ToString();

                txGiaNhap.Text = dtgvCTHD.Rows[numrow].Cells[3].Value.ToString();


            }
        }
        void LoadCTHD(string maHd)
        {
            try
            {
                string query = "Select T.TenThuoc,C.slNhap,C.donViTinh,PARSENAME(CONVERT(varchar, CAST(C.donGiaNhap AS money), 1), 2)as donGiaNhap from HoaDonNhapThuoc H,CTHDNhapThuoc C,ThuocVacXin T where H.maHd=C.maHd and C.maThuoc=T.MaThuoc and H.maHd='" + maHd + "'";
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
            string sql = "Select linkQr from HoaDonNhapThuoc where maHd='" + cbmaHD.Text + "'";
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
            string fileName = @"C:\Users\Admin\Documents\QuanLyBoSua\QuanLyBoSua\QR\HdNhapThuoc\" + cbmaHD.Text + ".jpg";
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encoder.QRCodeScale = 6;
            Bitmap bitmap = encoder.Encode(cbmaHD.Text);
            bitmap.Save(fileName, ImageFormat.Jpeg);
            string sql = "Update HoaDonNhapThuoc set linkQr='" + fileName + "' where maHd='" + cbmaHD.Text + "'";
            KetNoi.Istance.ExcuteQuerry(sql);
        }
        void exFile(DataGridView data)
        {
            bool fileError = true;
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XLS(*.xls)|*.xls";
                saveFileDialog.FileName = "HoaDonNhapThuoc.xls";
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

                    xlWorkSheet.Cells[7, 1] = "         Hóa Đơn Nhập Thuốc     ";
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
                    string sql = "Update HoaDonNhapThuoc set trangThai='1' where maHd='" + cbmaHD.Text + "'";
                    KetNoi.Istance.ExcuteQuerry(sql);
                    Alert a = new Alert("In thành công", AlertType.success);
                    a.ShowDialog();
                    kiemTra(cbmaHD.Text);

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
        int bien = 0;

      

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            
           
                bien = 1;
                txGiaNhap.ResetText();
                numericUpDown1.Value = 0;
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
                Alert a = new Alert("Hãy chọn chi tiết cần sửa", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                bien = 2;
                panelCTHD.Enabled = true;
                btnThemCT.Enabled = false;
                btnSuaCT.Enabled = false;
                btnXoaCT.Enabled = false;
                dtgvCTHD.Enabled = false;
                cbTenThuoc.Enabled = false;
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txGiaNhap.Text == "")
                {
                    Alert a = new Alert("Hãy Chọn Chi tiết hóa đơn cần Xóa", AlertType.error);
                    a.ShowDialog();
                }
                else
                {
                    string querry = "Delete CTHDNhapThuoc where maHd='" + cbmaHD.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    Alert a = new Alert("Xóa Thành Công", AlertType.success);
                    a.ShowDialog();
                    txGiaNhap.ResetText();                  
                    numericUpDown1.Value = 0;
                    LoadCTHD(cbmaHD.SelectedValue.ToString());
                    getTongTien();
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (bien == 1)
                {
                    if (numericUpDown1.Value == 0 || txGiaNhap.Text == "")
                    {
                        Alert a = new Alert("Bạn hãy nhập đủ thông tin", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        string querry = "insert into CTHDNhapThuoc values('" + cbmaHD.Text + "','" + cbTenThuoc.SelectedValue + "',N'" + cbDonViTinh.Text + "','" + numericUpDown1.Value + "','" + txGiaNhap.Text + "')";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                        Alert a = new Alert("Thêm thành công", AlertType.success);
                        a.ShowDialog();
                        LoadCTHD(cbmaHD.Text);
                        getTongTien();
                        txGiaNhap.ResetText();
                        numericUpDown1.Value = 0;
                        panelCTHD.Enabled = false;
                        btnThemCT.Enabled = true;
                        btnSuaCT.Enabled = true;
                        dtgvCTHD.Enabled = true;
                        btnXoaCT.Enabled = true;
                    }
                }
                if (bien == 2)
                {

                    if (numericUpDown1.Value == 0 || txGiaNhap.Text == "")
                    {
                        Alert a = new Alert("Bạn hãy nhập đủ thông tin", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        string querry = "Update CTHDNhapThuoc set slNhap='" + numericUpDown1.Value + "',donViTinh=N'" + cbDonViTinh.Text + "',donGiaNhap='" + txGiaNhap.Text + "' where maHd='" + cbmaHD.Text + "' and maThuoc='" + cbTenThuoc.SelectedValue + "'";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                        Alert a = new Alert("Sửa thành công", AlertType.error);
                        a.ShowDialog();
                        LoadCTHD(MaHd);
                        panelCTHD.Enabled = false;
                        txGiaNhap.ResetText();
                        numericUpDown1.Value = 0;
                        getTongTien();
                        btnThemCT.Enabled = true;
                        btnSuaCT.Enabled = true;
                        btnXoaCT.Enabled = true;
                        cbTenThuoc.Enabled = true;
                        dtgvCTHD.Enabled = true;
                    }
            }
        }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối", AlertType.error);
        a.ShowDialog();
            }
}

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txGiaNhap.ResetText();
            numericUpDown1.Value = 0;
            panelCTHD.Enabled = false;
            bien = 0;
            dtgvCTHD.ClearSelection();
            btnThemCT.Enabled = true;
            btnSuaCT.Enabled = true;
            btnXoaCT.Enabled = true;
            cbTenThuoc.Enabled = true;
            dtgvCTHD.Enabled = true;
            kiemTra(cbmaHD.Text);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
       






    
}
