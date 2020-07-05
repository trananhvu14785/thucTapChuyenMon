using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBoSua
{
    public partial class FBaoCao : Form
    {
        public FBaoCao()
        {
            InitializeComponent();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FTyLeDanBo tile = new FTyLeDanBo();
            tile.ShowDialog();
            this.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDoanhThuBanSua f = new FDoanhThuBanSua();
            f.ShowDialog();
            this.Show();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDoanhThuBanBo fdtbb = new FDoanhThuBanBo();
            fdtbb.ShowDialog();
            this.Show();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FVonMuaBo fvmb = new FVonMuaBo();
            fvmb.ShowDialog();
            this.Show();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FVonMuaThuoc fvmt = new FVonMuaThuoc();
            fvmt.ShowDialog();
            this.Show();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuImageButton8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FBieuDo fBieu = new FBieuDo();
            fBieu.ShowDialog();
            this.Show();
        }
    }
}
