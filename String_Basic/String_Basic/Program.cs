using System;

namespace String_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            // P.94 참조
            // 검색과 치환
            string greeting = "Good Morning";
            Console.WriteLine(greeting);
            Console.WriteLine();

            //IndexOf, LastIndexOf
            Console.WriteLine(greeting.IndexOf("Go")); // 시작인덱스 0
            Console.WriteLine(greeting.IndexOf("F"));  // -1
            Console.WriteLine(greeting.IndexOf("M"));  // 5
            Console.WriteLine(greeting.IndexOf("n"));  // 8
            Console.WriteLine(greeting.LastIndexOf("n"));  // 10
            Console.WriteLine();

            // StartsWith, EndsWith
            Console.WriteLine(greeting.StartsWith("Good"));  // true
            Console.WriteLine(greeting.EndsWith("Good"));    // false
            Console.WriteLine();

            // Contains
            Console.WriteLine(greeting.Contains("Good"));      // true
            Console.WriteLine(greeting.Contains("Afternoon")); // false
            Console.WriteLine();

            // replace
            Console.WriteLine(greeting.Replace("o", "O"));
            Console.WriteLine();

            // p.96
            // 문자열 변형
            Console.WriteLine("abc".ToUpper());
            Console.WriteLine("ABC".ToLower());
            Console.WriteLine();

            Console.WriteLine("ABC".Insert(1, "DEF")); // 지정된 인덱스에 삽입.
            Console.WriteLine("ABC".Remove(1, 1));     // 지정된 인덱스에서 지정된 글자수만큼 제거
            Console.WriteLine();

            Console.WriteLine("   ABC ".Trim());  // 좌우 공백제거
        }
    }
}
