using System;

namespace MyLibrary
{
    public class Robot
    {
        // класс для представления робота
        int x, y; // положение робота на плоскости 
        int n, m;
        char[,] field;
        public Robot() { }
        public Robot(int n, int m)
        {
            this.n = n;
            this.m = m;
            field = new char[n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    field[i, j] = ' ';
                }
            }
        }
        public void Right() { field[x++, y] = '+'; }      // направо
        public void Left() { field[x--, y] = '+'; }      // налево
        public void Forward() { field[x, y++] = '+'; }  // вперед
        public void Backward() { field[x, y--] = '+'; }  // назад

        public string Position()
        {  // сообщить координаты
            return String.Format("The Robot position: x={0}, y={1}", x, y);
        }
        public void Print()
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.ResetColor();
                    if (i == x && j == y)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        field[i, j] = '*';
                    }
                    if(field[i,j] == '+')
                    {
                        Console.ForegroundColor = ConsoleColor.Gray; 
                    }
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
            Console.ResetColor();

        }
    }
    public delegate void Steps(); // делегат-тип

}
