using System;

namespace Task1._1
{
    class Program
    {
        public static int[,] Gen(int n)
        {
            int[,] arr = new int[n, n];
            int num = 1;
            for(int i = 0; i < n; i+=2)
            {
                int j = 0 + i / 2, k = 0 + i / 2;
                for(; j < n - i / 2; j++)
                {
                    arr[k, j] = num++;
                }
                j--;
                k++;
                for(;k < n - i / 2; k++)
                {
                    arr[k, j] = num++;
                }
                k--;
                j--;
                for(;j>= 0 + i / 2; j--)
                {
                    arr[k, j] = num++;
                }
                j++;
                k--;
                for (; k >= 0 + i / 2; k--)
                {
                    arr[k, j] = num++;
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int n;
            do Console.WriteLine("Введите число: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            int[,] arr = Gen(n);
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.Write('\n');
            }
        }
    }
}
