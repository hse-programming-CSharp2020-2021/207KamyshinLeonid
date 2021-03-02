using System;
using System.Collections.Generic;

namespace Task2
{
    class Person
    {
        string FirstName { get; set; }
        string SecondName { get; set; }
        int Age { get; set; }

        public Person(string firstName, string secondName,int age)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age; 
        }

        public override string ToString()
        {
            return $"{FirstName} {SecondName} {Age}y/o";
        }
    }

    class ElectronicQueue<T>
    {
        public Queue<T> q = new Queue<T>();

        public void AddToTheEnd(T a)
        {
            q.Enqueue(a);
        }
        
        public T RemoveFromBegin()
        {
            return q.Dequeue();
        }

        public override string ToString()
        {
            string res = "";
            res += $"{q.Count} entities in queue";
            foreach(var e in q)
            {
                res += "\n" + e.ToString();
            }
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ElectronicQueue<Person> queue = new ElectronicQueue<Person>();
            queue.AddToTheEnd(new Person("asd", "ssss", 1231));
            Console.WriteLine(queue.ToString());
        }
    }
}
