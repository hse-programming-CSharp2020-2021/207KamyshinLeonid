using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do Console.WriteLine("Введите размер массива: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int d = i + j + 1;
                    if(d > n)
                    {
                        d %= n;
                    }
                    arr[i, j] = d;
                }
            }
            for(int i = 0; i < n; i++)
            {
                for(int j= 0;j < n; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
