using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timeproblem1
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int choiceNumber = int.Parse(textBox1.Text);
                if (choiceNumber == a)
                {
                    time = 0;
                    a = new Random().Next(10) + 1;
                    Console.WriteLine(a);
                    label1.Text = "Finish!!";
                }
                else
                {
                    if(choiceNumber > a)
                    {
                        MessageBox.Show("선택한 숫자가 큽니다");
                    }
                    else
                    {
                        MessageBox.Show("선택한 숫자가 작습니다");
                    }
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
            if(time > 10)
            {
                label1.Text = "timeover";
                time = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                int choiceNumber = int.Parse(textBox1.Text);
            bool result = int.TryParse(textBox1.Text, out choiceNumber);
                if(result == false)
                {
                MessageBox.Show("숫자 입력하세요");
                return;
                }
                if (choiceNumber == a)
                {
                    time = 0;
                    a = new Random().Next(10) + 1;
                    Console.WriteLine(a);
                    label1.Text = "Finish!!";
                }
                else
                {
                    if (choiceNumber > a)
                    {
                        MessageBox.Show("선택한 숫자가 큽니다");
                    }
                    else
                    {
                        MessageBox.Show("선택한 숫자가 작습니다");
                    }
                }


            
          

        }
    }
}
