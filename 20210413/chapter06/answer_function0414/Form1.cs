using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace answer_function0414
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int input);
            Mymath m = new Mymath();
            MessageBox.Show(textBox1.Text+"의 제곱은"+m.Power(input));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int input);
            int.TryParse(textBox2.Text, out int count);
            MessageBox.Show(textBox1.Text + "의 " + textBox2.Text + "곱은" + Mymath.Power(input,count));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int end);
            MessageBox.Show("0부터" +end+"까지의 합은" + Mymath.SumAll(end));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int start);
            int.TryParse(textBox4.Text, out int end);
            MessageBox.Show(start +"부터" +  end + "까지의 합은" + Mymath.SumAll(start,end));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mymath m = new Mymath();
            int.TryParse(textBox3.Text, out m.end);
            MessageBox.Show("0부터" +m.end+"까지의 합은 "+ m.SumAll());

            Mymath m2 = new Mymath();
            int.TryParse(textBox4.Text, out m2.end);
            MessageBox.Show("0부터" + m2.end + "까지의 합은 " + m2.SumAll());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mymath a = new Mymath();
            a.end = 100;
        }
    }
}
