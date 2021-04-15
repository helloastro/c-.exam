using System;

namespace IntegralTypes
{
    class MainApp
    {
        static void Main(string[] args)
        {
            sbyte a = -100;
            byte b = 100;

            Console.WriteLine($"a: {a}, b: {b}");

            int c = -1000000;
            uint d = 1_000_000;

            Console.WriteLine($"c: {c}, d: {d}");

            long e = -100000000;
            ulong f = 100_000_000;

            Console.WriteLine($"e: {e}, f: {f}");

            /* 보수법 : 음수표현 */ 
            byte g = 255;        // 1111 1111
            sbyte h = (sbyte)g;  // 보수법 -1

            Console.WriteLine($"g: {g}, h: {h}");

            /* overflow */
            uint i = uint.MaxValue;

            i = i + 1;

            Console.WriteLine($"i: {i}");
        }
    }
}
