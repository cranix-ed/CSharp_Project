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
    public partial class FormRadioButton : Form
    {
        public FormRadioButton()
        {
            InitializeComponent();
        }

        private void rdCong_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtSo1.Text);
                int b = int.Parse(txtSo2.Text);
                String kq = (a + b).ToString();

                txtKQ.Text = kq;
            }
            catch (Exception)
            {
                MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdTru_CheckedChanged(object sender, EventArgs e)
        {
            try 
            {
                int a = int.Parse(txtSo1.Text);
                int b = int.Parse(txtSo2.Text);
                String kq = (a - b).ToString();

                txtKQ.Text = kq; 
            }
            catch (Exception)
            {
                MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdNhan_CheckedChanged(object sender, EventArgs e)
        {
            try 
            {
                int a = int.Parse(txtSo1.Text);
                int b = int.Parse(txtSo2.Text);
                String kq = (a * b).ToString();

                txtKQ.Text = kq;
            }
            catch(Exception)
            {
                MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdChia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtSo1.Text);
                int b = int.Parse(txtSo2.Text);

                if (b == 0)
                {
                    MessageBox.Show("b phải lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                String kq = (a * 1.0 / b).ToString();
                txtKQ.Text = kq;
            } 
            catch(Exception) 
            { 
                MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
