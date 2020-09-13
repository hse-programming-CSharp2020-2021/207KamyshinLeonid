using System;

namespace Task2._2
{
    class Program
    {
        public static double CalcG(double x, double y)
        {
            if (x < y && x > 0)
            {
                return x + Math.Sin(y);
            }
            if (x > y && x < 0)
            {
                return y - Math.Cos(x);
            }
            return x * y / 2;

        }
        public static bool Read(out double a)
        {
            return double.TryParse(Console.ReadLine(), out a);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                double x, y;
                do Console.WriteLine("Введите два числа: ");
                while (!Read(out x) || !Read(out y));
                Console.WriteLine($"Результат: {CalcG(x, y):f3}");
            }
        }
    }
}
