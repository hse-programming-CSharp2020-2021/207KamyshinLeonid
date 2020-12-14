using System;
using MyLib;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = 'к', finish = 'ю';
            do
            {
                RusString testRusString = new RusString(start, finish, 10);
                LatString testLatString = new LatString(start, finish, 10);
                Console.WriteLine(testRusString);
                Console.WriteLine(testRusString.CountLetter('о'));
                // тестируем неверные входные данные
                try
                {
                    testRusString = new RusString(start, finish, -11);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Состояние объекта не изменено");// если объект не сформирован
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(testLatString);
                Console.WriteLine(testLatString.CountLetter('o'));
                // тестируем неверные входные данные
                try
                {
                    testLatString = new LatString(start, finish, -11);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Состояние объекта не изменено");// если объект не сформирован
                    Console.WriteLine(ex.Message);
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }

}
