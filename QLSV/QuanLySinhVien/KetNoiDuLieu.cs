using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    class KetNoiDuLieu
    {
        //Khởi tạo kết nối tới cơ sở dữ liệu
        public SqlConnection cnn = new SqlConnection
        ("Data Source=.;Initial Catalog=QLSV;Integrated Security=True");

        public void myconnect()
        {
            //Mở kết nối
            cnn.Open();
        }

        public void myclose()
        {
            //Đóng kết nối
            cnn.Close();
        }

        //Phương thức lấy danh sách sinh viên có trên cơ sở dữ liệu
        public DataTable taobang(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, cnn);
            ds.Fill(dt);
            return (dt);
        }
    }
}
