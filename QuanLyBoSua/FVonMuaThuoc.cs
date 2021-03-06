﻿using Microsoft.Reporting.WinForms;
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

namespace QuanLyBoSua
{
    public partial class FVonMuaThuoc : Form
    {
        public FVonMuaThuoc()
        {
            InitializeComponent();
           // this.Enabled = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int bien = 0;
        private void FVonMuaThuoc_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select H.maHD,N.tenNCC,H.maNv,H.ngayLap, PARSENAME(CONVERT(varchar, CAST(H.tongTien AS money), 1), 2)as tongTien from HoaDonNhapThuoc H,NhaCungCap N where H.maNCC=N.maNCC and H.ngayLap between N'" + dtpkTuNgay.Text + " 00:00:00' and N'" + dtpkDenNgay.Text + " 23:59:59'";
                string query1 = "select  PARSENAME(CONVERT(varchar, CAST(sum(tongTien) AS money), 1), 2)as thanhTien from HoaDonNhapThuoc where ngayLap between N'" + dtpkTuNgay.Text + " 00:00:00' and N'" + dtpkDenNgay.Text + " 23:59:59'";
                string query2 = "Select N'" + dtpkTuNgay.Text + "' as tuNgay ,N'" + dtpkDenNgay.Text + "' as denNgay";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                DataTable data1 = KetNoi.Istance.ExcuteQuerry(query1);
                DataTable data2 = KetNoi.Istance.ExcuteQuerry(query2);
                ReportDataSource rds = new ReportDataSource("DataSet1", data);
                ReportDataSource rds1 = new ReportDataSource("DataSet2", data1);
                ReportDataSource rds2 = new ReportDataSource("DataSet3", data2);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.DataSources.Add(rds1);
                reportViewer1.LocalReport.DataSources.Add(rds2);
                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
                bien = 1;
                //this.Enabled = false;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        string path="";
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                if (bien == 0)
                {
                    Alert a = new Alert("Hiện tại chưa có dữ liệu để xuất", AlertType.error);
                    a.ShowDialog();
                }
                else
                {
                    bool fileError = true;
                    try
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "PDF(*.pdf)|*.pdf";
                        saveFileDialog.FileName = "VonMuaThuoc.pdf";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            fileError = false;
                            if (File.Exists(saveFileDialog.FileName))
                            {
                                try
                                {
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
                            string deviceInfo =
                                   "<DeviceInfo>" +
                             "  <OutputFormat>EMF</OutputFormat>" +
                              "  <PageWidth>9in</PageWidth>" +
                               "  <PageHeight>6in</PageHeight>" +
                                 "  <MarginTop>0.25in</MarginTop>" +
                               "  <MarginLeft>0.25in</MarginLeft>" +
                                 "  <MarginRight>0.25in</MarginRight>" +
                                "  <MarginBottom>0.25in</MarginBottom>" +
                               "</DeviceInfo>";
                            byte[] bytes = reportViewer1.LocalReport.Render(
                          "PDF", deviceInfo);
                            FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create);

                            fs.Write(bytes, 0, bytes.Length);

                            fs.Close();
                            path = Convert.ToString(Path.GetFullPath(saveFileDialog.FileName));
                            Alert a = new Alert("Xuất thành công", AlertType.success);
                            a.ShowDialog();
                        }
                    }
                    catch
                    {
                        Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                        a.ShowDialog();
                    }
                }         
        }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }




        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
           

                if (path == "")
                {
                    Alert a = new Alert("Hãy Xuất file trước khi gửi!", AlertType.success);
                    a.ShowDialog();
                }
                else
                {
                    FGuiMailDoanhThu fGuiMailDoanhThu = new FGuiMailDoanhThu(path, dtpkTuNgay.Value.ToString(), dtpkDenNgay.Value.ToString(), "Vốn Mua Thuốc-Vắc Xin");
                    fGuiMailDoanhThu.ShowDialog();
                }
           
        }
    }
}

