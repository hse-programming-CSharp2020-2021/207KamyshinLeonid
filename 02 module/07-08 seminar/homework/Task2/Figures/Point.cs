using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Point : IComparable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public virtual double Area { get; }
        public virtual double Perimeter { get; }
        public virtual string Display()
        {
            return $"X = {X:f2}, Y = {Y:f2}";
        }
        public int CompareTo(object _a)
        {
            Point a = _a as Point;
            return this.Area.CompareTo(a.Area);
        }
    }
}
