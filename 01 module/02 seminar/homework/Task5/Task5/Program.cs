using System;
using System.ComponentModel.DataAnnotations;

namespace Task5
{
    class Program
    {
        public static string Check(double a, double b, double c)
        {
            double m1, m2;
            m1 = Math.Max(a, Math.Max(b, c));
            m2 = a + b + c - m1;
            string res = (m1 < m2) ? "Exists" : "Doesnt exists";
            return res;
        }
        public static bool Read(out double a)
        {
            return double.TryParse(Console.ReadLine(), out a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to end");
            while(true)
            {
                double a, b, c;
                Console.WriteLine("Input:");
                if(Read(out a) && Read(out b) && Read(out c))
                {
                    Console.WriteLine(Check(a, b, c));
                }
                else
                {
                    return;
                }
            }
        }
    }
}
