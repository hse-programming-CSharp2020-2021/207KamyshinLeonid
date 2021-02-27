using System;
using System.Drawing;

namespace Structures
{
    struct PointS
    {
        double x;
        double y;

        public double X
        {
            get => x;
            set => x = value;
        }

        public double Y
        {
            get => y;
            set => y = value;
        }

        public PointS(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Distance(PointS point)
        {
            return Math.Sqrt((point.x - x) * (point.x - x) + (point.y - y) * (point.y - y));
        }

        public override string ToString()
        {
            return $"X coord: {X}, \nY coord: {Y}";
        }
    }

    struct CircleS : IComparable<CircleS>
    {
        double r;

        public double R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }

        PointS center;

        public PointS Center
        {
            get
            {
                return center;
            }
            set
            {
                center = value;
            }
        }

        public CircleS(double X, double Y, double R)
        {
            center = new PointS(X, Y);
            r = R;
        }

        public double Length
        {
            get
            {
                return 2 * Math.PI * R;
            }
        }

        public override string ToString()
        {
            return $"Center: \n" + center.ToString() + $" \nRadius: {R}";
        }

        public int CompareTo(CircleS other)
        {
            return this.r.CompareTo(other.r);
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        CircleS circle = new CircleS(1.3, -3.2, 2.3);
    //        Console.WriteLine(circle.ToString());
    //    }
    //}

}
