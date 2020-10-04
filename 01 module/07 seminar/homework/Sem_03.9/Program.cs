using System;

namespace Sem_03._9
{
    class Program
    {
        public static int ReadN()
        {
            int n;
            do Console.WriteLine("Введите число");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            return n;
        }
        public static void printArr(double[] arr)
        {
            Array.ForEach(arr, x => Console.Write($"{x:f3} "));
            Console.Write('\n');
        }
        public static double[] Gen(int n)
        {
            Random rng = new Random();
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rng.NextDouble()*20 - 10;
            }
            return arr;
        }
        public static void ArrayHill(double[] arr)
        {
            int n = arr.Length;
            double[] srtArr = new double[n];
            Array.Copy(arr, srtArr,n);
            Array.Sort(srtArr);
            for(int i = 0, j = n-1, pos = 0; pos < n;pos++)
            {
                if(pos%2 == 0)
                {
                    arr[i++] = srtArr[pos];
                }
                else
                {
                    arr[j--] = srtArr[pos];
                }
            }
        }
        static void Main(string[] args)
        {
            int n = ReadN();
            double[] arr = Gen(n);
            printArr(arr);
            ArrayHill(arr);
            printArr(arr);

        }
    }
}
