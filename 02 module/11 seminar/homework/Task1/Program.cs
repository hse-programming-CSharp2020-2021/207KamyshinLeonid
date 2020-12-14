using System;

namespace Task1
{
    public static class Methods
    {
        // Получение значения целочисленного параметра
        public static int GetIntValue(string comment)
        {
            Console.Write(comment);
            return int.Parse(Console.ReadLine());
        }
        public static void MatrPrint(int[,] ar)
        {
            for (int i = 0; i <= ar.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= ar.GetUpperBound(1); j++)
                {
                    Console.Write(ar[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int[,] UnitMatr(int n)
        {// Сформировать единичную матрицу:
            if (n <= 0)
                throw new ArgumentOutOfRangeException("Аргумент метода " +
                    "должен быть положительным!");
            int[,] ar = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    ar[i, j] = (i == j ? 1 : 0);
            return ar;
        }
    }

    public class Program
    {
        public static void Main()
        {
            int[,] res; // ссылка на двумерный массив (матрица)
            int rank; // Порядок матрицы
            do
            { // цикл повторения решений
                try
                {
                    rank = Methods.GetIntValue("Введите порядок матрицы: ");
                    res = Methods.UnitMatr(rank);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Для завершения программы нажмите ESC");
                    continue;
                }
                catch (ArgumentNullException e1) { Console.WriteLine(e1.Message); break; }
                catch (FormatException e2) { Console.WriteLine(e2.Message); break; }
                catch (OverflowException e3) { Console.WriteLine(e3.Message); break; }

                Methods.MatrPrint(res);
                Console.WriteLine("Для завершения программы нажмите ESC");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        } // Main( )
    }

}
