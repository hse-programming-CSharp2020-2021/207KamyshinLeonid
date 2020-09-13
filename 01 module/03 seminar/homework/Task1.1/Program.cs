using System;

namespace Task1._1
{
    class Program
    {
        public static bool Find(out int pos)
        {
            pos = 0;
            int sum = 0, n = 0, a, b, c;
            while (sum < 1000)
            {
                n++;
                sum += n;
                a = sum % 10;
                b = (sum / 10) % 10;
                c = (sum / 100) % 10;
                if (a == b && b == c)
                {
                    pos = n;
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int n;
            if (Find(out n))
            {
                Console.WriteLine($"Число: {n * (n + 1) / 2}, количество: {n}");
                Console.WriteLine($"1 + 2 + 3 + ... + {n - 2} + {n - 1} + {n}");

            }
            else
            {
                Console.WriteLine("Такого числа не существует");
            }
        }
    }
}
