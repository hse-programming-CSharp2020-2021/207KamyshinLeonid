using System;

namespace Task6
{
    class Program
    {
        public static double Total(double k, double r, uint n)
        {
            if (n == 0)
            {
                return k;
            }
            return Total(k, r, n - 1) * (1.0 + r / 100);
        }
        static void Main(string[] args)
        {
            while (true)
            {

                double k, r, sum;
                uint n;
                do Console.Write("Введите начальный капитал: ");
                while (!double.TryParse(Console.ReadLine(), out k) | k <= 0);

                do Console.Write("Введите годовой процент: ");
                while (!double.TryParse(Console.ReadLine(), out r) | r <= 0);

                do Console.Write("Введите число лет: ");
                while (!uint.TryParse(Console.ReadLine(), out n) | n <= 0);
                sum = k;
                for (int i = 1; i <= n; i++)
                {
                    sum = Total(sum, r, 1);
                    string tmp = "год";
                    if(i > 1)
                    {
                        tmp = (i >= 5) ? "лет" : "года";
                    }
                    Console.WriteLine($"Через {i} {tmp}: {sum:f3}");
                }

            }
        }
    }
}
