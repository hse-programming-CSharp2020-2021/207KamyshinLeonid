using System;
using System.Linq;

namespace DoubleArr
{
    class Circle
    {
        double _r;
        public double Radius
        {
            get
            {
                return _r;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Radius should be non-negative");
                _r = value;
            }
        }

        public double S
        {
            get
            {
                return Math.PI * _r * _r;
            }
        }

        public double Length
        {
            get
            {
                return Math.PI * _r * 2;
            }
        }
        public Circle()
        {
            Radius = 1;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return $"Circle: radius = {Radius:f3}, Square = {S:f3}, Length = {Length:f3}";
        }
    }

    /*
     * этап 2
     * Свойство подсчета длины окружности. 
     * Ввести значение n.
     * Генерируем массив из кругов со случайным значением радиуса (Rmin, Rmax)
     * Для всех кругов считаем площадь и длину окружности и вывести на экран.
     * Найти круг с наибольшей площадью и вывести его на экран.
*/

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double rmin = double.Parse(Console.ReadLine());
            double rmax = double.Parse(Console.ReadLine());
            Random rng = new Random();
            Circle[] circles = new Circle[n];

            for (int i = 0; i < n; i++)
            {
                circles[i] = new Circle(rng.NextDouble() * (rmax - rmin) + rmin);
                Console.WriteLine(circles[i].ToString());
            }
            Console.WriteLine(circles.Max(Circle => Circle.S).ToString());
        }
    }
}