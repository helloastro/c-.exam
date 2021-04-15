using System;

namespace FloatinPoint
{
    class MainApp
    {
        static void Main(string[] args)
        {
            float a = 3.141592653589f;
            double b = 3.1415_9265_3589;
            Console.WriteLine($"{a}, {b}");

            Console.WriteLine(0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f);

            decimal c = 3.1415_9265_3589m;
            Console.WriteLine(c);
            Console.WriteLine(0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m);
        }
    }
}
