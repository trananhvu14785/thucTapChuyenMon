using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
namespace QuanLyBoSua 
{
    public partial class FormHDNhapBo : Form
    {
        private string maNv;
        public FormHDNhapBo(string maNv=null)
        {
            this.maNv = maNv;
            InitializeComponent();
            loadNhaCungCap();
            loadNhanVien();
            LoadHoaDon();
            picQr.BackgroundImage = null;
        }
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice CaptureDevice;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

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

            }
        }
        private int dem = 0;       

        void LoadHoaDon()
        {
            try
            {
                string query = "select H.maHD,N.tenNCC,H.maNv,convert(nvarchar(30), H.ngayLap, 20)as ngayLap,PARSENAME(CONVERT(varchar, CAST(H.tongTien AS money), 1), 2)as tongTien,trangThai,linkQr from HDNhapBo H,NhaCungCap N where H.maNCC=N.maNCC";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvHD.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }
        private int rowIndex;

        private void dtgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                picQr.Image = null;
                lbMaHd.Text = dtgvHD.Rows[numrow].Cells["maHd"].Value.ToString();
                rowIndex = numrow;
                lbMaHd.Visible = true;
                label13.Visible = true;
                cbNcc.Text = dtgvHD.Rows[numrow].Cells["nhacungcap"].Value.ToString();
                cbMaNv.Text = dtgvHD.Rows[numrow].Cells["nhanvien"].Value.ToString();
                DateTime dt = Convert.ToDateTime(dtgvHD.Rows[numrow].Cells["ngayLap"].Value.ToString());
                dtpkNgayLap.Value = dt;
                
                var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                decimal tien = decimal.Parse(dtgvHD.Rows[numrow].Cells["tt"].Value.ToString());
                txTongTien.Text = String.Format(info, "{0:c}", tien);
                string img= dtgvHD.Rows[numrow].Cells["qr"].Value.ToString();
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
               
                string trangThai= dtgvHD.Rows[numrow].Cells["trangThai"].Value.ToString();
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
        public string MaNv { get => maNv; set => maNv = value; }       
        void update()
        {
            panelInforHD.Enabled = false;
            dtpkNgayLap.Enabled = false;         
            dem = 0;            
            txTongTien.ResetText();
            dtgvHD.ClearSelection();          
            txTongTien.Text="0";          
        }    
       private void txTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "select H.maHD,N.tenNCC,H.maNv,convert(nvarchar(30), H.ngayLap, 20)as ngayLap,PARSENAME(CONVERT(varchar, CAST(H.tongTien AS money), 1), 2)as tongTien,trangThai,linkQr from HDNhapBo H,NhaCungCap N where H.maNCC=N.maNCC and maHd like N'%" + txTimKiem.Text + "%'";

              //  string query = "select H.maHD,N.tenNCC,H.maNv,convert(nvarchar(30), H.ngayLap, 20)as ngayLap,H.tongTien from HDNhapBo H,NhaCungCap N where H.maNCC=N.maNCC ";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvHD.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

       
        //void ExportPDF(DataGridView dgt,string fileName)
        //{
        //    try
        //    {
        //        BaseFont bf = BaseFont.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\arialbd.TTF", BaseFont.IDENTITY_H, true);
        //        PdfPTable pdfPTable = new PdfPTable(dgt.Columns.Count);
        //        PdfPTable inner = new PdfPTable(1);
        //        PdfPTable header = new PdfPTable(2);
        //        PdfPTable footer = new PdfPTable(1);
        //        pdfPTable.DefaultCell.Padding = 3;
        //        pdfPTable.WidthPercentage = 100;
        //        pdfPTable.HorizontalAlignment = Element.ALIGN_MIDDLE;
        //        pdfPTable.DefaultCell.BorderWidth = 1;
        //        iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
        //        // pdfPTable.AddCell(new PdfPCell(new Phrase("Hóa đơn nhập bò")));
        //        PdfPCell cell_1 = new PdfPCell();
        //        Paragraph p = new Paragraph("Hóa đơn nhập Bò", text);
        //        p.Alignment = Element.ALIGN_CENTER;
        //        cell_1.AddElement(p);
        //        cell_1.Border = 0;
        //        inner.AddCell(cell_1);

        //        PdfPCell cell_2_1 = new PdfPCell();
        //      //  Paragraph p1 = new Paragraph("Mã hóa đơn: " + cbmaHD.Text, text);
        //        p1.Alignment = Element.ALIGN_CENTER;
        //        cell_2_1.AddElement(p1);
        //        cell_2_1.Border = 0;
        //        header.AddCell(cell_2_1);

        //        PdfPCell cell_2_2 = new PdfPCell();
        //        Paragraph p2 = new Paragraph("Ngày lập: " + dtpkNgayLap.Value.ToString(), text);
        //        p2.Alignment = Element.ALIGN_CENTER;
        //        cell_2_2.AddElement(p2);
        //        cell_2_2.Border = 0;
        //        header.AddCell(cell_2_2);

        //        PdfPCell cell_3_1 = new PdfPCell();
        //        Paragraph p3_1 = new Paragraph("Nhà Cung Cấp: " + cbNcc.Text, text);
        //        p3_1.Alignment = Element.ALIGN_CENTER;
        //        cell_3_1.AddElement(p3_1);
        //        cell_3_1.Border = 0;
        //        header.AddCell(cell_3_1);

        //        PdfPCell cell_3_2 = new PdfPCell();
        //        Paragraph p3_2 = new Paragraph("Mã nhân viên: " + cbMaNv.Text, text);
        //        p3_2.Alignment = Element.ALIGN_CENTER;
        //        cell_3_2.AddElement(p3_2);
        //        cell_3_2.Border = 0;
        //        header.AddCell(cell_3_2);

        //        PdfPCell cell_Footer = new PdfPCell();
        //        Paragraph p_footer = new Paragraph("Tổng Tiền: " + txTongTien.Text, text);
        //        p_footer.Alignment = Element.ALIGN_LEFT;
        //        cell_Footer.AddElement(p_footer);
        //        cell_Footer.Border = 0;
        //        footer.AddCell(cell_Footer);


        //        foreach (DataGridViewColumn column in dgt.Columns)
        //        {
        //            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
        //            cell.BackgroundColor = new BaseColor(240, 240, 240);
        //            pdfPTable.AddCell(cell);

        //        }
        //        foreach (DataGridViewRow row in dgt.Rows)
        //        {
        //            foreach (DataGridViewCell cell in row.Cells)
        //            {
        //                pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
        //            }
        //        }
        //        var savefileDialog = new SaveFileDialog();
        //        savefileDialog.Filter = "PDF (*.pdf)|*.pdf";
        //        savefileDialog.FileName = fileName;
        //        //   savefileDialog.DefaultExt = ".pdf";
        //        if (File.Exists(fileName))
        //        {
        //            File.Delete(fileName);
        //        }

        //        using (FileStream stream = new FileStream(savefileDialog.FileName, FileMode.Create))
        //        {
        //            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
        //            PdfWriter.GetInstance(pdfDoc, stream);
        //            pdfDoc.Open();
        //            pdfDoc.Add(inner);
        //            pdfDoc.Add(header);
        //            pdfDoc.Add(pdfPTable);
        //            pdfDoc.Add(footer);
        //            pdfDoc.Close();
        //            stream.Close();
        //        }
        //        Alert a = new Alert("Xuất thành công", AlertType.success);
        //        a.ShowDialog();
        //    }
        //    catch
        //    {
        //        Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
        //        a.ShowDialog();
        //    }


        //}    

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
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
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
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
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
                    string query = "Delete HDnhapBo where maHd='" + lbMaHd.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Xóa thành công.", AlertType.success);

                    a.ShowDialog();
                    LoadHoaDon();
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


                    string query = "Insert into HDNhapBo(maNcc,maNv,ngayLap,TongTien,trangThai,linkQr) values('" + cbNcc.SelectedValue + "','" + cbMaNv.SelectedValue + "',convert(nvarchar(30), getDate(), 20),'0','0',null)";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Thêm thành công.", AlertType.success);
                    a.ShowDialog();
                    LoadHoaDon();
                    panelInforHD.Enabled = false;
                    update();
                    lbMaHd.Text = "0";
                    lbMaHd.Visible = false;
                    label13.Visible = false;
                    dtgvHD.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                }
                else if (dem == 2)
                {
                    string query = "update HDnhapBo set maNCC='" + cbNcc.SelectedValue + "',maNv='" + cbMaNv.SelectedValue + "',ngayLap=N'" + dtpkNgayLap.Value + "' where maHd='" + lbMaHd.Text + "'";
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
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
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
            picQr.Image = null;
            dtgvHD.ClearSelection();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnL.Enabled = true;
            dtgvHD.Enabled = true;
            picQr.BackgroundImage = null;
            if (CaptureDevice.IsRunning)
                CaptureDevice.Stop();
        }

     
        private void btnHuyCT_Click(object sender, EventArgs e)
        {
           
        }

      

        private void dtgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvHD.Columns[e.ColumnIndex].Name == "chitiet")
            {
                this.Hide();
                FCTHDNhapBo fCTHDNhapBo = new FCTHDNhapBo(lbMaHd.Text, dtpkNgayLap.Text, cbMaNv.Text);
                fCTHDNhapBo.ShowDialog();
                this.Show();
                LoadHoaDon();
                update();
                lbMaHd.Text = "0";
                lbMaHd.Visible = false;
                label13.Visible = false;

                dtgvHD.ClearSelection();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnL.Enabled = true;
                picQr.BackgroundImage = null;
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

        private void FormHDNhapBo_Load(object sender, EventArgs e)
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

        private void FormHDNhapBo_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            if (CaptureDevice.IsRunning)
                CaptureDevice.Stop();
        }
    }
}
