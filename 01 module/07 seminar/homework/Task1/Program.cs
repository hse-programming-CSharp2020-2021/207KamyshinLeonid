using System;
using System.IO;

namespace Task1
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
            bool[] ans = new bool[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    ans[i] = true;
                }
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
