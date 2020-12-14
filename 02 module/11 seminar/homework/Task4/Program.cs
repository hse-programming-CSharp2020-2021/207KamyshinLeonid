using System;

namespace Task4
{
    class QuadraticTrinomial
    {
        // коэффициенты при степенях 2,1 и 0
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public QuadraticTrinomial(double a, double b, double c)
        {
            A = a; B = b; C = c;
        }
        // значение квадратного трёхчлена в точке x0
        public double ValueInX(double x0)
        {
            return A * x0 * x0 + B * x0 + C;
        }
        // метод возвращает частное от деления значения в точке x0 
        // квадратного трёхчлена на значение в точке x0 квадратного
        // трёхчлена, переданного в качестве параметра
        public double Division(QuadraticTrinomial another, double x0)
        {
            double div = ValueInX(x0);
            if (another.ValueInX(x0) == 0)
            {
                throw new DivideByZeroException();
            }
            div /= another.ValueInX(x0);
            return div;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            QuadraticTrinomial a = new QuadraticTrinomial(2, 3, 7);
            QuadraticTrinomial b = new QuadraticTrinomial(1, -5, 6);
            int[] x0 = new int[] { 1, -3, 3, 2, 7, 100, 0 };
            for (int i = 0; i < x0.Length; i++)
            {
                try
                {
                    Console.WriteLine($"{a.Division(b, x0[i]):f3}");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
