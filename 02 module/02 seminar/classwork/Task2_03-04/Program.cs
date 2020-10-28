using System;
using System.Numerics;
using System.Runtime.InteropServices;

class Program
{
    class Point : IComparable<Point>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y) { X = x; Y = y; }
        public Point() : this(0, 0) { }
        public int CompareTo(Point pt)
        {
            return Ro.CompareTo(pt.Ro);
        }
        public double Ro
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }
        public double Fi
        {
            get
            {
                if (X == Y && X == 0)
                {
                    return 0;
                }
                if (X == 0 && Y > 0)
                {
                    return Math.PI / 2;
                }
                if (X == 0 && Y < 0)
                {
                    return 3 * Math.PI / 2;
                }
                if (X < 0)
                {
                    return Math.Atan2(Y, X) + Math.PI;
                }
                if (Y < 0)
                {
                    return Math.Atan2(Y, X) + 2 * Math.PI;
                }
                return Math.Atan2(Y, X);
            }
        }
        public string PointData
        {   // СВОЙСТВО 
            get
            {
                string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                return string.Format(maket, X, Y, Ro, Fi);
            }
        }
        static void Main()
        {
            Point[] arr = new Point[3];
            arr[0] = new Point(3, 4);
            Console.WriteLine(arr[0].PointData);
            arr[1] = new Point(0, 3);
            Console.WriteLine(arr[1].PointData);
            arr[2] = new Point();
            double x = 0, y = 0;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);
                arr[2].X = x; arr[2].Y = y;
                Array.Sort(arr);
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(arr[i].PointData);
                }
            } while (x != 0 | y != 0);


        }
        
    }
}
