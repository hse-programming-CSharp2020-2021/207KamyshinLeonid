using System;
using Figures;
namespace Task2
{
    class Program
    {
        static Point[] FigArray()
        {
            Random rng = new Random();
            Point[] arr = new Point[rng.Next(0, 11)];
            for (int i = 0; i < arr.Length; i++)
            {
                if (rng.Next(0, 2) == 0)
                {
                    arr[i] = new Circle(rng.NextDouble() * 90 + 10, rng.NextDouble() * 90 + 10, rng.NextDouble() * 90 + 10);
                }
                else
                {
                    arr[i] = new Square(rng.NextDouble() * 90 + 10, rng.NextDouble() * 90 + 10, rng.NextDouble() * 90 + 10);

                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Point[] arr = FigArray();
            int circlesCount = 0, squaresCount = 0;
            foreach (Point x in arr)
            {
                if (x is Circle)
                {
                    ++circlesCount;
                }
                else
                {
                    ++squaresCount;
                }
            }
            Console.WriteLine($"{circlesCount} окружностей:");
            foreach (Point x in arr)
            {
                if (x is Circle)
                {
                    Console.WriteLine(x.Display());
                }
            }
            Console.WriteLine($"{squaresCount} квадратов:");
            foreach (Point x in arr)
            {
                if (x is Square)
                {
                    Console.WriteLine(x.Display());
                }
            }
            Console.WriteLine("---------------------------------------------");
            Array.Sort(arr);
            foreach (Point x in arr)
            {
                Console.WriteLine(x.Display());
            }
        }
    }
}
