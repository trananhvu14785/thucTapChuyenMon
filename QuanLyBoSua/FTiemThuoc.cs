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
    public partial class FTiemThuoc : Form
    {
        private string maNv;
        public FTiemThuoc(string maNv=null)
        {
            this.maNv = maNv;
            InitializeComponent();
            loadBo();
            LoadThuoc();
            loadNhanVien();
            loadListTiem();

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
        void LoadThuoc()
        {
            try
            {
                string querry = "Select * from ThuocVacXin";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                cbTenThuoc.DataSource = data;
                cbTenThuoc.DisplayMember = "tenThuoc";
                cbTenThuoc.ValueMember = "maThuoc";
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void loadListTiem()
        {
            try
            {
                string query = "Select maTiem,IdBo,tenThuoc,lieuLuongTiem,CONVERT(nvarchar(10),NgayTiem,23)as NgayTiem,maNv from TiemThuoc T,ThuocvacXin TX where T.maThuoc=TX.maThuoc";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvTiemThuoc.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void dtgvTiemThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                txMaTiem.Text = dtgvTiemThuoc.Rows[numrow].Cells[0].Value.ToString();
                cbMaBo.Text= dtgvTiemThuoc.Rows[numrow].Cells[1].Value.ToString();
                cbTenThuoc.Text= dtgvTiemThuoc.Rows[numrow].Cells[2].Value.ToString();
                txLieuLuong.Text= dtgvTiemThuoc.Rows[numrow].Cells[3].Value.ToString();
                DateTime dt = Convert.ToDateTime(dtgvTiemThuoc.Rows[numrow].Cells[4].Value.ToString());
                dtpkNgayTiem.Value = dt;
                cbMaNv.Text= dtgvTiemThuoc.Rows[numrow].Cells[5].Value.ToString();
            }
        }
       private int dem = 0;

        public string MaNv { get => maNv; set => maNv = value; }

        private void btnThem_Click(object sender, EventArgs e)
        {
           

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            
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
                string query = "Select maTiem,IdBo,tenThuoc,lieuLuongTiem,CONVERT(nvarchar(10),NgayTiem,23)as NgayTiem,maNv from TiemThuoc T,ThuocvacXin TX where T.maThuoc=TX.maThuoc and IdBo like N'%" + txTimKiem.Text + "%' and ngayTiem=N'" + dtpkTimKiem.Value + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvTiemThuoc.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            dem = 1;
            panelTT.Enabled = true;
            txLieuLuong.ResetText();
            txMaTiem.ResetText();
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (txMaTiem.Text == "")
            {

                Alert a = new Alert("Hãy chọn bò cần sửa.", AlertType.error);
                a.ShowDialog();

            }
            else
            {
                dem = 2;
                panelTT.Enabled = true;
                cbMaBo.Enabled = false;
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (txMaTiem.Text == "")
            {

                Alert a = new Alert("Hãy chọn bò cần Xóa.", AlertType.error);
                a.ShowDialog();

            }
            else
            {
                try
                {
                    string query = "Delete TiemThuoc where maTiem='" + txMaTiem.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Xóa thành công.", AlertType.success);
                    a.ShowDialog();
                    loadListTiem();
                    panelTT.Enabled = false;
                    txLieuLuong.ResetText();
                    txMaTiem.ResetText();
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
                        if (txLieuLuong.Text == "")
                        {
                            Alert a = new Alert("Hãy nhập đủ thông tin.", AlertType.error);
                            a.ShowDialog();
                        }
                        else
                        {
                            string query = "Insert into TiemThuoc(IdBo,MaThuoc,NgayTiem,lieuLuongTiem,MaNv) values('" + cbMaBo.Text + "','" + cbTenThuoc.SelectedValue + "',N'" + dtpkNgayTiem.Value + "',N'" + txLieuLuong.Text + "','" + cbMaNv.Text + "') ";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                            Alert a = new Alert("Thêm thành công.", AlertType.success);
                            a.ShowDialog();
                            loadListTiem();
                            panelTT.Enabled = false;
                            dem = 0;
                            txLieuLuong.ResetText();
                            btnSua.Enabled = true;
                            btnThem.Enabled = true;
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
                    if (txLieuLuong.Text == "")
                    {
                        Alert a = new Alert("Hãy nhập đủ thông tin.", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        string query = "Update tiemThuoc set maThuoc='" + cbTenThuoc.SelectedValue + "',ngayTiem=N'" + dtpkNgayTiem.Value + "',lieuLuongTiem=N'" + txLieuLuong.Text + "',maNv='" + cbMaNv.Text + "' where maTiem='" + txMaTiem.Text + "'";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert a = new Alert("Sửa thành công.", AlertType.success);
                        a.ShowDialog();
                        loadListTiem();
                        panelTT.Enabled = false;
                        dem = 0;
                        txLieuLuong.ResetText();
                        txMaTiem.ResetText();
                        cbMaBo.Enabled = true;
                        btnSua.Enabled = true;
                        btnThem.Enabled = true;
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
            panelTT.Enabled = false;
            txLieuLuong.ResetText();
            txMaTiem.ResetText();
            txTimKiem.ResetText();
            dtgvTiemThuoc.ClearSelection();
            dem = 0;
            loadListTiem();
            cbMaBo.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
