using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayAT
{
    class Program
    {
        static void MaxProduct(int []arr, int n)
        {
            Console.WriteLine(n);
            int a = arr[0], b = arr[1];
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);

            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (arr[i] * arr[j] > a * b)
                    {
                        a = arr[i];
                        b = arr[j];
                    }
            Console.Write("Max product pair is {" +
                       a + ", " + b + "}");
        }
        public static void Main()
        {
            int[] arr = { 1, -5, 8, -20, 13 };
            int n = arr.Length;
            MaxProduct(arr, n);
        }
    }
}
