using System;

namespace MyLib
{
    public class A
    {
        public virtual void getA()
        {
            Console.Write("A");
        }
    }
    public class B : A
    {
        public override void getA()
        {
            Console.Write("B");
        }
    }
}
