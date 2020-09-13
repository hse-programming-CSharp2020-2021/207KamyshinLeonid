using System;
using System.Numerics;

namespace Task3
{
    class Program
    {
        public static void Print(Complex x, int im)
        {
            Console.Write($"{x.Real}");
            for(int i = 0; i < im; i++)
            {
                string tmp = "";
                tmp += (x.Imaginary < 0) ? "" : "+";
                Console.WriteLine(tmp + $"{x.Imaginary:f3}i");
            }
        }
        public static void Solve(int a, int b, int c)
        {
            Complex f = new Complex();
            Complex s = new Complex();

            int D = b * b - 4 * a * c;
            f += new Complex((double)b / -2,0);
            s = f;
            f += (D >= 0) ? new Complex(Math.Sqrt(D)/2, 0) : new Complex(0, Math.Sqrt(-D)/2);
            s += (D >= 0) ? new Complex(-Math.Sqrt(D)/2, 0) : new Complex(0, -Math.Sqrt(-D)/2);
            int cnt = 1;
            cnt += (D == 0) ? 0 : 1;
            int im = (D >= 0) ? 0 : 1;
            for(int i = 0; i < cnt;i++)
            {
                Print(f, im);
                f = s;
            }

        }
        static public bool Read(out int x)
        {
            return int.TryParse(Console.ReadLine(), out x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("To end press enter");
            while(true)
            {
                Console.WriteLine("Input: ");
                int a, b, c;
                if(Read(out a) && Read(out b) && Read(out c))
                {
                    Solve(a, b, c);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
