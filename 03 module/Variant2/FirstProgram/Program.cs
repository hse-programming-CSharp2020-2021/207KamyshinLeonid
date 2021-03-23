using System;
using System.IO;
using System.Text;
using MyLibrary;
//using System.Text.Encodings.CodePages;
namespace FirstProgram
{
    class Program
    {
        static int Check()
        {
            using(StreamReader str = new StreamReader("data.txt"))
            {
                int res = 0;
                while (!str.EndOfStream)
                {
                    ++res;
                    string[] s = str.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if(s.Length <= 1)
                    {
                        return 0;
                    }
                    for(int i = 1; i < s.Length; i++)
                    {
                        if(!int.TryParse(s[i], out int x))
                        {
                            return 0;
                        }
                    }
                }
                return res;
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите количество улиц");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Введите количество улиц");
            }
            int cnt;
            try
            {
                cnt = Check();
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
                return;
            }
            Street[] streetsArray;
            if (cnt == 0)
            {
                Console.WriteLine("Исходный файл некорректен");
                streetsArray = new Street[n];
                for(int i = 0; i < streetsArray.Length; i++)
                {
                    streetsArray[i] = new Street();
                }
            }
            else
            {
                cnt = Math.Min(cnt, n);
                streetsArray = new Street[cnt];
                try
                {
                    using (StreamReader str = new StreamReader("data.txt"))
                    {
                        for (int i = 0; i < cnt; i++)
                        {
                            streetsArray[i] = new Street(str.ReadLine());
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Что-то пошло не так");
                    return;
                }
            }
            using(StreamWriter str = new StreamWriter("output.txt"))
            {
                foreach(var e in streetsArray)
                {
                    str.WriteLine(e.ToString());
                }
            }
            foreach (var e in streetsArray)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
