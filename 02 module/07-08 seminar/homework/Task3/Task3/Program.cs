using System;
using MyLib;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            Employee[] arr = new Employee[rng.Next(0, 11)];
            for (int i = 0; i < arr.Length; i++)
            {
                string name = "";
                name += (char)rng.Next('A', 'Z');
                for (int j = 0; j < 5; j++)
                {
                    name += (char)rng.Next('a', 'z');
                }
                if (rng.Next(0, 2) == 0)
                {
                    arr[i] = new PartTimeEmployee(name, (decimal)rng.NextDouble() * 5000 + 220, rng.Next(5, 25));
                }
                else
                {
                    arr[i] = new SalesEmployee(name, (decimal)rng.NextDouble() * 5000 + 220, (decimal)rng.NextDouble() * 500);
                }
            }
            Array.Sort(arr, new EmployeeComparer());
            foreach(Employee x in arr)
            {
                x.ViewInfo();
                Console.WriteLine();
            }
        }
    }
}
