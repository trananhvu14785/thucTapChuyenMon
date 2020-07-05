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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            try
            {
                string querry = "select * from KhachHang";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                dgvKhachHang.DataSource = data;
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


        }

        Boolean kiemTra(string maKH)
        {
            string querry = "select * from KhachHang where maKH = '" + maKH + "'";
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
            tbMaKH.text = "";
            tbTenKH.text = "";
            tbEmail.text = "";
            tbSdt.text = "";
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            tbMaKH.text = dgvKhachHang.Rows[numrow].Cells[0].Value.ToString();
            tbTenKH.text = dgvKhachHang.Rows[numrow].Cells[1].Value.ToString();
            tbEmail.text = dgvKhachHang.Rows[numrow].Cells[2].Value.ToString();
            tbSdt.text = dgvKhachHang.Rows[numrow].Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           

        }
     
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void tbTimKiem_OnTextChange(object sender, EventArgs e)
        {
            string tenkh = tbTimKiem.text;
            string querry = "select * from khachhang where tenkh like N'%" + tenkh + "%'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvKhachHang.DataSource = data;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {

            dem = 1;
            tbMaKH.Enabled = false;
            groupBox1.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnthem.Enabled = false;
            setNull();
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            string maKH = tbMaKH.text;
            if (maKH == "")
            {
                Alert a = new Alert("Vui lòng chọn đối tượng muốn xóa!", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                try
                {
                    string querry = "delete KhachHang where maKH = '" + maKH + "'";
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

            if (tbMaKH.text == "")
            {
                Alert a = new Alert("Vui lòng chọn dòng cần sửa!", AlertType.error);
                a.ShowDialog();
            }
            else
            {
                dem = 2;
                groupBox1.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnthem.Enabled = false;
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dem == 1)
                {

                    string maKh = tbMaKH.text;
                    string tenkh = tbTenKH.text;
                    string email = tbEmail.text;
                    decimal sodienthoai = 0;
                    if (tbTenKH.text == "" || tbEmail.text == "" || tbSdt.text == "")
                    {
                        Alert a = new Alert("Vui lòng nhập đủ thông tin!", AlertType.info);
                        a.ShowDialog();
                    }
                    else if (kiemTra(maKh) == true)
                    {
                        Alert a = new Alert("Mã khách hàng đã tồn tại!", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        try
                        {
                            sodienthoai = decimal.Parse(tbSdt.text);
                        }
                        catch
                        {
                            Alert a = new Alert("Số điện thoại nhập không hợp lệ!", AlertType.error);
                            a.ShowDialog();

                        }

                        try
                        {
                            string querry = "insert into KhachHang(tenKh,email,sodt) values (N'" + tenkh + "',N'" + email + "','" + sodienthoai + "')";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            Alert a = new Alert("Thêm thành công", AlertType.success);
                            a.ShowDialog();
                            setNull();
                            dem = 0;
                            LoadData();
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                            btnthem.Enabled = true;

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
                    string maKH = tbMaKH.text;
                    string tenKH = tbTenKH.text;
                    string email = tbEmail.text;
                    decimal sdt = 0;
                    if (tbTenKH.text == "")
                    {
                        Alert a = new Alert("Vui lòng chọn đối tượng muốn sửa!", AlertType.error);
                        a.ShowDialog();
                    }
                    else if (tbMaKH.text == "" || tbTenKH.text == "" || tbEmail.text == "" || tbSdt.text == "")
                    {
                        Alert a = new Alert("Vui lòng nhập đủ thông tin!", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        try
                        {
                            sdt = decimal.Parse(tbSdt.text);
                        }
                        catch
                        {
                            Alert a = new Alert("Số điện thoại nhập không hợp lệ!", AlertType.error);
                            a.ShowDialog();

                        }
                        try
                        {
                            string querry = "update KhachHang set tenKh = N'" + tenKH + "',email = N'" + email + "',sodt = '" + sdt + "' where maKh = '" + maKH + "'";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            Alert a = new Alert("Sửa Thành Công!", AlertType.info);
                            a.ShowDialog();
                            setNull();
                            dem = 0;
                            LoadData();
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                            btnthem.Enabled = true;
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
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnthem.Enabled = true;
            groupBox1.Enabled = false;
            setNull();
            dem = 0;
            dgvKhachHang.ClearSelection();
        }
    }
}
