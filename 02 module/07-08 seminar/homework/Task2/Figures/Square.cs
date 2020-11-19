using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Square : Point
    {
        double side;
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }
        public Square(double x, double y, double side)
        {
            X = x;
            Y = y;
            Side = side;
        }
        public override double Area => Side * Side;
        public override double Perimeter => 4 * Side;
        public override string Display()
        {
            return $"Square side length = {side:f2}, center: " + base.Display() + $", area = {Area:f2}";
        }
    }
}
