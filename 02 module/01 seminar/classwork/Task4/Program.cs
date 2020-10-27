using System;
using System.Linq;

namespace Task4
{
    class Program
    {
        public static int[][] Gen(int n)
        {
            int[][] triangle = new int[n][];
            for (int i = 0; i < n; i++)
            {
                triangle[i] = new int[i + 1];
                triangle[i][0] = triangle[i][i] = 1;
                for (int j = 1; j < i; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }
            return triangle;
        }
        public static void Print(int[][] triangle)
        {
            Array.ForEach(triangle, x =>
            {
                Array.ForEach(x, y => Console.Write($"{y} "));
                Console.WriteLine();
            }
           );
        }
        static void Main(string[] args)
        {
            int n;
            do Console.WriteLine("Введите размер треугольника: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1);
            int[][] triangle = Gen(n);
            Print(triangle);
           
        }
    }
}
