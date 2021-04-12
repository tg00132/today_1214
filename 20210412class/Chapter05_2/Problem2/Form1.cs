using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem2
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        string[] ran = { "가위", "바위" ,"보"};

       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = r.Next(0, 3);
            int b = r.Next(0, 3);
            me.Text = ran[a];
            you.Text = ran[b];

            if(ran[a] == ran[b])
            {
                    MessageBox.Show("비겼습니다");
            }

            if(ran[a] == "보")
            {
                if(ran[b] == "바위")
                {
                    MessageBox.Show("나 가 이겼습니다");
                }
            }
            if (ran[a] == "바위")
            {
                if (ran[b] == "가위")
                {
                    MessageBox.Show("나 가 이겼습니다");
                }
            }
            if (ran[a] == "가위")
            {
                if (ran[b] == "보")
                {
                    MessageBox.Show("나 가 이겼습니다");
                }
            }
            if (ran[a] == "가위")
            {
                if (ran[b] == "바위")
                {
                    MessageBox.Show("상대 가 이겼습니다");
                }
            }
            if (ran[a] == "보")
            {
                if (ran[b] == "가위")
                {
                    MessageBox.Show("상대 가 이겼습니다");
                }
            }
            if (ran[a] == "바위")
            {
                if (ran[b] == "보")
                {
                    MessageBox.Show("상대 가 이겼습니다");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
