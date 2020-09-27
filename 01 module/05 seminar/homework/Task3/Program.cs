using System;

namespace Task3
{
    class Program
    {
        public static void gen(long[] arr, int n, int a, int d)
        {
            for(int i = 0; i < n; i++)
            {
                arr[i] = a + d * i;
            }
        }
        static void Main(string[] args)
        {
            int n, a, d;
            do Console.WriteLine("Введите числа: ");
            while (!int.TryParse(Console.ReadLine(), out n) || !int.TryParse(Console.ReadLine(), out a) || !int.TryParse(Console.ReadLine(), out d) || n <= 1);
            long[] arr = new long[n];
            gen(arr, n, a, d);
            foreach(long to in arr)
            {
                Console.Write($"{to} ");
            }
            Console.Write('\n');
        }
    }
}
