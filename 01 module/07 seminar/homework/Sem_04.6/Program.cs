using System;

namespace Sem_04._6
{
    class Program
    {
        public static int[,] Gen()
        {
            int[,] arr = new int[3, 6];
            Random rng = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    arr[i, j] = rng.Next(0, 21);
                }
            }
            return arr;
        }
        public static int SolveDet(int[,] arr, int p)
        {
            int D = 0;
            D += arr[0, 0 + p] * arr[1, 1 + p] * arr[2, 2 + p] + arr[0, 1 + p] * arr[1, 2 + p] * arr[2, 0 + p] + arr[0, 2 + p] * arr[1, 0 + p] * arr[2, 1 + p];
            D -= arr[2, 0 + p] * arr[1, 1 + p] * arr[1, 2 + p] - arr[2, 1 + p] * arr[1, 2 + p] * arr[0, 0 + p] - arr[2, 2 + p] * arr[1, 0 + p] * arr[0, 1 + p];
            return D;
        }
        public static void Print(int[,] arr)
        {
            int n = arr.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr.Length/n; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.Write('\n');
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = Gen();
            Print(arr);
            int[] D = new int[2];
            D[0] = SolveDet(arr, 0);
            D[1] = SolveDet(arr, 3);
            Array.ForEach(D, x => Console.Write($"{x} "));
            Console.Write('\n');
        }
    }
}
