﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public class LatString : MyString
    {
        public LatString(char start, char finish, int n)
        {
            Validate(start, finish, n);
            char[] letters = new char[n];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)rnd.Next(start, finish + 1);
            }
            str = new String(letters);
        }
        protected override void Validate(char start, char finish, int n)
        {
            // проверяем количество символов строки и допустимые границы
            if (n <= 0 || start < 'a' || finish > 'z')
                throw new ArgumentOutOfRangeException();
        }
        public override string ToString()
        {
            return str;
        }
        /// <summary>
        /// метод подсчитывает количество вхождений символа в строку
        /// </summary>
        /// <param name="letter">буква, которая ищется в строке</param>
        /// <returns></returns>
        public int CountLetter(char letter)
        {
            if (letter < 'a' || letter > 'z') return 0;
            int start = 0, result = -1, res;
            do
            {
                res = str.IndexOf(letter, start);
                start = res + 1;    // начало следующего поиска 
                result++;           // счетчик вхождений
            } while (res >= 0);
            return result;
        }
    }
}
