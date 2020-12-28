using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int[] ab = new int[3];

            for (int i = 0; i < ab.Length; i++)
            {
                Console.WriteLine("숫자 입력: ");
                ab[i] = int.Parse(Console.ReadLine());
            }

            int max = ab[0];
            int min = ab[0];

            for (int i = 0; i < ab.Length; i++)
            {
                if (max < ab[i])
                {
                    max = ab[i];
                }
                if (min > ab[i])
                {
                    min = ab[i];
                }
            }
            Console.WriteLine("큰값:" + max);
            Console.WriteLine("작은값:"+ min);

        }
    }
}
