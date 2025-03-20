using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest.FormTest
{
    public partial class methodOfForm : Form
    {
        public methodOfForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void methodOfForm_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn mở chương trình?", "Người dùng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                Dispose();
        }

        private void hienThi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Họ và Tên: " + hoVaTen.Text,"", MessageBoxButtons.OK);
        }

        private void methodOfForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers==Keys.Alt && e.KeyCode==Keys.H)
            {
                hoVaTen.Text = "Trường đại học Công nghệ Giao thông vận tải";
            }
        }

        private void methodOfForm_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Bạn vừa ấn chuột trái");
            }
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Bạn vừa ấn chuột phải");
            }
            if (e.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Bạn mới dùng chân gữa");
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát à?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }    
        }
    }
}
