using System;

namespace Task1
{
    class Program
    {
        static string Method1(string s)
        {
            string[] arr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i+1< arr.Length; i++)
            {
                arr[i] += " ";
            }
            return string.Concat(arr);
        }
        static int Method2(string s)
        {
            string[] arr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int cnt = 0;
            for (int i = 0; i + 1 < arr.Length; i++)
            {
                cnt += arr[i].Length > 4 ? 1 : 0;
            }
            return cnt;
        }
        static int Method3(string s)
        {
            string[] arr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int cnt = 0;
            char[] vowels = new char[] { 'а', 'у', 'о', 'ы', 'и', 'э', 'ю', 'ё', 'е', 'я' };
            for (int i = 0; i + 1 < arr.Length; i++)
            {
                if (Array.Exists(vowels, x => x == arr[i].ToLower()[0]))
                {
                    cnt++;
                }
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(Method1(s));
            Console.WriteLine("Слов длины больше 4: " + Method2(s));
            Console.WriteLine("Слов с гласной буквы: " + Method3(s));
        }
    }
}
