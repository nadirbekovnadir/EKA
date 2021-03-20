using System;
using System.Collections.Generic;

namespace AZS
{
    class Program
    {
        public delegate void Print();
        static void Main(string[] args)
        {
            const int m = 4;
            int[] array = new int[] { 5, 3, 5, 6, 0, 2, 4, 5, 0, 0 };
            List<int> larray = new List<int>(array);
            larray.RemoveRange(m, array.Length - m);
            

            HashSet<int> hs1 = new HashSet<int>(larray);
            HashSet<int> hs2 = new HashSet<int>();
            hs2.Add(0);

            int trueKey = hs1.Count;
            hs1.UnionWith(hs2);
            int falseKey = hs1.Count;

            

            Dictionary<int, Print> d = new Dictionary<int, Print>();
            d[trueKey] = PrintNo;
            d[falseKey] = PrintYes;

            d[trueKey]();
        }

        public static void PrintYes()
        {
            Console.WriteLine("Yes");
        }

        public static void PrintNo()
        {
            Console.WriteLine("No");
        }
    }
}
