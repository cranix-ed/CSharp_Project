namespace Project_CSharp.Forms
{
    partial class FormLopHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThemMoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbSearchKhoaHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbSearchNganh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbSearchKhoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearchHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearchMaLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvLopHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoahoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sosinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chitiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor2 = System.Drawing.Color.Plum;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(951, 217);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 45);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor2 = System.Drawing.Color.Plum;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(951, 125);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 45);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemMoi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemMoi.FillColor2 = System.Drawing.Color.Plum;
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.Location = new System.Drawing.Point(951, 43);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(149, 45);
            this.btnThemMoi.TabIndex = 10;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.Controls.Add(this.cmbSearchKhoaHoc);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GroupBox1.Controls.Add(this.cmbSearchNganh);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GroupBox1.Controls.Add(this.cmbSearchKhoa);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.txtSearchHoTen);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.txtSearchMaLop);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(844, 311);
            this.guna2GroupBox1.TabIndex = 9;
            this.guna2GroupBox1.Text = "Tìm kiếm";
            // 
            // cmbSearchKhoaHoc
            // 
            this.cmbSearchKhoaHoc.BackColor = System.Drawing.Color.Transparent;
            this.cmbSearchKhoaHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSearchKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchKhoaHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSearchKhoaHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSearchKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSearchKhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSearchKhoaHoc.ItemHeight = 30;
            this.cmbSearchKhoaHoc.Location = new System.Drawing.Point(120, 230);
            this.cmbSearchKhoaHoc.Name = "cmbSearchKhoaHoc";
            this.cmbSearchKhoaHoc.Size = new System.Drawing.Size(199, 36);
            this.cmbSearchKhoaHoc.TabIndex = 11;
            this.cmbSearchKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cmbSearchKhoaHoc_SelectedIndexChanged);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(12, 239);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(88, 26);
            this.guna2HtmlLabel6.TabIndex = 10;
            this.guna2HtmlLabel6.Text = "Khóa học";
            // 
            // cmbSearchNganh
            // 
            this.cmbSearchNganh.BackColor = System.Drawing.Color.Transparent;
            this.cmbSearchNganh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSearchNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchNganh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSearchNganh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSearchNganh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSearchNganh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSearchNganh.ItemHeight = 30;
            this.cmbSearchNganh.Location = new System.Drawing.Point(603, 146);
            this.cmbSearchNganh.Name = "cmbSearchNganh";
            this.cmbSearchNganh.Size = new System.Drawing.Size(212, 36);
            this.cmbSearchNganh.TabIndex = 9;
            this.cmbSearchNganh.SelectedIndexChanged += new System.EventHandler(this.cmbSearchNganh_SelectedIndexChanged);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(511, 157);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(66, 22);
            this.guna2HtmlLabel5.TabIndex = 8;
            this.guna2HtmlLabel5.Text = "Ngành";
            // 
            // cmbSearchKhoa
            // 
            this.cmbSearchKhoa.BackColor = System.Drawing.Color.Transparent;
            this.cmbSearchKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSearchKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchKhoa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSearchKhoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSearchKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSearchKhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSearchKhoa.ItemHeight = 30;
            this.cmbSearchKhoa.Location = new System.Drawing.Point(603, 58);
            this.cmbSearchKhoa.Name = "cmbSearchKhoa";
            this.cmbSearchKhoa.Size = new System.Drawing.Size(212, 36);
            this.cmbSearchKhoa.TabIndex = 7;
            this.cmbSearchKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbSearchKhoa_SelectedIndexChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(511, 69);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(57, 22);
            this.guna2HtmlLabel4.TabIndex = 6;
            this.guna2HtmlLabel4.Text = "Khoa";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 155);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(65, 22);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Họ tên";
            // 
            // txtSearchHoTen
            // 
            this.txtSearchHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchHoTen.DefaultText = "";
            this.txtSearchHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchHoTen.Location = new System.Drawing.Point(120, 145);
            this.txtSearchHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchHoTen.Name = "txtSearchHoTen";
            this.txtSearchHoTen.PlaceholderText = "";
            this.txtSearchHoTen.SelectedText = "";
            this.txtSearchHoTen.Size = new System.Drawing.Size(199, 32);
            this.txtSearchHoTen.TabIndex = 2;
            this.txtSearchHoTen.TextChanged += new System.EventHandler(this.txtSearchHoTen_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 68);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(65, 19);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Mã lớp";
            // 
            // txtSearchMaLop
            // 
            this.txtSearchMaLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchMaLop.DefaultText = "";
            this.txtSearchMaLop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchMaLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchMaLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchMaLop.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchMaLop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchMaLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchMaLop.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchMaLop.Location = new System.Drawing.Point(120, 58);
            this.txtSearchMaLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchMaLop.Name = "txtSearchMaLop";
            this.txtSearchMaLop.PlaceholderText = "";
            this.txtSearchMaLop.SelectedText = "";
            this.txtSearchMaLop.Size = new System.Drawing.Size(199, 32);
            this.txtSearchMaLop.TabIndex = 0;
            this.txtSearchMaLop.TextChanged += new System.EventHandler(this.txtSearchMaLop_TextChanged);
            // 
            // dgvLopHoc
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvLopHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvLopHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLopHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvLopHoc.ColumnHeadersHeight = 34;
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlop,
            this.malop,
            this.giaovien,
            this.tenkhoahoc,
            this.tenkhoa,
            this.tennganh,
            this.sosinhvien,
            this.ngaybatdau,
            this.ngayketthuc,
            this.chitiet});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLopHoc.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvLopHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLopHoc.Location = new System.Drawing.Point(12, 329);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.RowHeadersVisible = false;
            this.dgvLopHoc.RowHeadersWidth = 51;
            this.dgvLopHoc.RowTemplate.Height = 24;
            this.dgvLopHoc.Size = new System.Drawing.Size(1158, 312);
            this.dgvLopHoc.TabIndex = 8;
            this.dgvLopHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLopHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLopHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLopHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLopHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLopHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLopHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLopHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLopHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLopHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLopHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLopHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLopHoc.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvLopHoc.ThemeStyle.ReadOnly = false;
            this.dgvLopHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLopHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLopHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLopHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLopHoc.ThemeStyle.RowsStyle.Height = 24;
            this.dgvLopHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLopHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idlop
            // 
            this.idlop.DataPropertyName = "idlop";
            this.idlop.HeaderText = "ID Lớp";
            this.idlop.MinimumWidth = 6;
            this.idlop.Name = "idlop";
            this.idlop.Visible = false;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Mã lớp";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            // 
            // giaovien
            // 
            this.giaovien.DataPropertyName = "giaovien";
            this.giaovien.HeaderText = "Giáo viên";
            this.giaovien.MinimumWidth = 6;
            this.giaovien.Name = "giaovien";
            // 
            // tenkhoahoc
            // 
            this.tenkhoahoc.DataPropertyName = "tenkhoahoc";
            this.tenkhoahoc.HeaderText = "Khóa";
            this.tenkhoahoc.MinimumWidth = 6;
            this.tenkhoahoc.Name = "tenkhoahoc";
            // 
            // tenkhoa
            // 
            this.tenkhoa.DataPropertyName = "tenkhoa";
            this.tenkhoa.HeaderText = "Tên khoa";
            this.tenkhoa.MinimumWidth = 6;
            this.tenkhoa.Name = "tenkhoa";
            // 
            // tennganh
            // 
            this.tennganh.DataPropertyName = "tennganh";
            this.tennganh.HeaderText = "Tên ngành";
            this.tennganh.MinimumWidth = 6;
            this.tennganh.Name = "tennganh";
            // 
            // sosinhvien
            // 
            this.sosinhvien.DataPropertyName = "sosinhvien";
            this.sosinhvien.HeaderText = "Số sinh viên";
            this.sosinhvien.MinimumWidth = 6;
            this.sosinhvien.Name = "sosinhvien";
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.DataPropertyName = "ngaybatdau";
            this.ngaybatdau.HeaderText = "Ngày bắt đầu";
            this.ngaybatdau.MinimumWidth = 6;
            this.ngaybatdau.Name = "ngaybatdau";
            this.ngaybatdau.Visible = false;
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.DataPropertyName = "ngayketthuc";
            this.ngayketthuc.HeaderText = "Ngày kết thúc";
            this.ngayketthuc.MinimumWidth = 6;
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.Visible = false;
            // 
            // chitiet
            // 
            this.chitiet.HeaderText = "Chi tiết";
            this.chitiet.MinimumWidth = 6;
            this.chitiet.Name = "chitiet";
            // 
            // FormLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dgvLopHoc);
            this.Name = "FormLopHoc";
            this.Text = "FormLopHoc";
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnThemMoi;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSearchKhoaHoc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSearchNganh;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSearchKhoa;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchHoTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchMaLop;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoahoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sosinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn chitiet;
    }
}