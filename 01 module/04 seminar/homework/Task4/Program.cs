using System;

namespace Task4
{
    class Program
    {
        public static ulong solve(int n, int m)
        {
            ulong ans = 0;
            ans |= (1UL << n);
            if(n == m)
            {
                ans <<= 1;
            }
            else
            {
                ans |= (1UL << m);
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int n, m;
            do Console.WriteLine("Введите числа: ");
            while (!int.TryParse(Console.ReadLine(), out n) || !int.TryParse(Console.ReadLine(), out m) || n >= 64 || m >= 64);
            Console.WriteLine($"{solve(n, m)}");
        }
    }
}
