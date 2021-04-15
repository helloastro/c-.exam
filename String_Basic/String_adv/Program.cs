using System;

namespace String_adv
{
    class Program
    {
        static void Main(string[] args)
        {
            // p.97
            // 문자열 분리
            string greeting = "Good Morning";

            // substring 시작인덱스, 가져올 문자수는 0보다 큰 수를 사용해야한다.
            Console.WriteLine(greeting.Substring(0, 4)); // 시작인덱스, 가져올 문자수
            Console.WriteLine(greeting.Substring(4));    // 시작인덱스, 끝까지
            Console.WriteLine();

            // split
            string[] strs = greeting.Split(' ');
            Console.WriteLine(strs.Length);
            foreach(string str in strs)
            {
                Console.WriteLine(str);
            }

            string s = "abc def. 가나다 라마사";
            string[] strs1 = s.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in strs1)
            {
                Console.WriteLine(str);
            }


            // 문자열 서식
            // - 왼쪽기준, + 오른쪽
            Console.WriteLine("'{0, -7:D}'", 100); //출력 데이터 인덱스, 정렬과 길이:데이터(서식)
            Console.WriteLine("'{0, 7:D}'", 100);
            Console.WriteLine("'{0, 7:D}', '{1, 7:D}'", 100, 200);
            Console.WriteLine("'{0, 7}'", 100);
            Console.WriteLine();

            // 서식
            // 10진수:D, 16진수:X
            Console.WriteLine("{0, 7:D}", 100);
            Console.WriteLine("{0:D7}", 100);       //빈자리가 0으로 채워진다.

            // 숫자:N
            Console.WriteLine("{0:N}", 123456789);  // ,와 소수점 2자리까지 출력
            Console.WriteLine("{0:N0}", 123456789); // 0:소수점 자리수

            // 고정소수점:F
            Console.WriteLine("{0:F}", 123.456);    // 소수점 2자리까지 출력
            Console.WriteLine("{0:F5}", 123.456);   //빈자리가 0으로 채워진다.

            // E: 지수
            Console.WriteLine("{0:E}", 123.456789);
        }
    }
}
