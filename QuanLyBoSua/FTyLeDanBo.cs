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
    public partial class FTyLeDanBo : Form
    {
        public FTyLeDanBo()
        {
            InitializeComponent();
            loadTyLe();
        }

        void loadTyLe()
        {
            try
            {
                double tong = 0;
                string query = "select count(*)as soLuong,CategoryName from DanBo,categoryBo where DanBo.idCategory=categoryBo.idCategory and ngayXuatChuong is  null and maChuong is not null  group by CategoryName ";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                foreach (DataRow item in data.Rows)
                {
                    tong = tong + int.Parse(item["soLuong"].ToString());


                }
                lbTong.Text = tong.ToString();
                foreach (DataRow item in data.Rows)
                {

                    chart1.Series["Series1"].Points.AddXY(item["CategoryName"], (double.Parse(item["soLuong"].ToString())) / tong);

                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
