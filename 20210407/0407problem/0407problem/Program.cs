using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0407problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //1번 문제

            /*int[] num = new int[5];
            

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            int min = num[0];
            int max = num[0];

            for(int i=0; i<num.Length; i++)
            {
                if (num[i] < min)
                    min = num[i];
                if (num[i] > max)
                    max = num[i];
            }
            Console.WriteLine("최대값은:" + max +"이고 최솟값은" + min + "입니다");*/

            //2번 문제 
            string start = "1";
            for(int i=0; i<20; i++)
            {
                Console.WriteLine((i+1)+"번째 수열: "+start);
                char num = start[0];
                int count = 0;
                string end = "";

                //입력한 수열을 읽음
                for(int j = 0; j <start.Length; j++)
                {
                    if (num == start[j])
                    {
                        count++;
                    }
                    else
                    {
                        //1121 1에서 2로 넘어가는 시점 등
                        end = end + num + count;
                        num = start[j];
                        count = 1;
                    }
                }
                end = end + num + count;
                start = end;
            }



            //3번 별찍기 문제
            Console.WriteLine("3번 문제");
            int inputFloor = int.Parse(Console.ReadLine());
            int Flag = 0;

            if(inputFloor == 1)
                Console.WriteLine("*");
            else
            {
                for(int i=0; i < inputFloor*2; i++)
                {
                    for(int j = 0; j<inputFloor; j++)
                    {
                        if(Flag%2 ==0)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                        Flag++;
                    }
                    if (inputFloor % 2 == 0)
                        Flag++;
                    Console.WriteLine();
                }
            }

            //4번 설탕 배달 문제
            int sugar = int.Parse(Console.ReadLine());
            int podae = 0;
            while (true)
            {
                if(sugar%5 == 0)
                {
                    podae += sugar / 5;
                    break;
                }
                sugar -= 3;
                podae++;
                if (sugar < 0)
                {
                    podae = 1;
                    break;
                }
            }
            Console.WriteLine(podae);





            
            
        }
    }
}
