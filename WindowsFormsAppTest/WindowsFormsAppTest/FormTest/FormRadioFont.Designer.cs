namespace WindowsFormsAppTest.FormTest
{
    partial class FormRadioFont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRadioFont));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBlack = new System.Windows.Forms.RadioButton();
            this.rdBlue = new System.Windows.Forms.RadioButton();
            this.rdGreen = new System.Windows.Forms.RadioButton();
            this.rdRed = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbU = new System.Windows.Forms.CheckBox();
            this.cbItalic = new System.Windows.Forms.CheckBox();
            this.cbBold = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialogName = new System.Windows.Forms.ColorDialog();
            this.btnFont = new System.Windows.Forms.Button();
            this.fontDialogName = new System.Windows.Forms.FontDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.openFileDialogName = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.saveFileDialogName = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Name = "label1";
            // 
            // txtTen
            // 
            resources.ApplyResources(this.txtTen, "txtTen");
            this.txtTen.Name = "txtTen";
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBlack);
            this.groupBox1.Controls.Add(this.rdBlue);
            this.groupBox1.Controls.Add(this.rdGreen);
            this.groupBox1.Controls.Add(this.rdRed);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rdBlack
            // 
            resources.ApplyResources(this.rdBlack, "rdBlack");
            this.rdBlack.Name = "rdBlack";
            this.rdBlack.TabStop = true;
            this.rdBlack.UseVisualStyleBackColor = true;
            this.rdBlack.CheckedChanged += new System.EventHandler(this.rdBlack_CheckedChanged);
            // 
            // rdBlue
            // 
            resources.ApplyResources(this.rdBlue, "rdBlue");
            this.rdBlue.ForeColor = System.Drawing.Color.Blue;
            this.rdBlue.Name = "rdBlue";
            this.rdBlue.TabStop = true;
            this.rdBlue.UseVisualStyleBackColor = true;
            this.rdBlue.CheckedChanged += new System.EventHandler(this.rdBlue_CheckedChanged);
            // 
            // rdGreen
            // 
            resources.ApplyResources(this.rdGreen, "rdGreen");
            this.rdGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdGreen.Name = "rdGreen";
            this.rdGreen.TabStop = true;
            this.rdGreen.UseVisualStyleBackColor = true;
            this.rdGreen.CheckedChanged += new System.EventHandler(this.rdGreen_CheckedChanged);
            // 
            // rdRed
            // 
            resources.ApplyResources(this.rdRed, "rdRed");
            this.rdRed.ForeColor = System.Drawing.Color.Red;
            this.rdRed.Name = "rdRed";
            this.rdRed.TabStop = true;
            this.rdRed.UseVisualStyleBackColor = true;
            this.rdRed.CheckedChanged += new System.EventHandler(this.rdRed_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbU);
            this.groupBox2.Controls.Add(this.cbItalic);
            this.groupBox2.Controls.Add(this.cbBold);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cbU
            // 
            resources.ApplyResources(this.cbU, "cbU");
            this.cbU.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbU.Name = "cbU";
            this.cbU.UseVisualStyleBackColor = true;
            this.cbU.CheckedChanged += new System.EventHandler(this.cbU_CheckedChanged);
            // 
            // cbItalic
            // 
            resources.ApplyResources(this.cbItalic, "cbItalic");
            this.cbItalic.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.UseVisualStyleBackColor = true;
            this.cbItalic.CheckedChanged += new System.EventHandler(this.cbItalic_CheckedChanged);
            // 
            // cbBold
            // 
            resources.ApplyResources(this.cbBold, "cbBold");
            this.cbBold.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbBold.Name = "cbBold";
            this.cbBold.UseVisualStyleBackColor = true;
            this.cbBold.CheckedChanged += new System.EventHandler(this.cbBold_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Name = "label2";
            // 
            // lbTen
            // 
            this.lbTen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.lbTen, "lbTen");
            this.lbTen.Name = "lbTen";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnColor
            // 
            resources.ApplyResources(this.btnColor, "btnColor");
            this.btnColor.Name = "btnColor";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFont
            // 
            resources.ApplyResources(this.btnFont, "btnFont");
            this.btnFont.Name = "btnFont";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnImage
            // 
            resources.ApplyResources(this.btnImage, "btnImage");
            this.btnImage.Name = "btnImage";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // openFileDialogName
            // 
            this.openFileDialogName.FileName = "openFileDialog1";
            // 
            // btnSaveImage
            // 
            resources.ApplyResources(this.btnSaveImage, "btnSaveImage");
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // FormRadioFont
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Name = "FormRadioFont";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBlack;
        private System.Windows.Forms.RadioButton rdBlue;
        private System.Windows.Forms.RadioButton rdGreen;
        private System.Windows.Forms.RadioButton rdRed;
        private System.Windows.Forms.CheckBox cbU;
        private System.Windows.Forms.CheckBox cbItalic;
        private System.Windows.Forms.CheckBox cbBold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialogName;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog fontDialogName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogName;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialogName;
    }
}