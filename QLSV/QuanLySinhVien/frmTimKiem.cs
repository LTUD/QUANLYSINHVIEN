using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        //Khởi tạo lớp Database
        KetNoiDuLieu kn = new KetNoiDuLieu();

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            kn.myconnect();
            string sql = "SELECT * FROM SinhVien";
            cbMaSV.DataSource = kn.taobang(sql);
            cbMaSV.DisplayMember = "MaSV";
        }
        /// <summary>
        /// Xử lý button thoát khi người dùng ấn thoát sẽ trở về giao diện chính
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn quay lại trang chủ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
                this.Close();
            kn.myclose();
        }
        /// <summary>
        /// Xử lý button tìm kiếm khi người dùng chọn mã sinh viên và hiển thị ra datagridview thông tin tìm được
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string s = "SELECT * FROM SinhVien WHERE MaSV ='" + cbMaSV.Text + "'";
            DataTable d = kn.taobang(s);
            foreach (DataRow hang in d.Rows)
                txtHoSV.Text = hang["HoSV"].ToString();
            foreach (DataRow hang in d.Rows)
                txtTenSV.Text = hang["TenSV"].ToString();
            foreach (DataRow hang in d.Rows)
                txtGioiTinh.Text = hang["GioiTinh"].ToString();
            foreach (DataRow hang in d.Rows)
                dateNgaySinh.Text = hang["NgaySinh"].ToString();
            foreach (DataRow hang in d.Rows)
                txtNoiSinh.Text = hang["NoiSinh"].ToString();
            foreach (DataRow hang in d.Rows)
                txtDiaChi.Text = hang["DiaChi"].ToString();
            foreach (DataRow hang in d.Rows)
                txtMaKhoa.Text = hang["MaKhoa"].ToString();
            foreach (DataRow hang in d.Rows)
                txtLop.Text = hang["Lop"].ToString();
            foreach (DataRow hang in d.Rows)
                txtKhoaHoc.Text = hang["KhoaHoc"].ToString();

            string s1 = "SELECT * FROM SinhVien WHERE MaSV ='" + cbMaSV.Text + "'";
            dgvSinhVien.DataSource = kn.taobang(s1);
            kn.myclose();

        }       
    }
}
