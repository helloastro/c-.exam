using System;

namespace Swap_Ex
{
    class Program
    {
        static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Swap2(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args)
        {
            int x = 3, y = 4;
            Console.WriteLine($"{x}, {y}");

            Swap(x, y);
            Console.WriteLine($"{x}, {y}");

            Swap2(ref x, ref y);
            Console.WriteLine($"{x}, {y}");
        }
    }
}
