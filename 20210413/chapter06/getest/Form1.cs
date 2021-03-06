﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rect rec = new Rect();
            int.TryParse(textBox1.Text, out rec.w);
            int.TryParse(textBox2.Text, out rec.h);
            MessageBox.Show("사각형의 넓이는" + rec.getArea());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rect rec = new Rect();
            int.TryParse(textBox1.Text, out int width);
            int.TryParse(textBox2.Text, out int height);

            rec.setWidth(width);
            rec.setHeight(height);

            if(rec.getWidth()==0|| rec.getHeight() == 0)
            {
                MessageBox.Show("넓이나 높이에 이상한 값이 들어갔음!");
                return;
            }
            MessageBox.Show("사각형의 넓이는 " + rec.getArea_with_getset());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Circle c = new Circle();
            c.R = 100; //set 호출해서 value에 100넣은거임
            MessageBox.Show(c.R+"입니다");


            int radi;
            int.TryParse(textBox1.Text, out radi);
            c.radi = radi;
            if(c.radi == 0) 
            {
                MessageBox.Show("양수를 써라");
            }
            else
            {
                MessageBox.Show(c.R + "입니다");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Person p = new Person();
            Person p = new Person("홍길동", 23);
            MessageBox.Show(p.name +"," +p.age);

            Person p2 = new Person(textBox4.Text); //이름만 아는 경우
            int.TryParse(textBox5.Text, out int age);
            p2.age = age;
            MessageBox.Show(p2.name + "," + p2.age);

            Person p3 = new Person(); //아무것도 모르는 경우
            p3.name = textBox4.Text;
            p3.age = int.Parse(textBox5.Text);
            MessageBox.Show(p3.name + "," + p3.age);

            int yourAge = 300;
            yourAge = 30; // 변수는 선언 이후 값이 변할수 있음.

            const int myAge = 33;
            //myAge = 23; //상수는 한번 선언되면 값이 못 바뀜;


            



        }

        private void button5_Click(object sender, EventArgs e)
        {
            //일반 변수
            string name = "김길동";
            string name2 = name;
            name2 = "최길동";
            MessageBox.Show(name + "vs" + name2);

            //참조 변수
            Person p = new Person("박길동", 100);
            Person p2 = p;
            p2.name = "이길동";
            p2.age = 500;
            MessageBox.Show(p.name + "vs" +p2.name);
        }
    }
}
