using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consol2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("초를 입력");
            int a = int.Parse(Console.ReadLine());
            int sec;
            int min;
            min = a / 60;
            sec = a % 60;

            Console.WriteLine(min +"분" +sec +"초");


        }
			}
		}
    

