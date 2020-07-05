using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;

namespace QuanLyBoSua
{
    public partial class FQuenMK : Form
    {
        public FQuenMK()
        {
            InitializeComponent();
        }
        static string key { get; set; } = "A!9HHhi%XjjYY4YP2@Nob009X";
        public static string Decrypt(string cipher)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(cipher);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            string querry1 = "select * from account where tendn = '" + txtTenDn.Text + "'";
            DataTable data1 = KetNoi.Istance.ExcuteQuerry(querry1);
            if (data1.Rows.Count == 0)
            {
                Alert a = new Alert("Tài khoản không tồn tại!", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                try
                {
                    string querry = "select email from NhanVien nv, account acc where acc.maNv = nv.MaNv and acc.tendn = '" + txtTenDn.Text + "'";
                    string email = "";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    foreach (DataRow row in data.Rows)
                        email = row["email"].ToString();
                    MessageBox.Show(email);
                    string query2 = "select matKhau from account  where tenDn=N'" + txtTenDn.Text + "'";
                    string mk = "";
                    DataTable data2 = KetNoi.Istance.ExcuteQuerry(query2);
                    foreach (DataRow row in data1.Rows)
                        mk = Decrypt(row["matkhau"].ToString());

                    SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
                    mailClient.EnableSsl = true;
                    mailClient.Credentials = new NetworkCredential("hoanglaptrinh6399@gmail.com", "dinhhoang0603");

                    MailMessage message = new MailMessage("hoanglaptrinh6399@gmail.com", email);
                    message.Subject = "Password tài khoản" + txtTenDn.Text + "đã quên mật khẩu";
                    message.Body = "Mật khẩu của tài khoản " + txtTenDn.Text + " là:" + "\n" + mk;

                    mailClient.Send(message);
                    message = null;
                    Alert a = new Alert(" Check Mail để nhận lại mật khẩu!", AlertType.success);
                    a.ShowDialog();
                }
                catch
                {
                    Alert a = new Alert("Báo cáo chưa được gửi do lỗi mạng!", AlertType.info);
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
