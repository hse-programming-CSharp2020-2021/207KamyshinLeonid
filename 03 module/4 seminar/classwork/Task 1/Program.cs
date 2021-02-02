using System;

namespace Task_1
{
    class Program
    {
        delegate double operation (double x, int index);

        static void Main(string[] args)
        {
            operation mult = (double x, int index) =>
            {
                for (int i = 1; i < index; i++)
                {
                    x /= i;
                }
                return x;
            };
            operation sum = (double x, int index) =>
            {
                double res = 0;
                for (int i = 1; i <= index; i++)
                {
                    res += i * mult(x, index);
                }
                return res;
            };
            double res = 0;
            Console.WriteLine(sum(10, 5));
            
        }
    }
}
