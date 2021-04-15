using System;

namespace StringConversion_Ex
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 123;
            string b = a.ToString();
            Console.WriteLine($"{a}, {b}");

            string c = "3.1415";
            float d = float.Parse(c);
            Console.WriteLine($"{c}, {d}");

            string e = "12345";
            int f = Convert.ToInt32(e);
            Console.WriteLine($"{e}, {f}");

            string g = 123.ToString();
            String h = 1234.1234.ToString();
            Console.WriteLine($"{g}, {h}");

        }
    }
}
