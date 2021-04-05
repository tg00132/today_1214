using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemdap
{
    class Program
    {
        static void Main(string[] args)
        {
            //문제1
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine(inch*2.54+"cm");
            Console.WriteLine(string.Format("{0}cm", inch*2.54));
            int key = 190;
            string example = string.Format("나는 {0}살이고 내키는{1}.이름은{2}", 10, key, "이동준");
            Console.WriteLine($"{inch*2.54}cm");

            //문제2
            double pound = double.Parse(Console.ReadLine());
            Console.WriteLine(pound * 2.20462262 + "pound");

            //문제3
            double r = double.Parse(Console.ReadLine());
            const double PI = 3.14;
            Console.WriteLine("둘레:"+(r*PI*2));
            Console.WriteLine("넓이:"+(r*r*PI));


            //4번 문제 
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            string sOne = one.ToString();
           


            Console.WriteLine(one * (two%10));//첫번째숫자 곱하기 두번째숫자의 1의자리
            Console.WriteLine(one*((two%100)/10));//첫번째숫자 곱하기 두번째숫자의 10의자리
            Console.WriteLine(one * (two / 100));//첫번째숫자 곱하기 두번째숫자의 100의자리
            Console.WriteLine(one * two);//첫번째숫자 * 두번째 숫자


            Console.WriteLine("문제 제기!");
            string sTwo = two.ToString();

            //첫번째숫자 곱하기 두번째숫자의1의자리
            Console.WriteLine(one * int.Parse(sTwo[2].ToString()));
            Console.WriteLine(one * (sTwo[1]-'0'));
            Console.WriteLine(one * (sTwo[0]-'0'));
        }
    }
}
