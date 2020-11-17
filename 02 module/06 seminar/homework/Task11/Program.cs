using System;

namespace Task11
{
    class GeometricProgression
    {
        double _start { get; set; }
        double _increment { get; set; }
        public GeometricProgression() { }
        public GeometricProgression(double start, double increment)
        {
            _start = start;
            _increment = increment;
        }
        public double this[int index]
        {
            get
            {
                return _start * Math.Pow(_increment, index - 1);
            }
        }
        public double GetSum(int n)
        {
            double res = 0;
            for (int i = 1; i <= n; i++)
            {
                res += this[i];
            }
            return res;
        }
        public override string ToString()
        {
            return $"Геометрическая прогрессия с b_0 = {_start:f3} и знаменателем q = {_increment:f3}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = new Random().Next(5, 16);
                GeometricProgression geometric = new GeometricProgression(new Random().NextDouble() * 10, new Random().NextDouble() * (5 - 0.0001) + 0.0001);
                Console.WriteLine("Главная последовательность: ");
                Console.WriteLine(geometric.ToString());
                Console.WriteLine();
                int step = new Random().Next(3, 16);
                GeometricProgression[] arr = new GeometricProgression[n];
                Console.WriteLine($"У этих последовательностей элемент с номером {step} больше чем у главной: ");
                for (int i = 0; i < n; i++)
                {
                    double _start = new Random().NextDouble() * 10;
                    double _increment = new Random().NextDouble() * (5 - 0.0001) + 0.0001;
                    arr[i] = new GeometricProgression(_start, _increment);
                    if (arr[i][step] > geometric[step])
                    {
                        Console.WriteLine(arr[i].ToString());
                    }
                }
                Console.WriteLine("\nВесь массив: ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i].ToString());
                    Console.WriteLine($"Сумма первых {step} членов: {arr[i].GetSum(step):f3}");
                }
                Console.ReadLine();
            }
        }
    }
}
