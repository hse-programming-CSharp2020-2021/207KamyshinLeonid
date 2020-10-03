using System;

namespace Task4
{
    class Program
    {
        public static void Srt(int n)
        {
            int[] arr = new int[n];
            Random rng = new Random();
            for(int i = 0; i < n; i++)
            {
                arr[i] = rng.Next(-10, 11);
            }
            int[] ans = new int[n];
            for(int i = n-1, j = n-1; i >= 0 ; i--)
            {
                if(arr[i] < 0)
                {
                    ans[j--] = arr[i];
                }
            }
            for(int i = 0, j = 0; i < n; i++)
            {
                if(arr[i] >= 0)
                {
                    ans[j++] = arr[i];
                }
            }
            Console.WriteLine("Был массив: ");
            Array.ForEach(arr, x => Console.Write($"{x} "));
            Console.Write('\n');
            Console.Write("Стал: ");
            Array.ForEach(ans, x => Console.Write($"{x} "));
            Console.Write('\n');
        }
        static void Main(string[] args)
        {
            int n;
            do Console.WriteLine("Введите длину массива: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            Srt(n);
        }
    }
}
