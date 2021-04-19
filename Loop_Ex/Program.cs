using System;

namespace Loop_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            while (i > 0)
            {
                Console.WriteLine($"{i--}");
            }

            i = 10;
            do
            {
                Console.WriteLine($"{i--}");
            }
            while (i > 0);

            for(int j=1; j < 5; j++)
            {
                Console.WriteLine(j);
            }

            for (int j=1, len=5; j < len; j++)
            {
                Console.WriteLine(j);
            }

            for (int j=0; j<5; j++)
            {
                for (int k=0; k<=j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            int[] arr = new int[] { 0, 1, 2, 3, 4, 5 };
            foreach(int a in arr)
            {
                Console.WriteLine(a);
            }

            List<int> arr = new List<int>() { 0, 1, 2, 3, 4, 5 };
            foreach(int a in arr)
            {
                Console.WriteLine(a);
            }

            arr.ForEach(x => Console.WriteLine(x));
            
            while(true)
            {
                Console.Write("계속할까요?(y/n):");
                string answer = Console.ReadLine();

                if (answer == "n")
                    break;
            }

            for(int j=0; j < 10; j++)
            {
                if (j % 2 == 0)
                    continue;

                Console.WriteLine($"{j}");
            }

        }
    }
}
