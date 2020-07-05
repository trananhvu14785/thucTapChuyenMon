
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
    public partial class FCTHDNhapBo : Form
    {
        private string maHd;
        private string ngayLap;
        private string maNv;
        public FCTHDNhapBo(string mahd,string ngaylap,string manv)
        {
            this.maHd = mahd;
            this.ngayLap = ngaylap;
            this.maNv = manv;
            InitializeComponent();
            cbmaHD.Text = Mahd;
            LoadCTHD(Mahd);
            getTongTien();
            getTenCHuong();
            loadTrangThai();
            kiemTra(cbmaHD.Text);
            
        }
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice CaptureDevice;
        void kiemTra(string maHd)
        {
            string sql = "select * from HdNhapBo where trangThai='1' and maHd='" + maHd + "'";
            System.Data.DataTable data = KetNoi.Istance.ExcuteQuerry(sql);
            if(data.Rows.Count>0)
            {
                btnThemCT.Enabled = false;
                btnSuaCT.Enabled = false;
                btnXoaCT.Enabled = false;
                btnLuuCT.Enabled = false;
            }
        }
        string getQR()
        {
            string sql = "Select linkQr from HDNhapbo where maHd='" + cbmaHD.Text + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(sql);
            if (data.Rows.Count == 0)
                return "";
            else
            {
                DataRow row = data.Rows[0];
                return row["linkQr"].ToString();
            }
        }
        void LoadCTHD(string maHd)
        {
            string query = "";
            try
            {
                query = "select d.maBo,d.gioiTinh,d.trongLuong, d.idCategory,PARSENAME(CONVERT(varchar, CAST(cth.giaBoNhap AS money), 1), 2)as giaBoNhap,cth.LoaiNhap,d.MaChuong" +
                     " from HdNhapBo H,DanBo d, CTHDNhapBo cth,categoryBo C" +
                   " where H.maHD = cth.maHD and d.maBo = cth.maBo and C.idCategory = d.idCategory and cth.maHd = '" + maHd + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);

                data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvCTHD.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        private void dtgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        void createQR()
        {
            string fileName = @"E:\ThucTapChuyenMon\QR\HDNhapBo\" + cbmaHD.Text+".jpg";
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encoder.QRCodeScale = 6;
            Bitmap bitmap = encoder.Encode(cbmaHD.Text);          
            bitmap.Save(fileName, ImageFormat.Jpeg);
            string sql = "Update HdNhapBo set linkQr='" + fileName + "' where maHd='"+cbmaHD.Text+"'";
            KetNoi.Istance.ExcuteQuerry(sql);
        }
        void exFile(DataGridView data)
        {
            bool fileError = true;
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XLS(*.xls)|*.xls";
                saveFileDialog.FileName = "HoaDonNhapBo.xls";
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

                xlWorkSheet.Cells[7, 1] = "         Hóa Đơn Nhập Bò     ";
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
                string sql = "Update HDNhapBo set trangThai='1' where maHd='" + cbmaHD.Text + "'";
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
        void getTongTien()
        {
            string sql = "Select tongTien from HDNhapBo where maHd='" + cbmaHD.Text + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(sql);
            foreach (DataRow row in data.Rows)
            {
                var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                decimal tien = decimal.Parse(row["tongTien"].ToString());
                txTongTien.Text = String.Format(info, "{0:c}", tien);
              //  txTongTien.Text = 
            }

        }
        void loadTrangThai()
        {
            try
            {
                string query = "Select * from categoryBo";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                cbTrangThai.DataSource = data;
                cbTrangThai.DisplayMember = "categoryName";
                cbTrangThai.ValueMember = "idCategory";
            }
            catch { }
        }
        bool KiemTraMabo(string maBo)
        {
            try
            {
                string query = "Select * from danBo where maBo='" + maBo + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                if (data.Rows.Count > 0)
                    return false;
                return true;
            }
            catch
            {
                return true;
            }

        }
        void getTenCHuong()
        {
            try
            {
                string query = "Select * from ChuongTrai";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                cbTenChuong.DataSource = data;
                cbTenChuong.DisplayMember = "tenChuong";
                cbTenChuong.ValueMember = "maChuong";

            }
            catch { }
        }
        int bien = 0;

        public string Mahd { get => maHd; set => maHd = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public string MaNv { get => maNv; set => maNv = value; }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            bien = 1;
            txMaBo.ResetText();
            txTrongLuong.ResetText();
            txGiaNhap.ResetText();
            txMaBo.Focus();
            panelCTHD.Enabled = true;
            btnThemCT.Enabled = false;
            btnXoaCT.Enabled = false;
            btnSuaCT.Enabled = false;
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            bien = 2;
            panelCTHD.Enabled = true;
            txMaBo.ReadOnly = true;
            btnThemCT.Enabled = false;
            btnXoaCT.Enabled = false;
            btnSuaCT.Enabled = false;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txMaBo.Text != "" && KiemTraMabo(txMaBo.Text) || txMaBo.Text == "") == true)
                {
                    Alert a = new Alert("Hãy Chọn bò Cần Xóa", AlertType.error);
                    a.ShowDialog();
                }
                else
                {
                    string query = "Delete CTHDNhapBo where maBo='" + txMaBo.Text + "'";
                    string query1 = "Delete DanBo where maBo='" + txMaBo.Text + "'";

                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    DataTable data1 = KetNoi.Istance.ExcuteQuerry(query1);
                    Alert a = new Alert("Xóa thành công", AlertType.success);
                    setnull();
                    a.ShowDialog();
                    getTongTien();
                    LoadCTHD(cbmaHD.Text);
                   

                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void setnull()
        {
            txMaBo.ResetText();
            txTrongLuong.ResetText();
            txGiaNhap.ResetText();
            rdbCai.Checked = false;
            rdbDuc.Checked = false;
            panelCTHD.Enabled = false;
            dtgvCTHD.ClearSelection();
            btnThemCT.Enabled = true;
            btnXoaCT.Enabled = true;
            btnSuaCT.Enabled = true;
            txMaBo.ReadOnly = false;
            rdbtMua.Checked = false;
            rdbtThue.Checked = false;
            btnLuuCT.Enabled = true;
            kiemTra(cbmaHD.Text);
        }
        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            try
            {
                string gioitinh = "";
                if (rdbCai.Checked == true)
                    gioitinh = "Cái";
                else if (rdbDuc.Checked == true)
                    gioitinh = "Đực";
                if (bien == 1)
                {
                    if (txMaBo.Text == "" || txTrongLuong.Text == "" || txGiaNhap.Text == "" || (rdbCai.Checked == false && rdbDuc.Checked == false) || (rdbtThue.Checked == false && rdbtMua.Checked == false))
                    {
                        Alert a = new Alert("Bạn hãy nhập đủ thông tin", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        if (KiemTraMabo(txMaBo.Text) == false)
                        {
                            Alert a = new Alert("Mã bò đã tồn tại", AlertType.error);
                            a.ShowDialog();
                        }

                        else if (getTongSoCHo(cbTenChuong.Text) == demBo(cbTenChuong.SelectedValue.ToString()) )
                        {
                            Alert a = new Alert("Chuồng bạn chọn đã hết chỗ", AlertType.error);
                            a.ShowDialog();
                        }
                        else
                        {
                            string query = "";
                            string loaiNhap = "";

                            if (rdbtThue.Checked == true)
                            {
                                loaiNhap = "Thuê";
                             //   query = "Insert into DanBo values('" + txMaBo.Text + "',N'" + gioitinh + "','" + txTrongLuong.Text + "','" + cbTrangThai.SelectedValue + "',null,null,null)";
                            }
                            else
                            {
                                loaiNhap = "Mua";                              
                            }
                            query = "Insert into DanBo values('" + txMaBo.Text + "',N'" + gioitinh + "','" + txTrongLuong.Text + "','" + cbTrangThai.SelectedValue + "','" + cbTenChuong.SelectedValue + "',getDate(),null)";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                            string query1 = "Insert into CTHDNhapBo values('" + cbmaHD.Text + "','" + txMaBo.Text + "','" + txGiaNhap.Text + "',N'" + loaiNhap + "')";
                            DataTable data1 = KetNoi.Istance.ExcuteQuerry(query1);
                            Alert a = new Alert("Thêm thành công", AlertType.success);
                            a.ShowDialog();
                            setnull();
                            LoadCTHD(cbmaHD.Text.ToString());
                            getTongTien();
                            btnThemCT.Enabled = true;
                            btnXoaCT.Enabled = true;
                            btnSuaCT.Enabled = true;

                        }
                    }

                }
                if (bien == 2)
                {
                    if (txMaBo.Text == "" || txTrongLuong.Text == "" || txGiaNhap.Text == "" || (rdbCai.Checked == false && rdbDuc.Checked == false))
                    {
                        Alert a = new Alert("Bạn hãy nhập đủ thông tin", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        //if (getTongSoCHo(cbTenChuong.Text) == demBo(cbTenChuong.SelectedValue.ToString()))
                        //{
                        //    Alert a = new Alert("Chuồng bạn chọn đã hết chỗ", AlertType.error);
                        //    a.ShowDialog();
                        //}
                        //else 
                        if (cbTenChuong.Text != lbTenChuong.Text && getTongSoCHo(cbTenChuong.Text) == demBo(cbTenChuong.SelectedValue.ToString()) )
                        {
                            Alert a = new Alert("Chuồng bạn chọn đã hết chỗ", AlertType.error);
                            a.ShowDialog();
                        }

                        else
                        {
                            string query = "";
                            string loaiNhap = "";
                            if (rdbtMua.Checked == true)
                            {
                               
                                loaiNhap = "Mua";
                             //   query = "Update DanBo set gioiTinh=N'" + gioitinh + "',trongLuong='" + txTrongLuong.Text + "',idcategory='" + cbTrangThai.SelectedValue + "',maChuong='" + cbTenChuong.SelectedValue + "',ngayNhapChuong=getdate() where maBo='" + txMaBo.Text + "'";
                            }
                            else
                            {
                                loaiNhap = "Thuê";
                               
                            }
                            query = "Update DanBo set gioiTinh=N'" + gioitinh + "',trongLuong='" + txTrongLuong.Text + "',idcategory='" + cbTrangThai.SelectedValue + "',maChuong='" + cbTenChuong.SelectedValue + "',ngayNhapChuong=getdate() where maBo='" + txMaBo.Text + "'";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                          
                            string query1 = "Update CTHDNhapBo set giaBoNhap='" + txGiaNhap.Text + "',loaiNhap=N'" + loaiNhap + "' where maHd='" + cbmaHD.Text + "' and maBo='" + txMaBo.Text + "'";
                            DataTable data1 = KetNoi.Istance.ExcuteQuerry(query1);
                            Alert a = new Alert("Sửa thành công", AlertType.success);
                            setnull();
                            a.ShowDialog();
                            getTongTien();
                            LoadCTHD(cbmaHD.Text);                          
                            txMaBo.ReadOnly = false;
                            bien = 0;                        
                            btnThemCT.Enabled = true;
                            btnXoaCT.Enabled = true;
                            btnSuaCT.Enabled = true;
                        }
                    }
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        int demBo(string maChuong)
        {
            int sobo = 0;
            string query = "Select * from danBo where maCHuong='" + maChuong + "' and ngayXuatChuong is null";
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            foreach (DataRow item in data.Rows)
                sobo++;

            return sobo;
        }
        int getTongSoCHo(string tenChuong)
        {
            try
            {
                int tongcho = 0;
                string query = "Select * from chuongTrai where tenChuong=N'" + tenChuong + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                foreach (DataRow item in data.Rows)
                {
                    tongcho = int.Parse(item["tongsoCho"].ToString());
                }

                return tongcho;
            }
            catch
            {
                return 0;
            }
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            setnull();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            exFile(dtgvCTHD);
        }

        private void dtgvCTHD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {

                txMaBo.Text = dtgvCTHD.Rows[numrow].Cells[0].Value.ToString();
                string gioitinh = dtgvCTHD.Rows[numrow].Cells[1].Value.ToString();
                if (gioitinh == "Đực")
                    rdbDuc.Checked = true;
                else
                    rdbCai.Checked = true;
                txTrongLuong.Text = dtgvCTHD.Rows[numrow].Cells[2].Value.ToString();
                cbTrangThai.SelectedValue = dtgvCTHD.Rows[numrow].Cells[3].Value.ToString();
                string loaiNhap = dtgvCTHD.Rows[numrow].Cells[5].Value.ToString();
                if (loaiNhap == "Thuê")
                    rdbtThue.Checked = true;
                else
                    rdbtMua.Checked = true;
                string tenChuong = dtgvCTHD.Rows[numrow].Cells[6].Value.ToString();
                if (tenChuong != "")
                {
                    cbTenChuong.SelectedValue = dtgvCTHD.Rows[numrow].Cells[6].Value.ToString();
                    lbTenChuong.Text = cbTenChuong.Text;
                }
                txGiaNhap.Text = dtgvCTHD.Rows[numrow].Cells[4].Value.ToString();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FCTHDNhapBo_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            CaptureDevice = new VideoCaptureDevice(FilterInfoCollection[1].MonikerString);
        }

        private void txTrongLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txTrongLuong.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
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
