using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace parking
{
    class DataManager
    {
        public static List<Parkingcar> Cars = new List<Parkingcar>();
        static DataManager()
        {
            Load();
        }
        public static void Load()
        {
            Cars.Clear();
            try
            {
                string carsOutput = File.ReadAllText(@"./Cars.xml");
                XElement carsxElement = XElement.Parse(carsOutput);
                foreach (var item in carsxElement.Descendants("car"))
                {
                    //Element = 구성 요소 html body태그안에 h1태그같은 존재
                    int tempParkingSpot = int.Parse(item.Element("parkingSpot").Value);
                    string tempCarNumber = item.Element("carNumber").Value;
                    string tempDriverName = item.Element("driverName").Value;
                    string tempPhoneNumber = item.Element("phoneNumber").Value;
                    DateTime tempParkingTime = item.Element("parkingTime").Value ==
                        "" ? DateTime.Now : DateTime.Parse(item.Element("parkingTime").Value);

                    Parkingcar tempCar = new Parkingcar()
                    {
                        parkingSpot = tempParkingSpot,
                        carNumber = tempCarNumber,
                        driverName = tempDriverName,
                        phoneNumber = tempPhoneNumber,
                        parkingTime = tempParkingTime
                    };
                    Cars.Add(tempCar);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                //만약 파일이 없어서 여기로 진입한 경우라면
                CreateFile(); //파일을 다시만들고
                Save(); // 그 파일을 저장후
                Load(); // 다시 불러들여본다.

                //단, Load 함수 자체가 잘못된거라면 이 코드는 무한루프에 빠진다.
            }
        }
        private static void CreateFile()
        {
            //Cars.xml 파일을 만들겁니다.
            string fileName = @"./Cars.xml";
            StreamWriter writer = File.CreateText(fileName); //파일이 없으면 해당 파일 생성
            writer.Dispose(); //메모리 해제
        }
        public static void Save()
        {
            string booksOutput = "";
            booksOutput += "<cars>\n"; // \n대신에 Enviroment.NewLine 써도됨
            if (Cars.Count > 0)
            {
                foreach (var item in Cars)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $" <parkingSpot>{item.parkingSpot}</parkingSpot>";
                    booksOutput += $" <carNumber>{item.carNumber}</carNumber>";
                    booksOutput += $" <driverName>{item.driverName}</driverName>";
                    booksOutput += $" <phoneNumber>{item.phoneNumber}</phoneNumber>";
                    booksOutput += $" <parkingTime>{item.parkingTime}</parkingTime>";
                    booksOutput += "</car>\n";
                }
            }
            else //xml 파일에 아무것도 없는 경우
            {
                for (int i = 0; i <= 5; i++)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $" <parkingSpot>{i}</parkingSpot>";
                    booksOutput += " <carNumber></carNumber>";
                    booksOutput += " <driverName></driverName>";
                    booksOutput += " <phoneNumber></phoneNumber>";
                    booksOutput += " <parkingTime></parkingTime>";
                    booksOutput += "</car>\n";
                }
            }
            booksOutput += "</cars>";
            File.WriteAllText(@"./Cars.xml", booksOutput);
        }

        //두번째 파라미터를 넣지 않으면 name에는 parkingHistory가 들어감
        public static void printLog(string contents, string name = "parkingHistory")
        {
            DirectoryInfo di = new DirectoryInfo("parkingHistory");
            //if(di.Exists == false)
            if (!di.Exists)
            {
                di.Create(); //폴더 만들기
            }
            //앞에 @있으면
            // \를 한개만 적는다.
            // @ 없으면 \\ 이렇게 해야 1개로 인식
            using (StreamWriter writer = new StreamWriter(@"parkingHistory\" + name + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
