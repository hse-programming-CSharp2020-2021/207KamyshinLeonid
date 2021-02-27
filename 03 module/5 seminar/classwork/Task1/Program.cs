using System;

namespace Task1
{
    interface ICalculation
    {
        double Perform(double a);
    }

    class Add : ICalculation
    {
        readonly double C;

        public Add(double c)
        {
            C = c;
        }

        public double Perform(double a)
        {
            return a + C;
        }
    }

    class Multiply : ICalculation
    {
        readonly double C;

        public Multiply(double c)
        {
            C = c;
        }

        public double Perform(double a)
        {
            return a * C;
        }

    }
    class Program
    {
        static double Calculate(double a, Func<double, double> add, Func<double, double> multiply)
        {
            a = add(a);
            a = multiply(a);
            return a;
        }

        static void Main(string[] args)
        {
            Add add = new Add(12.3);
            Multiply multiply = new Multiply(2.7);
            Console.WriteLine(Calculate(12, add.Perform, multiply.Perform));
        }
    }
}
