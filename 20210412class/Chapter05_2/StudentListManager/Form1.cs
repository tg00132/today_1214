﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentListManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "정연우", grade = 1 });
            Student s = new Student() { name = "홍길동" , grade =2 };
            students.Add(s);
            Student ss = new Student();
            ss.name = "박길동";
            ss.grade = 3;
            students.Add(ss);
            students.Add(new Student() { name = "김동준", grade = 4 });
            students.Add(new Student() { name = "박동준", grade = 1 });
            students.Add(new Student() { name = "최동준", grade = 2 });

           // string names = "";
            for (int i = 0; i < students.Count; i++)
            {
                //names += students[i].name + "" + students[i].grade + "\n";
                Label label = new Label();
                label.Text = $"{students[i].grade}학년 {students[i].name}학생";
                label.AutoSize = true;
                label.Location = new Point(13, 13 + (26*i));
                Controls.Add(label);
            }
            //MessageBox.Show(names);

            //for (int i = 0; i < students.Count; i++)일반적 for문
            for(int i=students.Count-1; i>=0; i--) //역 for문
            {
                if (students[i].grade > 1)
                    students.RemoveAt(i);
            }
            for (int i = 0; i < students.Count; i++)
            {
                //names += students[i].name + "" + students[i].grade + "\n";
                Label label = new Label();
                label.Text = $"{students[i].grade}학년 {students[i].name}학생";
                label.AutoSize = true;
                label.Location = new Point(130, 13 + (26 * i));
                Controls.Add(label);
            }

        }
    }
}
