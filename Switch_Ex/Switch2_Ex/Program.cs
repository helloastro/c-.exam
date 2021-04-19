using System;

namespace Switch2_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("점수를 입력해 주세요: ");
            int score = Convert.ToInt32(Console.ReadLine());

            // Switch 식
            string grade = ((score/10)*10) switch {
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"
            };

            Console.WriteLine($"학점: {grade}");

            Console.Write("재수강 인가요?(y/n): ");
            string repeated = Console.ReadLine();
            bool repeated_yn = repeated == "y" ? true : false;

            string grade1 = (int)(Math.Truncate(score / 10.0) * 10) switch
            {
                90 when repeated_yn == true => "B+",
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"
            };

            Console.WriteLine($"학점: {grade1}");
        }
    }
}
