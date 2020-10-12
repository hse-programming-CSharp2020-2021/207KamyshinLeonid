using System;
using System.IO;

namespace Task2
{
    class Program
    {
        public static void Solve(string readPath, string writePath)
        {

            string[] input = File.ReadAllLines(readPath)[0].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[input.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int.TryParse(input[i], out arr[i]);
            }
            int[] ans = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                ans[i] = (int)Math.Log2(arr[i] - 1);
            }
            using (StreamWriter outputFile = new StreamWriter(writePath))
            {
                Array.ForEach(ans, x => outputFile.Write($"{x} "));
                outputFile.Write('\n');
                outputFile.Flush();
            }
        }
        static void Main(string[] args)
        {
            Solve("input.txt", "output.txt");
        }
    }
}
