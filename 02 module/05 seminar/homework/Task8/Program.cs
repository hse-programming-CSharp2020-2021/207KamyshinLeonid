using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Task8
{
    class Point
    {
        double x, y;
        public double X
        {
            get
            {
                return x;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
        }
        public Point() { }
        public Point(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public override string ToString()
        {
            return $"x: {x:f3}, y: {y:f3}"; 
        }
    }
    class Triangle
    {
        Point a, b, c;
        public Triangle() { }
        public Triangle(Point _a, Point _b, Point _c)
        {
            a = _a;
            b = _b;
            c = _c;
        }
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            a = new Point(x1, y1);
            b = new Point(x2, y2);
            c = new Point(x3, y3);
        }
        public Point[] GetPoints
        {
            get
            {
                return new Point[] { a, b, c };
            }
        }
        public double Perimeter
        {
            get
            {
                double n = Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
                double m = Math.Sqrt((a.X - c.X) * (a.X - c.X) + (a.Y - c.Y) * (a.Y - c.Y));
                double k = Math.Sqrt((c.X - b.X) * (c.X - b.X) + (c.Y - b.Y) * (c.Y - b.Y));
                double p = n + m + k;
                return p;
            }
        }
        public double Area
        {
            get
            {
                double n = Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
                double m = Math.Sqrt((a.X - c.X) * (a.X - c.X) + (a.Y - c.Y) * (a.Y - c.Y));
                double k = Math.Sqrt((c.X - b.X) * (c.X - b.X) + (c.Y - b.Y) * (c.Y - b.Y));
                double p = (n + m + k) / 2;
                return Math.Sqrt(p * (p - n) * (p - m) * (p - k));
            }
        }
        public override string ToString()
        {
            return $"Вершины:\n{a.ToString()}\n{b.ToString()}\n{c.ToString()}\nПериметер: {this.Perimeter:f3}\nПлощадь: {this.Area:f3}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int n = rng.Next(5, 16);
            double[] pts = new double[6];
            Triangle[] arr = new Triangle[n];
            Console.WriteLine($"{n} треугольников");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    pts[j] = rng.NextDouble() * 20 - 10;
                }
                arr[i] = new Triangle(pts[0], pts[1], pts[2], pts[3], pts[4], pts[5]);
                Console.WriteLine(arr[i].ToString());
            }
        }
        
    }
}
