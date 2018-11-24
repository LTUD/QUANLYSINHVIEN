namespace QuanLySinhVien
{
    partial class frmManHinhChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinhChinh));
            this.msQuanLySinhVien = new System.Windows.Forms.MenuStrip();
            this.toolsmiQuanTri = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmsiDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsmiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsmiDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsmiSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsmiKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsmiMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsmiKetQua = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsmiThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.msQuanLySinhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // msQuanLySinhVien
            // 
            this.msQuanLySinhVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsmiQuanTri,
            this.toolsmiDanhMuc,
            this.toolsmiThoat});
            this.msQuanLySinhVien.Location = new System.Drawing.Point(0, 0);
            this.msQuanLySinhVien.Name = "msQuanLySinhVien";
            this.msQuanLySinhVien.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msQuanLySinhVien.Size = new System.Drawing.Size(1085, 25);
            this.msQuanLySinhVien.TabIndex = 0;
            this.msQuanLySinhVien.Text = "Quản Lý Sinh Viên";
            // 
            // toolsmiQuanTri
            // 
            this.toolsmiQuanTri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolmsiDangNhap,
            this.toolsmiDangXuat,
            this.thoátToolStripMenuItem});
            this.toolsmiQuanTri.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsmiQuanTri.Name = "toolsmiQuanTri";
            this.toolsmiQuanTri.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.toolsmiQuanTri.Size = new System.Drawing.Size(78, 21);
            this.toolsmiQuanTri.Text = "&Quản Trị";
            this.toolsmiQuanTri.Click += new System.EventHandler(this.toolsmiQuanTri_Click);
            // 
            // toolmsiDangNhap
            // 
            this.toolmsiDangNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolmsiDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("toolmsiDangNhap.Image")));
            this.toolmsiDangNhap.Name = "toolmsiDangNhap";
            this.toolmsiDangNhap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolmsiDangNhap.Size = new System.Drawing.Size(201, 22);
            this.toolmsiDangNhap.Text = "Đăng Nhập";
            this.toolmsiDangNhap.Click += new System.EventHandler(this.toolmsiDangNhap_Click);
            // 
            // toolsmiDangXuat
            // 
            this.toolsmiDangXuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsmiDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("toolsmiDangXuat.Image")));
            this.toolsmiDangXuat.Name = "toolsmiDangXuat";
            this.toolsmiDangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.toolsmiDangXuat.Size = new System.Drawing.Size(201, 22);
            this.toolsmiDangXuat.Text = "Đăng Xuất";
            this.toolsmiDangXuat.Click += new System.EventHandler(this.toolsmiDangXuat_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // toolsmiDanhMuc
            // 
            this.toolsmiDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsmiSinhVien,
            this.toolsmiKhoa,
            this.lớpToolStripMenuItem,
            this.toolsmiMonHoc,
            this.toolsmiKetQua});
            this.toolsmiDanhMuc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsmiDanhMuc.Name = "toolsmiDanhMuc";
            this.toolsmiDanhMuc.Size = new System.Drawing.Size(88, 21);
            this.toolsmiDanhMuc.Text = "Danh &Mục";
            // 
            // toolsmiSinhVien
            // 
            this.toolsmiSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("toolsmiSinhVien.Image")));
            this.toolsmiSinhVien.Name = "toolsmiSinhVien";
            this.toolsmiSinhVien.Size = new System.Drawing.Size(138, 22);
            this.toolsmiSinhVien.Text = "Sinh Viên";
            this.toolsmiSinhVien.Click += new System.EventHandler(this.toolsmiSinhVien_Click);
            // 
            // toolsmiKhoa
            // 
            this.toolsmiKhoa.Name = "toolsmiKhoa";
            this.toolsmiKhoa.Size = new System.Drawing.Size(138, 22);
            this.toolsmiKhoa.Text = "Khoa";
            this.toolsmiKhoa.Click += new System.EventHandler(this.toolsmiKhoa_Click);
            // 
            // lớpToolStripMenuItem
            // 
            this.lớpToolStripMenuItem.Name = "lớpToolStripMenuItem";
            this.lớpToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.lớpToolStripMenuItem.Text = "Lớp";
            // 
            // toolsmiMonHoc
            // 
            this.toolsmiMonHoc.Name = "toolsmiMonHoc";
            this.toolsmiMonHoc.Size = new System.Drawing.Size(138, 22);
            this.toolsmiMonHoc.Text = "Môn Học";
            this.toolsmiMonHoc.Click += new System.EventHandler(this.toolsmiMonHoc_Click);
            // 
            // toolsmiKetQua
            // 
            this.toolsmiKetQua.Name = "toolsmiKetQua";
            this.toolsmiKetQua.Size = new System.Drawing.Size(138, 22);
            this.toolsmiKetQua.Text = "Kết Quả";
            this.toolsmiKetQua.Click += new System.EventHandler(this.toolsmiKetQua_Click);
            // 
            // toolsmiThoat
            // 
            this.toolsmiThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsmiThoat.Name = "toolsmiThoat";
            this.toolsmiThoat.Size = new System.Drawing.Size(58, 21);
            this.toolsmiThoat.Text = "&Thoát";
            this.toolsmiThoat.Click += new System.EventHandler(this.toolsmiThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(362, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msQuanLySinhVien);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.msQuanLySinhVien;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManHinhChinh";
            this.Text = "                                                                                Q" +
                "UẢN LÝ SINH VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManHinhChinh_FormClosing);
            this.msQuanLySinhVien.ResumeLayout(false);
            this.msQuanLySinhVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msQuanLySinhVien;
        private System.Windows.Forms.ToolStripMenuItem toolsmiQuanTri;
        private System.Windows.Forms.ToolStripMenuItem toolmsiDangNhap;
        private System.Windows.Forms.ToolStripMenuItem toolsmiDangXuat;
        private System.Windows.Forms.ToolStripMenuItem toolsmiDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem toolsmiKhoa;
        private System.Windows.Forms.ToolStripMenuItem toolsmiSinhVien;
        private System.Windows.Forms.ToolStripMenuItem toolsmiMonHoc;
        private System.Windows.Forms.ToolStripMenuItem toolsmiKetQua;
        private System.Windows.Forms.ToolStripMenuItem toolsmiThoat;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

