using System;

namespace Task4
{
    class Program
    {
        public static double FastPow(double a, int st)
        {
            if(st == 0)
            {
                return 1;
            }
            double res = FastPow(a, st / 2);
            res *= res;
            if(st%2 == 1)
            {
                res *= a;
            }
            return res;
        }
        public static double Iterate(double x, double a, int n)
        {
            double nx = (n - 1) * x + a / FastPow(x, n - 1);
            nx /= n;
            return nx;
        }
        public static bool Root(double a, int n, out double x0)
        {
            x0 = a;
            if (a < 0)
            {
                return false;
            }
            while(x0 != Iterate(x0, a, n))
            {
                x0 = Iterate(x0, a, n);
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to end");
            while(true)
            {
                Console.WriteLine("Input: ");
                double a;
                int n;
                if(double.TryParse(Console.ReadLine(),out a) && int.TryParse(Console.ReadLine(),out n))
                {
                    double answer;
                    if (Root(a, n, out answer)){
                        Console.WriteLine($"Result: {answer:f3}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input");
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
