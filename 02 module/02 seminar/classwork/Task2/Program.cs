using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Task2
{
    class LatinChar
    {
        char _char;
        public char Char
        {
            get
            {
                return _char;
            }
            set
            {
                if ((value >= 'A' && value <= 'Z') || (value >= 'a' && value <= 'z'))
                {
                    _char = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public LatinChar()
        {
            _char = 'a';
        }
        public LatinChar(char _Char)
        {
            Char = _Char;
        }
        public override string ToString()
        {
            return Char.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char minChar, maxChar;
            do Console.WriteLine("Введите нижнюю границу: ");
            while (!char.TryParse(Console.ReadLine(), out minChar));
            do Console.WriteLine("Введите верхнюю границу: ");
            while (!char.TryParse(Console.ReadLine(), out maxChar));
            for (char i = minChar; i <= maxChar; i++)
            {
                try
                {
                    LatinChar tmp = new LatinChar(i);
                    Console.WriteLine(tmp.ToString());
                }
                catch
                {

                }
            }
        }

    }
}
