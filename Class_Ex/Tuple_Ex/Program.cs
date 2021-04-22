using System;

namespace Tuple_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = ("슈퍼맨", 999);
            Console.WriteLine($"{a.Item1}, {a.Item2}");

            var (b, c) = a;
            Console.WriteLine($"{b}, {c}");

            var (d, e) = (1, 3);
            Console.WriteLine($"{d}, {e}");

            var f = (name:"슈퍼맨", age:999);
            Console.WriteLine($"{f.name}, {f.age}");

            (int qo, int re) Divid(int a, int b)
            {
                int q = a / b;
                int r = a % b;

                return (q, r);
            }

            var result = Divid(3, 4);
            Console.WriteLine($"{result.qo}, {result.re}");
        }
    }
}
