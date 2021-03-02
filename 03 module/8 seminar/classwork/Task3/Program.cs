using System;

namespace Task3
{
    interface IFigure
    {
        double Area { get; }
    }

    class Square : IFigure
    {
        double len;

        public double Area
        {
            get => len * len;
        }

        public Square(double len)
        {
            this.len = len;
        }

        public override string ToString()
        {
            return $"Square with side: {len}, area: {Area}";
        }
    }
    
    class Circle : IFigure
    {
        double r;

        public double Area
        {
            get => 2 * Math.PI * r * r;
        }

        public Circle(double r)
        {
            this.r = r;
        }

        public override string ToString()
        { 
            return $"Circle with radius: {r}, area: {Area}";
        }
    }

    static class Outputer
    {
        public static void Print<T>(T[] arr, double bound) where T:IFigure
        {
            for(int i = 0; i < arr.Length; i++)
            {
                var elem = arr[i];
                if(elem.Area >= bound)
                {
                    Console.WriteLine(arr[i].ToString());
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            IFigure[] arr = new IFigure[100];
            for(int i = 0;  i< 100; i++)
            {
                if(rng.Next(0,2)%2 == 1)
                {
                    arr[i] = new Circle(rng.NextDouble() * rng.Next(1, 50));
                }
                else
                {
                    arr[i] = new Square(rng.NextDouble() * rng.Next(1, 50));
                }
            }
            Console.WriteLine($"Area not less than {34.5}");
            Outputer.Print(arr, 34.5);
            Console.WriteLine($"Area not less than {1}");
            Outputer.Print(arr, 1);
        }
    }
}
