using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "안녕";
            int abc = 100;
            if (abc == 100)
                button1.Enabled = false;


            Button b = new Button();
            b.Text = "반갑다";
            b.Location = new Point(50, 50); //form1을 기준으로 x축 y축 
            Controls.Add(b); // 만든걸 나타냄

            List<int> iList = new List<int>();
            iList.Add(10);
            iList.Add(50);
            iList.Add(123);
            for (int i = 0; i < iList.Count; i++)
            {
                Console.WriteLine(iList[i]);
            }
            iList.Add(1000);
            MessageBox.Show(iList.Count + "개");

            List<string> sList = new List<string>();
            sList.Add("홍길동");
            sList.Add("김길동");
            sList.Add("박길동");
            sList.Add("이길동");
            MessageBox.Show(sList.Count + "명");
            sList.Remove("박길동");            
            string names = string.Empty;
            for (int i = 0; i < sList.Count; i++)
            {
                names += sList[i];
            }
            MessageBox.Show(names);

            Label l = new Label();
            l.Text = "절댓값: " + Math.Abs(-1000);
            l.Location = new Point(100, 100);
            Controls.Add(l);


            int pp;
            int ppp = 0;
            product p = new product();
            p.name = "코인";
            p.price = 2000000;
            product.count++;
            MessageBox.Show("제품명 : " +p.name);
            MessageBox.Show("제품가격 : " + p.price);
            MessageBox.Show("제품개수 :" +product.count);

            product p2 = new product();
            p2.name = "비트";
            p2.price = 50000;
            product.count++;


            //선언과 동시에 값들 지정
            product p3 = new product() { name = "업비트", price = 5000 };

            Dog dj = new Dog("리플",3000);
            MessageBox.Show(dj.name+dj.age);
            Dog abcc = new Dog("넴", 700);
            MessageBox.Show("코인:" + Dog.theNumberofDog);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }
    }
}
