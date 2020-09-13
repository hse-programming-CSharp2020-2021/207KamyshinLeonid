using System;

namespace Task7
{
    class Program
    {
        public static void FirstMethod(double a)
        {
            long intPart = (long)a;
            double frac = a - intPart;
            Console.WriteLine($"Integer part is: {intPart}, fraction part is: {frac:f3}");
        }
        public static void SecondMethod(double a)
        {
            double pw = a * a;
            double sq = Math.Sqrt(a);
            Console.WriteLine($"2nd power is: {pw:f3}, square root is: {sq:f3}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to end");
            while (true)
            {
                double a;
                Console.Write("Input: ");
                if(double.TryParse(Console.ReadLine(),out a))
                {
                    FirstMethod(a);
                    SecondMethod(a);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
