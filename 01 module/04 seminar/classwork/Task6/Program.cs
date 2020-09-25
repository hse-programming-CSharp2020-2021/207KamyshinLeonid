using System;

namespace Task6
{
    class Program
    {
        public static double firstSum(double x)
        {
            double res = 0, curRes = -1;
            double xPow = x, twoPowDivideFactorial = 1;
            // j - поддерживает текущий факториал
            for (int i = 1,j = 3; res != curRes; i++,j+=2)
            {
                curRes = res;
                if(i%2 == 1)
                {
                    res += xPow * twoPowDivideFactorial;
                }
                else
                {
                    res -= xPow * twoPowDivideFactorial;
                }
                xPow *= x * x;
                twoPowDivideFactorial *= 4;
                twoPowDivideFactorial /= j * (j + 1);
            }
            return res;
        }
        public static double secondSum(double x)
        {
            double res = 0, curRes = -1;
            double xPowDivideFactorial = 1;
            // i - поддерживает текущий факториал
            for (int i = 1; res != curRes; i++)
            {
                curRes = res;
                res += xPowDivideFactorial;
                xPowDivideFactorial *= x;
                xPowDivideFactorial /= i;
            }
            return res;
        }
        static void Main(string[] args)
        {
            double x;
            while(true)
            {
                Console.Write("Введите х: ");
                if(double.TryParse(Console.ReadLine(),out x))
                {
                    Console.WriteLine($"Первая сумма: {firstSum(x)}");
                    Console.WriteLine($"Вторая сумма: {secondSum(x)}");
                }
            }
        }
    }
}
