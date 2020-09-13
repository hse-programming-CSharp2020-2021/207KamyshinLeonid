using System;

namespace Task2._4
{
    class Program
    {
        public static int Ost(int a)
        {
            return a - 100 * (a / 100);
        }
        public static int Min(int a, int b, int c)
        {
            int answer = a;
            int ost1 = Ost(a);
            int ost2 = Ost(b);
            int ost3 = Ost(c);
            int curOst = ost1;
            if (curOst > ost2)
            {
                answer = b;
                curOst = ost2;
            }
            if (curOst > ost3)
            {
                answer = c;
                curOst = ost3;
            }
            return answer;
        }
        public static bool Read(out int a)
        {
            return int.TryParse(Console.ReadLine(), out a);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int a, b, c;
                do Console.WriteLine("Введите 3 номера аудиторий:");
                while (!Read(out a) || !Read(out b) || !Read(out c));
                Console.WriteLine($"Аудитория с наименьшим номером на этаже: {Min(a, b, c)}");
            }
        }
    }
}
