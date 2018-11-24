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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMaKhoa_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorMaKhoa.SetError(txtMaKhoa, "Nhập trường mã khoa");
            else
                this.errorMaKhoa.Clear();

        }

        private void txtTenKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKhoa_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorTenKhoa.SetError(txtTenKhoa, "Nhập trường tên khoa");
            else
                this.errorTenKhoa.Clear();

        }

        private void txtTenKhoa_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chi nhap ki tu");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn quay lại trang chủ","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
                this.Close();
        }
    }
}
