using System;

namespace ConsoleApp1
{
    class Program
    {
        public static long F(long x)
        {
            long res = 0;
            res += 12;
            res *= x;
            res += 9;
            res *= x;
            res -= 3;
            res *= x;
            res += 2;
            res *= x;
            res -= 4;
            return res;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("If you want to exit, type any symb");
            while(true)
            {
                Console.WriteLine("Input x: ");
                long x;
                if(long.TryParse(Console.ReadLine(),out x))
                {
                    Console.WriteLine(F(x));
                }
                else
                {
                    return;
                }
            }
        }
    }
}
