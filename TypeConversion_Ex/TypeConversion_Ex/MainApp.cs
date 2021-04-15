using System;

namespace TypeConversion_Ex
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //정수형
            sbyte a = 127;
            int b = (int)a;
            Console.WriteLine($"{a}, {b}");

            int c = 128;
            sbyte d = (sbyte)c;
            Console.WriteLine($"{c}, {d}");

            // 실수형(소수)
            float e = 69.6875f;
            double f = (double)e;
            Console.WriteLine($"{e}, {f}");
            Console.WriteLine(69.6875 == f);

            float g = 0.1f;
            double h = (double)g;
            Console.WriteLine($"{g}, {h}");
            Console.WriteLine(0.1 == h);

            // 부호
            int i = 500, j = -30;
            uint x = (uint)i;
            uint y = (uint)j;

            Console.WriteLine($"{i}, {x}");
            Console.WriteLine($"{j}, {y}");

            // 실수 -> 정수
            float k = 0.9f;
            int l = (int)k;
            Console.WriteLine($"{k}, {l}");

            int m = (int)g;
            Console.WriteLine($"{g}, {m}");


        }
    }
}
