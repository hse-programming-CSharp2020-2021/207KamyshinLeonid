using System;

namespace Task5
{
    class Program
    {
        public static int[] cmpr(int n)
        {
            Random rng = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rng.Next(-10, 11);
            }
            Console.WriteLine("Текущий массив: ");
            Array.ForEach(arr, x => Console.Write($"{x} "));
            Console.Write('\n');
            int[] ans = Array.FindAll(arr, x => x % 2 == 1);
            return ans;
        }
        static void Main(string[] args)
        {
            int n;
            do Console.WriteLine("Введите длину: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            int[] res = cmpr(n);
            Console.WriteLine("Сжатый массив: ");
            Array.ForEach(res, x => Console.Write($"{x} "));
            Console.Write('\n');
        }
    }
}
