using System;

namespace Char_Ex
{
    class MainApp
    {
        static void Main(string[] args)
        {
            char a = 'a'; //2byte, unicode
            char b = '가';

            Console.WriteLine($"{a}, {b}");
            Console.WriteLine((int)a);
            Console.WriteLine((int)'가');

            string c = "안녕하세요.";
            String d = "안녕하세요.";
            Console.WriteLine($"{c}, {d}");

        }
    }
}
