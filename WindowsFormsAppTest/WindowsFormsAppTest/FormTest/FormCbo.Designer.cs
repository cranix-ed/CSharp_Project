namespace WindowsFormsAppTest.FormTest
{
    partial class FormCbo
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lboInput = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lboView = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddOne = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnBackOne = new System.Windows.Forms.Button();
            this.btnBackAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(201, 30);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(209, 22);
            this.txtInput.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(461, 30);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 31);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lboInput
            // 
            this.lboInput.FormattingEnabled = true;
            this.lboInput.ItemHeight = 16;
            this.lboInput.Items.AddRange(new object[] {
            "cs",
            "vsec",
            "vcs"});
            this.lboInput.Location = new System.Drawing.Point(68, 139);
            this.lboInput.Name = "lboInput";
            this.lboInput.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lboInput.Size = new System.Drawing.Size(209, 164);
            this.lboInput.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(484, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Kết thúc";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lboView
            // 
            this.lboView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lboView.FormattingEnabled = true;
            this.lboView.ItemHeight = 16;
            this.lboView.Location = new System.Drawing.Point(433, 139);
            this.lboView.Name = "lboView";
            this.lboView.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lboView.Size = new System.Drawing.Size(190, 164);
            this.lboView.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ và tên";
            // 
            // btnAddOne
            // 
            this.btnAddOne.Location = new System.Drawing.Point(335, 139);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(43, 23);
            this.btnAddOne.TabIndex = 11;
            this.btnAddOne.Text = ">";
            this.btnAddOne.UseVisualStyleBackColor = true;
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(335, 186);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(43, 23);
            this.btnAddAll.TabIndex = 12;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnBackOne
            // 
            this.btnBackOne.Location = new System.Drawing.Point(335, 236);
            this.btnBackOne.Name = "btnBackOne";
            this.btnBackOne.Size = new System.Drawing.Size(43, 23);
            this.btnBackOne.TabIndex = 13;
            this.btnBackOne.Text = "<";
            this.btnBackOne.UseVisualStyleBackColor = true;
            this.btnBackOne.Click += new System.EventHandler(this.btnBackOne_Click);
            // 
            // btnBackAll
            // 
            this.btnBackAll.Location = new System.Drawing.Point(335, 280);
            this.btnBackAll.Name = "btnBackAll";
            this.btnBackAll.Size = new System.Drawing.Size(43, 23);
            this.btnBackAll.TabIndex = 14;
            this.btnBackAll.Text = "<<";
            this.btnBackAll.UseVisualStyleBackColor = true;
            this.btnBackAll.Click += new System.EventHandler(this.btnBackAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormCbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBackAll);
            this.Controls.Add(this.btnBackOne);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnAddOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lboInput);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtInput);
            this.Name = "FormCbo";
            this.Text = "FormCbo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lboInput;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lboView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnBackOne;
        private System.Windows.Forms.Button btnBackAll;
        private System.Windows.Forms.Button button1;
    }
}