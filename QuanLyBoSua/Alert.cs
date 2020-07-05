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
    public partial class Alert : Form
    {
        public Alert(string mess,AlertType type)
        {
            InitializeComponent();
            lbMess.Text = mess;

            switch (type)
            {
                case AlertType.success :
                    this.BackColor = Color.Yellow;
                    ptbIcon.BackgroundImage = imageList1.Images[0];
                     
                    break;
                case AlertType.info:
                    this.BackColor = Color.Yellow;
                    ptbIcon.BackgroundImage = imageList1.Images[1];
                    break;
                case AlertType.warning:
                    this.BackColor = Color.Yellow;
                    ptbIcon.BackgroundImage = imageList1.Images[2];
                    break;
                case AlertType.error:
                    this.BackColor = Color.Yellow;
                    ptbIcon.BackgroundImage = imageList1.Images[3];
                    break;

            }
        }

        private void Alert_Load(object sender, EventArgs e)
        {
          

        }

        private void timeOut_Tick(object sender, EventArgs e)
        {
         
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();//close.Start();
        }

        private void close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
                this.Opacity--;
            else
                this.Close();
        }

        private void TimeOut_Tick_1(object sender, EventArgs e)
        {
          
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public enum AlertType
    {
        success,info,warning,error
    }
}
