using System;

namespace Return_EX
{
    class Program
    {
        static void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("이름을 입력해 주세요.");
                return;
            }

            Console.WriteLine($"{name}, {phone}");
        }
        
        static void Main(string[] args)
        {
            PrintProfile("", "123-1234-1234");
            PrintProfile("홍길동", "123-1234-1234");
        }
    }
}
