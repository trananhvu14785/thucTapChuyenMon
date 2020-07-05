using QuanLyBoSua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBoSua
{
    public partial class Fmain : Form
    {
        private string maNhanVien;
        private string tenDangNhap;
       
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        Thread thread;
        public Fmain(string maNv = null, string tenDn = null)
        {
            this.maNhanVien = maNv;
            this.tenDangNhap = tenDn;
           
            InitializeComponent();
            picAnh.Hide();
           
            timer3.Start();
            getAnh();
            ThreadStart ts = new ThreadStart(LoadImage);
             thread = new Thread(ts);
            thread.Start();
            lbmaNv.Text = MaNhanVien;
            enAble();
            PhanQuyen();           
            gunaTransition1.Show(picAnh);           
        }
        void enAble()
        {
            btnAdmin.Enabled = false;
            btnBaoCao.Enabled = false;
            btnCHuongTrai.Enabled = false;
            btnSucKhoe.Enabled = false;
            btnCt.Enabled = false;
            btHD.Enabled = false;
            btnBaoCao.Enabled = false;
            btnKH.Enabled = false;
            btnNhaCC.Enabled = false;
            btnThucAn.Enabled = false;
            btnThuoc.Enabled = false;
        }
        void getAnh()
        {
            string querry = "Select anh from nhanvien where maNv='" + MaNhanVien + "'";
            string img=null;
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            foreach(DataRow row in data.Rows)
            {
                img= row["anh"].ToString();               
             }
            if (img != null)
            {
                Bitmap bitmap = new Bitmap(img);
                ptUser.BackgroundImage = bitmap;
            }
            else
                ptUser.BackgroundImage = null;

        }
        string getLoaiTK()
        {
            string query = "Select loaiTk from account where tenDn=N'" + TenDangNhap + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            string a="";
            foreach(DataRow row in data.Rows)
            {
                a = row["loaiTk"].ToString();
            }
           
            return a;
        }
        
        void PhanQuyen()
        {
            if ( getLoaiTK() == "1")
            {
                btnAdmin.Enabled = true;
                btnBaoCao.Enabled = true;
                btnCHuongTrai.Enabled = true;
                btnCt.Enabled = true;
                btHD.Enabled = true;
                btnSucKhoe.Enabled = true;
                btnBaoCao.Enabled = true;
                btnKH.Enabled = true;
                btnNhaCC.Enabled = true;
                btnThucAn.Enabled = true;
                btnThuoc.Enabled = true;
            }
            else if(MaNhanVien=="" && getLoaiTK()=="2"){
                enAble();

            }
            else
            {
                string query = "select * from PhanViec where manv='" + MaNhanVien + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                foreach(DataRow row in data.Rows)
                {
                    if(row["tenCv"].ToString()== "Quản lý chuồng trại")
                    {
                        btnCHuongTrai.Enabled = true;
                        btnCt.Enabled = true;
                    }
                    else if(row["tenCv"].ToString()== "Quản lý hóa đơn")
                    {
                        btHD.Enabled = true;
                        btnBaoCao.Enabled = true;
                        btnNhaCC.Enabled = true;
                        btnKH.Enabled = true;
                    }
                    else if (row["tenCv"].ToString() == "Quản lý sức khỏe")
                    {
                        btnSucKhoe.Enabled = true;
                        btnThuoc.Enabled = true;
                        btnThucAn.Enabled = true;
                    }
                    else if (row["tenCv"].ToString() == "Admin")
                    {
                        btnAdmin.Enabled = true;
                        btnBaoCao.Enabled = true;
                        btnCHuongTrai.Enabled = true;
                        btnCt.Enabled = true;
                        btHD.Enabled = true;
                        btnSucKhoe.Enabled = true;
                        btnBaoCao.Enabled = true;
                        btnKH.Enabled = true;
                        btnNhaCC.Enabled = true;
                        btnThucAn.Enabled = true;
                        btnThuoc.Enabled = true;
                    }
                }
            }
        }
        void LoadImage()
        {
          
                picAnh.Image = Properties.Resources.panner1;
                picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
               
                //int index = DateTime.Now.Second % list.Count;
                while (true)
                {
                    picAnh.Image = Properties.Resources.panner1;
                
                    Thread.Sleep(3000);
                    picAnh.Image = Properties.Resources.panner2;
               
                Thread.Sleep(3000);                
                picAnh.Image = Properties.Resources.panner3;
               
                Thread.Sleep(3000);
                   picAnh.Image = Properties.Resources.panner4;
               
                Thread.Sleep(3000);
                }



           
        }
      
      
        //void showHdMenu(Panel meNu)
        //{
        //    if (meNu.Visible == false)
        //    {
        //       // HideMenu();
        //        meNu.Visible = true;
        //    }
        //    else
        //        meNu.Visible = false; 
        //}

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
            FormHDNhapBo dhdnb = new FormHDNhapBo(MaNhanVien);
            this.Hide();
            dhdnb.ShowDialog();
            this.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            FHdBanSua fhdbs = new FHdBanSua(MaNhanVien);
            this.Hide();
            fhdbs.ShowDialog();
            this.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
           
            FHdNhapThuoc dhdnt = new FHdNhapThuoc(MaNhanVien);
            this.Hide();
            dhdnt.ShowDialog();
            this.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            FHdBanBo dhdbb = new FHdBanBo(MaNhanVien);
            this.Hide();
            dhdbb.ShowDialog();
            this.Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            FTiemThuoc ftt = new FTiemThuoc(MaNhanVien);
            this.Hide();
            ftt.ShowDialog();
            this.Show();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            FChoSua fchosua = new FChoSua(MaNhanVien);
            this.Hide();
            fchosua.ShowDialog();
            this.Show();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            FKhauPhanAn fkpa = new FKhauPhanAn(MaNhanVien);
            this.Hide();
            fkpa.ShowDialog();
            this.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            thread.Abort();
            this.Close();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FdoiMatKhau fdmk = new FdoiMatKhau(MaNhanVien,TenDangNhap);
           
            fdmk.ShowDialog();
            this.Show();
        }

        private void Fmain_Load(object sender, EventArgs e)
        {

            panelMenuHoaDon.Size = panelMenuHoaDon.MinimumSize;
            panelMenuChamSoc.Size = panelMenuChamSoc.MinimumSize;
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            FChuongTrai fct = new FChuongTrai();
            this.Hide();
            fct.ShowDialog();
            this.Show();
        }
        bool iscollpase=true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (iscollpase)
            {

                btHD.Iconimage_right = Properties.Resources.Arrows_Up_4_icon;
                 panelMenuHoaDon.Height += 10;
                 if (panelMenuHoaDon.Size == panelMenuHoaDon.MaximumSize)
                  {
                           timer1.Stop();
                           iscollpase = false;

                    }
            }
            else
            {
                btHD.Iconimage_right = Properties.Resources.Arrows_Down_4_icon;

                panelMenuHoaDon.Height -= 10;
                if (panelMenuHoaDon.Size == panelMenuHoaDon.MinimumSize)
                {
                    timer1.Stop();
                    iscollpase = true;
                }
            }

        }
        private bool iscolpase2=true;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (iscolpase2)
            {
                btnSucKhoe.Iconimage_right = Properties.Resources.Arrows_Up_4_icon;
                panelMenuChamSoc.Height += 10;
                if (panelMenuChamSoc.Size == panelMenuChamSoc.MaximumSize)
                {
                    timer2.Stop();
                    iscolpase2 = false;
                }
            }
            else
            {
                btnSucKhoe.Iconimage_right = Properties.Resources.Arrows_Down_4_icon;

                panelMenuChamSoc.Height -= 10;
                if (panelMenuChamSoc.Size == panelMenuChamSoc.MinimumSize)
                {
                    timer2.Stop();
                    iscolpase2 = true;
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            FPhoiGiong fpg = new FPhoiGiong(MaNhanVien);
            this.Hide();
            fpg.ShowDialog();
            this.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string link = @"http://benrifarm.asia/#/";
            Process.Start(link);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string link = @"https://www.facebook.com/benrifarm/?__tn__=kC-R&eid=ARDVwOdYAaY1H6wutDuYxrFVTCwZU5h5A8altODdgVcO9S548xDYfQc9VtchL8CPU-DpTlLzh7bYlQpC&hc_ref=ARSb5o_dXbcvka3ltqWcrta5liawHmWvJeS6p6a1uPL16MfYkcsOLTBn2CzR3REIFQs&fref=nf";
            Process.Start(link);
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            FBaoCao fbc = new FBaoCao();
            this.Hide();
            fbc.ShowDialog();
            this.Show();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDanhMuc fdm = new FDanhMuc();
            fdm.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thread.Abort();
            this.Close();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            frmKhachHang khachHang = new frmKhachHang();
            this.Hide();
            khachHang.ShowDialog();
            this.Show();
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap fncc = new frmNhaCungCap();
            this.Hide();
            fncc.ShowDialog();
            this.Show();
        }

        private void btnCHuongTrai_Click(object sender, EventArgs e)
        {
            frmChuongTrai fct = new frmChuongTrai();
            this.Hide();
            fct.ShowDialog();
            this.Show();
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            frmThuocVacXin fthuoc = new frmThuocVacXin();
            this.Hide();
            fthuoc.ShowDialog();
            this.Show();
        }

        private void btnThucAn_Click(object sender, EventArgs e)
        {
            frmThucAn fta = new frmThucAn();
            this.Hide();
            fta.ShowDialog();
            this.Show();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            string time = "";
            if (hour < 10)
            {
                time += "0" + hour;

            }
            else
                time += hour;
            time += ":";
            if (min < 10)
                time += "0" + min;
            else
                time += min;
            time += ":";
            if (second < 10)
                time += "0" + second;
            else
                time += second;
            lbTime.Text = time;
        }
    }
}
