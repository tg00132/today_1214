using adressTest0218.control;
using adressTest0218.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218
{
    class Program
    {
        
        static void Main(string[] args) {
            Menu m = new Menu();
            StudentCtrl sc = new StudentCtrl();


            while (true) {
                switch (m.mainMenu()) {
                    case Menu.MENU_MAIN_ADD:
                        sc.addItem();
                        break;
                    case Menu.MENU_MAIN_VIEW:
                        sc.viewItem();
                        break;
                    case Menu.MENU_MAIN_RANDOM_ADD:
                        sc.randData(100);
                        break;
                    case Menu.MENU_MAIN_DELETE:
                        sc.delItem(m.delMenu());
                        break;
                    case Menu.MENU_MAIN_DELETE_ALL:
                        sc.delItemAll();
                        break;
                    case Menu.MENU_MAIN_UPDATE:
                        sc.updateItem(m.updateMenu());
                        break;
                    case Menu.MENU_MAIN_EXIT:
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;
                }
            }
        }

       /* public static void addItem()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("-----------------");
            Console.Write("이름: ");
            string name = Console.ReadLine();
            Console.Write("전화: ");
            string tel = Console.ReadLine();
            Console.Write("주소: ");
            string address = Console.ReadLine();
            Console.Write("이메일: ");
            string email = Console.ReadLine();

            addrList.Add(
                new Student(name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");
        }

        public static void viewItem()
        {
            for (int i=0; i<addrList.Count; i++)
            {
                Console.WriteLine("번호: " + (i+1));
                Console.WriteLine("이름: " + addrList[i].Name);
                Console.WriteLine("전화: " + addrList[i].Tel);
                Console.WriteLine("주소: " + addrList[i].Address);
                Console.WriteLine("이메일: " + addrList[i].Email);
                Console.WriteLine("-------------------------");
            }
        }

        
        public static void randData()
        {
            string[] name =
                {"홍길동", "김길동",
                "이길동", "박길동", "최길동"};
            string[] tel = {"010-1111-1111",
                "010-2222-2222", "010-2222-3333",
                "010-2222-4444", "010-2222-5555"};
            string[] address = {"대구시 동구 신암동",
                "광주시 동구 신암동", "서울시 동구 신암동",
                "대전시 동구 신암동", "부산시 동구 신암동"};
            string[] email = {"hong@naver.com",
                "kim@naver.com", "lee@naver.com",
                "park@naver.com", "choi@naver.com"};

            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                addrList.Add(new Student(
                    name[r.Next(0, 5)],
                    tel[r.Next(0, 5)],
                    address[r.Next(0, 5)],
                    email[r.Next(0, 5)]));
            }
        }

        static void delItem()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("주소록 정보 삭제");
            Console.WriteLine("-----------------");
            Console.Write("삭제할 이름: ");
            string name = Console.ReadLine();

            for (int i=0; i<addrList.Count; i++)
            {
                if (name.Equals(addrList[i].Name))
                {
                    addrList.RemoveAt(i--);
                }
            }

            /*
            int cnt = 0;
            while (cnt < addrList.Count)
            {
                if (name.Equals(addrList[cnt].Name))
                {
                    addrList.RemoveAt(cnt);
                }
                else
                {
                    cnt++;
                }
            }
            
        }

        static void delItemAll()
        {
            addrList.Clear();
        }

        static string getId()
        {
            Random r = new Random();
            string rdata = 
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789"+
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ"+
                "~!@#$%^&*?";
            StringBuilder rs = new StringBuilder();
            for (int i=0; i<10; i++)
            {
                rs.Append(rdata[(int)(r.NextDouble()*rdata.Length)]);
            }
            //Console.WriteLine("id: " + rs.ToString());
            return rs.ToString();
        } */
    }
}
