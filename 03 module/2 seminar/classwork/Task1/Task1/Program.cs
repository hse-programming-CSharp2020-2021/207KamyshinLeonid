using System;

namespace Task1
{
    delegate string ConvertRule(string s);

    class Converter
    {
        public string Convert(string str, ConvertRule cr)
        {
            return cr(str);
        }
    }

    class Program
    {
        public static string RemoveDigits(string str)
        {
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < '0' || str[i] > '9')
                {
                    res += str[i];
                }
            }
            return res;
        }

        public static string RemoveSpaces(string str)
        {
            string[] arr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string res = "";
            for (int i = 0; i < arr.Length; i++)
            {
                res += arr[i];
            }
            return res;
        }

        static void Main(string[] args)
        {
            string[] test = new string[20];
            Random rng = new Random();
            for (int i = 0; i < test.Length; i++)
            {
                for (int j = 0; j < rng.Next(1, 20); j++)
                {
                    test[i] += (char)rng.Next(' ', 'z' + 1);
                }
            }
            ConvertRule dig = new ConvertRule(RemoveDigits);
            ConvertRule spc = new ConvertRule(RemoveSpaces);
            ConvertRule both = new ConvertRule(RemoveDigits);
            both += dig;
            Converter tmp = new Converter();
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine($"{test[i]} -> {tmp.Convert(test[i], dig)}");
                Console.WriteLine($"{test[i]} -> {tmp.Convert(test[i], spc)}");
                Console.WriteLine($"{test[i]} -> {tmp.Convert(test[i], both)}");
            }
        }
    }
}
