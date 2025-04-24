namespace Project_CSharp.Forms.Tung
{
    partial class thongtintotnghiep
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
            this.idtotnghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytotnghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeploai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemtrungbinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masobang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbnganh = new System.Windows.Forms.ComboBox();
            this.cbkhoa = new System.Windows.Forms.ComboBox();
            this.cbxeploai = new System.Windows.Forms.ComboBox();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.txtmabang = new System.Windows.Forms.TextBox();
            this.txtdiemtb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbmasv = new System.Windows.Forms.ComboBox();
            this.txtngtn = new System.Windows.Forms.DateTimePicker();
            this.txtmtotnghiep = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchnganh = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.searchmasv = new System.Windows.Forms.ComboBox();
            this.Xuat = new System.Windows.Forms.Button();
            this.Timkiem = new System.Windows.Forms.Button();
            this.searchkhoa = new System.Windows.Forms.TextBox();
            this.searchmtotnghiep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nhapexcel
            // 
            this.nhapexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nhapexcel.Location = new System.Drawing.Point(538, 471);
            this.nhapexcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nhapexcel.Name = "nhapexcel";
            this.nhapexcel.Size = new System.Drawing.Size(131, 26);
            this.nhapexcel.TabIndex = 30;
            this.nhapexcel.Text = "Nhập Excel";
            this.nhapexcel.UseVisualStyleBackColor = true;
            this.nhapexcel.Click += new System.EventHandler(this.nhapexcel_Click);
            // 
            // Thoat
            // 
            this.Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Thoat.Location = new System.Drawing.Point(763, 471);
            this.Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(76, 26);
            this.Thoat.TabIndex = 29;
            this.Thoat.Text = "Thoat";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Xoa
            // 
            this.Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Xoa.Location = new System.Drawing.Point(375, 471);
            this.Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(83, 26);
            this.Xoa.TabIndex = 28;
            this.Xoa.Text = "Xoa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Sua
            // 
            this.Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Sua.Location = new System.Drawing.Point(186, 471);
            this.Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(78, 26);
            this.Sua.TabIndex = 27;
            this.Sua.Text = "Sua";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Luu
            // 
            this.Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Luu.Location = new System.Drawing.Point(37, 471);
            this.Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(74, 26);
            this.Luu.TabIndex = 26;
            this.Luu.Text = "Luu";
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
            this.idtotnghiep,
            this.idsinhvien,
            this.ngaytotnghiep,
            this.xeploai,
            this.khoa,
            this.nganh,
            this.diemtrungbinh,
            this.masobang,
            this.ghichu});
            this.dataGridView1.Location = new System.Drawing.Point(11, 126);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 157);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idtotnghiep
            // 
            this.idtotnghiep.DataPropertyName = "idtotnghiep";
            this.idtotnghiep.HeaderText = "Ma tot nghiep";
            this.idtotnghiep.MinimumWidth = 8;
            this.idtotnghiep.Name = "idtotnghiep";
            this.idtotnghiep.Width = 150;
            // 
            // idsinhvien
            // 
            this.idsinhvien.DataPropertyName = "idsinhvien";
            this.idsinhvien.HeaderText = "Ma sinh vien";
            this.idsinhvien.MinimumWidth = 8;
            this.idsinhvien.Name = "idsinhvien";
            this.idsinhvien.Width = 150;
            // 
            // ngaytotnghiep
            // 
            this.ngaytotnghiep.DataPropertyName = "ngaytotnghiep";
            this.ngaytotnghiep.HeaderText = "Ngay tot nghiep";
            this.ngaytotnghiep.MinimumWidth = 8;
            this.ngaytotnghiep.Name = "ngaytotnghiep";
            this.ngaytotnghiep.Width = 150;
            // 
            // xeploai
            // 
            this.xeploai.DataPropertyName = "xeploai";
            this.xeploai.HeaderText = "Xep loai";
            this.xeploai.MinimumWidth = 8;
            this.xeploai.Name = "xeploai";
            this.xeploai.Width = 150;
            // 
            // khoa
            // 
            this.khoa.DataPropertyName = "khoa";
            this.khoa.HeaderText = "Khoa";
            this.khoa.MinimumWidth = 8;
            this.khoa.Name = "khoa";
            this.khoa.Width = 150;
            // 
            // nganh
            // 
            this.nganh.DataPropertyName = "nganh";
            this.nganh.HeaderText = "Nganh";
            this.nganh.MinimumWidth = 8;
            this.nganh.Name = "nganh";
            this.nganh.Width = 150;
            // 
            // diemtrungbinh
            // 
            this.diemtrungbinh.DataPropertyName = "diemtrungbinh";
            this.diemtrungbinh.HeaderText = "Diem trung binh";
            this.diemtrungbinh.MinimumWidth = 8;
            this.diemtrungbinh.Name = "diemtrungbinh";
            this.diemtrungbinh.Width = 150;
            // 
            // masobang
            // 
            this.masobang.DataPropertyName = "masobang";
            this.masobang.HeaderText = "Ma so bang";
            this.masobang.MinimumWidth = 8;
            this.masobang.Name = "masobang";
            this.masobang.Width = 150;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chu";
            this.ghichu.MinimumWidth = 8;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cbnganh);
            this.panel2.Controls.Add(this.cbkhoa);
            this.panel2.Controls.Add(this.cbxeploai);
            this.panel2.Controls.Add(this.txtnote);
            this.panel2.Controls.Add(this.txtmabang);
            this.panel2.Controls.Add(this.txtdiemtb);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lable);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbmasv);
            this.panel2.Controls.Add(this.txtngtn);
            this.panel2.Controls.Add(this.txtmtotnghiep);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(11, 288);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 170);
            this.panel2.TabIndex = 24;
            // 
            // cbnganh
            // 
            this.cbnganh.FormattingEnabled = true;
            this.cbnganh.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Hệ thống thông tin",
            "Mạng máy tính và Truyền thông dữ liệu",
            "Điện tử - viễn thông",
            "Cơ điện tử",
            "Quản lý doanh nghiệp",
            "Marketing",
            "Logistics và Quản lý chuỗi cung ứng",
            "Kế toán doanh nghiệp",
            "Quản trị doanh nghiệp",
            "Quản trị Marketing",
            "Thương mại điện tử",
            "Quản trị tài chính và Đầu tư",
            "Công nghệ kỹ thuật Ô tô",
            "Công nghệ chế tạo máy",
            "Công nghệ Kỹ thuật Cơ khí Máy xây dựng",
            "Công nghệ kỹ thuật Cơ khí đầu máy - toa xe và tàu điện Metro",
            "CNKT Xây dựng Cầu đường bộ",
            "Quản lý chất lượng công trình xây dựng",
            "CNKT xây dựng đường sắt và Metro",
            "CNKT xây dựng Cảng - Đường thủy và Công trình biển",
            "Trí tuệ nhân tạo và giao thông thông minh"});
            this.cbnganh.Location = new System.Drawing.Point(580, 46);
            this.cbnganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbnganh.Name = "cbnganh";
            this.cbnganh.Size = new System.Drawing.Size(202, 24);
            this.cbnganh.TabIndex = 23;
            // 
            // cbkhoa
            // 
            this.cbkhoa.FormattingEnabled = true;
            this.cbkhoa.Items.AddRange(new object[] {
            "CNTT",
            "Cơ Khí",
            "Kinh Tế, Logistics",
            "Công Trình - Xây Dựng"});
            this.cbkhoa.Location = new System.Drawing.Point(580, 12);
            this.cbkhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbkhoa.Name = "cbkhoa";
            this.cbkhoa.Size = new System.Drawing.Size(202, 24);
            this.cbkhoa.TabIndex = 22;
            // 
            // cbxeploai
            // 
            this.cbxeploai.FormattingEnabled = true;
            this.cbxeploai.Items.AddRange(new object[] {
            "Xuất Sắc",
            "Giỏi",
            "Khá",
            "Trung Bình"});
            this.cbxeploai.Location = new System.Drawing.Point(137, 138);
            this.cbxeploai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxeploai.Name = "cbxeploai";
            this.cbxeploai.Size = new System.Drawing.Size(188, 24);
            this.cbxeploai.TabIndex = 21;
            // 
            // txtnote
            // 
            this.txtnote.Location = new System.Drawing.Point(580, 140);
            this.txtnote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(226, 22);
            this.txtnote.TabIndex = 20;
            // 
            // txtmabang
            // 
            this.txtmabang.Location = new System.Drawing.Point(580, 110);
            this.txtmabang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmabang.Name = "txtmabang";
            this.txtmabang.Size = new System.Drawing.Size(226, 22);
            this.txtmabang.TabIndex = 19;
            // 
            // txtdiemtb
            // 
            this.txtdiemtb.Location = new System.Drawing.Point(580, 77);
            this.txtdiemtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiemtb.Name = "txtdiemtb";
            this.txtdiemtb.Size = new System.Drawing.Size(226, 22);
            this.txtdiemtb.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(484, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Ghi chú";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(475, 110);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(78, 16);
            this.lable.TabIndex = 14;
            this.lable.Text = "Mã số bằng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(449, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Điểm trung bình";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Xếp loại";
            // 
            // cbmasv
            // 
            this.cbmasv.FormattingEnabled = true;
            this.cbmasv.Location = new System.Drawing.Point(137, 60);
            this.cbmasv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbmasv.Name = "cbmasv";
            this.cbmasv.Size = new System.Drawing.Size(198, 24);
            this.cbmasv.TabIndex = 10;
            // 
            // txtngtn
            // 
            this.txtngtn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngtn.Location = new System.Drawing.Point(137, 98);
            this.txtngtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtngtn.Name = "txtngtn";
            this.txtngtn.Size = new System.Drawing.Size(178, 22);
            this.txtngtn.TabIndex = 9;
            // 
            // txtmtotnghiep
            // 
            this.txtmtotnghiep.Location = new System.Drawing.Point(137, 18);
            this.txtmtotnghiep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmtotnghiep.Name = "txtmtotnghiep";
            this.txtmtotnghiep.Size = new System.Drawing.Size(208, 22);
            this.txtmtotnghiep.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ngày tốt nghiệp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ngành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã tốt nghiệp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchnganh);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.searchmasv);
            this.panel1.Controls.Add(this.Xuat);
            this.panel1.Controls.Add(this.Timkiem);
            this.panel1.Controls.Add(this.searchkhoa);
            this.panel1.Controls.Add(this.searchmtotnghiep);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 103);
            this.panel1.TabIndex = 23;
            // 
            // searchnganh
            // 
            this.searchnganh.Location = new System.Drawing.Point(580, 62);
            this.searchnganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchnganh.Name = "searchnganh";
            this.searchnganh.Size = new System.Drawing.Size(184, 22);
            this.searchnganh.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(498, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "Ngành";
            // 
            // searchmasv
            // 
            this.searchmasv.FormattingEnabled = true;
            this.searchmasv.Location = new System.Drawing.Point(137, 67);
            this.searchmasv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchmasv.Name = "searchmasv";
            this.searchmasv.Size = new System.Drawing.Size(198, 24);
            this.searchmasv.TabIndex = 8;
            // 
            // Xuat
            // 
            this.Xuat.Location = new System.Drawing.Point(876, 64);
            this.Xuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Xuat.Name = "Xuat";
            this.Xuat.Size = new System.Drawing.Size(84, 29);
            this.Xuat.TabIndex = 7;
            this.Xuat.Text = "Xuat Excel";
            this.Xuat.UseVisualStyleBackColor = true;
            this.Xuat.Click += new System.EventHandler(this.Xuat_Click);
            // 
            // Timkiem
            // 
            this.Timkiem.Location = new System.Drawing.Point(876, 20);
            this.Timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timkiem.Name = "Timkiem";
            this.Timkiem.Size = new System.Drawing.Size(84, 29);
            this.Timkiem.TabIndex = 6;
            this.Timkiem.Text = "Tim kiem";
            this.Timkiem.UseVisualStyleBackColor = true;
            this.Timkiem.Click += new System.EventHandler(this.Timkiem_Click);
            // 
            // searchkhoa
            // 
            this.searchkhoa.Location = new System.Drawing.Point(580, 24);
            this.searchkhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchkhoa.Name = "searchkhoa";
            this.searchkhoa.Size = new System.Drawing.Size(184, 22);
            this.searchkhoa.TabIndex = 5;
            // 
            // searchmtotnghiep
            // 
            this.searchmtotnghiep.Location = new System.Drawing.Point(137, 18);
            this.searchmtotnghiep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchmtotnghiep.Name = "searchmtotnghiep";
            this.searchmtotnghiep.Size = new System.Drawing.Size(208, 22);
            this.searchmtotnghiep.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tốt nghiệp";
            // 
            // thongtintotnghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 515);
            this.Controls.Add(this.nhapexcel);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "thongtintotnghiep";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.thongtintotnghiep_Load);
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
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.TextBox txtmabang;
        private System.Windows.Forms.TextBox txtdiemtb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbmasv;
        private System.Windows.Forms.TextBox txtmtotnghiep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchnganh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox searchmasv;
        private System.Windows.Forms.Button Xuat;
        private System.Windows.Forms.Button Timkiem;
        private System.Windows.Forms.TextBox searchkhoa;
        private System.Windows.Forms.TextBox searchmtotnghiep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbnganh;
        private System.Windows.Forms.ComboBox cbkhoa;
        private System.Windows.Forms.ComboBox cbxeploai;
        private System.Windows.Forms.DateTimePicker txtngtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtotnghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytotnghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn xeploai;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemtrungbinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn masobang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}