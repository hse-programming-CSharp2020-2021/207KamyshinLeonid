using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Circle : Point
    {
        double rad;
        public double Rad
        {
            get
            {
                return rad;
            }
            set
            {
                rad = value;
            }
        }
        public Circle(double x, double y, double rad)
        {
            X = x;
            Y = y;
            Rad = rad;
        }
        public override double Area => Math.PI * Rad * Rad;
        public override double Perimeter => 2 * Math.PI * Rad;
        public override string Display()
        {
            return $"Circle radius = {Rad:f2}, center: " + base.Display() + $", area = {Area:f2}";
        }
    }
}
