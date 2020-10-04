using System;

namespace Sem_04._1
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
        public static int[,] Gen(int n)
        {
            int[,] arr = new int[n, n];
            int cur = 1;
            int len = n - 1;
            int i = 0, j = 0;
            while (len > 0)
            {
                for (int k = 0; k < len; k++)
                {
                    arr[i, j] = cur++;
                    i++;
                }
                for (int k = 0; k < len; k++)
                {
                    arr[i, j] = cur++;
                    j++;
                }
                for (int k = 0; k < len; k++)
                {
                    arr[i, j] = cur++;
                    i--;
                }
                for (int k = 0; k < len; k++)
                {
                    arr[i, j] = cur++;
                    j--;
                }
                j++;
                i++;
                len -= 2;
            }
            if (len == 0)
            {
                arr[i, j] = cur++;
            }
            return arr;
        }
        public static void Print(int[,] arr)
        {
            int n = arr.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[j, i]} ");
                }
                Console.Write('\n');
            }
        }
        static void Main(string[] args)
        {
            int n = Read();
            int[,] arr = Gen(n);
            Print(arr);
        }
    }
}
