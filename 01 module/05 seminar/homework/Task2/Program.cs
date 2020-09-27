using System;

namespace Task2
{
    class Program
    {
        public static void gen(int[] arr, int n)
        {
            arr[0] = 1;
            for (int i = 1; i < n; i++)
            {
                arr[i] = arr[i - 1] + 2;
            }
        }
        static void Main(string[] args)
        {
            int n;
            do Console.WriteLine("Введите число: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            int[] arr = new int[n];
            gen(arr, n);
            foreach(int to in arr)
            {
                Console.Write($"{to} ");
            }
            Console.Write('\n');
        }
    }
}
