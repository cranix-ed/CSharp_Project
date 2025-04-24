namespace Project_CSharp.Forms.Anh
{
    partial class kyluat
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
            this.Thoat = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idkyluat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vipham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhthucxuly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbmasv = new System.Windows.Forms.ComboBox();
            this.txtngay = new System.Windows.Forms.DateTimePicker();
            this.txthinhthuc = new System.Windows.Forms.TextBox();
            this.txtvipham = new System.Windows.Forms.TextBox();
            this.txtmakl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchmasv = new System.Windows.Forms.ComboBox();
            this.Xuat = new System.Windows.Forms.Button();
            this.Timkiem = new System.Windows.Forms.Button();
            this.searchvipham = new System.Windows.Forms.TextBox();
            this.searchmakl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nhapexcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Thoat
            // 
            this.Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Thoat.Location = new System.Drawing.Point(763, 471);
            this.Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(76, 26);
            this.Thoat.TabIndex = 13;
            this.Thoat.Text = "Thoat";
            this.Thoat.UseVisualStyleBackColor = true;
            // 
            // Xoa
            // 
            this.Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Xoa.Location = new System.Drawing.Point(375, 471);
            this.Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(83, 26);
            this.Xoa.TabIndex = 12;
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
            this.Sua.TabIndex = 11;
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
            this.Luu.TabIndex = 10;
            this.Luu.Text = "Luu";
            this.Luu.UseVisualStyleBackColor = true;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkyluat,
            this.idsinhvien,
            this.vipham,
            this.hinhthucxuly,
            this.ngay});
            this.dataGridView1.Location = new System.Drawing.Point(11, 126);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 157);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idkyluat
            // 
            this.idkyluat.DataPropertyName = "idkyluat";
            this.idkyluat.HeaderText = "Ma ky luat";
            this.idkyluat.MinimumWidth = 8;
            this.idkyluat.Name = "idkyluat";
            // 
            // idsinhvien
            // 
            this.idsinhvien.DataPropertyName = "idsinhvien";
            this.idsinhvien.HeaderText = "Ma sinh vien";
            this.idsinhvien.MinimumWidth = 8;
            this.idsinhvien.Name = "idsinhvien";
            // 
            // vipham
            // 
            this.vipham.DataPropertyName = "vipham";
            this.vipham.HeaderText = "Vi pham";
            this.vipham.MinimumWidth = 8;
            this.vipham.Name = "vipham";
            // 
            // hinhthucxuly
            // 
            this.hinhthucxuly.DataPropertyName = "hinhthucxuly";
            this.hinhthucxuly.HeaderText = "Hinh thuc xu ly";
            this.hinhthucxuly.MinimumWidth = 8;
            this.hinhthucxuly.Name = "hinhthucxuly";
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "ngay";
            this.ngay.HeaderText = "Ngay";
            this.ngay.MinimumWidth = 8;
            this.ngay.Name = "ngay";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cbmasv);
            this.panel2.Controls.Add(this.txtngay);
            this.panel2.Controls.Add(this.txthinhthuc);
            this.panel2.Controls.Add(this.txtvipham);
            this.panel2.Controls.Add(this.txtmakl);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(11, 288);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 142);
            this.panel2.TabIndex = 8;
            // 
            // cbmasv
            // 
            this.cbmasv.FormattingEnabled = true;
            this.cbmasv.Location = new System.Drawing.Point(127, 61);
            this.cbmasv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbmasv.Name = "cbmasv";
            this.cbmasv.Size = new System.Drawing.Size(198, 24);
            this.cbmasv.TabIndex = 10;
            // 
            // txtngay
            // 
            this.txtngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngay.Location = new System.Drawing.Point(127, 101);
            this.txtngay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new System.Drawing.Size(178, 22);
            this.txtngay.TabIndex = 9;
            // 
            // txthinhthuc
            // 
            this.txthinhthuc.Location = new System.Drawing.Point(580, 80);
            this.txthinhthuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txthinhthuc.Name = "txthinhthuc";
            this.txthinhthuc.Size = new System.Drawing.Size(226, 22);
            this.txthinhthuc.TabIndex = 8;
            // 
            // txtvipham
            // 
            this.txtvipham.Location = new System.Drawing.Point(580, 33);
            this.txtvipham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtvipham.Name = "txtvipham";
            this.txtvipham.Size = new System.Drawing.Size(226, 22);
            this.txtvipham.TabIndex = 7;
            // 
            // txtmakl
            // 
            this.txtmakl.Location = new System.Drawing.Point(127, 12);
            this.txtmakl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmakl.Name = "txtmakl";
            this.txtmakl.Size = new System.Drawing.Size(208, 22);
            this.txtmakl.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ngày";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Hình thức kỷ luật";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vi phạm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã kỷ luật";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchmasv);
            this.panel1.Controls.Add(this.Xuat);
            this.panel1.Controls.Add(this.Timkiem);
            this.panel1.Controls.Add(this.searchvipham);
            this.panel1.Controls.Add(this.searchmakl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 103);
            this.panel1.TabIndex = 7;
            // 
            // searchmasv
            // 
            this.searchmasv.FormattingEnabled = true;
            this.searchmasv.Location = new System.Drawing.Point(127, 62);
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
            // searchvipham
            // 
            this.searchvipham.Location = new System.Drawing.Point(589, 42);
            this.searchvipham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchvipham.Name = "searchvipham";
            this.searchvipham.Size = new System.Drawing.Size(184, 22);
            this.searchvipham.TabIndex = 5;
            // 
            // searchmakl
            // 
            this.searchmakl.Location = new System.Drawing.Point(127, 18);
            this.searchmakl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchmakl.Name = "searchmakl";
            this.searchmakl.Size = new System.Drawing.Size(208, 22);
            this.searchmakl.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vi phạm";
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
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã kỷ luật";
            // 
            // nhapexcel
            // 
            this.nhapexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nhapexcel.Location = new System.Drawing.Point(538, 471);
            this.nhapexcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nhapexcel.Name = "nhapexcel";
            this.nhapexcel.Size = new System.Drawing.Size(131, 26);
            this.nhapexcel.TabIndex = 14;
            this.nhapexcel.Text = "Nhập Excel";
            this.nhapexcel.UseVisualStyleBackColor = true;
            this.nhapexcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // kyluat
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
            this.Name = "kyluat";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.kyluat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker txtngay;
        private System.Windows.Forms.TextBox txthinhthuc;
        private System.Windows.Forms.TextBox txtvipham;
        private System.Windows.Forms.TextBox txtmakl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Xuat;
        private System.Windows.Forms.Button Timkiem;
        private System.Windows.Forms.TextBox searchvipham;
        private System.Windows.Forms.TextBox searchmakl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkyluat;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn vipham;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhthucxuly;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.ComboBox cbmasv;
        private System.Windows.Forms.ComboBox searchmasv;
        private System.Windows.Forms.Button nhapexcel;
    }
}