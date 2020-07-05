using Microsoft.Reporting.WinForms;
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
    public partial class FDoanhThuBanBo : Form
    {
        public FDoanhThuBanBo()
        {
            InitializeComponent();
        }

        private void FDoanhThuBanBo_Load(object sender, EventArgs e)        {  }
        int bien = 0;
       
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select H.maHd,K.tenKH,H.ngayMua,H.maNV,H.thanhTien from HDBanBo H,KhachHang K where H.maKH=K.maKh and H.ngayMua between N'" + dtpkTuNgay.Value + "' and N'" + dtpkDenNgay.Value + "'";
                string query1 = "select sum(thanhTien) as thanhTien from HDBanBo where ngayMua between N'" + dtpkTuNgay.Text + " 00:00:00' and N'" + dtpkDenNgay.Text + " 23:59:59'";
                string query2 = "Select N'" + dtpkTuNgay.Value + "' as tuNgay ,N'" + dtpkDenNgay.Value + "' as denNgay";
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (bien == 0)
            {
                Alert a = new Alert("Hiện tại chưa có dữ liệu để xuất", AlertType.error);
                a.ShowDialog();
            }
            else
            { bool fileError = true;
                try
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PDF(*.pdf)|*.pdf";
                    saveFileDialog.FileName = "DoanhThuBanBo.pdf";
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
                    if (!fileError) {
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

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (bien == 0)
            {
                Alert a = new Alert("Hiện tại chưa có dữ liệu để xuất", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                
                string query = "select convert(nvarchar(30), ngayMua, 23)as ngayLap,sum(thanhTien)as tongTien from HDBanBo " +
                    "where ngayMua between N'" + dtpkTuNgay.Text+" 00:00:00' and N'"+dtpkDenNgay.Text+ " 23:59:59' group by convert(nvarchar(30), ngayMua, 23)";
                this.Hide();
                FBieuDo fbd = new FBieuDo(query);
                fbd.ShowDialog();
                this.Show();

            }
        }
        string path="";
        private void btnMail_Click(object sender, EventArgs e)
        {
            try
            {
                if (path == "")
                {
                    Alert b = new Alert("Hãy Xuất file trước khi gửi!", AlertType.success);
                    b.ShowDialog();
                }
                else
                {
                    SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                    mailclient.EnableSsl = true;
                    mailclient.Credentials = new NetworkCredential("hoanglaptrinh6399@gmail.com", "dinhhoang0603");

                    MailMessage message = new MailMessage("hoanglaptrinh6399@gmail.com", "trumpbaby6969@gmail.com");
                    message.Subject = "BÁO CÁO DOANH THU BÁN BÒ";
                    message.Body = "Gửi admin báo cáo doanh thu bán bò " + dtpkTuNgay.Value.ToString() + " đến ngày " + dtpkDenNgay.Value.ToString();
                    message.Attachments.Add(new Attachment(Convert.ToString(path)));

                    mailclient.Send(message);
                    message = null;
                    Alert a = new Alert("Mail đã được gửi đi!", AlertType.success);
                    a.ShowDialog();
                }
            }
            catch
            {
                Alert a = new Alert("Báo cáo chưa được gửi do lỗi mạng!", AlertType.info);
                a.ShowDialog();
            }
        }
    }
}
