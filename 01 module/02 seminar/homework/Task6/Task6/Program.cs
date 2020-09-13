using System;
using System.Globalization;

namespace Task6
{
    class Program
    {
        public static void Calc(double money, int part)
        {
            money *= part;
            money /= 100;
            Console.WriteLine(money.ToString("c3", CultureInfo.GetCultureInfo("en-US")));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to end");
            while (true)
            {
                Console.WriteLine("Input:");
                double money;
                int part;
                if(double.TryParse(Console.ReadLine(),out money) && int.TryParse(Console.ReadLine(),out part))
                {
                    Calc(money, part);
                }
                else
                {
                    return;
                }

            }
        }
    }
}
