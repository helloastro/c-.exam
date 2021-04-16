using System;

namespace Condition_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            // if
            Console.Write("숫자를 입력해 주세요. : ");
            string input = Console.ReadLine();
            int num = Int32.Parse(input);

            if (num > 0)
            {
                Console.WriteLine("양수");
            } else if (num < 0)
            {
                Console.WriteLine("음수");
            } else
            {
                Console.WriteLine("0");
            }

            if (num % 2 == 0)
            {
                Console.WriteLine("짝수");
            } else
            {
                Console.WriteLine("홀수");
            }

            if (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("0보다 큰 짝수");
                }
                else
                {
                    Console.WriteLine("0보다 큰 홀수");
                }
            }
            else
            {
                Console.WriteLine("0 보다 작거나 같은 수.");
            }
        }
    }
}
