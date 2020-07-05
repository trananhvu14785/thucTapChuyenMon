using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoSua
{
    public class KetNoi
    {
        private static KetNoi instance;
        private string connStr = "Data Source=DESKTOP-PFHMF67;Initial Catalog=QuanLyBoSua;Persist Security Info=True;User ID=sa;Password=123";
        public static KetNoi Istance
        {
            get
            {
                if (instance == null)
                    instance = new KetNoi();
                return KetNoi.instance;
            }
            private set
            {
                KetNoi.instance = value;
            }
        }
        public DataTable ExcuteQuerry(string querry)
        {

            DataTable data = new DataTable();
            SqlConnection connect = new SqlConnection(connStr);
            connect.Open();
            SqlCommand command = new SqlCommand(querry, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connect.Close();
            return data;

        }
    }
}
