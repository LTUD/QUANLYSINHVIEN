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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        //Kết nối Cơ Sở Dữ Liệu SQL
        public SqlConnection getConnect()
        {
            return new SqlConnection
            ("Data Source=.;Initial Catalog=QuanLySinhVien;Integrated Security=True");
        }
        
        //Bắt lỗi trường Khóa Học
        private void txtKhoaHoc_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorKhoaHoc.SetError(txtKhoaHoc, "Bạn bắt buộc nhập vào Khóa học");
            else
                this.errorKhoaHoc.Clear();
        }

        //Bắt lỗi trường Địa Chỉ
        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorDiaChi.SetError(txtDiaChi, "Bạn bắt buộc nhập vào Địa chỉ");
            else
                this.errorDiaChi.Clear();
        }
        
        //Bắt lỗi trường Tên Sinh Viên
        private void txtTenSV_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorTenSV.SetError(txtTenSV, "Nhập trường tên SV");
            else
                this.errorTenSV.Clear();
        }

        //Chỉ nhập kí tự không nhập số cho trường Tên Sinh Viên
        private void txtTenSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chi nhap ki tu");
            }
        }

        //Bắt lỗi trường Nơi Sinh
        private void txtNoiSinh_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorNoiSinh.SetError(txtNoiSinh, "Nhập trường Nơi sinh");
            else
                this.errorNoiSinh.Clear();
        }
        //Bắt lỗi trường Mã Sinh Viên
        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorMaSV.SetError(txtMaSV, "Nhập trường mã sinh viên");
            else
                this.errorMaSV.Clear();
        }

        //Bắt lỗi trường Họ Sinh Viên
        private void txtHoSV_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorHoSV.SetError(txtTenSV, "Nhập trường Họ Sinh Viên");
            else
                this.errorHoSV.Clear();
        }

        //Chỉ nhập kí tự không nhập số cho trường Họ Sinh Viên
        private void txtHoSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chi nhap ki tu");
            }
        }
        
        //==============================================
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = getConnect();
            SqlDataAdapter ds = new SqlDataAdapter("SELECT MaSV, HoSV, " + 
                "TenSV, GioiTinh, NgaySinh, NoiSinh, DiaChi," + "MaKhoa, Lop, KhoaHoc From SinhVien", cnn);
            DataTable dt = new DataTable();
            ds.Fill(dt);
            dgvSinhVien.DataSource = dt;

            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        /// <summary>
        /// Button xử lý sự kiện click chuột để đưa dữ liệu vào các ô textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSV.Text = dgvSinhVien.Rows[dong].Cells[0].Value.ToString();
            txtHoSV.Text = dgvSinhVien.Rows[dong].Cells[1].Value.ToString();
            txtTenSV.Text = dgvSinhVien.Rows[dong].Cells[2].Value.ToString();
            txtGioiTinh.Text = dgvSinhVien.Rows[dong].Cells[3].Value.ToString();
            dateNgaySinh.Text = dgvSinhVien.Rows[dong].Cells[4].Value.ToString();
            txtNoiSinh.Text = dgvSinhVien.Rows[dong].Cells[5].Value.ToString();
            txtDiaChi.Text = dgvSinhVien.Rows[dong].Cells[6].Value.ToString();
            txtMaKhoa.Text = dgvSinhVien.Rows[dong].Cells[7].Value.ToString();
            txtLop.Text = dgvSinhVien.Rows[dong].Cells[8].Value.ToString();
            txtKhoaHoc.Text = dgvSinhVien.Rows[dong].Cells[9].Value.ToString();

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
        }

        /// <summary>
        /// Button Thêm dữ liệu vào bảng sinh viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        int flag;
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        /// <summary>
        /// Button Xóa Sinh Viên ra khỏi bảng Sinh Viên tại Mã Sinh Viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = getConnect();
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = System.String.Concat("delete from SinhVien " +
                    "Where MaSV= '" + txtMaSV.Text.ToString() + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                txtMaSV.ResetText();
                txtHoSV.ResetText();
                txtTenSV.ResetText();
                txtGioiTinh.ResetText();
                dateNgaySinh.ResetText();
                txtNoiSinh.ResetText();
                txtDiaChi.ResetText();
                txtMaKhoa.ResetText();
                txtLop.ResetText();
                txtKhoaHoc.ResetText();

                txtMaSV.Focus();

                frmSinhVien_Load(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu xóa ");
            }
            con.Close();


        }

        /// <summary>
        /// Button xử lý nút cập nhật dữ liệu vào bảng Sinh Viên tại Mã Sinh Viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtMaSV.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        /// <summary>
        /// Hủy bỏ sự kiện đang được xử lý
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSV.ResetText();
            txtHoSV.ResetText();
            txtTenSV.ResetText();
            txtGioiTinh.ResetText();
            dateNgaySinh.ResetText();
            txtNoiSinh.ResetText();
            txtDiaChi.ResetText();
            txtMaKhoa.ResetText();
            txtLop.ResetText();
            txtKhoaHoc.ResetText();
            txtMaSV.Focus();

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        /// <summary>
        /// Xử lý button lưu để thêm sinh viên vào bảng Sinh Viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                SqlConnection con = getConnect();
                con.Open();

                try
                {
               

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("INSERT INTO dbo.SinhVien " +
                        "VALUES('" + txtMaSV.Text.ToString() + "', " +
                        "'" + txtHoSV.Text.ToString() + "', " +
                        "'" + txtTenSV.Text.ToString() + "', " +
                        "'" + txtGioiTinh.Text.ToString() + "', " +
                        "'" + dateNgaySinh.Value.ToShortDateString() + "', " +
                        "'" + txtNoiSinh.Text.ToString() + "', " +
                        "'" + txtDiaChi.Text.ToString() + "', " +
                        "'" + txtMaKhoa.Text.ToString() + "', " +
                        "'" + txtLop.Text.ToString() + "', " +
                        "'" + txtKhoaHoc.Text.ToString() + "')");
                     

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    txtMaSV.ResetText();
                    txtHoSV.ResetText();
                    txtTenSV.ResetText();
                    txtGioiTinh.ResetText();
                    dateNgaySinh.ResetText();
                    txtNoiSinh.ResetText();
                    txtDiaChi.ResetText();
                    txtMaKhoa.ResetText();
                    txtLop.ResetText();
                    txtKhoaHoc.ResetText();

                    txtMaSV.Focus();

                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;

                    btnSua.Enabled = true;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;

                    frmSinhVien_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show(" Mã Sinh Viên đã có, Vui lòng nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            else if (flag == 1)
            {

                SqlConnection con = getConnect();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = System.String.Concat("update SinhVien " +
                    "set HoSV= '" + txtHoSV.Text.ToString() + "'," +
                    "TenSV= '" + txtTenSV.Text.ToString() + "'," +
                    "GioiTinh='" + txtGioiTinh.Text.ToString() + "'," +
                    "NgaySinh= '" + dateNgaySinh.Value.ToShortDateString() + "'," +
                    "NoiSinh= '" + txtNoiSinh.Text.ToString() + "'," +
                    "DiaChi= '" + txtDiaChi.Text.ToString() + "'," +
                    "MaKhoa= '" + txtMaKhoa.Text.ToString() + "'," +
                    "Lop= '" + txtLop.Text.ToString() + "'," +
                    "KhoaHoc= '" + txtKhoaHoc.Text.ToString() + "'," +
                    "where MaSV = '" + txtMaSV.Text.ToString() + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                txtMaSV.ResetText();
                txtHoSV.ResetText();
                txtTenSV.ResetText();
                txtGioiTinh.ResetText();
                dateNgaySinh.ResetText();
                txtNoiSinh.ResetText();
                txtDiaChi.ResetText();
                txtMaKhoa.ResetText();
                txtLop.ResetText();
                txtKhoaHoc.ResetText();

                txtMaSV.Focus();

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;

                frmSinhVien_Load(sender, e);
                con.Close();
            }
        }
        /// <summary>
        /// Xử lý button tải ảnh 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    ptrAnh.ImageLocation = imageLocation;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

              
    }  
}


