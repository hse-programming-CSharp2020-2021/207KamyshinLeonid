using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Task7
{
    class Program
    {
        public static bool Solve(double a, double b, double c, out double x1, out double x2)
        {
            x1 = x2 = 0;
            if (a == 0 && b == 0)
            {
                return false;
            }
            if (a == 0)
            {
                x1 = x2 = -c;
                return true;
            }
            else
            {
                if (b * b - 4 * a * c < 0)
                {
                    return false;
                }
                double sqD = Math.Sqrt(b * b - 4 * a * c) / (2 * a);
                x1 = x2 = -b / (2 * a);
                x1 += sqD;
                x2 -= sqD;
                return true;
            }
        }
        public static bool Read(out double p)
        {
            return !double.TryParse(Console.ReadLine(), out p);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                double x1, x2, a, b, c;
                do Console.WriteLine("Введите коэффициенты: ");
                while (Read(out a) || Read(out b) || Read(out c));
                if (Solve(a, b, c, out x1, out x2))
                {
                    if (x1 == x2)
                    {
                        Console.WriteLine($"Решение: {x1:f3}");
                    }
                    else
                    {
                        Console.WriteLine($"Решения:\n {x1:f3} \n {x2:f3}");
                    }
                }
                else
                {
                    Console.WriteLine("Корней нет");
                }
            }
        }
    }
}
