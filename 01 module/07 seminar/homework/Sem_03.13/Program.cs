using System;

namespace Sem_03._13
{
    class Program
    {
        public static void Read(out int n, out int k)
        {
            do Console.WriteLine("Введите число");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || !int.TryParse(Console.ReadLine(), out k) || k < 1 || k > n);
        }
        public static void Gen(int n, int k)
        {
            int[] arr = new int[n];
            Random rng = new Random();
            for(int i = 0; i < n; i++)
            {
                arr[i] = rng.Next(-100, 101);
            }
            for (int i = 0; i < n; i += k)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.Write('\n');
        }
        static void Main(string[] args)
        {
            int n, k;
            Read(out n, out k);
            Gen(n, k);
        }
    }
}
