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
    public partial class frmDangNhapTB : Form
    {
        public frmDangNhapTB()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Xử lý thời gian khi đăng nhập thất bại quá 3 lần
        /// </summary>
        int i, n;
        private void timer1_Tick(object sender, EventArgs e)
        {
            prgTime.Maximum = n;
            i--;
            this.lblDem.Text = " Thời gian còn lại " + i.ToString() + " Giây ";

            if (i >= 0)
            {
                prgTime.Value = i;
            }

            if (i < 0)
            {
                this.timer1.Enabled = false;
                frmUser user = new frmUser();
                user.Show();
                this.Hide();
            }
        }
        /// <summary>
        /// Xử lý button đăng nhập thất bại
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DangNhapTB_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            i = 100;
            n = i;
        
        }
    }
}

