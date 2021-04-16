using System;
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
            //  a = r.Next(1, 10);
            a = r.Next(10) + 1;
            Console.WriteLine("정답"+a);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            if (num == a)
            {
                MessageBox.Show("정답입니다");
                a = new Random().Next(10) + 1;
                Console.WriteLine("정답" + a);
            }

            else
            {
                if (num < a)
                {
                    MessageBox.Show("입력받은 수보다 큽니다");
                }


                if (num > a)
                {
                    MessageBox.Show("입력받은 수보다 작습니다");
                }
            }
            try
            {
                int choiceNumber = int.Parse(textBox1.Text);
                if(choiceNumber == a)
                {
                    time = 0;                  
                    a = new Random().Next(10) + 1;
                    Console.WriteLine(a);
                    label1.Text = "Finish!!";
                }
               
                
            }
            catch (Exception ee)
            {
                MessageBox.Show("숫자를 입력하세요");

            }
        }
        int time;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 10)
            {
                label2.Text = "timeover";
                time = 0;
            }
        }
    }
}
