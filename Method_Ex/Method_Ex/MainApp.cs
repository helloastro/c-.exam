using System;

namespace Method_Ex
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            int a = Calculator.Plus(1, 2);
            Console.WriteLine(a);

            int b = Calculator.Minus(3, 2);
            Console.WriteLine(b);
        }
    }
}
