using System;

namespace MyLibrary
{
    public class Street
    {
        public Street()
        {
            Random rng = new Random();
            Name += rng.Next('A', 'Z');
            for(int i = 0; i < rng.Next(3,10); i++)
            {
                Name += rng.Next('a', 'z');
            }
            Houses = new int[rng.Next(1, 11)];
            for(int i = 0; i < ~this; i++)
            {
                Houses[i] = rng.Next(1, 101);
            }
        }
        public Street(string src)
        {
            var arr = src.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Name = arr[0];
            Houses = new int[arr.Length - 1];
            for(int i = 1; i < arr.Length; i++)
            {
                Houses[i - 1] = int.Parse(arr[i]);
            }
        }
        public string Name { get; set; }

        public int[] Houses { get; set; }

        public static int operator ~(Street a)
        {
            return a.Houses.Length;
        }

        public static bool operator !(Street a)
        {
            for (int i = 0; i < ~a; i++)
            {
                foreach (var e in a.Houses[i].ToString())
                {
                    if (e == '7')
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            string res = this.Name;
            foreach (var e in this.Houses)
            {
                res += " " + e.ToString();
            }
            return res;
        }
    }
}
