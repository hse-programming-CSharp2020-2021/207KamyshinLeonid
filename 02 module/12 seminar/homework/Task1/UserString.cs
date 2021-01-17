using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class UserString
    {
        public string str;
        static Random gen = new Random();

        public UserString(int k, char minChar, char maxChar)
        {
            if (k < 0)
                throw new Exception("Аргумент должен быть положительным!");
            // minChar, minChar - границы диапазона символов
            if (maxChar < minChar)
            {
                char c = minChar;
                minChar = maxChar;
                maxChar = c;
            }
            // пустая строка, останется пустой, если символов 0
            string line = String.Empty;
            for (int i = 0; i < k; i++)
                line += (char)gen.Next(minChar, maxChar + 1);
            str = line;
        }

        // Удалить из строки s1 все символы другой строки s2:
        public string MoveOff(string s2)
        {
            string res = this.str;
            int index;
            for (int i = 0; i < s2.Length; i++)
                while ((index = res.IndexOf(s2[i])) >= 0)
                    res = res.Remove(index, 1);
            return res;
        } // end of MoveOff()


    }
}
