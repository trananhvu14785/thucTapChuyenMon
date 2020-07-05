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
    public partial class frmThuocVacXin : Form
    {
        public frmThuocVacXin()
        {
            InitializeComponent();
            LoadData();
            LoadCBBox();
        }

        void LoadData()
        {
            try
            {
                string querry = "Select * from ThuocVacxin";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                dgvThuoc.DataSource = data;
                groupBox1.Enabled = false;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        public void LoadCBBox()
        {
            string[] list = { "Chai", "Ống", "Vỉ", "Hộp", "Tuýp" };
            cbDVT.DataSource = list;
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            tbMaThuoc.text = dgvThuoc.Rows[numrow].Cells[0].Value.ToString();
            tbTenThuoc.text = dgvThuoc.Rows[numrow].Cells[1].Value.ToString();
            cbDVT.Text = dgvThuoc.Rows[numrow].Cells[2].Value.ToString();
            tbSoLuongCon.text = dgvThuoc.Rows[numrow].Cells[3].Value.ToString();
        }
        Boolean kiemTra(string tenThuoc)
        {
            string querry = "select * from ThuocVacxin where tenThuoc = N'" + tenThuoc + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            int dem = 0;
            foreach (DataRow item in data.Rows)
            {
                dem++;
            }
            if (dem > 0)
                return true;
            return false;
        }

        void setNull()
        {
            tbMaThuoc.text = "";
            tbTenThuoc.text = "";
            cbDVT.Text = "";
            tbSoLuongCon.text = "";
        }
        int dem;
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void tbTimKiem_OnTextChange(object sender, EventArgs e)
        {
            string tenthuoc = tbTimKiem.text;
            string querry = "select * from ThuocVacxin where tenthuoc like N'%" + tenthuoc + "%'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvThuoc.DataSource = data;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            dem = 1;
            groupBox1.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            setNull();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
           
            if (tbMaThuoc.text == "")
            {
                Alert a = new Alert("Vui lòng chọn dòng cần sửa!", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                dem = 2;
                groupBox1.Enabled = true;
                
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string mathuoc = tbMaThuoc.text;
            if (mathuoc == "")
            {
                Alert a = new Alert("Vui lòng chọn đối tượng muốn xóa!", AlertType.error);
                a.ShowDialog();

            }
            else
            {
                try
                {
                    string querry = "delete ThuocVacxin where maThuoc = '" + mathuoc + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    Alert a = new Alert("Xóa Thành Công!", AlertType.success);
                    a.ShowDialog();
                    setNull();
                    LoadData();
                    LoadCBBox();
                }
                catch
                {
                    Alert a = new Alert("Xóa thất bại!", AlertType.info);
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
                    string mathuoc = tbMaThuoc.text;
                    string tenthuoc = tbTenThuoc.text;
                    string dvt = cbDVT.Text;
                    decimal soluongcon = 0;
                    if ( tbTenThuoc.text == "" || cbDVT.Text == "" || tbSoLuongCon.text == "")
                    {
                        Alert a = new Alert("Vui lòng nhập đủ thông tin!", AlertType.info);
                        a.ShowDialog();
                    }
                    else if (kiemTra(tenthuoc) == true)
                    {
                        Alert a = new Alert("Tên thuốc đã tồn tại!", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        try
                        {
                            soluongcon = decimal.Parse(tbSoLuongCon.text);
                        }
                        catch
                        {

                            Alert a = new Alert("Số lượng nhập không hợp lệ!", AlertType.error);
                            a.ShowDialog();

                        }

                        try
                        {
                            string querry = "insert into ThuocVacXin(tenthuoc,donvitinh,slcon) values (N'" + tenthuoc + "',N'" + dvt + "','" + soluongcon + "')";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            Alert a = new Alert("Thêm thành công", AlertType.success);
                            a.ShowDialog();
                            setNull();
                            dem = 0;
                            btnXoa.Enabled = true;
                            btnThem.Enabled = true;
                            btnSua.Enabled = true;
                            LoadData();
                            LoadCBBox();
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
                    string mathuoc = tbMaThuoc.text;
                    string tenthuoc = tbTenThuoc.text;
                    string dvt = cbDVT.Text;
                    decimal soluongcon = 0;
                    if (tbTenThuoc.text == "")
                    {
                        Alert a = new Alert("Vui lòng chọn đối tượng muốn sửa!", AlertType.error);
                        a.ShowDialog();
                    }
                    else if ( tbTenThuoc.text == "" || cbDVT.Text == "" || tbSoLuongCon.text == "")
                    {
                        Alert a = new Alert("Vui lòng nhập đủ thông tin!", AlertType.error);
                        a.ShowDialog();
                    }
                    else if (kiemTra(tenthuoc) == true)
                    {
                        Alert a = new Alert("Tên thuốc đã tồn tại!", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        try
                        {
                            soluongcon = decimal.Parse(tbSoLuongCon.text);
                        }
                        catch
                        {
                            Alert a = new Alert("Số lượng nhập không hợp lệ!", AlertType.error);
                            a.ShowDialog();

                        }
                        try
                        {
                            string querry = "update ThuocVacxin set tenthuoc = N'" + tenthuoc + "',donvitinh = N'" + dvt + "',slcon = '" + soluongcon + "' where mathuoc = '" + mathuoc + "'";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            Alert a = new Alert("Sửa Thành Công!", AlertType.info);
                            a.ShowDialog();
                            setNull();
                            LoadData();
                            LoadCBBox();
                            dem = 0;
                            btnXoa.Enabled = true;
                            btnThem.Enabled = true;
                            btnSua.Enabled = true;
                            tbMaThuoc.Enabled = true;
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
            dem = 0;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
        }
    }
}
