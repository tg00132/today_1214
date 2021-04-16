using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateLamda
{
    public partial class Form1 : Form
    {
        delegate void TestDelegate();
        public Form1()
        {
            InitializeComponent();

            Button button2 = new Button();
            button2.Text = "코드로 만든 버튼";
            button2.AutoSize = true;
            button2.Location = new Point(100, 100);
            button2.Click += Button2_Click;
            button2.Click += Button2_Click1;
            button2.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("Test delegate");
            };
            button2.Click += (object sender, EventArgs e) => { MessageBox.Show("lamda"); };
            Controls.Add(button2);
        }

        private void Button2_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("Test222222");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("두 번째 버튼을 클릭하셨습니다.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestDelegate a = Hello;
            TestDelegate b = delegate ()
            {MessageBox.Show("안녕하세요");};
            TestDelegate c = () =>
            {MessageBox.Show("안녕하세요");};

            a();
            b();
            c();
            exCallBack(a);
        }
        private void Hello()
        {
            MessageBox.Show("안녕하세요");
        }
        private void exCallBack(TestDelegate t)
        {
            for (int i = 0; i < 3; i++)
            {
                t();
            }
        }
    }
}
