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
    public partial class FdoiMatKhau : Form
    {
        private string maNhanVien;
        private string tenDangNhap;
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public FdoiMatKhau(string maNv = null, string tenDn = null)
        {
            this.maNhanVien = maNv;
            this.tenDangNhap = tenDn;
            InitializeComponent();
        }
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
        bool kiemTraMkCu(string pass)
        {
            try
            {
                string query = "select * from account where tenDn='" + TenDangNhap + "'and matKhau='" + Encrypt(pass) + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                if (data.Rows.Count > 0)
                    return true;
                return false;
            }
            catch {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
                return false;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           

        }

        private void FdoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
          
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txMkCu.Text == "" || txMkMoi.Text == "" || txNhapLaiMk.Text == "")
                {

                    Alert a = new Alert("Hãy nhập đầy đủ thông tin", AlertType.error);
                    a.ShowDialog();
                }
                else
                {

                    if (kiemTraMkCu(txMkCu.Text) == false)
                    {
                        Alert b = new Alert("Mật khẩu cũ không đúng", AlertType.error);
                        b.ShowDialog();
                    }
                    else
                    {
                        if (txMkMoi.Text != txNhapLaiMk.Text)
                        {
                            Alert d = new Alert("Mật khẩu nhập lại không đúng", AlertType.error);
                            d.ShowDialog();
                        }
                        else
                        {
                            string query = "Update account set matKhau='" + Encrypt(txMkMoi.Text) + "' where tenDn='" + TenDangNhap + "'";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                            Alert c = new Alert("Đổi mẩu thành công", AlertType.success);
                            c.ShowDialog();
                            txMkCu.ResetText();
                            txMkMoi.ResetText();
                            txNhapLaiMk.ResetText();
                            txMkCu.Focus();
                        }
                    }
                }
            }
            catch
            {
                Alert a = new Alert("Lỗi Kết Nối", AlertType.error);
                a.ShowDialog();
            }
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
