using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyBoSua
{
    public partial class FChuongTrai : Form
    {
        public FChuongTrai()
        {
            InitializeComponent();
            loadChuong();
            getTenCHuong();
            loadTrangThai();

            Bunifu.Framework.UI.BunifuDragControl a = new Bunifu.Framework.UI.BunifuDragControl();
            a.TargetControl = this.paneltop;
            a.Vertical = true;

        }
        void loadChuong()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                string query = "Select * from ChuongTrai where tenCHuong is not null";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                foreach (DataRow item in data.Rows)
                {

                    Button bt = new Button() { Width = 105, Height = 90 };
                    bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    bt.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
                    bt.FlatAppearance.BorderSize = 2;
                    bt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
                    bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
                    bt.Text = item["tenChuong"] + "\n";
                    bt.Click += bt_Click;
                    bt.Tag = item["tenChuong"];
                    bt.Name = item["maChuong"].ToString();
                    bt.Cursor= Cursors.Hand;


                    if (item["soChoConTrong"].ToString() == "0")
                    {

                        bt.BackColor = Color.LightSteelBlue;
                        bt.ForeColor = Color.DarkRed;
                        bt.Image = Properties.Resources.Button_warning_icon;
                        bt.ImageAlign = System.Drawing.ContentAlignment.TopRight;
                    }
                    else
                    {

                        bt.BackColor = Color.White;
                    }


                    flowLayoutPanel1.Controls.Add(bt);
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }

        }
        void showBo(string id)
        {
            try
            {
                dtgvChuongTrai.Hide();
                string query = "select maBo, gioitinh, trongluong, CategoryBo.CategoryName,CONVERT(nvarchar(10), ngayNhapChuong, 23) as ngayNhapChuong from DanBo, CategoryBo where DanBo.idcategory = CategoryBo.idcategory  and ngayXuatChuong is null and MaChuong = '" + id + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dtgvChuongTrai.DataSource = data;
                gunaTransition1.Show(dtgvChuongTrai);
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void getTenCHuong()
        {
            try
            {
                string query = "Select * from ChuongTrai";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                cbTenChuong.DataSource = data;
                cbTenChuong.DisplayMember = "tenChuong";
                cbTenChuong.ValueMember = "maChuong";
                cbTenChuong.Text = "";
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        void loadTrangThai()
        {
            try
            {
                string query = "Select * from categoryBo";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                cbTrangThai.DataSource = data;
                cbTrangThai.DisplayMember = "categoryName";
                cbTrangThai.ValueMember = "idCategory";
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }

        
        private void bt_Click(object sender, EventArgs e)
        {
            try
            {
                string idChuong = (sender as System.Windows.Forms.Button).Name;
                showBo(idChuong);

                cbTenChuong.Text = (sender as System.Windows.Forms.Button).Tag.ToString();
                lbTenChuong.Text = idChuong;

                string querry = "Select * from ChuongTrai where maChuong='" + idChuong + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                foreach (DataRow row in data.Rows)
                {
                    lbTongSoCHo.Text = row["tongSoCho"].ToString();
                    lbtrong.Text = row["soChoConTrong"].ToString();
                }
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
           
        }
        string getTenChuongFromId(string maBo)
        {
            try
            {
                string tenchuong = "";
                string query = "select tenchuong from danBo,chuongTrai where danbo.machuong=chuongtrai.machuong and maBo='" + maBo + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                foreach (DataRow item in data.Rows)
                {
                    tenchuong = item["tenChuong"].ToString();
                }
                return tenchuong;
            }
            catch {
                return "";
            }
        }
        bool kiemTraThue(string maBo)
        {
            string sql = "Select * from CTHDNhapBo where maBo='" + maBo + "' and LoaiNhap=N'Thuê'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(sql);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }
        private void dtgvChuongTrai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                txMaBo.Text = dtgvChuongTrai.Rows[numrow].Cells[0].Value.ToString();
                
                string gioitinh = dtgvChuongTrai.Rows[numrow].Cells[1].Value.ToString();
                if (gioitinh == "Đực")
                    rdbDuc.Checked = true;
                else
                    rdbCai.Checked = true;
                txTrongLuong.Text= dtgvChuongTrai.Rows[numrow].Cells[2].Value.ToString();
                cbTrangThai.Text = dtgvChuongTrai.Rows[numrow].Cells[3].Value.ToString();
                //DateTime dt = Convert.ToDateTime(dtgvChuongTrai.Rows[numrow].Cells[4].Value.ToString());
                //dtpkNgayNhap.Value = dt;
                cbTenChuong.Text = getTenChuongFromId(txMaBo.Text);
                lbTenChuong.Text = cbTenChuong.SelectedValue.ToString();
                if (kiemTraThue(txMaBo.Text))
                    chbThue.Checked = true;
                else
                    chbThue.Checked = false;

            }

        }
        int getTongSoCHo(string tenChuong)
        {
            try
            {
                int tongcho = 0;
                string query = "Select * from chuongTrai where tenChuong=N'" + tenChuong + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                foreach (DataRow item in data.Rows)
                {
                    tongcho = int.Parse(item["tongsoCho"].ToString());
                }
                return tongcho;
            }
            catch {
                return 0;
            }
        }
        private int dem = 0;

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
                
                    
        }
        bool KiemTraMabo(string maBo)
        {
            try
            {
                string query = "Select * from danBo where maBo='" + maBo + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                if (data.Rows.Count > 0)
                    return false;
                return true;
            }
            catch
            {
                return true;
            }

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

        }
        int demBo(string maChuong)
        {
            int sobo =0;
            string query = "Select * from danBo where maCHuong='" + maChuong + "' and ngayXuatChuong is null and ngayNhapChuong is not null";
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            foreach(DataRow item in data.Rows)
                sobo++;
            return sobo;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void tbTK_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "select maBo, gioitinh, trongluong, CategoryBo.CategoryName,CONVERT(nvarchar(10), ngayNhapChuong, 23) as ngayNhapChuong from DanBo, CategoryBo where DanBo.idcategory = CategoryBo.idcategory and ngayXuatChuong is null and maBo like N'%" + txMaBoTk.Text + "%'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                getTenCHuong();
                dtgvChuongTrai.DataSource = data;
            }
            catch
            {
                Alert a = new Alert("Lỗi Kết nối", AlertType.error);
                a.ShowDialog();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txTrongLuong_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txTrongLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(ch==46 && txTrongLuong.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (lbTongSoCHo.Text == "0")
            {
                Alert a = new Alert("Vui Lòng Chọn Chuồng.", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                if (getTongSoCHo(cbTenChuong.Text) == dtgvChuongTrai.RowCount)
                {
                  
                    Alert a = new Alert("Hiện tại không còn chỗ trống trong Chuồng.", AlertType.error);
                    a.ShowDialog();
                }
                else
                {
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnThem.Enabled = false;
                    panelInfor.Enabled = true;
                    cbTenChuong.Enabled = false;
                    dtpkNgayNhap.Enabled = false;
                    dtgvChuongTrai.Enabled = false;
                    dem = 1;
                    txMaBo.ResetText();
                    txMaBoTk.ResetText();
                    txTrongLuong.ResetText();
                   
                }

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (lbTongSoCHo.Text == "0")
            {
                Alert a = new Alert("Vui Lòng Chọn Chuồng.", AlertType.error);
                a.ShowDialog();
            }
            else if (txMaBo.Text == "")
            {
                Alert a = new Alert("Vui Lòng Chọn Bò.", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                dem = 2;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                cbTenChuong.Enabled = true;
                panelInfor.Enabled = true;
                dtpkNgayNhap.Enabled = true;
                txMaBo.ReadOnly = true;
                dtgvChuongTrai.Enabled = false;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (lbTongSoCHo.Text == "0")
            {
                Alert a = new Alert("Vui Lòng Chọn Chuồng.", AlertType.error);
                a.ShowDialog();
            }
            else if (txMaBo.Text == "")
            {
                Alert a = new Alert("Vui Lòng Chọn Bò.", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                try
                {
                    string mabo = txMaBo.Text;


                    string machuong = cbTenChuong.SelectedValue.ToString();
                    string query = "Delete DanBo where maBo='" + mabo + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);

                    Alert a = new Alert("Xóa Thành Công.", AlertType.success);
                    a.ShowDialog();
                    loadChuong();
                    showBo(machuong);
                    lbtrong.Text = (getTongSoCHo(cbTenChuong.Text) - dtgvChuongTrai.RowCount).ToString();
                    txMaBo.ResetText();
                    txTrongLuong.ResetText();
                    panelInfor.Enabled = false;
                    txMaBo.ReadOnly = false;
                    dem = 0;
                }
                catch
                {
                    Alert a = new Alert("Lỗi Kết nối hoặc \n do mã bò có liên quan đến các bảng khác", AlertType.error);
                    a.ShowDialog();
                }
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            if (dem == 1)
            {
                try
                {
                    if (txMaBo.Text == "" || (rdbCai.Checked == false && rdbDuc.Checked == false) || txTrongLuong.Text == "")
                    {
                        Alert a = new Alert("Bạn hãy nhập đủ thông tin", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        string mabo = txMaBo.Text;
                        string gioitinh = "";
                        if (rdbCai.Checked == true)
                            gioitinh = "Cái";
                        else
                            gioitinh = "Đực";
                        string tl = txTrongLuong.Text;
                        string idcategory = cbTrangThai.SelectedValue.ToString();

                        string machuong = cbTenChuong.SelectedValue.ToString();
                        if (KiemTraMabo(mabo) == false)
                        {
                            Alert b = new Alert("Mã bò đã tồn tại", AlertType.error);
                            b.ShowDialog();
                        }
                        else
                        {

                            string query = "Insert into DanBo values('" + mabo + "',N'" + gioitinh + "','" + tl + "','" + idcategory + "','" + cbTenChuong.SelectedValue + "',getDate(),null)";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                            Alert a = new Alert("Thêm thành Công", AlertType.success);
                            a.ShowDialog();
                            txMaBo.ResetText();
                            txTrongLuong.ResetText();
                            panelInfor.Enabled = false;
                            dem = 0;
                            loadChuong();
                            showBo(machuong);
                            panelInfor.Enabled = false;
                            lbtrong.Text = (getTongSoCHo(cbTenChuong.Text) - dtgvChuongTrai.RowCount).ToString();
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                            btnThem.Enabled = true;
                            dtgvChuongTrai.Enabled = true;
                        }
                    }
                }
                catch
                {
                    Alert a = new Alert("Lỗi Kết Nối", AlertType.error);
                    a.ShowDialog();

                }

            }
            if (dem == 2)
            {
                if ((rdbCai.Checked == false && rdbDuc.Checked == false) || txTrongLuong.Text == "")
                {
                    Alert a = new Alert("Bạn hãy nhập đủ thông tin", AlertType.error);
                    a.ShowDialog();
                }
                else
                {
                    try
                    {
                        string mabo = txMaBo.Text;
                        string gioitinh = "";
                        if (rdbCai.Checked == true)
                            gioitinh = "Cái";
                        else
                            gioitinh = "Đực";
                        string tl = txTrongLuong.Text;
                        string idcategory = cbTrangThai.SelectedValue.ToString();

                        string machuong = cbTenChuong.Text;

                        if (machuong != lbTenChuong.Text && demBo(cbTenChuong.SelectedValue.ToString()) == getTongSoCHo(machuong))
                        {
                            Alert a = new Alert("Chuồng bạn chọn đã đủ chỗ", AlertType.error);
                            a.ShowDialog();
                        }
                        else
                        {
                            //MessageBox.Show(demBo(cbTenChuong.SelectedValue.ToString()) + " "+ getTongSoCHo(machuong));

                            string query = "Update DanBo set gioiTinh=N'" + gioitinh + "',trongLuong='" + tl + "',idcategory='" + idcategory + "',maChuong='" + cbTenChuong.SelectedValue + "',ngayNhapCHuong=N'" + dtpkNgayNhap.Value + "' where maBo='" + mabo + "'";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                            Alert a = new Alert("Sửa Thành Công", AlertType.success);
                            dem = 0;
                            a.ShowDialog();
                            panelInfor.Enabled = false;
                            txMaBo.ReadOnly = false;
                            dtpkNgayNhap.Enabled = true;
                            loadChuong();
                            showBo(cbTenChuong.SelectedValue.ToString());
                            txMaBo.ResetText();
                            lbTongSoCHo.Text= getTongSoCHo(cbTenChuong.Text.ToString()).ToString();
                            lbtrong.Text = (getTongSoCHo(cbTenChuong.Text)-dtgvChuongTrai.RowCount).ToString();
                            txTrongLuong.ResetText();
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                            btnThem.Enabled = true;
                            dtgvChuongTrai.Enabled = true;
                        }
                }
                    catch
                {
                    Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                    a.ShowDialog();
                }
            }
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            panelInfor.Enabled = false;
            txMaBo.ResetText();
            txTrongLuong.ResetText();
            dtgvChuongTrai.ClearSelection();
            loadTrangThai();
            txMaBoTk.Text = "";
            ((DataTable)dtgvChuongTrai.DataSource).Rows.Clear();
            getTenCHuong();
            dem = 0;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            chbThue.Checked = false;
            dtgvChuongTrai.Enabled = true;
        }
    }
}
