using System;

namespace Task2
{
    struct Coords
    {
        public double X { get; set; }
        public double Y { get; set; }

        public override string ToString()
        {
            return $"X coord: {X}, \nY coord: {Y}";
        }
    }

    class Circle
    {
        public Coords center;
        public double R
        {
            get
            {
                return R;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Радиус не может быть отрицательным");
                }
                R = value;
            }
        }

        public Circle(double X, double Y, double R)
        {
            center.X = X;
            center.Y = Y;
            this.R = R;
        }

        public override string ToString()
        {
            return $"Center: \n" + center.ToString() + $" \nRadius: {R}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(1.2, -1.3, 23.1);
            Console.WriteLine(circle);
        }
    }
}
