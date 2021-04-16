using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managing_Car_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Datamanager.Load();
            //List<ParkingCar> cars = new List<ParkingCar>();
            //cars.Add(new ParkingCar()
            //{
            //    parkingSpot = 1,
            //    carNumber = "30고 9484",
            //    driverName = "정연우",
            //    phoneNumber = "010-7659-7939",
            //    parkingTime = DateTime.Now});
            dataGridView1.DataSource = Datamanager.Cars;
            textBox1.Text = Datamanager.Cars[0].parkingSpot.ToString();
            textBox2.Text = Datamanager.Cars[0].carNumber.ToString();
            textBox3.Text = Datamanager.Cars[0].driverName.ToString();
            textBox4.Text = Datamanager.Cars[0].phoneNumber.ToString();

            //cars.Add(new ParkingCar());            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WhatTime.Text = "지금은 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "입니다";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeLog("1번 버튼 클릭");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeLog("2번 버튼 클릭");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //writeLog("3번 버튼 클릭");
            writeLog("3번 버튼 클릭",DateTime.Now.ToString("yyyy_MM_dd"));
        }
        private void writeLog(string contents)
        {
                     
            string logContens = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]" +
                $"{contents}";            
            listBox1.Items.Insert(0, logContens);            
            Datamanager.printLog(logContens);
        }
        private void writeLog(string contents,string date)
        {
            
            // MessageBox.Show(a.ToString("00")); //01이라고 출력됨 . 3자리 이상 입력시 그대로 출력
            string logContens = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]" +
                $"{contents}";
            // 옛날 것이 가장 위에 올라가는 방식
            // 새로운 내용이 뒤에 추가가 되어서, 새로운 내용을 보려면
            // 밑으로 내려가야 함
            // listBox1.Items.Add(logContens);

            // 새로운 것이 가장 위에 올라가는 방식
            // 새로운 내용이 가장 앞에 있게 되는 것!
            listBox1.Items.Insert(0, logContens);
            //List<int> list = new list<int>();
            //list.Insert(0,1);
            Datamanager.printLog(logContens, date);
        }
    }
}
