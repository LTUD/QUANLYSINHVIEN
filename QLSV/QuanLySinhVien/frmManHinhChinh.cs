/*
 Nhóm bao gồm:
 * -Nguyễn Thị Như Quỳnh_MSSV:15211TT2596
 * -Trương Bảo Ni_MSSV: 15211TT1108
 * _Mai Thi Quanh_MSSV:1621TT1403
 * Đề tài: QUẢN LÝ SINH VIÊN
 * Màn hình chính: Hiện thị giao diện đầu tiên của ứng dụng bao gồm:
 * +Hình nền trường Cao đẳng công nghệ thủ đức
 * +Menu sổ xuống, bao gồm các chức năng:
 * 1.Quản trị: Đăng nhập và Đăng xuất
 * 2.Danh muc: Khoa, Sinh viên, Môn học, Kết quả
 * 3.Thoát
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLySinhVien
{
    public partial class frmManHinhChinh : Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
        }
        
        //Hộp thoại hỏi người dùng có muốn thoát khỏi ứng dụng hay không ?
        private void frmManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Tạo hộp thoại hỏi bằng DialogResult và Messagebox
            DialogResult d = MessageBox.Show("Bạn muốn thoát ứng dụng không ?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Nếu hộp thoại người dùng chọn No thì không thoát ứng dụng tương đương với chức năng Cancel, ngược lại là Yes thì thoát khỏi ứng dụng
            if (d == DialogResult.No)
                e.Cancel = true;
        }

        //Xử lý sự kiện Thoát khỏi ứng dụng bằng formclosing có hộp thoại hỏi
        private void toolsmiThoat_Click(object sender, EventArgs e)
        {
            //thoat khỏi ứng dụng
            this.Close();
        }
        
        //Xử lý sự kiện Đăng xuất khỏi tài khoản và tạo hộp thoại hỏi
        private void toolsmiDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn đăng xuất khỏi tài khoản hay không ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.No)//Nếu là No thì không đăng xuất, ngược lại là Yes thì đăng xuất tài khoản
                this.Close();
        }

        //Xử lý sự kiện Kết quả chuyển sang màn hình Kết quả
        private void toolsmiKetQua_Click(object sender, EventArgs e)
        {
            //Khởi tạo biến chứa màn hình kết quả
            frmKetQua f = new frmKetQua();
            f.Show();//hiển thị màn form Kết quả
        }

        

        private void toolsmiKhoa_Click(object sender, EventArgs e)
        {
            frmKhoa khoa = new frmKhoa();
            khoa.Show();
        }

        private void toolsmiMonHoc_Click(object sender, EventArgs e)
        {
            frmMonHoc monHoc = new frmMonHoc();
            monHoc.Show();
        }

        private void toolsmiSinhVien_Click(object sender, EventArgs e)
        {
            frmSinhVien sinhVien = new frmSinhVien();
            sinhVien.Show();
        }

        private void toolmsiDangNhap_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            user.Show();
        }

        public void EnableMenu()
        {
            toolsmiSinhVien.Enabled = true;
            toolsmiKhoa.Enabled = true;
            toolsmiMonHoc.Enabled = true;
            toolsmiKetQua.Enabled = true;
            TimKiemToolStripMenuItem.Enabled = true;
            
        }
        public void DisableMenu()
        {
            toolsmiSinhVien.Enabled = false;
            toolsmiKhoa.Enabled = false;
            toolsmiMonHoc.Enabled = false;
            toolsmiKetQua.Enabled = false;
            TimKiemToolStripMenuItem.Enabled = false;
        }

        private void TimKiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem search = new frmTimKiem();
            search.Show();
        }  
    }
}
