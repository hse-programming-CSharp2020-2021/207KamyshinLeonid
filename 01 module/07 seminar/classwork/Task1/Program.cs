using System;

namespace Task1
{
    class Program
    {
        public static char[][] Gen1(int n)
        {
            char[][] arr = new char[n][];
            for(int i = 0; i < n; i++)
            {
                arr[i] = new char[i + 1];
                for(int j = 0; j < i + 1; j++)
                {
                    arr[i][j] = '*';
                }
            }
            return arr;
        }
        public static char[][] Gen2(int n)
        {
            char[][] arr = new char[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new char[n / 2 + i];
                for (int j = n/2+i-1, cnt = i; cnt >= 0 ; j--,cnt--)
                {
                    arr[i][j] = '*';
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int n;
            do Console.WriteLine("Введите число: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            char[][] ans = Gen1(n);
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < i+1; j++)
                {
                    Console.Write($"{ans[i][j]} ");
                }
                Console.Write('\n');
            }
            char[][] ans2 = Gen2(n);
            for(int i = 0; i < n; i++)
            {
                Array.ForEach(ans2[i], x => Console.Write($"{x} "));
                Console.Write('\n');
            }
        }
    }
}
