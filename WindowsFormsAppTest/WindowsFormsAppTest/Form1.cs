using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String soa = heSoA.Text;
            String sob = heSoB.Text;
            String soc = heSoC.Text;

            double a = double.Parse(heSoA.Text);
            double b = double.Parse(heSoB.Text);
            double c = double.Parse(heSoC.Text);


            Regex reg = new Regex(@"\d");
            bool isNum = Regex.IsMatch(heSoA.Text, @"^\d+$");
            
           
            double delta = b * b - 4 * a * c;
            if(delta > 0)
            {
                double n1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double n2 = (-b - Math.Sqrt(delta)) / (2 * a);

                // ketQua.Text = "n1 = " + n1+ "~~n2 = " + n2;
                MessageBox.Show("n1 = " + n1 + " ~~ n2 = " + n2);
            } 
            else if(delta == 0) 
            {
                double n = -b / (2 * a);
                // ketQua.Text = "n: " + n;
                MessageBox.Show("n = " + n);
            }
            else
            {
                // ketQua.Text = "Phương trình vô nghiệm";
                MessageBox.Show("Phương trình vô nghiệm");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
