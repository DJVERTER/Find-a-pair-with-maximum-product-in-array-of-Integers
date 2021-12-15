using System;

namespace Copie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -5, 42, 70, -85, 90, 7 };
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
            Console.WriteLine($"Max product pairs is: {a} and {b}");
            Console.WriteLine($"Result of this pairs is: {a + b}");
        }
    }
}
