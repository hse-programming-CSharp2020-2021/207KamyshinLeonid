using System;

namespace Sem_04._5
{
    class Program
    {
        public static int Read()
        {
            int n;
            do Console.WriteLine("Введите число");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            return n;
        }
        public static double[,] Gen(int n)
        {
            double[,] arr = new double[n, n];
            Random rng = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rng.NextDouble() * 25;
                }
            }
            return arr;
        }
        public static void Print1(double[,] arr)
        {
            int n = arr.GetLength(0);
            for (int i = 1, j = 1; i < n - 1; i++)
            {
                for (int k = 0; k < j; k++)
                {
                    Console.Write($"{arr[i, k]:f3} ");
                }
                Console.Write('\n');
                if (i * 2 == n - 2 && n % 2 == 0)
                {
                    j--;
                }
                if (i * 2 < n - 1)
                {
                    j++;
                }
                else
                {
                    j--;
                }
            }
        }
        public static void Prin2(double[,] arr)
        {

        }
        static void Main(string[] args)
        {
            int n = Read();
            double[,] arr = Gen(n);
            Print1(arr);
        }
    }
}
