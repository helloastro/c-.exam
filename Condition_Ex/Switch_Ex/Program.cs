using System;

namespace Switch_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("요일을 입력하세요. (일, 월, 화, 수, 목, 금, 토) :");
            string day = Console.ReadLine();

            switch(day)
            {
                case "일":
                    Console.WriteLine("Sun");
                    break;
                case "월":
                    Console.WriteLine("Mon");
                    break;
                case "화":
                    Console.WriteLine("Tue");
                    break;
                case "수":
                    Console.WriteLine("Wed");
                    break;
                case "목":
                    Console.WriteLine("Thu");
                    break;
                case "금":
                    Console.WriteLine("Fri");
                    break;
                case "토":
                    Console.WriteLine("Sat");
                    break;
                default:
                    Console.WriteLine($"{day}는 요일이 아닙니다.");
                    break;
            }

        }
    }
}