using System;
using System.Runtime.InteropServices;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][][] arr = new char[3][][];
            arr[0] = new char[3][];
            arr[1] = new char[2][];
            arr[2] = new char[1][];
            for (int i = 0; i < arr[0].Length; i++)
            {
                arr[0][i] = new char[i + 2];
            }
            for (int i = 0; i < arr[1].Length; i++)
            {
                arr[1][i] = new char[i + 2];
            }
            arr[2][0] = new char[4];
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    cnt += arr[i][j].Length;
                }
            }
            Console.WriteLine($"Ранг массива: {arr.Rank}");
            Console.WriteLine($"Всего элементов: {cnt}");
            Random rng = new Random();
            Console.WriteLine($"Первый уровень состоит из {arr.Length} элементов");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Второй уровень {i} элемента состоит из {arr[i].Length} элементов");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine($"Третий уровень {i} -> {j} состоит из {arr[i][j].Length} элементов");
                    for (int p = 0; p < arr[i][j].Length; p++)
                    {
                        arr[i][j][p] = (char)rng.Next('a', 'z');
                        Console.WriteLine($"{arr[i][j][p]}");
                    }   
                }
            }

        }
    }
}
