using System;
using System.Collections;

namespace Opt_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            // 산술연산자.
            int a = 111;
            int b = 222;

            int c = a + b;
            double d = a / b;
            int e = a % 100;

            Console.WriteLine($"22/7 = {22 / 7}, {22%7}");
            Console.WriteLine();

            // 증가연산자 감소연산자.
            int a1 = 10;
            Console.WriteLine($"{a1}, {a1++}");
            Console.WriteLine($"{a1}, {++a1}");

            Console.WriteLine($"{a1}, {a1--}");
            Console.WriteLine($"{a1}, {--a1}");
            Console.WriteLine();

            // 문자열 결합 연산자
            string s = "Hello" + " " + "World!!!";

            // 관계 연산자
            Console.WriteLine($"{3 > 4}, {3 >= 4}, {3 == 4}, {3 != 4}");
            Console.WriteLine();

            // 논리연산자
            Console.WriteLine($"{3 < 4 && 3 <= 4}");
            Console.WriteLine($"{3 > 4 && 3 <= 4}");
            Console.WriteLine($"{3 > 4 || 3 <= 4}");
            Console.WriteLine($"{3 > 4 || 3 >= 4}");

            // 단축평가
            bool divid(int b1)
            {
                Console.WriteLine(10/b1);
                return true;
            }

            int b1 = 0; // 0일 경우, 0이 아닐 경우.
            bool c1 = b1 != 0 && divid(b1);

            // 조건식
            string result = (10 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);
            Console.WriteLine();

            // 널 조건부 연산자 
            ArrayList al = null;
            al?.Add("하나");
            al?.Add("둘");
            Console.WriteLine($"{al?.Count}");

            al = new ArrayList();
            al?.Add("하나");
            al?.Add("둘");
            Console.WriteLine($"{al?.Count}");

            // 할당 연산자
            int a2 = 100;
            Console.WriteLine($"{a2 += 1}, {a2}");
            Console.WriteLine($"{a2 -= 1}, {a2}");

            // null 병합연산자.
            int? num = null;
            Console.WriteLine($"{num ?? 0}");
            num = 99;
            Console.WriteLine($"{num ?? 0}");

            string str = null;
            Console.WriteLine($"{str ?? "Default"}");
            str = "String";
            Console.WriteLine($"{str ?? "Default"}");
        }
    }
}
