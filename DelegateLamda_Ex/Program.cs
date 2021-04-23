using System;
using System.Linq;

namespace DelegateLamda_Ex
{
    class Calc
    {
        public int Plus(int a, int b) { return a + b; }
        public int Minus(int a, int b) { return a - b; }
    }

    delegate int Deli(int a, int b); 

    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();

            Deli deli;

            deli = new Deli(calc.Plus);
            Console.WriteLine(deli(3, 4));

            deli = new Deli(calc.Minus);
            Console.WriteLine(deli(3, 4));

            Console.WriteLine();

            Deli cal = new Deli(calc.Plus);
            cal += new Deli(calc.Minus);
            Console.WriteLine(cal(3, 4));

            cal -= new Deli(calc.Minus);
            Console.WriteLine(cal(3, 4));

            Deli plus = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(plus(3, 4));

            Deli minus = (a, b) => a - b;
            Console.WriteLine(minus(3, 4));

            Func<int, int, int> func = (a, b) => a * b;
            Console.WriteLine(func(3, 4));

            Action<string> act = (x) => Console.WriteLine(x);
            act("Hello");

            //System.Linq
            int[] nums = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

            var result = from n in nums
                         where n % 2 == 0
                         orderby n
                         select n;

            foreach (int n in result)
                Console.WriteLine("짝수: {0}", n);



        }
    }
}
