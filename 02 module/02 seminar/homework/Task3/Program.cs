using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;

namespace Task3
{
    public class Polygon : IComparable<Polygon>
    { // Класс многоугольников
        int numb;       // Число сторон
        double radius;  // Радиус вписанной окружности
        public Polygon(int n = 3, double r = 1)
        { // конструктор       
            numb = n;
            radius = r;
        }
        public double Perimeter
        { // Периметр многоугольника - свойство
            get
            {   // аксессор свойства
                double term = Math.Tan(Math.PI / numb);
                return 2 * numb * radius * term;
            }
        }

        public double Area
        { // Площадь многоугольника - свойство
            get
            {   // аксессор свойства
                return Perimeter * radius / 2;
            }
        }
        public string PolygonData()
        {
            string res =
            string.Format("N={0}; R={1}; P={2,2:F3}; S={3,4:F3}",
            numb, radius, Perimeter, Area);
            return res;
        }
        public int CompareTo(Polygon a)
        {
            return Area.CompareTo(a.Area);
        }
    }   // Polygon 
    public class Program
    {
        public static void Main()
        {
            List<Polygon> poligons = new List<Polygon>();
            double rad;
            int number;
            do
            {
                do Console.Write("Введите число сторон: ");
                while (!int.TryParse(Console.ReadLine(), out number) | (number < 3 && number != 0));
                do Console.Write("Введите радиус: ");
                while (!double.TryParse(Console.ReadLine(), out rad) | (rad <= 0 && number != 0));
                if (number == 0)
                {
                    if (rad != 0)
                    {
                        continue;
                    }
                    break;
                }
                poligons.Add(new Polygon(number, rad));
                foreach (var item in poligons)
                {
                    Console.WriteLine("Сведения о многоугольнике:");
                    Console.WriteLine(item.PolygonData());
                }
                Console.WriteLine("Многоугольник с наименьшей площадью:");
                Console.WriteLine(poligons.Min().PolygonData());
                Console.WriteLine("Многоугольник с наибольшей площадью:");
                Console.WriteLine(poligons.Max().PolygonData());
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}
