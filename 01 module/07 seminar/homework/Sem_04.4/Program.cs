using System;

namespace Sem_04._4
{
    class Program
    {
        public static void Read(out int n, out int MIN, out int MAX)
        {
            do Console.WriteLine("Введите число");
            while (!int.TryParse(Console.ReadLine(), out n) 
                  || n <= 0
                  || !int.TryParse(Console.ReadLine(), out MIN) 
                  || !int.TryParse(Console.ReadLine(), out MAX));
        }
        public static double[,] Gen(int n, int MIN, int MAX)
        {
            Random rng = new Random();
            double[,] arr = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rng.NextDouble() * (MAX - MIN) + MIN;
                }
            }
            return arr;
        }
        public static void Print(double[,] arr)
        {
            int n = arr.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j]:f3} ");
                }
                Console.Write('\n');
            }
        }
        public static double SolveDet(double [,] arr)
        {
            int n = arr.GetLength(0);
            if(n == 2)
            {
                return arr[0, 0] * arr[1, 1] - arr[0, 1] * arr[1, 0];
            }
            if (n == 3)
            {
                double D = 0;
                D += arr[0, 0] * arr[1, 1] * arr[2, 2] + arr[0, 1] * arr[1, 2] * arr[2, 0] + arr[0, 2] * arr[1, 0] * arr[2, 1];
                D -= arr[2, 0] * arr[1, 1] * arr[1, 2] - arr[2, 1] * arr[1, 2] * arr[0, 0] - arr[2, 2] * arr[1, 0] * arr[0, 1];
                return D;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int n, MIN, MAX;
            Read(out n, out MIN, out MAX);
            double[,] arr = Gen(n, MIN, MAX);
            Print(arr);
            Console.WriteLine($"Определитель матрицы: {SolveDet(arr):f3} ");
        }
    }
}
