namespace Project_CSharp.Forms.Tung
{
    partial class hocky
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
            this.nhapexcel = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idhocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbnamhoc = new System.Windows.Forms.ComboBox();
            this.txtngaykt = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbhocky = new System.Windows.Forms.ComboBox();
            this.txtngaybd = new System.Windows.Forms.DateTimePicker();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchnamhoc = new System.Windows.Forms.ComboBox();
            this.searchtenhk = new System.Windows.Forms.ComboBox();
            this.Xuat = new System.Windows.Forms.Button();
            this.Timkiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nhapexcel
            // 
            this.nhapexcel.Location = new System.Drawing.Point(597, 593);
            this.nhapexcel.Name = "nhapexcel";
            this.nhapexcel.Size = new System.Drawing.Size(104, 33);
            this.nhapexcel.TabIndex = 15;
            this.nhapexcel.Text = "Nhập Excel";
            this.nhapexcel.UseVisualStyleBackColor = true;
            this.nhapexcel.Click += new System.EventHandler(this.nhapexcel_Click);
            // 
            // Thoat
            // 
            this.Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Thoat.Location = new System.Drawing.Point(784, 584);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(86, 33);
            this.Thoat.TabIndex = 14;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Xoa
            // 
            this.Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Xoa.Location = new System.Drawing.Point(422, 584);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(93, 33);
            this.Xoa.TabIndex = 13;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Sua
            // 
            this.Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sua.Location = new System.Drawing.Point(209, 584);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(88, 33);
            this.Sua.TabIndex = 12;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Luu
            // 
            this.Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Luu.Location = new System.Drawing.Point(42, 584);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(83, 33);
            this.Luu.TabIndex = 11;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = true;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idhocky,
            this.tenhocky,
            this.namhoc,
            this.ngaybatdau,
            this.ngayketthuc,
            this.trangthai});
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 196);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idhocky
            // 
            this.idhocky.DataPropertyName = "idhocky";
            this.idhocky.HeaderText = "Ma hoc ky";
            this.idhocky.MinimumWidth = 8;
            this.idhocky.Name = "idhocky";
            this.idhocky.Width = 150;
            // 
            // tenhocky
            // 
            this.tenhocky.DataPropertyName = "tenhocky";
            this.tenhocky.HeaderText = "Ten hoc ky";
            this.tenhocky.MinimumWidth = 8;
            this.tenhocky.Name = "tenhocky";
            this.tenhocky.Width = 150;
            // 
            // namhoc
            // 
            this.namhoc.DataPropertyName = "namhoc";
            this.namhoc.HeaderText = "Nam hoc";
            this.namhoc.MinimumWidth = 8;
            this.namhoc.Name = "namhoc";
            this.namhoc.Width = 150;
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.DataPropertyName = "ngaybatdau";
            this.ngaybatdau.HeaderText = "Ngay bat dau";
            this.ngaybatdau.MinimumWidth = 8;
            this.ngaybatdau.Name = "ngaybatdau";
            this.ngaybatdau.Width = 150;
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.DataPropertyName = "ngayketthuc";
            this.ngayketthuc.HeaderText = "Ngay ket thuc";
            this.ngayketthuc.MinimumWidth = 8;
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.Width = 150;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trang thai";
            this.trangthai.MinimumWidth = 8;
            this.trangthai.Name = "trangthai";
            this.trangthai.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cbnamhoc);
            this.panel2.Controls.Add(this.txtngaykt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbhocky);
            this.panel2.Controls.Add(this.txtngaybd);
            this.panel2.Controls.Add(this.txttrangthai);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 178);
            this.panel2.TabIndex = 9;
            // 
            // cbnamhoc
            // 
            this.cbnamhoc.FormattingEnabled = true;
            this.cbnamhoc.Items.AddRange(new object[] {
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.cbnamhoc.Location = new System.Drawing.Point(652, 12);
            this.cbnamhoc.Name = "cbnamhoc";
            this.cbnamhoc.Size = new System.Drawing.Size(240, 28);
            this.cbnamhoc.TabIndex = 13;
            // 
            // txtngaykt
            // 
            this.txtngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngaykt.Location = new System.Drawing.Point(663, 126);
            this.txtngaykt.Name = "txtngaykt";
            this.txtngaykt.Size = new System.Drawing.Size(200, 26);
            this.txtngaykt.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(511, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ngày kết thúc";
            // 
            // cbhocky
            // 
            this.cbhocky.FormattingEnabled = true;
            this.cbhocky.Items.AddRange(new object[] {
            "Học Kỳ I",
            "Học Kỳ II"});
            this.cbhocky.Location = new System.Drawing.Point(143, 48);
            this.cbhocky.Name = "cbhocky";
            this.cbhocky.Size = new System.Drawing.Size(234, 28);
            this.cbhocky.TabIndex = 10;
            // 
            // txtngaybd
            // 
            this.txtngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngaybd.Location = new System.Drawing.Point(143, 126);
            this.txtngaybd.Name = "txtngaybd";
            this.txtngaybd.Size = new System.Drawing.Size(200, 26);
            this.txtngaybd.TabIndex = 9;
            // 
            // txttrangthai
            // 
            this.txttrangthai.Location = new System.Drawing.Point(652, 76);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(254, 26);
            this.txttrangthai.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ngày bắt đầu";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Năm học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên học kỳ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.searchnamhoc);
            this.panel1.Controls.Add(this.searchtenhk);
            this.panel1.Controls.Add(this.Xuat);
            this.panel1.Controls.Add(this.Timkiem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 129);
            this.panel1.TabIndex = 8;
            // 
            // searchnamhoc
            // 
            this.searchnamhoc.FormattingEnabled = true;
            this.searchnamhoc.Items.AddRange(new object[] {
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.searchnamhoc.Location = new System.Drawing.Point(663, 49);
            this.searchnamhoc.Name = "searchnamhoc";
            this.searchnamhoc.Size = new System.Drawing.Size(200, 28);
            this.searchnamhoc.TabIndex = 9;
            // 
            // searchtenhk
            // 
            this.searchtenhk.FormattingEnabled = true;
            this.searchtenhk.Location = new System.Drawing.Point(171, 52);
            this.searchtenhk.Name = "searchtenhk";
            this.searchtenhk.Size = new System.Drawing.Size(228, 28);
            this.searchtenhk.TabIndex = 8;
            // 
            // Xuat
            // 
            this.Xuat.Location = new System.Drawing.Point(985, 80);
            this.Xuat.Name = "Xuat";
            this.Xuat.Size = new System.Drawing.Size(94, 36);
            this.Xuat.TabIndex = 7;
            this.Xuat.Text = "Xuất Excel";
            this.Xuat.UseVisualStyleBackColor = true;
            this.Xuat.Click += new System.EventHandler(this.Xuat_Click);
            // 
            // Timkiem
            // 
            this.Timkiem.Location = new System.Drawing.Point(985, 25);
            this.Timkiem.Name = "Timkiem";
            this.Timkiem.Size = new System.Drawing.Size(94, 36);
            this.Timkiem.TabIndex = 6;
            this.Timkiem.Text = "Tìm kiếm";
            this.Timkiem.UseVisualStyleBackColor = true;
            this.Timkiem.Click += new System.EventHandler(this.Timkiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên học kỳ";
            // 
            // hocky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.nhapexcel);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "hocky";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.hocky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nhapexcel;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbhocky;
        private System.Windows.Forms.DateTimePicker txtngaybd;
        private System.Windows.Forms.TextBox txttrangthai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox searchtenhk;
        private System.Windows.Forms.Button Xuat;
        private System.Windows.Forms.Button Timkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtngaykt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbnamhoc;
        private System.Windows.Forms.ComboBox searchnamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}