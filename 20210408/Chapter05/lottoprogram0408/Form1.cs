using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottoprogram0408
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lotto_button.Text = "돌리기";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lotto_button_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int randomnum = r.Next(1, 46);
            string num = randomnum.ToString();
           
            if (randomnum < 10)
            {
                num = "0" + randomnum.ToString();
            }
            for (int i = 0; i < 6; i++)
            {
                randomnum = r.Next(1, 46);
                string temp = randomnum.ToString();
                if (randomnum < 10)
                {
                    temp = "0" + temp;
                }

                if (num.Contains(temp))
                {
                    i--;
                    continue;
                }
               
                num += "_" + temp;
            }
            Console.WriteLine(num);

            string[] lotto = num.Split('_');
            Label[] lotto_display = { label_1, label_2, label_3, label_4, 
                label_5, label_6,label_7 };

            for (int i = 0; i < lotto.Length; i++)
            {
                lotto_display[i].Text = lotto[i];
            }
            int[] lottonum2 = new int[lotto.Length];

            int temp2;
            for (int i = 0; i < lotto.Length; i++)
            {
                lottonum2[i] = int.Parse(lotto[i]);
            }
            for (int i = 0; i < lottonum2.Length; i++)
            {
                for (int j = 0; j < lottonum2.Length; j++)
                {
                    if (lottonum2[i] < lottonum2[j])
                    {
                        temp2 = lottonum2[i];
                        lottonum2[i] = lottonum2[j];
                        lottonum2[j] = temp2;
                        temp2 = 0;
                    }
                }
            }
            for (int i = 0; i < lottonum2.Length; i++)
            {
                Console.WriteLine(lottonum2[i]);
            }
            for (int i = 0; i < lotto.Length; i++)
            {
                lotto_display[i].Text = Convert.ToString(lottonum2[i]);
            }






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_6_Click(object sender, EventArgs e)
        {

        }

        private void label_5_Click(object sender, EventArgs e)
        {

        }

        private void label_4_Click(object sender, EventArgs e)
        {

        }

        private void label_3_Click(object sender, EventArgs e)
        {

        }

        private void label_2_Click(object sender, EventArgs e)
        {

        }

        private void label_1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
