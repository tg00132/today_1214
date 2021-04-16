using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace overloding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            black();
        }

        private void black()
        {
            MessageBox.Show("리플");
        }
        private void black(string name)
        {
            MessageBox.Show(name);
        }
        private void black(string name, string name2)
        {
            MessageBox.Show(name + name2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            black(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            black(button2.Text,button1.Text);
        }
    }
}
