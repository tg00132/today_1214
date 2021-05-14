using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parking
{
    public partial class ParkingManager : Form
    {
        public ParkingManager()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataManager.Cars;
            textBox1.Text = DataManager.Cars[0].parkingSpot.ToString();
            textBox2.Text = DataManager.Cars[0].carNumber.ToString();
            textBox3.Text = DataManager.Cars[0].driverName.ToString();
            textBox4.Text = DataManager.Cars[0].phoneNumber.ToString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WhatTime.Text = "지금은 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "입니다";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeLog("주차 버튼 클릭");
            //공간번호
            if (textBox1.Text.Trim() == "") //Trim 공백 제거 함수
            {
                MessageBox.Show("주차공간을 입력해라");
                writeLog("주차공간을 입력해라");
            }
            else if (textBox2.Text.Trim() == "") //차량 번호를 입력하지 않은 경우
            {
                MessageBox.Show("차번호를 입력해라");
                writeLog("차번호를 입력해라");
            }
            else
            {

                try
                {
                    //본격적으로 입력하는 작업

                    //창조변수와 람다개념을 알고있는 경우! (=>)람다
                    Parkingcar Car =
                    DataManager.Cars.Single((x) => x.parkingSpot.ToString() == textBox1.Text);
                    if (Car.carNumber.Trim() != "") //이미 차 정보가 저장되어있음
                    {
                        MessageBox.Show(textBox1.Text + "번 주차공간에는 차량이 있습니다.");
                        writeLog(textBox1.Text + "번 주차공간에는 이미 차량이 있습니다.");
                    }

                    else // 아직 차 정보가 저장되어있지 않음
                    {

                        Car.parkingSpot = int.Parse(textBox1.Text);
                        Car.carNumber = textBox2.Text;
                        Car.driverName = textBox3.Text;
                        Car.phoneNumber = textBox4.Text;
                        Car.parkingTime = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Cars;
                        DataManager.Save();

                        string contents = $"주차 공간 {textBox1.Text}에 {textBox2.Text}차를 주차함";
                        MessageBox.Show(contents);
                        writeLog(contents, DateTime.Now.ToString("yyyy_MM_dd"));
                    }
                }
                catch (Exception ex)
                {

                    string contens = "주차 할 수 없습니다." + textBox1.Text;
                    MessageBox.Show(contens);
                    writeLog(contens);
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeLog("출차 버튼 클릭");

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("주차 공간 번호를 입력해주세요!");
                return;
            }
            //Single 없이 조회하고 해당하는 데이터 변경
            try
            {
                for (int i = 0; i < DataManager.Cars.Count; i++)
                {
                    if (DataManager.Cars[i].parkingSpot.ToString() == textBox1.Text)
                    {
                        if (DataManager.Cars[i].carNumber.Trim() == "")
                        {
                            MessageBox.Show("아직 차 없음");
                            writeLog("아직 차 없음");
                            break;
                        }
                        else
                        {

                            DataManager.Cars[i].carNumber = "";
                            DataManager.Cars[i].driverName = "";
                            DataManager.Cars[i].phoneNumber = "";
                            DataManager.Cars[i].parkingTime = DateTime.Now;
                            string contents = $"주차공간 {textBox1.Text}에 {textBox2.Text} 차량 출차";
                            MessageBox.Show(contents);
                            writeLog(contents);
                            dataGridView1.DataSource = null; // dataGridView1의 데이터를 한번 지워주고
                            dataGridView1.DataSource = DataManager.Cars; //다시 리셋
                            DataManager.Save();
                            break;
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                writeLog("출차 안됨");
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //writeLog("3번 버튼 클릭");
            //writeLog("3번 버튼 클릭", DateTime.Now.ToString("yyyy_MM_dd"));
            writeLog("조회 버튼 클릭");
            if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show("조회할 번호를 입력해주세요");

            }
            for (int i = 0; i < DataManager.Cars.Count; i++)
            {
                if (DataManager.Cars[i].parkingSpot.ToString() == textBox5.Text)
                {
                    if (DataManager.Cars[i].carNumber.Trim() == "")
                    {

                        MessageBox.Show("아직 차 없음");
                        writeLog("아직 차 없음");
                        break;
                    }
                    else
                    {

                        MessageBox.Show("주차 되있는건 " + DataManager.Cars[i].carNumber + "차량입니다");
                        break;
                    }
                }
            }
            textBox5.Text = "";
        }

        private void writeLog(string contents)
        {

            string logContens = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]" +
                $"{contents}";
            listBox1.Items.Insert(0, logContens);
            DataManager.printLog(logContens);
        }
        private void writeLog(string contents, string date)
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
            DataManager.printLog(logContens, date);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Parkingcar temp = dataGridView1.CurrentRow.DataBoundItem as Parkingcar;
                textBox1.Text = temp.parkingSpot.ToString();
                textBox2.Text = temp.carNumber;
                textBox3.Text = temp.driverName;
                textBox4.Text = temp.phoneNumber;
                textBox5.Text = temp.parkingSpot.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
