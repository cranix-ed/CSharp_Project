namespace WindowsFormsAppTest.FormTest
{
    partial class FormKiemTra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgTableSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchSoLuong = new System.Windows.Forms.TextBox();
            this.txtSearchTenSanPham = new System.Windows.Forms.TextBox();
            this.txtSearchMaSanPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.cbSearchNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ma_san_pham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_san_pham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_nha_cung_cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_nha_cung_cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableSanPham)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgTableSanPham
            // 
            this.dtgTableSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTableSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTableSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_san_pham,
            this.ten_san_pham,
            this.gia,
            this.so_luong,
            this.ma_nha_cung_cap,
            this.ten_nha_cung_cap});
            this.dtgTableSanPham.Location = new System.Drawing.Point(12, 132);
            this.dtgTableSanPham.Name = "dtgTableSanPham";
            this.dtgTableSanPham.RowHeadersWidth = 51;
            this.dtgTableSanPham.RowTemplate.Height = 24;
            this.dtgTableSanPham.Size = new System.Drawing.Size(1008, 243);
            this.dtgTableSanPham.TabIndex = 11;
            this.dtgTableSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTableSanPham_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemMoi);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.cbNhaCungCap);
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Controls.Add(this.txtTenSanPham);
            this.groupBox2.Controls.Add(this.txtMaSanPham);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1008, 225);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật thông tin chi tiết";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(807, 179);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(494, 179);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(369, 179);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(244, 179);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 31);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(201, 130);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(187, 22);
            this.txtSoLuong.TabIndex = 13;
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbNhaCungCap.Location = new System.Drawing.Point(637, 37);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(266, 24);
            this.cbNhaCungCap.TabIndex = 11;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(637, 79);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(266, 22);
            this.txtGia.TabIndex = 9;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(201, 82);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(271, 22);
            this.txtTenSanPham.TabIndex = 8;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(201, 40);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(271, 22);
            this.txtMaSanPham.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(541, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(541, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nhà cung cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbSearchNhaCungCap);
            this.groupBox1.Controls.Add(this.txtSearchSoLuong);
            this.groupBox1.Controls.Add(this.txtSearchTenSanPham);
            this.groupBox1.Controls.Add(this.txtSearchMaSanPham);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 114);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thông tin";
            // 
            // txtSearchSoLuong
            // 
            this.txtSearchSoLuong.Location = new System.Drawing.Point(795, 28);
            this.txtSearchSoLuong.Name = "txtSearchSoLuong";
            this.txtSearchSoLuong.Size = new System.Drawing.Size(172, 22);
            this.txtSearchSoLuong.TabIndex = 7;
            this.txtSearchSoLuong.TextChanged += new System.EventHandler(this.txtSearchSoLuong_TextChanged);
            // 
            // txtSearchTenSanPham
            // 
            this.txtSearchTenSanPham.Location = new System.Drawing.Point(115, 78);
            this.txtSearchTenSanPham.Name = "txtSearchTenSanPham";
            this.txtSearchTenSanPham.Size = new System.Drawing.Size(188, 22);
            this.txtSearchTenSanPham.TabIndex = 5;
            this.txtSearchTenSanPham.TextChanged += new System.EventHandler(this.txtSearchTenSanPham_TextChanged);
            // 
            // txtSearchMaSanPham
            // 
            this.txtSearchMaSanPham.Location = new System.Drawing.Point(115, 33);
            this.txtSearchMaSanPham.Name = "txtSearchMaSanPham";
            this.txtSearchMaSanPham.Size = new System.Drawing.Size(188, 22);
            this.txtSearchMaSanPham.TabIndex = 4;
            this.txtSearchMaSanPham.TextChanged += new System.EventHandler(this.txtSearchMaSanPham_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(711, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(108, 179);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 31);
            this.btnThemMoi.TabIndex = 18;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // cbSearchNhaCungCap
            // 
            this.cbSearchNhaCungCap.FormattingEnabled = true;
            this.cbSearchNhaCungCap.Location = new System.Drawing.Point(479, 31);
            this.cbSearchNhaCungCap.Name = "cbSearchNhaCungCap";
            this.cbSearchNhaCungCap.Size = new System.Drawing.Size(196, 24);
            this.cbSearchNhaCungCap.TabIndex = 11;
            this.cbSearchNhaCungCap.SelectedIndexChanged += new System.EventHandler(this.cbSearchNhaCungCap_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nhà cung cấp";
            // 
            // ma_san_pham
            // 
            this.ma_san_pham.DataPropertyName = "ma_san_pham";
            this.ma_san_pham.HeaderText = "Mã sản phẩm";
            this.ma_san_pham.MinimumWidth = 6;
            this.ma_san_pham.Name = "ma_san_pham";
            // 
            // ten_san_pham
            // 
            this.ten_san_pham.DataPropertyName = "ten_san_pham";
            this.ten_san_pham.HeaderText = "Tên sản phẩm";
            this.ten_san_pham.MinimumWidth = 6;
            this.ten_san_pham.Name = "ten_san_pham";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            // 
            // so_luong
            // 
            this.so_luong.DataPropertyName = "so_luong";
            dataGridViewCellStyle3.NullValue = null;
            this.so_luong.DefaultCellStyle = dataGridViewCellStyle3;
            this.so_luong.HeaderText = "Số lượng";
            this.so_luong.MinimumWidth = 6;
            this.so_luong.Name = "so_luong";
            // 
            // ma_nha_cung_cap
            // 
            this.ma_nha_cung_cap.DataPropertyName = "ma_nha_cung_cap";
            this.ma_nha_cung_cap.HeaderText = "Mã nhà cung cấp";
            this.ma_nha_cung_cap.MinimumWidth = 6;
            this.ma_nha_cung_cap.Name = "ma_nha_cung_cap";
            // 
            // ten_nha_cung_cap
            // 
            this.ten_nha_cung_cap.DataPropertyName = "ten_nha_cung_cap";
            this.ten_nha_cung_cap.HeaderText = "Tên nhà cung cấp";
            this.ten_nha_cung_cap.MinimumWidth = 6;
            this.ten_nha_cung_cap.Name = "ten_nha_cung_cap";
            // 
            // FormKiemTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 616);
            this.Controls.Add(this.dtgTableSanPham);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKiemTra";
            this.Text = "FormKiemTra";
            this.Load += new System.EventHandler(this.FormKiemTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableSanPham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTableSanPham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchSoLuong;
        private System.Windows.Forms.TextBox txtSearchTenSanPham;
        private System.Windows.Forms.TextBox txtSearchMaSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSearchNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_san_pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_san_pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_nha_cung_cap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_nha_cung_cap;
    }
}