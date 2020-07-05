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
    public partial class frmChuongTrai : Form
    {
        public frmChuongTrai()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                string querry = "Select * from ChuongTrai where tenChuong is not null";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                dgvChuongTrai.DataSource = data;
                groupBox1.Enabled = false;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        int dem;
        private void btnThem_Click(object sender, EventArgs e)
        {
           
            //string maCh = tbMaChuong.text;
            
        }
        string tenChuongTrai = "";
        private void dgvChuongTrai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txmachuong.Text = dgvChuongTrai.Rows[numrow].Cells[0].Value.ToString();
            tbTenChuong.text = dgvChuongTrai.Rows[numrow].Cells[1].Value.ToString();
            tenChuongTrai = tbTenChuong.text;
            tbTongCho.text = dgvChuongTrai.Rows[numrow].Cells[2].Value.ToString();
          
            tbMaNv.text = dgvChuongTrai.Rows[numrow].Cells[4].Value.ToString();
        }
        bool kiemTra(string tenCh)
        {
            string querry = "select * from ChuongTrai where tenchuong = N'" + tenCh + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
           if(data.Rows.Count>0)
                return true;
            return false;
        }

        void setNull()
        {
            
            tbTenChuong.text = "";
            tbTongCho.text = "";
           
            tbMaNv.text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            
        }
        public void loadGridByKeyWord()
        {
           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadGridByKeyWord();
        }
        public int DemBo(string maChuong)
        {
            int i = 0;
            DataTable data = KetNoi.Istance.ExcuteQuerry("select * from DanBo where ngayXuatChuong is null  and machuong=N'" + maChuong + "'");
            foreach (DataRow item in data.Rows)
            {
                i++;
            }
            return i;
        }
       
        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void tbTimKiem_OnTextChange(object sender, EventArgs e)
        {
            string tenCh = tbTimKiem.text;
            string querry = "select * from ChuongTrai where tenchuong like N'%" + tenCh + "%'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvChuongTrai.DataSource = data;
        }

        private void frmChuongTrai_Load(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            setNull();
            dem = 1;
            groupBox1.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvChuongTrai.Enabled = false;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string tenCH = tbTenChuong.text;
            if (tenCH == "")
            {
                Alert a = new Alert("Vui lòng chọn đối tượng muốn xóa!", AlertType.error);
                a.ShowDialog();

            }
            else if (DemBo(txmachuong.Text) > 0)
            {
                Alert a = new Alert("Không thể xóa vì còn bò trong chuồng!", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                try
                {
                    string querry = "delete ChuongTrai where tenChuong = N'" + tenCH + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);

                    Alert a = new Alert("Xóa Thành Công!", AlertType.success);
                    a.ShowDialog();
                    setNull();
                    LoadData();
                }
                catch
                {

                    Alert a = new Alert("Xóa thất bại!", AlertType.info);
                    a.ShowDialog();

                }

            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
           
            if (tbMaNv.text == "")
            {
                Alert a = new Alert("Vui lòng chọn dòng cần sửa!", AlertType.info);
                a.ShowDialog();
            }
            else
            {
                dem = 2;
                groupBox1.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                dgvChuongTrai.Enabled = false;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dem == 1)
                {
                    string tenCh = tbTenChuong.text;
                    decimal tongCho = 0;

                    string manv = tbMaNv.text;
                    try
                    {
                        tongCho = decimal.Parse(tbTongCho.text);

                    }
                    catch
                    {
                        Alert a = new Alert("Tổng số chỗ hoặc số chỗ trống nhập không hợp lệ!", AlertType.error);
                        a.ShowDialog();
                        return;
                    }
                    if (tbTenChuong.text == "" || tbTongCho.text == "" || tbMaNv.text == "")
                    {
                        Alert a = new Alert("Vui lòng nhập đủ thông tin!", AlertType.info);
                        a.ShowDialog();
                    }
                    else if (kiemTra(tenCh) == true)
                    {
                        Alert a = new Alert("Tên chuồng đã tồn tại!", AlertType.error);
                        a.ShowDialog();
                    }

                    else
                    {
                        try
                        {
                            tongCho = decimal.Parse(tbTongCho.text);

                        }
                        catch
                        {
                            Alert a = new Alert("Tổng số chỗ hoặc số chỗ trống nhập không hợp lệ!", AlertType.error);
                            a.ShowDialog();
                        }
                        try
                        {
                            string querry = "insert into ChuongTrai(tenChuong,tongsocho,sochocontrong,manv) values (N'" + tenCh + "',N'" + tongCho + "','" + tongCho + "','" + manv + "')";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            Alert a = new Alert("Thêm thành công", AlertType.success);
                            a.ShowDialog();
                            setNull();
                            LoadData();
                            dem = 0;
                            btnThem.Enabled = true;
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                            dgvChuongTrai.Enabled = true;
                        }
                        catch
                        {
                            Alert a = new Alert("Thêm thất bại!", AlertType.info);
                            a.ShowDialog();
                        }
                    }
                }
                else if (dem == 2)
                {

                    string tenCh = tbTenChuong.text;
                    string tongCho = tbTongCho.text;

                    string manv = tbMaNv.text;

                    if (tbTenChuong.text == "")
                    {
                        Alert a = new Alert("Vui lòng chọn đối tượng muốn sửa!", AlertType.error);
                        a.ShowDialog();
                    }
                    else if (tbTenChuong.text == "" || tbTongCho.text == "" || tbMaNv.text == "")
                    {
                        Alert a = new Alert("Vui lòng nhập đủ thông tin!", AlertType.error);
                        a.ShowDialog();
                    }
                    else if (tbTenChuong.text != tenChuongTrai && kiemTra(tbTenChuong.text) == true)
                    {
                        Alert a = new Alert("Tên chuồng đã tồn tại!", AlertType.error);
                        a.ShowDialog();
                    }

                    else if (int.Parse(tongCho) < DemBo(txmachuong.Text))
                    {

                        Alert a = new Alert("Số bò trong chuồng phải ít hơn hoặc bằng \n tổng số chỗ!", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {

                        try
                        {

                            string querry = "update ChuongTrai set tenChuong = N'" + tenCh + "',tongsocho=N'" + tongCho + "',manv = '" + manv + "' where maChuong = N'" + txmachuong.Text + "'";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            Alert a = new Alert("Sửa Thành Công!", AlertType.success);
                            a.ShowDialog();
                            setNull();
                            LoadData();
                            dem = 0;
                            btnThem.Enabled = true;
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                            dgvChuongTrai.Enabled = true;
                        }
                        catch
                        {
                            Alert a = new Alert("Sửa Thất Bại!", AlertType.info);
                            a.ShowDialog();
                        }
                    }
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            setNull();
            LoadData();
            tbTimKiem.ResetText();
            dem = 0;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            dgvChuongTrai.Enabled = true;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
