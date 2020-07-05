using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBoSua
{
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            try
            {
                string querry = "Select * from NhaCungCap";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                dgvNhaCungCap.DataSource = data;
                groupBox1.Enabled = false;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            tbMaNcc.text = dgvNhaCungCap.Rows[numrow].Cells[0].Value.ToString();
            tbTenNcc.text = dgvNhaCungCap.Rows[numrow].Cells[1].Value.ToString();
            tbDiaChi.text = dgvNhaCungCap.Rows[numrow].Cells[2].Value.ToString();
            tbSdt.text = dgvNhaCungCap.Rows[numrow].Cells[3].Value.ToString();
        }
        Boolean kiemTra(string maNcc)
        {
            string querry = "select * from NhaCungCap where maNcc = '" + maNcc + "'";
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
            tbMaNcc.text = "";
            tbTenNcc.text = "";
            tbDiaChi.text = "";
            tbSdt.text = "";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void tbTimKiem_OnTextChange(object sender, EventArgs e)
        {
            string tenncc = tbTimKiem.text;
            string querry = "select * from NhaCungCap where tenncc like N'%" + tenncc + "%'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvNhaCungCap.DataSource = data;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            dem = 1;
            groupBox1.Enabled = true;
            setNull();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
           
            if (tbMaNcc.text == "")
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
            string maNcc = tbMaNcc.text;
            if (maNcc == "")
            {
                Alert a = new Alert("Vui lòng chọn đối tượng muốn xóa!", AlertType.error);
                a.ShowDialog();

            }
            else
            {
                try
                {
                    string querry = "delete NhaCungCap where maNCC = '" + maNcc + "'";
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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dem == 1)
                {
                    groupBox1.Enabled = true;
                    string maNcc = tbMaNcc.text;
                    string tenNcc = tbTenNcc.text;
                    string diachi = tbDiaChi.text;
                    decimal sodienthoai = 123;
                    if ( tbTenNcc.text == "" || tbDiaChi.text == "" || tbSdt.text == "")
                    {
                        Alert a = new Alert("Vui lòng nhập đủ thông tin!", AlertType.info);
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
                            string querry = "insert into NhaCungCap(tenNCC,diachi,sodt) values (N'" + tenNcc + "',N'" + diachi + "','" + sodienthoai + "')";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            Alert a = new Alert("Thêm thành công", AlertType.success);
                            a.ShowDialog();
                            setNull();
                            LoadData();
                            dem = 0;
                            btnXoa.Enabled = true;
                            btnSua.Enabled = true;
                            btnThem.Enabled = true;
                            groupBox1.Enabled = false;
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
                    groupBox1.Enabled = true;
                    string maNcc = tbMaNcc.text;
                    string tenNcc = tbTenNcc.text;
                    string diachi = tbDiaChi.text;
                    decimal sdt = 0;
                    if (tbTenNcc.text == "")
                    {

                        Alert a = new Alert("Vui lòng chọn đối tượng muốn sửa!", AlertType.error);
                        a.ShowDialog();

                    }
                    else if (tbTenNcc.text == "" || tbDiaChi.text == "" || tbSdt.text == "")
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
                            string querry = "update NhaCungCap set tenNcc = N'" + tenNcc + "',diachi=N'" + diachi + "',sodt = '" + sdt + "' where maNcc = '" + maNcc + "'";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);

                            Alert a = new Alert("Sửa Thành Công!", AlertType.info);
                            a.ShowDialog();
                            btnXoa.Enabled = true;
                            btnSua.Enabled = true;
                            btnThem.Enabled = true;
                            setNull();
                            dem = 0;
                            LoadData();
                            groupBox1.Enabled = false;
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
            btnSua.Enabled = true;
            btnThem.Enabled = true;
        }

        private void quanLyBoSuaDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
