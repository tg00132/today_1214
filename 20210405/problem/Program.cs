using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inch : ");
            int i = int.Parse(Console.ReadLine());
            double d = i * 2.54;
            Console.WriteLine(i + "inch = " + d + "cm");

            Console.Write("kg : ");
            int k = int.Parse(Console.ReadLine());
            double pound = k * 2.20462262;
            Console.WriteLine(k + "kg = "+ pound + "pound");


            double pi = 3.14;
            Console.Write("반지름: ");
            int ban = int.Parse(Console.ReadLine());
            Console.WriteLine("둘레 =" + 2 * pi * ban);
            Console.WriteLine("넓이 =" + pi * ban * ban);


            Console.Write("첫번째 숫자:");
            int sa = int.Parse(Console.ReadLine());
            Console.Write("두번째 숫자:");
            int sam = int.Parse(Console.ReadLine());

            int dab1 = sa * (sam % 10);
            int dab2 = sa * ((sam % 100) / 10);
            int dab3 = sa * (sam / 100);
            int hap = sa * sam;
            Console.Write("답 :");
            Console.WriteLine(dab1);
            Console.WriteLine(dab2);
            Console.WriteLine(dab3);
            Console.WriteLine(hap);

           

        }
    }
}
