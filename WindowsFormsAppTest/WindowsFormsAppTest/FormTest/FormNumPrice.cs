using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest.FormTest
{
    public partial class FormNumPrice : Form
    {
        public FormNumPrice()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool isNum = int.TryParse(txtNum.Text, out int result);
            /* if (!isNum)
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum.Text = "";
            } */
            cboNum.Items.Add(txtNum.Text);
            txtNum.Text = "";
            txtNum.Focus();
        }

        private void cboNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = int.Parse(cboNum.SelectedItem.ToString());
            for (int i = 1; i < Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    lboNum.Items.Add(i.ToString());
                    if(i != num / i)
                    {
                        lboNum.Items.Add(i.ToString());

                    }
                }
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach(object item in lboNum.Items)
            {
                sum+= int.Parse(item.ToString());
            }

            MessageBox.Show("Tổng các ước số là: " + sum, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(object item in lboNum.Items)
            {
                int num = int.Parse(item.ToString());
                if (num % 2 == 0)
                {
                    count++;
                }
            }

            MessageBox.Show("Số lượng các ước số chẵn: " + count, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCountPrime_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(object item in lboNum.Items)
            {
                int num = int.Parse(item.ToString());
                if (num < 2) { continue; }
                if(num == 2 || num == 3) { count++; }

                for(int i = 5; i * i < num; i += 6)
                {
                    if(num % 2 != 0 || num % (i + 2) != 0)
                    {
                        count++;
                    }
                }
            }

            MessageBox.Show("Số lượng các ước số nguyên tố: " + count, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
