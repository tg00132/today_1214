using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol5
{
    class Program
    {
        static void Main(string[] args)
        {
            //프로그램 실행법
            //java : ctrl+F11
            //c# : ctrl+F5

            //java : System.out.println("Hello"); //한줄 출력후 한줄띄는거
            //c# : Console.WriteLine("Hello");
            //cw 입력 후 tab키 두번
            Console.WriteLine("Hello 한줄 띄움");

            //java : System.out.print("Hello"); // 출력 하면 옆에
            //c# : Console.Write("Hello");
            Console.Write("쓰고 한줄 안 띄움");

            //java : System.out.println(); // 아무것도 안하고 그냥 한줄 띄우기
            //c# : Console.WriteLine();

            Console.WriteLine();


            //변수
            //java와 동일

            int a = 100;
            //단 String 변수는 String이랑 string 둘 다 동일하게 쓸 수 있음
            //c#에서는 보통 s를 소문자로 적는다.
            string ex = "하이";
            string ex2 = "바이";
            string 한글 = "ㄹㅇ랑러ㅏㅇ링라ㅓ아미러ㅣㅏㅇㄹ낭ㄹ";
            Console.WriteLine(한글);

            //문자열과 숫자 혼합하기
            string ex3 = a + "더하기" + a + "는" + (a + a) + "이다.";
            string ex4 = $"{a} 더하기 {a}는 {a + a}이다.";
            string ex5 = string.Format("{0} 더하기 {1}은 {2}이다.", a, a, a + a);

            Console.WriteLine(ex3);
            Console.WriteLine(ex4);
            Console.WriteLine(ex5);

            //조건문
            //java와 동일
            if (a > 50)
            {
                Console.WriteLine("a는 50이상");
            }

            if (a>30)
            {
                Console.WriteLine("30이상");
            }
            else
            {
                Console.WriteLine("30미만");
            }

            if (a ==10)
            {
                Console.WriteLine("10");
            }
            else if (a ==20)
            {
                Console.WriteLine("20");
            } //*끝에 꼭 else 안 붙여도 됨*

            if (a==10)
            {
                Console.WriteLine("10");
            }
            else if (a ==20)
            {
                Console.WriteLine("20");
            }
            else
            {
                Console.WriteLine("10이랑 20은 아님");
            }

            //switch문도 java와 동일
            switch (a)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                default:
                    Console.WriteLine("10이랑 20은 아니다.");
                    break;
            }
            //반복문도 java와 동일
            //단 foreach라는 특수 문법이 있다. 몰라도 코드짜는데는 지장없다.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("같은 말 10번 반복");
            }
            int temp = 10;
            while (temp>0)
            {
                temp--;
            }
            do
            {
                temp++;
            } while (temp<10);

            //값을 입력받는 경우
            //java
            /*
             Scanner s = new Scanner(System.in)
             String test = s.nextLine();
             int test2 = s.nextint();

             */
            //c#
            // String test = Console.ReadLine();
            // int test2 = int.parse(Console.ReadLine());
            // Console.ReadLine은 단축키 없음.

            string test = Console.ReadLine();
            int test2 = int.Parse(Console.ReadLine());



        }
    }
}
