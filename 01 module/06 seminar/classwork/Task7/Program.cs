using System;

namespace Task7
{
    class Program
    {
        public static char[] gen(int n)
        {
            string s = Convert.ToString(n);
            char[] res = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                res[i] = s[i];
            }
            return res;
        }
        static void Main(string[] args)
        {
            int n;
            do Console.WriteLine("Введите число: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            char[] ans = gen(n);
            Array.ForEach(ans, x => Console.Write($"{x} "));
            Console.Write('\n');
        }
    }
}
