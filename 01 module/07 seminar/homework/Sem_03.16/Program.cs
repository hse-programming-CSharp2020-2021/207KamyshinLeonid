using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace Sem_03._16
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
        public static int[] Gen(int n)
        {
            int[] arr = new int[n];
            Random rng = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rng.Next(-100, 101);
            }
            Console.Write("Массив: ");
            Array.ForEach(arr, x => Console.Write($"{x} "));
            Console.Write('\n');
            return arr;
        }
        public static void Solve(int[] arr)
        {
            int n = arr.Length;
            int minValInd = Array.FindIndex(arr, x => x == arr.Min());
            Console.Write("Индекс минимального элемента: ");
            Console.WriteLine($"{minValInd}");
            int maxValInd = Array.FindIndex(arr, x => x == arr.Max());
            Console.Write("Сумма индексов минимального и максимального элементов : ");
            Console.WriteLine($"{minValInd + maxValInd}");
        }
        static void Main(string[] args)
        {
            int n = Read();
            int[] arr = Gen(n);
            Solve(arr);
        }
    }
}
