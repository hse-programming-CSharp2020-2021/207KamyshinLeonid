using System;

namespace Task10
{
    class Circle
    {
        public double x, y, r;
        public Circle()
        {
            x = new Random().NextDouble() * 16 - 1;
            y = new Random().NextDouble() * 16 - 1;
            r = new Random().NextDouble() * 16 - 1;
        }
        public bool Intersect(Circle a)
        {
            double dx = a.x - x;
            double dy = a.y - y;
            double len = Math.Sqrt(dx * dx + dy * dy);
            return (a.r + r <= len);
        }
        public override string ToString()
        {
            return $"Окружность с центром ({x:f3},{y:f3}) и радиусом {r:f3}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n;
                do Console.WriteLine("Введите количество окружностей: ");
                while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
                Console.Clear();
                Circle circle = new Circle();
                Console.WriteLine("Главная окружность:\n" + circle.ToString());
                Console.WriteLine("Создан массив окружностей:");
                Circle[] arr = new Circle[n];
                for(int i = 0; i < n; i++)
                {
                    arr[i] = new Circle();
                    Console.WriteLine(arr[i].ToString());
                }
                Console.WriteLine("\nС главной окружностью пересекаются:");
                for(int i = 0; i < n; i++)
                {
                    if (arr[i].Intersect(circle))
                    {
                        Console.WriteLine(arr[i].ToString());
                    }
                }
            }
        }
    }
}
