using System;
using System.Linq;

namespace Task9
{
    class Program
    {
        public static void def(int[] arr, int n, int par)
        {
            int mx = arr.Max();
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == mx)
                {
                    arr[i] = par;
                }
            }
        }
        public static void print(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.Write('\n');
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            int n, par;
            do Console.WriteLine("Введите длину массива: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rng.Next(0, n / 3 + 2);
            }
            do Console.WriteLine("Введите параметр ");
            while (!int.TryParse(Console.ReadLine(), out par));
            print(arr);
            def(arr, n, par);
            print(arr);
        }
    }
}
