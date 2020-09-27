using System;
using System.Dynamic;

namespace Task1
{
    class Program
    {
        public static void gen(long[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i] = (1L << i);
            }
        }
        static void Main(string[] args)
        {
            int n;
            do Console.WriteLine("Введите длину массива: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            long[] arr = new long[n];
            gen(arr, n);
            foreach(long to in arr)
            {
                Console.Write($"{to} ");
            }
            Console.Write('\n');
        }
    }
}
