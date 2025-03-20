namespace WindowsFormsAppTest.FormTest
{
    partial class methodOfForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.hoVaTen = new System.Windows.Forms.TextBox();
            this.hienThi = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hoVaTen
            // 
            this.hoVaTen.Location = new System.Drawing.Point(279, 68);
            this.hoVaTen.Name = "hoVaTen";
            this.hoVaTen.Size = new System.Drawing.Size(314, 22);
            this.hoVaTen.TabIndex = 1;
            // 
            // hienThi
            // 
            this.hienThi.Location = new System.Drawing.Point(279, 144);
            this.hienThi.Name = "hienThi";
            this.hienThi.Size = new System.Drawing.Size(75, 23);
            this.hienThi.TabIndex = 2;
            this.hienThi.Text = "Hiển thị";
            this.hienThi.UseVisualStyleBackColor = true;
            this.hienThi.Click += new System.EventHandler(this.hienThi_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(415, 144);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 23);
            this.thoat.TabIndex = 3;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // methodOfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.hienThi);
            this.Controls.Add(this.hoVaTen);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "methodOfForm";
            this.Text = "methodOfForm";
            this.Load += new System.EventHandler(this.methodOfForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.methodOfForm_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.methodOfForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hoVaTen;
        private System.Windows.Forms.Button hienThi;
        private System.Windows.Forms.Button thoat;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
    }
}