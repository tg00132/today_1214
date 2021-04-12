using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem4
{
    public partial class Form1 : Form
    {
        public List<string> list = new List<string>();
        Random r = new Random();
        int a;

        public Form1()
        {
           
            InitializeComponent();
            a = r.Next(0, 100);
            button1.Text=  Convert.ToString(r.Next(0, 100));
            button2.Text = Convert.ToString(r.Next(0, 100));
            button3.Text = Convert.ToString(r.Next(0, 100));
            button4.Text = Convert.ToString(r.Next(0, 100));
            button5.Text = button1.Text;
            button6.Text = button2.Text;
            button7.Text = button3.Text;
            button8.Text = button4.Text;

        }

        //private void inputLabel()
        //{
        //    labelname.Text += list[0];
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(button1.Text);
            labelname.Text = "";
            foreach (var item in list)
            {
                labelname.Text += item + " ";
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Add(button2.Text);
            labelname.Text = "";
            foreach (var item in list)
            {
                labelname.Text += item + " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Add(button3.Text);
            labelname.Text = "";
            foreach (var item in list)
            {
                labelname.Text += item + " ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Add(button4.Text);
            labelname.Text = "";
            foreach (var item in list)
            {
                labelname.Text += item + " ";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list.Remove(button5.Text);
            labelname.Text = "";
            foreach (var item in list)
            {
                labelname.Text += item + " ";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            list.Remove(button6.Text);
            labelname.Text = "";
            foreach (var item in list)
            {
                labelname.Text += item + " ";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            list.Remove(button7.Text);
            labelname.Text = "";
            foreach (var item in list)
            {
                labelname.Text += item + " ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            list.Remove(button8.Text);
            labelname.Text = "";
            foreach (var item in list)
            {
                labelname.Text += item + " ";
            }
        }
    }
}
