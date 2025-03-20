namespace WindowsFormsAppTest.FormTest
{
    partial class FormNumPrice
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
            this.btnSum = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnCountPrime = new System.Windows.Forms.Button();
            this.lboNum = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboNum = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(6, 194);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(340, 23);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "Tổng các ước số";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(6, 223);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(340, 23);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Số lượng các ước số chẵn";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnCountPrime
            // 
            this.btnCountPrime.Location = new System.Drawing.Point(6, 266);
            this.btnCountPrime.Name = "btnCountPrime";
            this.btnCountPrime.Size = new System.Drawing.Size(340, 23);
            this.btnCountPrime.TabIndex = 5;
            this.btnCountPrime.Text = "Số lượng các ước số nguyên tố";
            this.btnCountPrime.UseVisualStyleBackColor = true;
            this.btnCountPrime.Click += new System.EventHandler(this.btnCountPrime_Click);
            // 
            // lboNum
            // 
            this.lboNum.FormattingEnabled = true;
            this.lboNum.ItemHeight = 16;
            this.lboNum.Location = new System.Drawing.Point(6, 25);
            this.lboNum.Name = "lboNum";
            this.lboNum.Size = new System.Drawing.Size(340, 132);
            this.lboNum.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNum);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Location = new System.Drawing.Point(36, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 149);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(36, 37);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(133, 22);
            this.txtNum.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(193, 37);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.Enter += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboNum
            // 
            this.cboNum.FormattingEnabled = true;
            this.cboNum.Location = new System.Drawing.Point(36, 88);
            this.cboNum.Name = "cboNum";
            this.cboNum.Size = new System.Drawing.Size(133, 24);
            this.cboNum.TabIndex = 11;
            this.cboNum.SelectedIndexChanged += new System.EventHandler(this.cboNum_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lboNum);
            this.groupBox2.Controls.Add(this.btnSum);
            this.groupBox2.Controls.Add(this.btnCountPrime);
            this.groupBox2.Controls.Add(this.btnCount);
            this.groupBox2.Location = new System.Drawing.Point(436, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 349);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(275, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // FormNumPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNumPrice";
            this.Text = "FormNumPrice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnCountPrime;
        private System.Windows.Forms.ListBox lboNum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboNum;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
    }
}