using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public abstract class MyString
    {
        protected String str;
        static protected Random rnd;
        protected abstract void Validate(char start, char finish, int n);
        protected bool IsPalindrome()
        {
            if (str.Length > 0)
            {
                char[] tmp = str.ToCharArray();
                Array.Reverse(tmp);
                string tmpString = new string(tmp);
                if (str.CompareTo(tmpString) == 0) return true;
            }
            return false;
        }
    }
}
