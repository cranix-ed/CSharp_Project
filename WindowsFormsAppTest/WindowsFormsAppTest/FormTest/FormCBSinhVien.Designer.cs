namespace WindowsFormsAppTest.FormTest
{
    partial class FormCBSinhVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgTableDocGia = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbSearchGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtSearchTenSinhVien = new System.Windows.Forms.TextBox();
            this.txtSearchMaSinhVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ma_sinh_vien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_sinh_vien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dien_thoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSearchLophoc = new System.Windows.Forms.ComboBox();
            this.cbLophoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableDocGia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgTableDocGia
            // 
            this.dtgTableDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTableDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTableDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_sinh_vien,
            this.ten_sinh_vien,
            this.gioi_tinh,
            this.ngay_sinh,
            this.dien_thoai,
            this.dia_chi,
            this.ma_lop,
            this.ten_lop});
            this.dtgTableDocGia.Location = new System.Drawing.Point(12, 132);
            this.dtgTableDocGia.Name = "dtgTableDocGia";
            this.dtgTableDocGia.RowHeadersWidth = 51;
            this.dtgTableDocGia.RowTemplate.Height = 24;
            this.dtgTableDocGia.Size = new System.Drawing.Size(1008, 206);
            this.dtgTableDocGia.TabIndex = 8;
            this.dtgTableDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTableDocGia_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbLophoc);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.dtpNgaySinh);
            this.groupBox2.Controls.Add(this.cbGioiTinh);
            this.groupBox2.Controls.Add(this.txtDienThoai);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.txtMaSinhVien);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1008, 262);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật thông tin chi tiết";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(533, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Lớp";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(810, 222);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(473, 222);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(314, 222);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(172, 222);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(172, 170);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(713, 22);
            this.txtDiaChi.TabIndex = 13;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(172, 122);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(271, 22);
            this.dtpNgaySinh.TabIndex = 12;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(619, 23);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(266, 24);
            this.cbGioiTinh.TabIndex = 11;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(619, 71);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(266, 22);
            this.txtDienThoai.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(172, 74);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(271, 22);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(172, 32);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(271, 22);
            this.txtMaSinhVien.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(533, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Họ và tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã sinh viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSearchLophoc);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbSearchGioiTinh);
            this.groupBox1.Controls.Add(this.btnXuatFile);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearchSoDienThoai);
            this.groupBox1.Controls.Add(this.txtSearchTenSinhVien);
            this.groupBox1.Controls.Add(this.txtSearchMaSinhVien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(632, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Lớp";
            // 
            // cbSearchGioiTinh
            // 
            this.cbSearchGioiTinh.FormattingEnabled = true;
            this.cbSearchGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbSearchGioiTinh.Location = new System.Drawing.Point(415, 31);
            this.cbSearchGioiTinh.Name = "cbSearchGioiTinh";
            this.cbSearchGioiTinh.Size = new System.Drawing.Size(172, 24);
            this.cbSearchGioiTinh.TabIndex = 18;
            this.cbSearchGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cbSearchGioiTinh_SelectedIndexChanged);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Location = new System.Drawing.Point(885, 78);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(102, 23);
            this.btnXuatFile.TabIndex = 9;
            this.btnXuatFile.Text = "Xuất";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(885, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchSoDienThoai
            // 
            this.txtSearchSoDienThoai.Location = new System.Drawing.Point(415, 74);
            this.txtSearchSoDienThoai.Name = "txtSearchSoDienThoai";
            this.txtSearchSoDienThoai.Size = new System.Drawing.Size(172, 22);
            this.txtSearchSoDienThoai.TabIndex = 7;
            this.txtSearchSoDienThoai.TextChanged += new System.EventHandler(this.txtSearchSoDienThoai_TextChanged);
            // 
            // txtSearchTenSinhVien
            // 
            this.txtSearchTenSinhVien.Location = new System.Drawing.Point(108, 74);
            this.txtSearchTenSinhVien.Name = "txtSearchTenSinhVien";
            this.txtSearchTenSinhVien.Size = new System.Drawing.Size(188, 22);
            this.txtSearchTenSinhVien.TabIndex = 5;
            this.txtSearchTenSinhVien.TextChanged += new System.EventHandler(this.txtSearchTenSinhVien_TextChanged);
            // 
            // txtSearchMaSinhVien
            // 
            this.txtSearchMaSinhVien.Location = new System.Drawing.Point(108, 33);
            this.txtSearchMaSinhVien.Name = "txtSearchMaSinhVien";
            this.txtSearchMaSinhVien.Size = new System.Drawing.Size(188, 22);
            this.txtSearchMaSinhVien.TabIndex = 4;
            this.txtSearchMaSinhVien.TextChanged += new System.EventHandler(this.txtSearchtxtMaSinhVien_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // ma_sinh_vien
            // 
            this.ma_sinh_vien.DataPropertyName = "ma_sinh_vien";
            this.ma_sinh_vien.HeaderText = "Mã sinh viên";
            this.ma_sinh_vien.MinimumWidth = 6;
            this.ma_sinh_vien.Name = "ma_sinh_vien";
            // 
            // ten_sinh_vien
            // 
            this.ten_sinh_vien.DataPropertyName = "ten_sinh_vien";
            this.ten_sinh_vien.HeaderText = "Tên sinh viên";
            this.ten_sinh_vien.MinimumWidth = 6;
            this.ten_sinh_vien.Name = "ten_sinh_vien";
            // 
            // gioi_tinh
            // 
            this.gioi_tinh.DataPropertyName = "gioi_tinh";
            this.gioi_tinh.HeaderText = "Giới tính";
            this.gioi_tinh.MinimumWidth = 6;
            this.gioi_tinh.Name = "gioi_tinh";
            // 
            // ngay_sinh
            // 
            this.ngay_sinh.DataPropertyName = "ngay_sinh";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.ngay_sinh.DefaultCellStyle = dataGridViewCellStyle1;
            this.ngay_sinh.HeaderText = "Ngày sinh";
            this.ngay_sinh.MinimumWidth = 6;
            this.ngay_sinh.Name = "ngay_sinh";
            // 
            // dien_thoai
            // 
            this.dien_thoai.DataPropertyName = "dien_thoai";
            this.dien_thoai.HeaderText = "Điện thoại";
            this.dien_thoai.MinimumWidth = 6;
            this.dien_thoai.Name = "dien_thoai";
            // 
            // dia_chi
            // 
            this.dia_chi.DataPropertyName = "dia_chi";
            this.dia_chi.HeaderText = "Địa chỉ";
            this.dia_chi.MinimumWidth = 6;
            this.dia_chi.Name = "dia_chi";
            // 
            // ma_lop
            // 
            this.ma_lop.DataPropertyName = "ma_lop";
            this.ma_lop.HeaderText = "Mã Lớp";
            this.ma_lop.MinimumWidth = 6;
            this.ma_lop.Name = "ma_lop";
            // 
            // ten_lop
            // 
            this.ten_lop.DataPropertyName = "ten_lop";
            this.ten_lop.HeaderText = "Tên Lớp";
            this.ten_lop.MinimumWidth = 6;
            this.ten_lop.Name = "ten_lop";
            // 
            // cbSearchLophoc
            // 
            this.cbSearchLophoc.FormattingEnabled = true;
            this.cbSearchLophoc.Location = new System.Drawing.Point(688, 33);
            this.cbSearchLophoc.Name = "cbSearchLophoc";
            this.cbSearchLophoc.Size = new System.Drawing.Size(160, 24);
            this.cbSearchLophoc.TabIndex = 21;
            this.cbSearchLophoc.SelectedIndexChanged += new System.EventHandler(this.cbSearchLophoc_SelectedIndexChanged);
            // 
            // cbLophoc
            // 
            this.cbLophoc.FormattingEnabled = true;
            this.cbLophoc.Location = new System.Drawing.Point(619, 119);
            this.cbLophoc.Name = "cbLophoc";
            this.cbLophoc.Size = new System.Drawing.Size(266, 24);
            this.cbLophoc.TabIndex = 19;
            // 
            // FormCBSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 621);
            this.Controls.Add(this.dtgTableDocGia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCBSinhVien";
            this.Text = "FormCBSinhVien";
            this.Load += new System.EventHandler(this.FormCBSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableDocGia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTableDocGia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbSearchGioiTinh;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchSoDienThoai;
        private System.Windows.Forms.TextBox txtSearchTenSinhVien;
        private System.Windows.Forms.TextBox txtSearchMaSinhVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sinh_vien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_sinh_vien;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dien_thoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_lop;
        private System.Windows.Forms.ComboBox cbSearchLophoc;
        private System.Windows.Forms.ComboBox cbLophoc;
    }
}