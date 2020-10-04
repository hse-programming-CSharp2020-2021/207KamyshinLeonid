using System;
using System.Security.Cryptography.X509Certificates;

namespace Sem_03._20
{
    class Program
    {
        public static void Read(out int n, out int Y)
        {
            do Console.WriteLine("Введите числа");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || !int.TryParse(Console.ReadLine(), out Y));
        }
        public static int[] Gen(int n)
        {
            Random rng = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rng.Next(10, 101);
            }
            return arr;
        }
        public static void Print(int[] arr)
        {
            Array.ForEach(arr, x => Console.Write($"{x} "));
            Console.Write('\n');
        }
        public static void ArrayItemDouble(int[] A, int X)
        {
            int n = A.Length;
            for (int i = 0; i < n; i++)
            {
                A[i] = A[i] == X ? A[i] * 2 : A[i];
            }
        }
        static void Main(string[] args)
        {
            int n, Y;
            Read(out n, out Y);
            int[] arr = Gen(n);
            Print(arr);
            ArrayItemDouble(arr, Y);
            Print(arr);

        }
    }
}
