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
    public partial class FormCbo : Form
    {
        public FormCbo()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lboInput.Items.Add(txtInput.Text);
            txtInput.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach(var item in lboInput.SelectedItems)
            {
                lboView.Items.Add(item);    
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            if(lboInput.SelectedItem!= null)
            {
                List<object> list = new List<object>();

                foreach(var item in lboInput.SelectedItems)
                {
                    lboView.Items.Add(item);
                    list.Add(item);
                }

                foreach(object item in list)
                {
                    lboInput.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một cái tên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lboInput.Items)
            {
                lboView.Items.Add(item);
            }
            lboInput.Items.Clear(); 
        }

        private void btnBackOne_Click(object sender, EventArgs e)
        {
            if (lboView.SelectedItem != null)
            {
                List<object> list = new List<object>();
                foreach (object item in lboView.SelectedItems)
                {
                    lboInput.Items.Add(item);
                    list.Add(item);
                }

                foreach(object item in list)
                {
                    lboView.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một cái tên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lboView.Items)
            {
                lboInput.Items.Add(item);
            }
            lboView.Items.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lboInput.Items.Clear();
        }
    }
}
