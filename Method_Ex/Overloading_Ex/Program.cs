using System;

namespace Overloading_Ex
{
    class Program
    {
        static int Plus(int a, int b)
        {
            return a + b;
        }

        static double Plus(double a, double b)
        {
            return a + b;
        }

        static int Plus(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1.1, 2.2));
            Console.WriteLine(Plus(1, 2, 3));
        }
    }
}
