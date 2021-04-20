using System;
using System.Collections.Generic;

namespace Method_Etc
{
    class Program
    {
        // out
        static void Divide(int a, int b, out int quo, out int rem)
        {
            quo = a / b;
            rem = a % b;
        }

        // 가변길이
        static int Sum(params int[] args)
        {
            int sum = 0;
            foreach(int arg in args)
            {
                sum += arg;
            }

            return sum;
        }

        // 명명된 매개변수
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"{name}, {phone}");
        }

        // 선택적 매개변수
        static void PrintProfile2(string name, string phone="")
        {
            Console.WriteLine($"{name}, {phone}");
        }

        // 지역함수
        static void LocalFunction()
        {
            int count = 0;
            LocalFunctionIn(1, 2);

            void LocalFunctionIn(int a, int b)
            {
                Console.WriteLine(count++);
            } 
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 2;

            // out
            Divide(a, b, out int c, out int d);
            Console.WriteLine($"{a}, {b}, {c}, {d}");

            // 가변길이
            int sum = Sum(1, 2, 3, 4, 5);
            Console.WriteLine(sum);

            // 명명된 매개변수
            PrintProfile(phone: "123-1234-1234", name: "홍길동");

            // 선택적 매개변수
            PrintProfile2(name: "홍길동");
        }
    }
}
