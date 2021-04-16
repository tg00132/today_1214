using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem0413
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cm = inchCm(int.Parse(textBox1.Text));
            label1.Text = Convert.ToString(cm + "cm");
        }

        private double inchCm(double inch)
        {
            double cm = inch * 2.54;
            return cm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double pound = Poundkg(int.Parse(textBox2.Text));
            label2.Text = Convert.ToString(pound + "pound");
        }

        private double Poundkg(double kg)
        {
            double pound = kg * 2.20462262;
            return pound;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label7.Text = "";
            int r = int.Parse(textBox3.Text);
            double doolle_answer = doolle(r);
            if (doolle_answer == -1)
                return;
            double area_answer = area(r);
            if (area_answer == -1)
                return;
            label3.Text = doolle_answer.ToString();
            label7.Text = area_answer.ToString();
        }

        private double doolle(int r)
        {
            if (r < 0)
            {
                MessageBox.Show(r+"은 음수 입니다");
                return -1;
            }
            else
            {
                return 2 * 3.14 * r;
            }
        }
        private double area(int r)
        {
            if (r < 0)
            {
                MessageBox.Show(r +"은 음수입니다");
                return -1;
            }
            else
            {
                return r * r * 3.14;
            }
        }
    }
}
