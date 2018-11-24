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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void txtkh_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorKhoaHoc.SetError(txtkh, "Bạn bắt buộc nhập vào Khóa học");
            else
                this.errorKhoaHoc.Clear();
        }

        private void cmbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbMaKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void cbxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbxLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorDiaChi.SetError(txtDiaChi, "Bạn bắt buộc nhập vào Địa chỉ");
            else
                this.errorDiaChi.Clear();
        }

        private void txtTenSV_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorHoTenSV.SetError(txtHoTenSV, "Nhập trường tên sinh viên");
            else
                this.errorHoTenSV.Clear();
        }


        private void txtNoiSinh_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void txtHoTenSV_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorHoTenSV.SetError(txtHoTenSV, "Nhập trường Họ tên SV");
            else
                this.errorHoTenSV.Clear();
        }

        private void txtHoTenSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chi nhap ki tu");
            }
        }

        private void txtnois_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorNoiSinh.SetError(txtnois, "Nhập trường Nơi sinh");
            else
                this.errorNoiSinh.Clear();
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorMaSV.SetError(txtMaSV, "Nhập trường mã sinh viên");
            else
                this.errorMaSV.Clear();
        }

        private void dateNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy chọn giới tính của bạn");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn quay lại trang chủ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
                this.Close();
        }

        
    }
}
