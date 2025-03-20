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
    public partial class FormRadioFont : Form
    {
        public FormRadioFont()
        {
            InitializeComponent();
        }

        private void UpdateFont()
        {
            FontStyle style = FontStyle.Regular;

            if (cbBold.Checked)
                style |= FontStyle.Bold;
            if (cbItalic.Checked)
                style |= FontStyle.Italic;
            if (cbU.Checked)
                style |= FontStyle.Underline;

            lbTen.Font = new Font("", 8, style);
        }

        private void rdRed_CheckedChanged(object sender, EventArgs e)
        {
            lbTen.ForeColor = Color.Red;
        }

        private void rdGreen_CheckedChanged(object sender, EventArgs e)
        {
            lbTen.ForeColor = Color.Green;
        }

        private void rdBlue_CheckedChanged(object sender, EventArgs e)
        {
            lbTen.ForeColor = Color.Blue;
        }

        private void rdBlack_CheckedChanged(object sender, EventArgs e)
        {
            lbTen.ForeColor = Color.Black;
        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void cbU_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            lbTen.Text = txtTen.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialogName.ShowDialog() == DialogResult.OK)
            {
                lbTen.ForeColor = colorDialogName.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if(fontDialogName.ShowDialog() == DialogResult.OK)
            {
                lbTen.Font = fontDialogName.Font;
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            if(openFileDialogName.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialogName.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            saveFileDialogName.DefaultExt = ".png";
            saveFileDialogName.ShowDialog();
            pictureBox1.Image.Save(saveFileDialogName.FileName);
        }
    }
}
