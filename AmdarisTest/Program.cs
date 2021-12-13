using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayAT
{
    class Program
    {
        public static void Main()
        {
            int[] arr = { 1, -5, 8, -20, 13 };
            int n = arr.Length;
            int a = arr[0];
            int b = arr[1];
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (arr[i] * arr[j] > a * b)
                    {
                        a = arr[i];
                        b = arr[j];
                    }
            Console.Write("Max product pair is {" + a + ", " + b + "}");
        }
    }
}
