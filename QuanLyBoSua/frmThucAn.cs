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
    public partial class frmThucAn : Form
    {
        public frmThucAn()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            try
            {
                string querry = "select * from ThucAn";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                dgvThucAn.DataSource = data;
                groupBox1.Enabled = false;
            }
            catch
            {
                Alert a = new Alert("Dữ liệu không hợp lệ hoặc lỗi kết nối.", AlertType.error);
                a.ShowDialog();
            }
        }
        int dem=0;
        private void btnThem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void dgvThucAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            tbMaThucAn.text = dgvThucAn.Rows[numrow].Cells[0].Value.ToString();
            tbTenThucAn.text = dgvThucAn.Rows[numrow].Cells[1].Value.ToString();
        }
        Boolean kiemTra(string maThucAn)
        {
            string querry = "select * from ThucAn where mathucan = '" + maThucAn + "'";
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
            tbMaThucAn.text = "";
            tbTenThucAn.text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }
        public void LoadGridByKeyword()
        {
            
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadGridByKeyword();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void tbTimKiem_OnTextChange(object sender, EventArgs e)
        {
            string timkiem = tbTimKiem.text;
            string querry = "select * from ThucAn where tenthucan like N'%" + timkiem + "%'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvThucAn.DataSource = data;
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
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
          

            if (tbMaThucAn.text == "")
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
            string mathucan = tbMaThucAn.text;
            if (mathucan == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng muốn xóa!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string querry = "delete ThucAn where maThucAn = '" + mathucan + "'";
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
                    string mathucan = tbMaThucAn.text;
                    string tenthucan = tbTenThucAn.text;
                    if (tbMaThucAn.text == "" || tbTenThucAn.text == "")
                    {
                        Alert a = new Alert("Vui lòng nhập đủ thông tin!", AlertType.info);
                        a.ShowDialog();
                    }
                    else if (kiemTra(mathucan) == true)
                    {
                        Alert a = new Alert("Mã thức ăn đã tồn tại!", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        try
                        {
                            string querry = "insert into ThucAn values ('" + mathucan + "',N'" + tenthucan + "')";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            Alert a = new Alert("Thêm thành công", AlertType.success);
                            a.ShowDialog();
                            setNull();
                            LoadData();
                            dem = 0;
                            btnXoa.Enabled = true;
                            btnThem.Enabled = true;
                            btnSua.Enabled = true;
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
                    string mathucan = tbMaThucAn.text;
                    string tenthucan = tbTenThucAn.text;
                    if (tbTenThucAn.text == "")
                    {
                        Alert a = new Alert("Vui lòng chọn đối tượng muốn sửa!", AlertType.error);
                        a.ShowDialog();
                    }
                    else if (tbMaThucAn.text == "" || tbTenThucAn.text == "")
                    {
                        Alert a = new Alert("Vui lòng nhập đủ thông tin!", AlertType.error);
                        a.ShowDialog();
                    }
                    else
                    {
                        try
                        {
                            string querry = "update ThucAn set tenthucan = N'" + tenthucan + "' where mathucan = '" + mathucan + "' ";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            Alert a = new Alert("Sửa Thành Công!", AlertType.info);
                            a.ShowDialog();
                            setNull();
                            LoadData();
                            dem = 0;
                            btnXoa.Enabled = true;
                            btnThem.Enabled = true;
                            btnSua.Enabled = true;
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

        private void quanLyBoSuaDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
