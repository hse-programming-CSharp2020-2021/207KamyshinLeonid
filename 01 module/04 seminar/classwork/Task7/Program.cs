using System;
using System.Collections.Generic;

namespace Task7
{
    class Program
    {
        public static long getGcd(long a, long b)
        {
            if (b == 0)
            {
                return a;
            }
            return getGcd(b, a % b);
        }
        public static void getAll(long a, long b, out long gcd, out long lcm)
        {
            gcd = getGcd(a, b);
            lcm = a * b / gcd;
        }
        static void Main(string[] args)
        {
            long a = 0, b = 0, gcd, lcm;
            while (true)
            {
                Console.WriteLine("Введите два числа: ");
                if (long.TryParse(Console.ReadLine(), out a) && long.TryParse(Console.ReadLine(), out b) && a >= 0 && b >= 0)
                {
                    getAll(a, b, out gcd, out lcm);
                    Console.WriteLine($"НОД: {gcd} \nНОК: {lcm}");
                }

            }
        }
    }
}
