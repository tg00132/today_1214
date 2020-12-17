using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 1; j < num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i * 2 + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }

        }
    }
}
