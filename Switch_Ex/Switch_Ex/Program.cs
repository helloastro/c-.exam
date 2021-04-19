using System;

namespace Switch_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("요일을 입력하세요. (일, 월, 화, 수, 목, 금, 토) :");
            string day = Console.ReadLine();

            switch (day)
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

            Console.Write("숫자를 입력하세요. :");
            string s = Console.ReadLine();

            object o = null;
            if (int.TryParse(s, out int out_i))
            {
                o = out_i;
            }
            else if (float.TryParse(s, out float out_f))
            {
                o = out_f;
            }
            else
            {
                o = s;
            }

            switch(o)
            {
                case int i:
                    Console.WriteLine($"{i}는 int 형입니다.");
                    break;
                case float f:
                    Console.WriteLine($"{f}는 float 형입니다.");
                    break;
                default:
                    Console.WriteLine($"{o}는 모르는 형식입니다.");
                    break;
            }

            switch (o)
            {
                case int i:
                    Console.WriteLine($"{i}는 int 형입니다.");
                    break;
                case float f when f >= 0:
                    Console.WriteLine($"{f}는 float 형이고 양수입니다.");
                    break;
                case float f:
                    Console.WriteLine($"{f}는 float 형입니다.");
                    break;
                default:
                    Console.WriteLine($"{o}는 모르는 형식입니다.");
                    break;
            }
        }
    }
}
