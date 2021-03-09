using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] arr = new byte[fs.Length];
                fs.Read(arr, 0, arr.Length);
                string text = System.Text.Encoding.Default.GetString(arr);
                Console.WriteLine(text);
                for (int i = 0; i < text.Length; i++)
                {
                    if(text[i] >= '0' && text[i] <= '9')
                    {
                        Console.WriteLine($"At pos {i} num {text[i]}");
                    }
                }
            }
           
        }
    }
}
