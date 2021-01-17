using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Parser
    {
        // comment - строка-сообщение для получения данных
        public static int GetIntValue(string comment)
        {
            int intVal;
            do Console.Write(comment);
            while (!int.TryParse(Console.ReadLine(), out intVal));
            return intVal;
        }
    }
}
