using System;

namespace Object_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 123;
            object b = 3.141592;
            object c = true;
            object d = "안녕하세요";

            // boxing, unboxing
            int e = 123;
            object f = (object)e;
            int g = (int)f;

            double h = 3.141592;
            object i = (object)h;
            double j = (double)i;
        }
    }
}
