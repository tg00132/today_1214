﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ㅎㅇ");
            Console.WriteLine("ㅎㅇ");
            Console.WriteLine("ㅎㅇ");

            for(int i=0; i<4; i++)
                Console.WriteLine("ㅎㅇ");

            Console.WriteLine("ㅎㅇ"+1);
            Console.WriteLine("ㅎㅇ"+2);
            Console.WriteLine("ㅎㅇ"+3);
            Console.WriteLine("ㅎㅇ"+4);
            for(int i=0; i<4; i++)
                Console.WriteLine("ㅎㅇ"+(i+1));


            Console.WriteLine("ㅂㅇㅂㅇ"[0]);
            Console.WriteLine("ㅂㅇㅂㅇ"[1]);
            Console.WriteLine("ㅂㅇㅂㅇ"[2]);
            Console.WriteLine("ㅂㅇㅂㅇ"[3]);
            for(int i = 0; i < 4; i++ )
                Console.WriteLine("ㅂㅇㅂㅇ"[i]);

            string name = "홍길동";
            string[] names = { "홍길동", "김길동", "박길동" };

            for(int i=0; i<name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            string[] one = new string[10];

            for (int i = (int)'A'; i < (int)'Z'; i++)
            
                Console.WriteLine((char)i);
                Console.WriteLine("..");


            for (int i = (int)'가'; i < (int)'힣'; i++)
            {
                break;
                Console.Write((char)i);
                //Thread.Sleep(5);
                Console.WriteLine("..");
                if (i == (int)'힣')
                    i = (int)'가';
            }

                //무한대로 도는 반복문을 쓰기에 적합한 while
                while(false)
                {
                    Console.Write(new Random().Next(int.MaxValue));
                }


                while (false)
                {
                    Console.Write("바보");
                }
                do
                {
                    Console.WriteLine("바보");
                } while (false);

                int count = 100;
                while (count<100)
                {
                    Console.WriteLine("카운트값은"+count+"입니다");
                }
                do
                {
                    Console.WriteLine("do while count는"+count);
                } while (count<100);  



            
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                //if(i%2 == 0)
                //sum += i;

                //continue 이용
                if (i % 2 != 0)
                    continue;

                sum += i;
            }
            Console.WriteLine(sum);

            foreach(var abcd in names)
            {
                Console.WriteLine(abcd + "is good man");
            }

            int countIndex = 0;
            foreach(var abcd in names)
            {
                if(countIndex == 0)
                {
                    countIndex++;
                    continue;
                }
                Console.WriteLine(abcd + " is good man");
            }

            for(int i = 0; i<names.Length; i++)
            {
                if(i == 0)
                {
                    
                    continue;
                }
                Console.WriteLine(names[i] + " !!is good man");
            }

            for(int i=0; i<10; i++)
            {
                for(int j=0; j< i; j++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j >i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int i=0; i<10; i++)
            {
                for(int j=10; j>i; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k<(2*i)+1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int i=0; i<5; i++)
            {
                for(int j=5-1; j>i; j--)
                {
                    Console.Write(" ");
                }
                for(int k=0; k<(2*i)+1; k++)
                {
                    Console.Write("*");
                }                
                Console.WriteLine();
            }

            for(int i=1; i<5; i++)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write(" ");
                }
                for(int k=2*5-1; k>2*i; k--)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }

            //goto문 
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("외부 반복문");
                for(int j=0; j<10; j++)
                {
                    Console.WriteLine("내부 반복문");
                    goto Example;
                }
            }



        Example: Console.WriteLine("go to");


            string teacher = Console.ReadLine();
            if (teacher == "홍길동")
                goto Example;

            //ToUpper, ToLower
            string example = "exAmple";
            Console.WriteLine(example.ToUpper());
            Console.WriteLine(example.ToLower());
            Console.WriteLine(example);
            example = example.ToUpper();
            //Split
            string guys = "김동혁,장승민,정연우,임수환";
            string[] guys_array = guys.Split(',');
            foreach(var item in guys_array)
            {
                Console.WriteLine(item+"님 하이");
            }
            //join -split의 반대
            string guys2 = string.Join(",",guys_array);
            Console.WriteLine(guys2);
            //Trim - 문자열 양 옆의 공백 제거
            string trim = "안녕하니";
            Console.WriteLine("!"+trim+"!");
            Console.WriteLine("!" + trim.Trim() + "!") ;



           

        }

    }
}
