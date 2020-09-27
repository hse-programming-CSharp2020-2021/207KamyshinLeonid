using System;

namespace Task3
{
    class Program
    {
        public static void tab(double a, double b, double c)
        {
            for (double x = 1.0; x <= 2.01; x += 0.05)
            {
                if(x == 1.2)
                {
                    Console.WriteLine($"x = {x:f2} : y = {a / x + Math.Sqrt(x * x + 1)}");
                }
                if(x > 1.2)
                {
                    Console.WriteLine($"x = {x:f2} : y = {(a+b*x)/Math.Sqrt(x*x+1)}");
                }
                if(x < 1.2)
                {
                    Console.WriteLine($"x = {x:f2} : y = {a*x*x + b*x + c}");
                }
            }

        }
        static void Main(string[] args)
        {
            double a, b, c;
            do Console.WriteLine("Введите числа: ");
            while (!double.TryParse(Console.ReadLine(), out a) || !double.TryParse(Console.ReadLine(), out b) || !double.TryParse(Console.ReadLine(), out c));
            tab(a, b, c);
        }
    }
}
