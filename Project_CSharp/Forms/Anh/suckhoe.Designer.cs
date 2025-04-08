namespace Project_CSharp.Forms.Anh
{
    partial class suckhoe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchmsv = new System.Windows.Forms.ComboBox();
            this.Xuat = new System.Windows.Forms.Button();
            this.Timkiem = new System.Windows.Forms.Button();
            this.searchvande = new System.Windows.Forms.TextBox();
            this.searchmahs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbmasv = new System.Windows.Forms.ComboBox();
            this.txtngay = new System.Windows.Forms.DateTimePicker();
            this.txtdieutri = new System.Windows.Forms.TextBox();
            this.txtvande = new System.Windows.Forms.TextBox();
            this.txtmahs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idhosuckhoe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dieutri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luu = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.nhapexcel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.searchmsv);
            this.panel1.Controls.Add(this.Xuat);
            this.panel1.Controls.Add(this.Timkiem);
            this.panel1.Controls.Add(this.searchvande);
            this.panel1.Controls.Add(this.searchmahs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 103);
            this.panel1.TabIndex = 0;
            // 
            // searchmsv
            // 
            this.searchmsv.FormattingEnabled = true;
            this.searchmsv.Location = new System.Drawing.Point(132, 64);
            this.searchmsv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchmsv.Name = "searchmsv";
            this.searchmsv.Size = new System.Drawing.Size(203, 24);
            this.searchmsv.TabIndex = 8;
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
            // searchvande
            // 
            this.searchvande.Location = new System.Drawing.Point(589, 42);
            this.searchvande.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchvande.Name = "searchvande";
            this.searchvande.Size = new System.Drawing.Size(184, 22);
            this.searchvande.TabIndex = 5;
            // 
            // searchmahs
            // 
            this.searchmahs.Location = new System.Drawing.Point(127, 18);
            this.searchmahs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchmahs.Name = "searchmahs";
            this.searchmahs.Size = new System.Drawing.Size(208, 22);
            this.searchmahs.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Van de";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ma sinh vien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma ho so";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cbmasv);
            this.panel2.Controls.Add(this.txtngay);
            this.panel2.Controls.Add(this.txtdieutri);
            this.panel2.Controls.Add(this.txtvande);
            this.panel2.Controls.Add(this.txtmahs);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(11, 279);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 142);
            this.panel2.TabIndex = 1;
            // 
            // cbmasv
            // 
            this.cbmasv.FormattingEnabled = true;
            this.cbmasv.Location = new System.Drawing.Point(127, 54);
            this.cbmasv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbmasv.Name = "cbmasv";
            this.cbmasv.Size = new System.Drawing.Size(208, 24);
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
            // txtdieutri
            // 
            this.txtdieutri.Location = new System.Drawing.Point(580, 80);
            this.txtdieutri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdieutri.Name = "txtdieutri";
            this.txtdieutri.Size = new System.Drawing.Size(226, 22);
            this.txtdieutri.TabIndex = 8;
            // 
            // txtvande
            // 
            this.txtvande.Location = new System.Drawing.Point(580, 33);
            this.txtvande.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtvande.Name = "txtvande";
            this.txtvande.Size = new System.Drawing.Size(226, 22);
            this.txtvande.TabIndex = 7;
            // 
            // txtmahs
            // 
            this.txtmahs.Location = new System.Drawing.Point(127, 12);
            this.txtmahs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmahs.Name = "txtmahs";
            this.txtmahs.Size = new System.Drawing.Size(208, 22);
            this.txtmahs.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ngay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Dieu tri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Van de";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ma sinh vien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ma ho so";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idhosuckhoe,
            this.idsinhvien,
            this.vande,
            this.dieutri,
            this.ngay});
            this.dataGridView1.Location = new System.Drawing.Point(11, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 157);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idhosuckhoe
            // 
            this.idhosuckhoe.DataPropertyName = "idhosuckhoe";
            this.idhosuckhoe.HeaderText = "Ma ho so";
            this.idhosuckhoe.MinimumWidth = 8;
            this.idhosuckhoe.Name = "idhosuckhoe";
            // 
            // idsinhvien
            // 
            this.idsinhvien.DataPropertyName = "idsinhvien";
            this.idsinhvien.HeaderText = "Ma sinh vien";
            this.idsinhvien.MinimumWidth = 8;
            this.idsinhvien.Name = "idsinhvien";
            // 
            // vande
            // 
            this.vande.DataPropertyName = "vande";
            this.vande.HeaderText = "Van de";
            this.vande.MinimumWidth = 8;
            this.vande.Name = "vande";
            // 
            // dieutri
            // 
            this.dieutri.DataPropertyName = "dieutri";
            this.dieutri.HeaderText = "Dieu tri";
            this.dieutri.MinimumWidth = 8;
            this.dieutri.Name = "dieutri";
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "ngay";
            this.ngay.HeaderText = "Ngay";
            this.ngay.MinimumWidth = 8;
            this.ngay.Name = "ngay";
            // 
            // Luu
            // 
            this.Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Luu.Location = new System.Drawing.Point(37, 462);
            this.Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(74, 26);
            this.Luu.TabIndex = 3;
            this.Luu.Text = "Luu";
            this.Luu.UseVisualStyleBackColor = true;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // Sua
            // 
            this.Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Sua.Location = new System.Drawing.Point(186, 462);
            this.Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(78, 26);
            this.Sua.TabIndex = 4;
            this.Sua.Text = "Sua";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Xoa.Location = new System.Drawing.Point(357, 462);
            this.Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(83, 26);
            this.Xoa.TabIndex = 5;
            this.Xoa.Text = "Xoa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Thoat
            // 
            this.Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Thoat.Location = new System.Drawing.Point(697, 462);
            this.Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(76, 26);
            this.Thoat.TabIndex = 6;
            this.Thoat.Text = "Thoat";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // nhapexcel
            // 
            this.nhapexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nhapexcel.Location = new System.Drawing.Point(531, 462);
            this.nhapexcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nhapexcel.Name = "nhapexcel";
            this.nhapexcel.Size = new System.Drawing.Size(92, 26);
            this.nhapexcel.TabIndex = 7;
            this.nhapexcel.Text = "Nhập Excel";
            this.nhapexcel.UseVisualStyleBackColor = true;
            // 
            // suckhoe
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
            this.Name = "suckhoe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.suckhoe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Xuat;
        private System.Windows.Forms.Button Timkiem;
        private System.Windows.Forms.TextBox searchvande;
        private System.Windows.Forms.TextBox searchmahs;
        private System.Windows.Forms.DateTimePicker txtngay;
        private System.Windows.Forms.TextBox txtdieutri;
        private System.Windows.Forms.TextBox txtvande;
        private System.Windows.Forms.TextBox txtmahs;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhosuckhoe;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn vande;
        private System.Windows.Forms.DataGridViewTextBoxColumn dieutri;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.ComboBox searchmsv;
        private System.Windows.Forms.ComboBox cbmasv;
        private System.Windows.Forms.Button nhapexcel;
    }
}