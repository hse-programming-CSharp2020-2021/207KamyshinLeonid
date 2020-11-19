using System;
using MyLib;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            A[] arr = new A[10];
            Random rng = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                if (rng.Next(0, 2) % 2 == 1)
                {
                    arr[i] = new A();
                }
                else
                {
                    arr[i] = new B();
                }
            }
            foreach (A x in arr)
            {
                x.getA();
            }
            Console.WriteLine("\nОбъекты класса B: ");
            foreach (A x in arr)
            {
                if (x is B)
                {
                    x.getA();
                }
            }
            Console.WriteLine("\nОбъекты класса A: ");
            foreach (A x in arr)
            {
                if (!(x is B))
                {
                    x.getA();
                }
            }
            Console.WriteLine();
        }
    }
}
