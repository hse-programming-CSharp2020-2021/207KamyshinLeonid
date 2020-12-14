using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            GeomProgr geomProgrObj; // ссылка на объект типа GeomProgr
            bool flag;
            int b, q;
            do
            {
                flag = false;
                try
                {
                    Console.Write("Введите начальный член прогрессии: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("Введите знаменатель прогрессии: ");
                    q = int.Parse(Console.ReadLine());
                    geomProgrObj = new GeomProgr(b, q); // создаем объект 2
                }
                catch (ArgumentException e1)
                {
                    flag = true;
                    Console.WriteLine("Некорректные входные данные! ");
                    Console.WriteLine(e1.Message);
                }
            } while (flag);
        }

    }
}
