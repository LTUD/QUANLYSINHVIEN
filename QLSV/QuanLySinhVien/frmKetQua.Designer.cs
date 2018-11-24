namespace QuanLySinhVien
{
    partial class frmKetQua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetQua));
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.lblDiem = new System.Windows.Forms.Label();
            this.nrdLanThi = new System.Windows.Forms.NumericUpDown();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLanThi = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.epMSSV = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMMH = new System.Windows.Forms.ErrorProvider(this.components);
            this.epHoTen = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nrdLanThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.grpKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMSSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHoTen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(263, 65);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(201, 22);
            this.txtMaMH.TabIndex = 4;
            this.txtMaMH.TextChanged += new System.EventHandler(this.txtMaMH_TextChanged);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(263, 28);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(200, 22);
            this.txtMSSV.TabIndex = 2;
            this.txtMSSV.TextChanged += new System.EventHandler(this.txtMSSV_TextChanged);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(479, 394);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 31);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(272, 394);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 31);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(378, 394);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 31);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.BackColor = System.Drawing.Color.Transparent;
            this.lblKetQua.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.Black;
            this.lblKetQua.Location = new System.Drawing.Point(308, 10);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lblKetQua.Size = new System.Drawing.Size(195, 32);
            this.lblKetQua.TabIndex = 21;
            this.lblKetQua.Text = "KẾT QUẢ";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(388, 152);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(75, 22);
            this.txtDiem.TabIndex = 12;
            this.txtDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiem_KeyPress);
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.BackColor = System.Drawing.Color.Transparent;
            this.lblDiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.ForeColor = System.Drawing.Color.Black;
            this.lblDiem.Location = new System.Drawing.Point(335, 152);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(48, 17);
            this.lblDiem.TabIndex = 11;
            this.lblDiem.Text = "Điểm:";
            // 
            // nrdLanThi
            // 
            this.nrdLanThi.Location = new System.Drawing.Point(263, 152);
            this.nrdLanThi.Name = "nrdLanThi";
            this.nrdLanThi.Size = new System.Drawing.Size(55, 22);
            this.nrdLanThi.TabIndex = 10;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(263, 110);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(201, 22);
            this.txtHoTen.TabIndex = 6;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // btnDoc
            // 
            this.btnDoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.ForeColor = System.Drawing.Color.Black;
            this.btnDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnDoc.Image")));
            this.btnDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoc.Location = new System.Drawing.Point(67, 394);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(84, 31);
            this.btnDoc.TabIndex = 14;
            this.btnDoc.Text = "ĐỌC";
            this.btnDoc.UseVisualStyleBackColor = true;
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.ForeColor = System.Drawing.Color.Black;
            this.btnGhi.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.Image")));
            this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhi.Location = new System.Drawing.Point(162, 394);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(84, 31);
            this.btnGhi.TabIndex = 15;
            this.btnGhi.Text = "GHI";
            this.btnGhi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(588, 394);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 31);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.MMH,
            this.HoTen,
            this.Khoa,
            this.LanThi,
            this.Diem});
            this.dgvThongTin.Location = new System.Drawing.Point(67, 194);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.Size = new System.Drawing.Size(604, 185);
            this.dgvThongTin.TabIndex = 13;
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "Mã SV";
            this.MSSV.Name = "MSSV";
            // 
            // MMH
            // 
            this.MMH.HeaderText = "Mã MH";
            this.MMH.Name = "MMH";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            // 
            // Khoa
            // 
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.Name = "Khoa";
            // 
            // LanThi
            // 
            this.LanThi.HeaderText = "Lần thi";
            this.LanThi.Name = "LanThi";
            // 
            // Diem
            // 
            this.Diem.HeaderText = "Điểm";
            this.Diem.Name = "Diem";
            // 
            // lblLanThi
            // 
            this.lblLanThi.AutoSize = true;
            this.lblLanThi.BackColor = System.Drawing.Color.Transparent;
            this.lblLanThi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanThi.ForeColor = System.Drawing.Color.Black;
            this.lblLanThi.Location = new System.Drawing.Point(183, 152);
            this.lblLanThi.Name = "lblLanThi";
            this.lblLanThi.Size = new System.Drawing.Size(59, 17);
            this.lblLanThi.TabIndex = 9;
            this.lblLanThi.Text = "Lần thi:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.Black;
            this.lblHoTen.Location = new System.Drawing.Point(180, 110);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(77, 17);
            this.lblHoTen.TabIndex = 5;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.BackColor = System.Drawing.Color.Transparent;
            this.lblMaMH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMH.ForeColor = System.Drawing.Color.Black;
            this.lblMaMH.Location = new System.Drawing.Point(180, 70);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(66, 17);
            this.lblMaMH.TabIndex = 3;
            this.lblMaMH.Text = "Mã MH:";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.BackColor = System.Drawing.Color.Transparent;
            this.lblMSSV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.ForeColor = System.Drawing.Color.Black;
            this.lblMSSV.Location = new System.Drawing.Point(180, 29);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(56, 17);
            this.lblMSSV.TabIndex = 1;
            this.lblMSSV.Text = "Mã SV:";
            // 
            // grpKetQua
            // 
            this.grpKetQua.BackColor = System.Drawing.Color.Transparent;
            this.grpKetQua.Controls.Add(this.txtDiem);
            this.grpKetQua.Controls.Add(this.lblDiem);
            this.grpKetQua.Controls.Add(this.nrdLanThi);
            this.grpKetQua.Controls.Add(this.txtHoTen);
            this.grpKetQua.Controls.Add(this.txtMaMH);
            this.grpKetQua.Controls.Add(this.txtMSSV);
            this.grpKetQua.Controls.Add(this.btnSua);
            this.grpKetQua.Controls.Add(this.btnThoat);
            this.grpKetQua.Controls.Add(this.btnThem);
            this.grpKetQua.Controls.Add(this.btnDoc);
            this.grpKetQua.Controls.Add(this.btnGhi);
            this.grpKetQua.Controls.Add(this.btnXoa);
            this.grpKetQua.Controls.Add(this.dgvThongTin);
            this.grpKetQua.Controls.Add(this.lblLanThi);
            this.grpKetQua.Controls.Add(this.lblHoTen);
            this.grpKetQua.Controls.Add(this.lblMaMH);
            this.grpKetQua.Controls.Add(this.lblMSSV);
            this.grpKetQua.Location = new System.Drawing.Point(42, 45);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Size = new System.Drawing.Size(702, 442);
            this.grpKetQua.TabIndex = 22;
            this.grpKetQua.TabStop = false;
            // 
            // epMSSV
            // 
            this.epMSSV.ContainerControl = this;
            // 
            // epMMH
            // 
            this.epMMH.ContainerControl = this;
            // 
            // epHoTen
            // 
            this.epHoTen.ContainerControl = this;
            // 
            // frmKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 514);
            this.ControlBox = false;
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.grpKetQua);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmKetQua";
            this.Text = "                                                                                 " +
                "  QUẢN LÝ SINH VIÊN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKetQua_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nrdLanThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.grpKetQua.ResumeLayout(false);
            this.grpKetQua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMSSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHoTen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.NumericUpDown nrdLanThi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
        private System.Windows.Forms.Label lblLanThi;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.GroupBox grpKetQua;
        private System.Windows.Forms.ErrorProvider epMSSV;
        private System.Windows.Forms.ErrorProvider epMMH;
        private System.Windows.Forms.ErrorProvider epHoTen;

    }
}