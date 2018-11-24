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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }
        private void txtMaMon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaMon_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorMaMon.SetError(txtMaMon, "Nhập trường mã khoa");
            else
                this.errorMaMon.Clear();
        }
        private void txtTenMon_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorTenMon.SetError(txtTenMon, "Nhập trường mã khoa");
            else
                this.errorTenMon.Clear();
        }
        private void txtTenMon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chi nhap ki tu");
            }
        }
        private void txtTinChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTinChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số");
            }
        }

        



    }
}
