using System;
using System.Runtime.InteropServices;

namespace Task4
{
    class Program
    {
        public static void Print(int x)
        {
            while(x > 0)
            { 
                Console.Write(x % 10);
                x /= 10;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to end");
            while(true)
            {
                Console.Write("Input: ");
                int x;
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    Print(x);
                    Console.Write('\n');
                }
                else
                {
                    return;
                }
            }
            
        }
    }
}
