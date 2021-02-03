using System;

public delegate void LineCompleteEvent();

public delegate void ItemAssign(int val);

namespace Task6
{

    public class Methods
    {
        // статическое событие
        public static event LineCompleteEvent LineComplete;

        public static event ItemAssign NewItemFilled;

        public static int sum = 0;

        public static void ArrayPrint(int[,] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    Console.Write(arr[i, j] + " ");
                LineComplete(); // событие!!

            }
        }

        public static void ArrayFill(int i, int j, int val)
        {
            Program.arr[i, j] = val;
            NewItemFilled?.Invoke(val);
        }
    }

    class Program
    {
        public static int[,] arr = new int[15, 15];
        static void Main()
        {
            Random rnd = new Random();
            Methods.NewItemFilled += (int elem) =>
            {
                Methods.sum += elem;
                Console.WriteLine($"Sum of array elements is:{Methods.sum}");
            };
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    Methods.ArrayFill(i, j, rnd.Next(100));
            // в качестве обработчика - лямбда-выражение
            Methods.LineComplete += () => { Console.WriteLine(); };

            Methods.ArrayPrint(arr);
        }



    }
}