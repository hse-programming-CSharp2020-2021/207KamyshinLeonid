using System;
using System.IO;
namespace Task3
{
    class Program
    {
        static string Solve1(string path)
        {
            string res = File.ReadAllText(path);
            //int[] arr = res.Split(' ',)
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            string path  = @"..\..\MyTest.txt";
            int[] arr = new int[10];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rng.Next(0, 1234);
            }

        }
    }
}
