using System;
using MyLibrary;

namespace Task4
{

    class Program
    {
        static Robot rob = new Robot();    // конкретный робот 
        static Steps Checker(char t)
        {
            return t switch
            {
                'R' => new Steps(rob.Right),
                'L' => new Steps(rob.Left),
                'F' => new Steps(rob.Forward),
                'B' => new Steps(rob.Backward),
                _ => throw new ArgumentException("Некорректная команда"),
            };
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ограничения поля:");
            int n, m;
            string[] inp = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (!int.TryParse(inp[0], out n) || !int.TryParse(inp[1], out m))
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }
            rob = new Robot(n, m);
            Steps delR = new Steps(rob.Right);      // направо
            Steps delL = new Steps(rob.Left);       // налево
            Steps delF = new Steps(rob.Forward);    // вперед
            Steps delB = new Steps(rob.Backward);   // назад

            string s = Console.ReadLine().ToUpper();
            try
            {
                Steps movement;
                movement = Checker(s[0]);
                for (int i = 1; i < s.Length; i++)
                {
                    movement += Checker(s[i]);
                }
                Console.WriteLine("Start: " + rob.Position());
                movement();
                Console.WriteLine("End: " + rob.Position());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            rob.Print();

        }
    }
}
