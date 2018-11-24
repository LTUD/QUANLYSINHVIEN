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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorTenDN.SetError(txtTenDangNhap, "Bạn bắt buộc nhập Tài khoản");
            else
                this.errorTenDN.Clear();
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy lựa chọn đúng người dùng");
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorMatKhau.SetError(txtMatKhau, "Bạn bắt buộc nhập Mật khẩu");
            else
                this.errorMatKhau.Clear();

            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn quay lại trang chủ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
                this.Close();
        }
    }
}
