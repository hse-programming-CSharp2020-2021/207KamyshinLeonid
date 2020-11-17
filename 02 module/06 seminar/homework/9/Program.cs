using System;

namespace _9
{
    class Linear : IComparable
    {
        public double a, b, c;
        public Linear() { }
        public Linear(double _a, double _b, double _c)
        {
            a = _a;
            b = _b;
            c = _c;
        }
        public double x
        {
            get
            {
                if (a == 0)
                {
                    if (b != c)
                    {
                        return double.NegativeInfinity;
                    }
                    else
                    {
                        return double.PositiveInfinity;
                    }
                }
                return (c - b) / a;
            }
        }
        public override string ToString()
        {
            string res = $"Уравнение вида {a:f3}x + {b:f3} = {c:f3}.\n";
            switch (x)
            {
                case double.NegativeInfinity:
                    res += "Не имеет решений";
                    break;
                case double.PositiveInfinity:
                    res += "Имеет бесконечно много решений";
                    break;
                default:
                    res += $"Имеет единственное решение x = {x:f3}";
                    break;
            }
            return res;
        }
        public int CompareTo(object a)
        {
            Linear tmp = a as Linear;
            return x.CompareTo(tmp.x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n;
                do Console.WriteLine("Введите количество уравнений:");
                while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
                Console.Clear();
                Linear[] arr = new Linear[n];
                Random rng = new Random();
                for (int i = 0; i < n; i++)
                {
                    double a, b, c;
                    a = rng.NextDouble() * 20 - 10;
                    b = rng.NextDouble() * 20 - 10;
                    c = rng.NextDouble() * 20 - 10;
                    arr[i] = new Linear(a, b, c);
                    Console.WriteLine(arr[i].ToString());
                }
                Console.WriteLine("\nОтсортируем корни по возрастанию:");
                Array.Sort(arr);
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i].ToString());
                }
            }
        }
    }
}
