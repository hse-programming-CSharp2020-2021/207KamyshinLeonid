using System;

namespace Task2._3
{
    class Program
    {
        public static double CalcF(double x)
        {
            if (x <= 0.5)
            {
                return 1;
            }
            else
            {
                return Math.Sin(Math.PI * (x - 1) / 2);
            }
        }
        public static bool Read(out double a)
        {
            return double.TryParse(Console.ReadLine(), out a);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                double x;
                do Console.WriteLine("Введите число: ");
                while (!Read(out x));
                Console.WriteLine($"Результат: {CalcF(x):f3}");
            }
        }
    }
}
