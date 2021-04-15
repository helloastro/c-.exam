using System;

namespace IntegralTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -100;
            byte b = 100;

            Console.WriteLine($"{a}, {b}");
            Console.WriteLine("Hello world!!");
            Console.WriteLine(a + ", " + b);

            int c = -1000000;
            uint d = 1_000_000;
            Console.WriteLine($"{c}, {d}");

            long e = -1000000000;
            ulong f = 1_000_000_000;
            Console.WriteLine($"{e}, {f}");

            /* 보수법: 음수표현 */
            byte g = 255; // 1111 1111
            sbyte h = (sbyte)g;
            Console.WriteLine($"{g}, {h}");

            /* overflow */
            uint i = uint.MaxValue;
            i = i + 1;
            Console.WriteLine(i);


        }
    }
}
