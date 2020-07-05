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
    public partial class FPhoiGiong : Form
    {
        private string maNv;
        public FPhoiGiong(string maNv=null)
        {
            this.maNv = maNv;
            InitializeComponent();
            loadBo();
            loadNhanVien();
            loadListPhoiGiong();
            lbMaPhoiGiong.Visible = false;
        }
        void loadBo()
        {
            try
            {
                string query = "Select * from danBo where gioiTinh=N'Cái' and ngayXuatChuong is null";
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
        void loadListPhoiGiong()
        {
            try
            {
                string query = "Select maPhoiGiong,maBo,CONVERT(nvarchar(30),ngayPhoi,20)as ngayPhoi,maNv from phoiGiong";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvPhoiGiong.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        private void dtgvPhoiGiong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                lbMaPhoiGiong.Text= dtgvPhoiGiong.Rows[numrow].Cells[0].Value.ToString();
                cbMaBo.Text = dtgvPhoiGiong.Rows[numrow].Cells[1].Value.ToString();
                DateTime dt = Convert.ToDateTime(dtgvPhoiGiong.Rows[numrow].Cells[2].Value.ToString());
                dtpkNgayPhoi.Value = dt;
                cbMaNv.Text= dtgvPhoiGiong.Rows[numrow].Cells[3].Value.ToString();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select maPhoiGiong,maBo,CONVERT(nvarchar(30),ngayPhoi,20)as ngayPhoi,maNv from phoiGiong where maBo like N'%" + txTimKiem.Text + "%' and ngayPhoi between N'" + dtpkTimKiem.Text + " 00:00:00' and N'"+dtpkTimKiem.Text+" 23:59:59'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvPhoiGiong.DataSource = data;
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
            panelPG.Enabled = true;
            dem = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            if (MaNv != "")
            {
                cbMaNv.Text = MaNv;
                cbMaNv.Enabled = false;
            }

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (lbMaPhoiGiong.Text == "")
            {
                Alert a = new Alert("Hãy chọn bò cần sửa.", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                dem = 2;
                cbMaBo.Enabled = false;
                dtpkNgayPhoi.Enabled = true;
                panelPG.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (lbMaPhoiGiong.Text == "")
                {
                    Alert a = new Alert("Hãy chọn bò cần xóa.", AlertType.error);
                    a.ShowDialog();
                }
                else
                {
                    string query = "Delete phoiGiong where maphoiGiong='" + lbMaPhoiGiong.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    Alert a = new Alert("Xóa thành công.", AlertType.success);
                    a.ShowDialog();
                    loadListPhoiGiong();
                    lbMaPhoiGiong.Text = "";
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
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
                        string query = "Insert into PhoiGiong(maBo,ngayPhoi,maNv) values('" + cbMaBo.Text + "',convert(nvarchar(30), getDate(), 20),'" + cbMaNv.Text + "')";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert a = new Alert("Thêm thành công.", AlertType.success);
                        a.ShowDialog();
                        loadListPhoiGiong();
                        panelPG.Enabled = false;
                        dem = 0;
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;

                    }
                    catch
                    {
                        Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                        a.ShowDialog();
                    }

                }
                else if (dem == 2)
                {
                    try
                    {
                        string query = "Update phoiGiong set ngayPhoi=N'" + dtpkNgayPhoi.Value + "',maNv='" + cbMaNv.Text + "' where maPhoiGiong='" + lbMaPhoiGiong.Text + "'";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        Alert a = new Alert("Sửa thành công.", AlertType.success);
                        a.ShowDialog();
                        loadListPhoiGiong();
                        cbMaBo.Enabled = true;
                        dtpkNgayPhoi.Enabled = false;
                        lbMaPhoiGiong.Text = "";
                        dem = 0;
                        panelPG.Enabled = false;
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                    catch
                    {
                        Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                        a.ShowDialog();
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
            dem = 0;
            dtgvPhoiGiong.ClearSelection();
            panelPG.Enabled = false;
            lbMaPhoiGiong.Text = "";
            cbMaBo.Enabled = true;
            dtpkNgayPhoi.Enabled = false;
            loadListPhoiGiong();
            txTimKiem.ResetText();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
