using System;

namespace Task1
{
    public class Program
    {

        static void Main(string[] args)
        {
            int n = Parser.GetIntValue("Введите число");
            UserString cur = new UserString(n, '0', '9');
            cur.str = cur.MoveOff("02468");
            Console.WriteLine(cur.str);
        }
       

    }
}
