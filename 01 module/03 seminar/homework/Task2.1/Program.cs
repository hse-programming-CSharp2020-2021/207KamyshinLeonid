using System;

namespace Task2._1
{
    class Program
    {
        public static bool Check(double x, double y)
        {
            double angle = Math.Atan2(x, y);
            if (x * x + y * y > 4)
            {
                return false;
            }
            if (angle <= Math.PI / 4 && angle >= -Math.PI / 2)
            {
                return true;
            }
            return false;
        }
        public static bool Read(out double a)
        {
            return double.TryParse(Console.ReadLine(), out a);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                double x, y;
                do Console.WriteLine("Введите координаты: ");
                while (!Read(out x) || !Read(out y));
                if (Check(x, y))
                {
                    Console.WriteLine("Точка внутри фигуры");
                }
                else
                {
                    Console.WriteLine("Точка вне фигуры");
                }
            }
        }
    }
}
