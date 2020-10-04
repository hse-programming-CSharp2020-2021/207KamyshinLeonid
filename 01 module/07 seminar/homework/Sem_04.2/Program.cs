using System;

namespace Sem_04._2
{
    class Program
    {
        public static int Read()
        {
            int n;
            do Console.WriteLine("Введите число");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            return n;
        }
        public static int[][] Gen(int n)
        {
            int length = (int)Math.Ceiling(Math.Sqrt(2*n));
            int[][] ans = new int[length][];
            int cur = n;
            for(int i = 0; i < length; i++)
            {
                ans[i] = new int[Math.Min(i + 1, cur)];
                for(int j = 0; j < ans[i].Length; j++)
                {
                    ans[i][j] = cur--;
                }
            }
            return ans;
        }
        public static void Print(int[][] arr)
        {
            foreach(int[] to in arr)
            {
                Array.ForEach(to, x => Console.Write($"{x} "));
                Console.Write('\n');
            }
        }
        static void Main(string[] args)
        {
            int n = Read();
            Print(Gen(n));
        }
    }
}
