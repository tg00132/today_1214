using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol
{
    class Program
    {
        static void Main(string[] args)
        {
            int hap = 0;
            int i = 0;

            for (i = 1; i<100; i++)
            {
                if (i % 3 == 0)
                {
                    hap += i;

                }
            }

            
            Console.WriteLine("3의 배수의 합" + hap);
        }

    }
}
