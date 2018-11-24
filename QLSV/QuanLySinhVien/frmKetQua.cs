/*Nhóm bao gồm:
 * -Nguyễn Thị Như Quỳnh_MSSV:15211TT2596
 * -Trương Bảo Ni_MSSV: 15211TT1108
 * _Mai Thi Quanh_MSSV:1621TT1403
 * Đề tài: QUẢN LÝ SINH VIÊN
 * Màn hình chính: Hiện thị giao diện Kết quả của ứng dụng bao gồm:
 * 1.Thuộc tính: MSSV, Mã MH, Họ và tên, Khoa, Lần thi, Điểm
 * 2.Chức năng: Đọc, Ghi, Thêm, Xóa, Sửa, Thoát
 * 3.Sử dụng database là sql
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmKetQua : Form
    {
        public frmKetQua()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Sự liện Thoát khỏi màn hình Kết quả và quay về màn hình chính
        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Hộp thoại hỏi bạn có muốn quay lại màn hình chính
            DialogResult d = MessageBox.Show("Thông báo", "Bạn có muốn quay lại màn hình chính hay không ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)//Nếu chọn Yes thì thoát khỏi form Kết quả và quay lại màn hình chính, ngược lại thì không thực hiện
            {
                //Khởi tạo biến chứa màn hình chính
                frmManHinhChinh f2 = new frmManHinhChinh();
                //hiển thị màn hình chính
                f2.Show();
                //thoát màn hình Kết quả
                this.Close();
            }

        }

        private void frmKetQua_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.epMSSV.SetError(txtMSSV, "Bạn bắt buộc nhập vào Mã sinh viên");
            else
                this.epMSSV.Clear();

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn quay lại màn hình chính ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMaMH_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.epMMH.SetError(txtMaMH, "Bạn bắt buộc nhập vào Mã môn học");
            else
                this.epMMH.Clear();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.epHoTen.SetError(txtHoTen, "Bạn bắt buộc nhập vào Họ và tên");
            else
                this.epHoTen.Clear();
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số");
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập ký tự");
            }

        }

        
    }
}
