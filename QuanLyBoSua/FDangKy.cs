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
    public partial class FDangKy : Form
    {
        private string manv = null;
        public FDangKy(string maNv=null)
        {
            this.manv = maNv;
            InitializeComponent();
            if (Manv != null)
            {
                txmaNv.Text = Manv;
                txmaNv.Enabled = false;
                txmaNv.ForeColor = Color.Red;
            }
        }

        public string Manv { get => manv; set => manv = value; }

        private void FDangKy_Load(object sender, EventArgs e)
        {

        }
        bool kiemtraTenTK(string tenDn)
        {
            string query = "select * from account where tenDn=N'" + tenDn + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            return data.Rows.Count > 0;
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
        bool kiemtraMaNv(string maNv)
        {
            string query = "Select * from nhanVien where maNv='" + maNv + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }
        bool kiemtraTkTonTai(string maNv)
        {
            string query = "Select * from account where maNv='" + maNv + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtTenDn.Text == "" || txrepass.Text == "" || txPass.Text == "")
            {
                Alert a = new Alert("Hãy nhập đủ thông tin.", AlertType.error);
                a.Show();
            }
            else if (kiemtraMaNv(txmaNv.Text) == false)
            {
                Alert a = new Alert("Mã nhân viên không tồn tại.", AlertType.error);
                a.Show();
            }
            else if (kiemtraTkTonTai(txmaNv.Text) == true)
            {
                Alert a = new Alert("Mỗi nhân viên chỉ có một tài khoản.", AlertType.error);
                a.Show();
            }
            else if (kiemtraTenTK(txtTenDn.Text))
            {
                Alert a = new Alert("Tên Tài khoản đã tồn tại.", AlertType.error);
                a.Show();
            }
            else if(txPass.Text!=txrepass.Text)
            {
                Alert a = new Alert("Mật khẩu nhập lại không đúng.", AlertType.error);
                a.Show();
            }
           
            else
            {
                string query;
                if (Manv == null)
                    query = "Insert into account values(N'" + txtTenDn.Text + "',N'" + Encrypt(txPass.Text) + "','2','"+txmaNv.Text+"')";
                else
                    query = "Insert into account values(N'" + txtTenDn.Text + "',N'" + Encrypt(txPass.Text) + "','2','" + Manv + "')";

                DataTable data = KetNoi.Istance.ExcuteQuerry(query);

                Alert a = new Alert("Đăng kí thành công.", AlertType.success);
                a.Show();
                txPass.ResetText();
                txrepass.ResetText();
                txtTenDn.ResetText();
            }
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
