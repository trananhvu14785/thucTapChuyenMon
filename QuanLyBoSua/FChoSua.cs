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
    public partial class FChoSua : Form
    {
        private string maNv;
        public FChoSua(string maNv=null)
        {
            this.MaNv = maNv;
            InitializeComponent();
            loadNhanVien();
            loadBo();
            loadListLaySua();
        }
        void loadNhanVien()
        {
            try
            {
                string query = "select * from NhanVien";
                DataTable Data = KetNoi.Istance.ExcuteQuerry(query);
                cbMaNv.DataSource = Data;
                cbMaNv.DisplayMember = "maNv";
                cbMaNv.ValueMember = "maNv";
                cbMaNv.Text = "";
                if (MaNv != "")
                {
                    cbMaNv.Text = MaNv;
                    cbMaNv.Enabled = false;
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void loadBo()
        {
            try { 
            string query = "select * from DanBo,categoryBo where DanBo.idCategory=categoryBo.idCategory" +
                    " and DanBo.idCategory='3' and GioiTinh=N'Cái' and ngayXuatChuong is null";
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            cbMaBo.DataSource = data;
            cbMaBo.DisplayMember = "maBo";
            cbMaBo.ValueMember = "maBo";
                }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadListLaySua()
        {
            try
            {
                string query = "select maChoSua, IDBo,CONVERT(nvarchar(30),NgayLaySua,20)as NgayLaySua,soLuongSua, maNv from ChoSua";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvVatSua.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        int dem = 0;

        public string MaNv { get => maNv; set => maNv = value; }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dem = 1;
            panelVatsua.Enabled = true;
            txSoluong.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void dtgvVatSua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                lbmachosua.Text= dtgvVatSua.Rows[numrow].Cells[0].Value.ToString();
                cbMaBo.Text = dtgvVatSua.Rows[numrow].Cells[1].Value.ToString();
                DateTime dt = Convert.ToDateTime(dtgvVatSua.Rows[numrow].Cells[2].Value.ToString());
                dtpkNgayLay.Value = dt;
                txSoluong.Text= dtgvVatSua.Rows[numrow].Cells[3].Value.ToString();
                cbMaNv.Text= dtgvVatSua.Rows[numrow].Cells[4].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void txTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "select maChoSua, IDBo,CONVERT(nvarchar(30),NgayLaySua,20)as NgayLaySua,soLuongSua, maNv from ChoSua where idBo like N'%" + txTimKiem.Text + "%'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvVatSua.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void txSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (ch == 46 && txSoluong.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            dem = 1;
            panelVatsua.Enabled = true;
            txSoluong.ResetText();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (lbmachosua.Text == "0")
            {
                Alert a = new Alert("Hãy chọn bò cần sửa.", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                dem = 2;
                panelVatsua.Enabled = true;
                dtpkNgayLay.Enabled = true;
                cbMaBo.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (lbmachosua.Text == "0")
            {

                Alert a = new Alert("Hãy chọn bò cần xóa.", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                try
                {
                    string query = "Delete chosua where maChoSua='" + lbmachosua.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Xóa thành công.", AlertType.success);
                    a.ShowDialog();
                    loadListLaySua();
                    grbVatSua.Enabled = false;
                    txSoluong.ResetText();
                    lbmachosua.Text = "0";
                }
                catch
                {
                    Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                    a.ShowDialog();
                }
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dem == 1)
                {
                    if (txSoluong.Text == "")
                    {
                        Alert a = new Alert("Hãy nhập đủ thông tin.", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        string query = "Insert into ChoSua(IdBo,ngayLaySua,soLuongSua,maNv,maKho) values ('" + cbMaBo.Text + "',convert(nvarchar(30), getDate(), 20),'" + txSoluong.Text + "','" + cbMaNv.Text + "','kho1')";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert a = new Alert("Thêm thành công.", AlertType.success);
                        a.ShowDialog();
                        loadListLaySua();
                        panelVatsua.Enabled = false;
                        txSoluong.ResetText();
                        dem = 0;
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                }
                else if (dem == 2)
                {
                    if (txSoluong.Text == "")
                    {
                        Alert a = new Alert("Hãy nhập đủ thông tin.", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        string querry = "Update choSua set ngayLaySua=N'" + dtpkNgayLay.Value + "',soLuongsua='" + txSoluong.Text + "',maNv='" + cbMaNv.Text + "' where maChoSua='" + lbmachosua.Text + "'";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                        Alert a = new Alert("Sửa thành công.", AlertType.success);
                        a.ShowDialog();
                        loadListLaySua();
                        panelVatsua.Enabled = false;
                        txSoluong.ResetText();
                        cbMaBo.Enabled = true;
                        dtpkNgayLay.Enabled = false;
                        dem = 0;
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
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
            panelVatsua.Enabled = false;
            dtgvVatSua.ClearSelection();
            lbmachosua.Text = "0";
            txSoluong.ResetText();
            txTimKiem.ResetText();
            cbMaBo.Enabled = true;
            dtpkNgayLay.Enabled = false;
            loadListLaySua();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            dem = 0;
        }
    }
}
