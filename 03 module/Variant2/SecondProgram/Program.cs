using System;
using MyLibrary;
using System.Collections.Generic;
using System.IO;
namespace SecondProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Street> streetsArray = new List<Street>();
            try
            {
                using (StreamReader str = new StreamReader(@"C:\Users\1626158\source\repos\207KamyshinLeonid\03 module\Variant2\FirstProgram\bin\Debug\netcoreapp3.1\output.txt"))
                {
                    while (!str.EndOfStream)
                    {
                        streetsArray.Add(new Street(str.ReadLine()));
                    }
                }
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
                return;
            }
            
            List<Street> magicStreets = new List<Street>();
            foreach(var e in streetsArray)
            {
                if (!e)
                {
                    magicStreets.Add(e);
                }
            }
            foreach(var e in magicStreets)
            {
                Console.WriteLine(e);
            }
        }
    }
}
