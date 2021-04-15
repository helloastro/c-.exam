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
            Console.WriteLine(b);

            int c = 128;
            sbyte d = (sbyte)c;
            Console.WriteLine(d);

            //실수형
            float e = 69.6875f;
            double f = (double)e;
            Console.WriteLine($"{e}, {f}");
            Console.WriteLine(69.6875 == f);

            float g = 0.1f;
            double h = (double)g;
            Console.WriteLine($"{g}, {h}");
            Console.WriteLine(0.1 == h);


        }
    }
}
