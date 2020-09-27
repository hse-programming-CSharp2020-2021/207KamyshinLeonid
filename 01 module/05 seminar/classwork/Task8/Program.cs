using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Task8
{
    class Program
    {
        // 8.1
        public static double[] gen(int n)
        {
            double[] arr = new double[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = (i * (i + 1) / 2)%n;
            }
            return arr;
        }
        // 8.2
        public static double[] norm(double[] arr, int n)
        {
            double mx = 0;
            double[] res = new double[n];
            foreach(double to in arr)
            {
                if(Math.Abs(mx) < Math.Abs(to))
                {
                    mx = to;
                }
            }
            for(int i = 0; i < n; i++)
            {
                res[i] = arr[i] / mx;
            }
            return res;
        }
        // 8.3
        public static void print(ref double[] arr)
        {
            foreach(double to in arr)
            {
                Console.Write($"{to:f3} ");
            }
            Console.Write('\n');
        }
        // 8.4
        static void Main(string[] args)
        {
            int n;
            while(true)
            {
                do Console.WriteLine("Введите длину массива: ");
                while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
                double[] arr = gen(n);
                double[] narr = norm(arr, n);
                print(ref arr);
                print(ref narr);
            }
        }
    }
}
