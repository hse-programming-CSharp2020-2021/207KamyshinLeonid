using System;

namespace Task1._2
{
    class Program
    {
        public static int Reverse(int n)
        {
            int revN = 0;
            while (n > 0)
            {
                revN *= 10;
                revN += n % 10;
                n /= 10;
            }
            return revN;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int n;
                do Console.WriteLine("Введите число: ");
                while (!int.TryParse(Console.ReadLine(), out n));
                Console.WriteLine(Reverse(n));
            }
        }
    }
}
