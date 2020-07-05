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
    public partial class FKhauPhanAn : Form
    {
        private string maNv;
        public FKhauPhanAn(string maNv=null)
        {
            this.maNv = maNv;
            InitializeComponent();
            loadBo();
            LoadTenThucAn();
            LoadListKhauPhanAn();
        }
        void loadBo()
        {
            try
            {
                string query = "Select * from danBo where ngayXuatChuong is null";
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
        void LoadTenThucAn()
        {
            try
            {
                string query = "Select * from ThucAn";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                cbTenThucAn.DataSource = data;
                cbTenThucAn.DisplayMember = "tenThucAn";
                cbTenThucAn.ValueMember = "maThucAn";
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void LoadListKhauPhanAn()
        {
            try
            {
                string query = "select maKhauPhanAn,IdBo,tenThucAn,SoLuong,CONVERT(nvarchar(10),ngayAn,23)as ngayAn from KhauPhanAn K, ThucAn T where T.mathucAn=K.maThucAn";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvKPA.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void dtgvKPA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                txMaKp.Text= dtgvKPA.Rows[numrow].Cells[0].Value.ToString();
                cbMaBo.Text = dtgvKPA.Rows[numrow].Cells[1].Value.ToString();
                cbTenThucAn.Text= dtgvKPA.Rows[numrow].Cells[2].Value.ToString();
                numSoLuong.Value= int.Parse(dtgvKPA.Rows[numrow].Cells[3].Value.ToString());
                DateTime dt = Convert.ToDateTime(dtgvKPA.Rows[numrow].Cells[4].Value.ToString());
                dtpkNgayAn.Value = dt;
            }
        }

        int dem = 0;

        public string MaNv { get => maNv; set => maNv = value; }

        private void btnThem_Click(object sender, EventArgs e)
        {
           

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select maKhauPhanAn,IdBo,tenThucAn,SoLuong,CONVERT(nvarchar(10),ngayAn,23)as ngayAn from KhauPhanAn K, ThucAn T where T.mathucAn=K.maThucAn and IdBo like N'%" + txTimKiem.Text + "%' and ngayAn =N'" + dtpkTimKiem.Value + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvKPA.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            dem = 1;
            panelKPA.Enabled = true;
            numSoLuong.Value = 0;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (txMaKp.Text == "")
            {
                Alert a = new Alert("Hãy Chọn bò cần sửa.", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                dem = 2;
                panelKPA.Enabled = true;
                cbMaBo.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (txMaKp.Text == "")
            {
                Alert a = new Alert("Hãy Chọn bò cần Xóa.", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                try
                {
                    string query = "Delete KhauPhanAn where maKhauPhanAn='" + txMaKp.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Xóa thành công.", AlertType.success);
                    a.ShowDialog();
                    LoadListKhauPhanAn();
                    numSoLuong.Value = 0;
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
                    try
                    {
                        if (numSoLuong.Value == 0)
                        {
                            Alert a = new Alert("Hãy nhập đủ thông tin.", AlertType.error);
                            a.ShowDialog();
                        }
                        else
                        {
                            string query = "insert into KhauPhanAn(IdBo,MaThucAn,SoLuong,ngayAn) values('" + cbMaBo.Text + "','" + cbTenThucAn.SelectedValue + "','" + numSoLuong.Value + "',N'" + dtpkNgayAn.Value + "') ";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                            Alert a = new Alert("Thêm thành công.", AlertType.success);
                            a.ShowDialog();
                            LoadListKhauPhanAn();
                            dem = 0;
                            numSoLuong.Value = 0;
                            panelKPA.Enabled = false;
                            btnThem.Enabled = true;
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;

                        }
                    }
                    catch
                    {
                        Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                        a.ShowDialog();
                    }
                }
                else if (dem == 2)
                {
                    if (numSoLuong.Value == 0)
                    {
                        Alert a = new Alert("Hãy nhập đủ thông tin.", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        string query = "Update khauPhanAn set maThucAn='" + cbTenThucAn.SelectedValue + "',soLuong='" + numSoLuong.Value + "',ngayAn=N'" + dtpkNgayAn.Value + "' where maKhauPhanAn='" + txMaKp.Text + "'";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert a = new Alert("Sửa thành công.", AlertType.success);
                        a.ShowDialog();
                        LoadListKhauPhanAn();
                        dem = 0;
                        numSoLuong.Value = 0;
                        panelKPA.Enabled = false;
                        cbMaBo.Enabled = true;
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

            panelKPA.Enabled = false;
            numSoLuong.Value = 0;
            dtgvKPA.ClearSelection();
            LoadListKhauPhanAn();
            dem = 0;
            txMaKp.Text = "";
            txTimKiem.Text = "";
            cbMaBo.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
