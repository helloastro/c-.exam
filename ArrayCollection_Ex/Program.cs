using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayCollection_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 60;
            scores[2] = 70;
            scores[^2] = 80;  // System.Index 
            scores[^1] = 90;  // 마지막 인덱스

            string[] arry1 = new string[3] { "A", "B", "C" };
            string[] arry2 = new string[] { "A", "B", "C" };
            string[] arry3 = { "A", "B", "C" };

            foreach(string arr in arry3)
            {
                Console.WriteLine(arr);
            }

            Array.Sort(scores);
            Array.ForEach<int>(scores, x => Console.WriteLine(x));

            Array.ForEach<int>(scores[1..3], x => Console.WriteLine(x)); //System.Range 마지막 인덱스 제외
            Array.ForEach<int>(scores[..3], x => Console.WriteLine(x));
            Array.ForEach<int>(scores[2..], x => Console.WriteLine(x));

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Insert(1, 3);
            list.RemoveAt(0);

            for(int i=0, len=list.Count; i < len; i++)
            {
                Console.WriteLine(list[i]);
            }

            Hashtable ht = new Hashtable();
            ht["book"] = "책";
            ht["cook"] = "요리사";

            Console.WriteLine(ht["cook"]);

            foreach(string key in ht.Keys)
            {
                Console.WriteLine(ht[key]);
            }

            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Insert(1, 3);
            list1.RemoveAt(0);

            list1.ForEach(x => Console.WriteLine(x));

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict["book"] = "책";
            dict["cook"] = "요리사";

            Console.WriteLine(dict["cook"]);

        }
    }
}
