using System;

namespace Task4
{
    class Program
    {
        public static void gen(ulong[] arr, int n)
        {
            arr[0] = 1;
            arr[1] = 1;
            for(int i = 2;i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
        }
        static void Main(string[] args)
        {
            int n;
            do Console.WriteLine("Введите длину массива: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 1);
            ulong[] arr = new ulong[n];
            gen(arr, n);
            for(int i = n-1; i>= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.Write('\n');
        }
    }
}
