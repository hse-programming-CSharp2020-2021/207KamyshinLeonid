using System;

namespace Task2
{
    class Program
    {
        public static void solve()
        {
            int cur, sum = 0, cnt = 0;
            do
            {
                if (int.TryParse(Console.ReadLine(), out cur))
                {
                    if (cur < 0)
                    {
                        sum += cur;
                        cnt++;
                    }
                }
                else
                {
                    break;
                }

            } while (cur >= -1000);
            double res = (double)sum / cnt;
            Console.WriteLine($"{res:f3}");
        }
        static void Main(string[] args)
        {
            solve();
        }
    }
}
