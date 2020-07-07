using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBoSua
{
    public partial class FGuiMailDoanhThu : Form
    {
        private string path;
        private string tungay;
        private string denngay;
        private string name;
        public FGuiMailDoanhThu( string Path,string TuNgay,string DenNgay, string Name)
        {
            InitializeComponent();
            this.path = Path;
            this.tungay = TuNgay;
            this.denngay = DenNgay;
            this.name = Name;
        }

        public string Path { get => path; set => path = value; }
        public string Tungay { get => tungay; set => tungay = value; }
        public string Denngay { get => denngay; set => denngay = value; }
        public string Name1 { get => name; set => name = value; }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (txMail.Text == "")
            {
                Alert a = new Alert("Hãy Nhập đị chỉ Email", AlertType.success);
                a.ShowDialog();
                
            }
            else
            {
                try
                {
                    SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                    mailclient.EnableSsl = true;
                    mailclient.Credentials = new NetworkCredential("trananhvu10121999@gmail.com", "01884767166");

                    MailMessage message = new MailMessage("trananhvu10121999@gmail.com", txMail.Text);
                    message.Subject = "BÁO CÁO " + Name1;
                    message.Body = "Gửi admin báo cáo "+Name1+" từ " + Tungay + " đến ngày " + Denngay;
                    message.Attachments.Add(new Attachment(Convert.ToString(Path)));

                    mailclient.Send(message);
                    message = null;
                    Alert a = new Alert("Mail đã được gửi đi!", AlertType.success);
                    a.ShowDialog();
                    this.Close();

                }
                catch
                {
                    Alert a = new Alert("Mail không hợp lệ hoặc lỗi kết nối!", AlertType.success);
                    a.ShowDialog();
                }
            }
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
