using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyBoSua
{
    public partial class FBieuDo : Form
    {
        private string query;
      
        public FBieuDo(string queRy=null)
        {
            this.query = queRy;
           
            InitializeComponent();
            loadTyLe();
        }
        void loadTyLe()
        {
           
          
            try
            {
                if (Query == null)
                {

                    string querry1 = "select tien.c as N'Ngày Mua',sum(tien.a) as N'Tổng Tiền' from (select " +
                        "     MONTH(hs.ngayMua) as c,MONTH(hb.ngayMua) as b,sum(hb.thanhTien + hs.thanhTien) as a from HDBanSua hs,HDBanBo hb" +
                        " where YEAR(hs.ngayMua)= 2020 and YEAR(hb.ngayMua)= 2020" +
                        "     group by  MONTH(hs.ngayMua),MONTH(hb.ngayMua)) as tien group by tien.c";
                    string query2 = "select tien.b as N'Ngày Mua',sum(tien.a)as N'Tổng Tiền'  from (select " +
                        "MONTH(ht.ngayLap) as c,MONTH(hb.ngayLap) as b,sum(hb.tongTien + ht.tongTien)" +
                        " as a from HoaDonNhapThuoc ht,HDNhapBo hb group by  MONTH(ht.ngayLap),MONTH(hb.ngayLap))as tien " +
                        "group by tien.b";
                    chart1.Series["Vốn"].Enabled = true;


                    DataTable data1 = KetNoi.Istance.ExcuteQuerry(querry1);
                    foreach (DataRow row in data1.Rows)
                    {
                        chart1.Series["Doanh Thu"].Points.AddXY(row["Ngày Mua"], (Decimal.Parse(row["Tổng Tiền"].ToString())));
                       

                    }
                    DataTable data2 = KetNoi.Istance.ExcuteQuerry(query2);
                    foreach (DataRow row in data2.Rows)
                    {
                       
                        chart1.Series["Vốn"].Points.AddXY(row["Ngày Mua"], (Decimal.Parse(row["Tổng Tiền"].ToString())));


                    }
                 

                }
                else
                {
                    DataTable data = KetNoi.Istance.ExcuteQuerry(Query);
                    foreach (DataRow row in data.Rows)
                    {
                        chart1.Series["Doanh Thu"].Points.AddXY(row["ngayLap"], (Decimal.Parse(row["tongTien"].ToString())));
                        chart1.Series["Vốn"].Enabled = false;

                    }
                }
            }
            catch
            {

            }
        }

        public string Query { get => query; set => query = value; }
       

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
