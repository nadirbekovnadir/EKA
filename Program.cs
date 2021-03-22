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

            int[] arr_m = new int[m];

            CopyTo(arr_m, array);
            DetectZero(arr_m);


        }

        public static void PrintYes()
        {
            Console.WriteLine("Yes");
        }

        public static void PrintNo()
        {
            Console.WriteLine("No");
        }

        static void CopyTo(int[] to, int[] from, int n = 0)
        {
            try
            {
                to[n] = from[n];
                CopyTo(to, from, n + 1);
            }
            catch (Exception)
            {
                return;
            }
        }

        static void DetectZero(int[] arr, int n = 0)
        {
            int test = 1;
            int zer = 1;

            try
            {
                zer = arr[n];
                test = test / zer;

                DetectZero(arr, n + 1);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Zero is not detected");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Zero is detected");
            }
        }
    }

    
}
