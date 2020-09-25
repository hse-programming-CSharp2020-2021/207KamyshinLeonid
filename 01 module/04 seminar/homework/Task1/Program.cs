using System;

namespace Task1
{
    class Program
    {
        public static void getAllGood()
        {
            for (int a = 1; a <= 20; a++)
            {
                for(int b = a+1; b <= 20; b++)
                {
                    for(int c = b + 1; c <= 20; c++)
                    {
                        if(a*a + b*b == c * c)
                        {
                            Console.WriteLine($"{a}^2 + {b}^2 = {c}^2");
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            getAllGood();
        }
    }
}
