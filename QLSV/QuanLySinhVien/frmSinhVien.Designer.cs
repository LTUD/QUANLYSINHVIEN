namespace QuanLySinhVien
{
    partial class frmSinhVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtkh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnois = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpSV = new System.Windows.Forms.GroupBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMaKhoa = new System.Windows.Forms.ComboBox();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorMaSV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorHoTenSV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNoiSinh = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorKhoaHoc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDiaChi = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHoTenSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoiSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorKhoaHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiaChi)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(550, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Lớp:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbNu);
            this.groupBox3.Controls.Add(this.rbNam);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(635, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 49);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbNu.Location = new System.Drawing.Point(97, 16);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(46, 21);
            this.rbNu.TabIndex = 8;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Checked = true;
            this.rbNam.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbNam.Location = new System.Drawing.Point(29, 16);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(56, 21);
            this.rbNam.TabIndex = 7;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
            // 
            // cbxLop
            // 
            this.cbxLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(637, 112);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(174, 21);
            this.cbxLop.TabIndex = 6;
            this.cbxLop.SelectedIndexChanged += new System.EventHandler(this.cbxLop_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(550, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mã Khoa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(550, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Khoá Học:";
            // 
            // txtkh
            // 
            this.txtkh.Location = new System.Drawing.Point(635, 29);
            this.txtkh.Name = "txtkh";
            this.txtkh.Size = new System.Drawing.Size(174, 20);
            this.txtkh.TabIndex = 4;
            this.txtkh.TextChanged += new System.EventHandler(this.txtkh_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(113, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Họ Tên SV:";
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Location = new System.Drawing.Point(223, 71);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(176, 20);
            this.txtHoTenSV.TabIndex = 3;
            this.txtHoTenSV.TextChanged += new System.EventHandler(this.txtHoTenSV_TextChanged);
            this.txtHoTenSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTenSV_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(113, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nơi Sinh:";
            // 
            // txtnois
            // 
            this.txtnois.Location = new System.Drawing.Point(223, 147);
            this.txtnois.Name = "txtnois";
            this.txtnois.Size = new System.Drawing.Size(176, 20);
            this.txtnois.TabIndex = 2;
            this.txtnois.TextChanged += new System.EventHandler(this.txtnois_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(113, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(113, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sinh Viên:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnGhi);
            this.groupBox4.Controls.Add(this.btnDoc);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(42, 547);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1004, 60);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Location = new System.Drawing.Point(662, 20);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(83, 32);
            this.btnGhi.TabIndex = 8;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            // 
            // btnDoc
            // 
            this.btnDoc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.Location = new System.Drawing.Point(544, 20);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(78, 32);
            this.btnDoc.TabIndex = 7;
            this.btnDoc.Text = "Đọc";
            this.btnDoc.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(420, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 33);
            this.button5.TabIndex = 6;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(170, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(303, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(795, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // grpSV
            // 
            this.grpSV.BackColor = System.Drawing.Color.Transparent;
            this.grpSV.Controls.Add(this.txtMaSV);
            this.grpSV.Controls.Add(this.txtDiaChi);
            this.grpSV.Controls.Add(this.label11);
            this.grpSV.Controls.Add(this.label10);
            this.grpSV.Controls.Add(this.cmbMaKhoa);
            this.grpSV.Controls.Add(this.dateNgaySinh);
            this.grpSV.Controls.Add(this.label9);
            this.grpSV.Controls.Add(this.groupBox3);
            this.grpSV.Controls.Add(this.cbxLop);
            this.grpSV.Controls.Add(this.label8);
            this.grpSV.Controls.Add(this.label7);
            this.grpSV.Controls.Add(this.txtkh);
            this.grpSV.Controls.Add(this.label6);
            this.grpSV.Controls.Add(this.label5);
            this.grpSV.Controls.Add(this.txtHoTenSV);
            this.grpSV.Controls.Add(this.txtnois);
            this.grpSV.Controls.Add(this.label4);
            this.grpSV.Controls.Add(this.label2);
            this.grpSV.Location = new System.Drawing.Point(40, 50);
            this.grpSV.Name = "grpSV";
            this.grpSV.Size = new System.Drawing.Size(996, 265);
            this.grpSV.TabIndex = 9;
            this.grpSV.TabStop = false;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(223, 32);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(179, 20);
            this.txtMaSV.TabIndex = 17;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(635, 154);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(172, 20);
            this.txtDiaChi.TabIndex = 16;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(550, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Địa Chỉ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(550, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Giới Tính:";
            // 
            // cmbMaKhoa
            // 
            this.cmbMaKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaKhoa.FormattingEnabled = true;
            this.cmbMaKhoa.Location = new System.Drawing.Point(635, 71);
            this.cmbMaKhoa.Name = "cmbMaKhoa";
            this.cmbMaKhoa.Size = new System.Drawing.Size(176, 21);
            this.cmbMaKhoa.TabIndex = 13;
            this.cmbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbMaKhoa_SelectedIndexChanged);
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaySinh.Location = new System.Drawing.Point(223, 105);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(173, 20);
            this.dateNgaySinh.TabIndex = 12;
            this.dateNgaySinh.ValueChanged += new System.EventHandler(this.dateNgaySinh_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(398, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "THÔNG TIN SINH VIÊN";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.MMH,
            this.HoTen,
            this.Khoa});
            this.dgvSinhVien.Location = new System.Drawing.Point(42, 342);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(1004, 185);
            this.dgvSinhVien.TabIndex = 14;
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "Mã Sinh Viên";
            this.MSSV.Name = "MSSV";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Họ Sinh Viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Sinh Viên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nơi Sinh";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Khóa Học";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mã Khoa";
            this.Column6.Name = "Column6";
            // 
            // MMH
            // 
            this.MMH.HeaderText = "Lớp";
            this.MMH.Name = "MMH";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Địa Chỉ";
            this.HoTen.Name = "HoTen";
            // 
            // Khoa
            // 
            this.Khoa.HeaderText = "Giới Tính";
            this.Khoa.Name = "Khoa";
            // 
            // errorMaSV
            // 
            this.errorMaSV.ContainerControl = this;
            // 
            // errorHoTenSV
            // 
            this.errorHoTenSV.ContainerControl = this;
            // 
            // errorNoiSinh
            // 
            this.errorNoiSinh.ContainerControl = this;
            // 
            // errorKhoaHoc
            // 
            this.errorKhoaHoc.ContainerControl = this;
            // 
            // errorDiaChi
            // 
            this.errorDiaChi.ContainerControl = this;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 634);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpSV);
            this.Controls.Add(this.label1);
            this.Name = "frmSinhVien";
            this.Text = "frmSinhVien";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.grpSV.ResumeLayout(false);
            this.grpSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHoTenSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoiSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorKhoaHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiaChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtkh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnois;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMaKhoa;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.ErrorProvider errorMaSV;
        private System.Windows.Forms.ErrorProvider errorHoTenSV;
        private System.Windows.Forms.ErrorProvider errorNoiSinh;
        private System.Windows.Forms.ErrorProvider errorKhoaHoc;
        private System.Windows.Forms.ErrorProvider errorDiaChi;
        private System.Windows.Forms.TextBox txtMaSV;
    }
}