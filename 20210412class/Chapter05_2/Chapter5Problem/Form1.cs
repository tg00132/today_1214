﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter5Problem
{
    public partial class Form1 : Form
    {
        
        Random r = new Random();
        int a;
       
        public Form1()
        {
            InitializeComponent();
            a = r.Next(1, 10);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a == int.Parse(textBox1.Text))
            {
                MessageBox.Show("정답입니다");
                 a = r.Next(1, 10);
            }
            if (a > int.Parse(textBox1.Text))
            {
                MessageBox.Show("입력받은 수보다 큽니다");
            }
            if (a <int.Parse(textBox1.Text))
            {
                MessageBox.Show("입력받은 수보다 작습니다");
            }
        }
    }
}
