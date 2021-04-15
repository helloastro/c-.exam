using System;

namespace NullVar_Ex
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int? a = null;
            Console.WriteLine(a.HasValue);
            // Console.WriteLine(a.Value); // null 오류발생
            Console.WriteLine(a != null);

            var b = 20; // 데이터 타입 자동지정.
            Console.WriteLine($"{b.GetType()}, {b}");

            // b = "String";  //오류발생

            var c = "Hello World!!!";
            Console.WriteLine($"{c.GetType()}, {c}");

            var d = new int[] { 10, 20, 30 };
            Console.WriteLine($"{d.GetType()}, {d}");
            foreach(var e in d)
            {
                Console.WriteLine(e);
            }


        }
    }
}
