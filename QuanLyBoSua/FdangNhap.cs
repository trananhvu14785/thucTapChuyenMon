using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBoSua
{
    public partial class FdangNhap : Form
    {
        public FdangNhap()
        {
            InitializeComponent();
            // txtTenDn.Text = "admin";
            //   txPass.Text = "123";
            panel3.Hide();
            gunaTransition1.Show(panel3);
        }
        //public string MaHoaMK(string password)
        //{
        //    byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
        //    byte[] hasdata = new MD5CryptoServiceProvider().ComputeHash(temp);
        //    string haspass = "";
        //    foreach (byte item in hasdata)
        //    {
        //        haspass += item;
        //    }
        //    return haspass;
        //}
        
      
        static string key { get; set; } = "A!9HHhi%XjjYY4YP2@Nob009X";
        public static string Encrypt(string text)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FDangKy dangKy = new FDangKy();
            dangKy.ShowDialog();
            this.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // string query = "select matKhau from account  where tenDn=N'" + txtTenDn.Text + "'";
            //// string query = "Update account set matkhau='" + Encrypt("123") + "'";
            // string mk="";
            // DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            // foreach (DataRow row in data.Rows)
            //     mk = row["matkhau"].ToString();
            // MessageBox.Show("Mat khau cua ban la:"+ Decrypt(mk));
            FQuenMK fqmk = new FQuenMK();
            this.Hide();
            fqmk.ShowDialog();
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FdangNhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txtTenDn.Text = Properties.Settings.Default.UserName;
                txPass.Text = Properties.Settings.Default.PassWord;
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (chbNhomk.Checked == true)
            {
                Properties.Settings.Default.UserName = txtTenDn.Text;
                Properties.Settings.Default.PassWord = txPass.Text;
                Properties.Settings.Default.Save();
            }
            else if (chbNhomk.Checked == false)
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.PassWord = "";
                Properties.Settings.Default.Save();
            }

            string querry = "Select * from account where tenDn='" + txtTenDn.Text + "' and matKhau='" + Encrypt(txPass.Text) + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            if (data.Rows.Count > 0)
            {
                Alert a = new Alert("Đăng nhập thành công.", AlertType.success);
                string maNv = "";
                foreach (DataRow item in data.Rows)
                {
                    maNv = item["maNv"].ToString();
                }

                a.ShowDialog();
                Fmain fm = new Fmain(maNv, txtTenDn.Text);
                this.Hide();
                fm.ShowDialog();
                this.Show();

            }
            else
            {
                Alert a = new Alert("Tên đăng nhập hoặc mật khẩu không đúng", AlertType.error);
                a.ShowDialog();
            }
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
