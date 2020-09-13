using System;
using System.ComponentModel.DataAnnotations;

namespace Task2
{
    class Program
    {
        public static int Decomp(int p)
        {
            int a, b, c;
            a = p % 10;
            p /= 10;
            b = p % 10;
            p /= 10;
            c = p;
            int m1 = Math.Max(a, Math.Max(b, c));
            int m2 = Math.Min(a, Math.Min(b, c));
            int res = m1 * 100 + (a + b + c - m1 - m2) * 10 + m2;
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("To end press any enter");
            while(true)
            {
                Console.Write("Input: ");
                int p;
                if(int.TryParse(Console.ReadLine(),out p)){
                    Console.WriteLine($"Maximum is: {Decomp(p)}");
                }
                else
                {
                    return;
                }
            }
        }
    }
}
