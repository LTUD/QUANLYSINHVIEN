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
    public partial class frmDangNhapTC : Form
    {
        public frmDangNhapTC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xử lý button đăng nhập khi người dùng đăng nhập thành công 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDangNhapTC_Click_1(object sender, EventArgs e)
        {
            frmManHinhChinh manhinh = new frmManHinhChinh();
            manhinh.EnableMenu();
            manhinh.Show();
            this.Hide();
        }
    }
}
