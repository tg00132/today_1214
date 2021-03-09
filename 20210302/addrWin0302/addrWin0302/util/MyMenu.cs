﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218.util
{
    class MyMenu
    {
        public const int MENU_ADD = 1;
        public const int MENU_VIEW = 2;
        public const int MENU_RANDOM_ADD = 3;
        public const int MENU_DELETE = 4;
        public const int MENU_DELETE_ALL = 5;
        public const int MENU_EXIT = 6;

        static public int mainMenu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("1.주소록 정보 추가");
            Console.WriteLine("2.주소록 정보 보기");
            Console.WriteLine("3.랜덤 데이터 추가");
            Console.WriteLine("4.주소록 정보 삭제");
            Console.WriteLine("5.전체 데이터 삭제");
            Console.WriteLine("6.종료");
            Console.WriteLine("-----------------");
            Console.Write("메뉴 선택: ");
            int menu =
                Convert.ToInt32(Console.ReadLine());
            return menu;
        }
    }
}
