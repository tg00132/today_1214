using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            

            for (int i = 0; i < 3; i++)

                n *= int.Parse(Console.ReadLine());



            string result = n.ToString();



            for (int i = 0; i <= 9; i++)

                Console.WriteLine(result.Length - result.Replace(i.ToString(), "").Length);
        }
    }
}
