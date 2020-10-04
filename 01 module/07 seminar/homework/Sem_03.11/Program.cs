using System;

namespace Sem_03._11
{
    class Program
    {
        public static int ReadN()
        {
            int n;
            do Console.WriteLine("Введите число");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 1);
            return n;
        }
        public static void Gen(int n)
        {
            long[] arr = new long[n];
            arr[0] = 0;
            arr[1] = 1;
            for(int i = 2; i < n; i++)
            {
                arr[i] = 34 * arr[i - 1] - arr[i - 2] + 2;
            }
            Array.ForEach(arr, x => Console.Write($"{x} "));
            Console.Write('\n');
        }
        static void Main(string[] args)
        {
            int n = ReadN();
            Gen(n);
        }
    }
}
