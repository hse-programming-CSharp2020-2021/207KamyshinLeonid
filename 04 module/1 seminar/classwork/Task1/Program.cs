using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace Task1
{
    [Serializable]
    public class Student
    {
        string secondName;
        int grade;
        public Student() { }
        public Student(string secondName, int grade)
        {
            this.secondName = secondName;
            this.grade = grade;
        }
        public override string ToString()
        {
            return $"{secondName}, курс: {grade}";
        }
    }
    [Serializable]
    public class Group
    {
        static Random rng = new Random();
        Student[] arr = new Student[10];
        public Group()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                string secondName = rng.Next('A', 'Z').ToString();
                for (int j = 0; j < rng.Next(5, 9); j++)
                {
                    secondName += rng.Next('a', 'z');
                }
                arr[i] = new Student(secondName, rng.Next(1, 5));
            }
        }

        public override string ToString()
        {
            string res = "";
            foreach(var e in arr)
            {
                res += e.ToString() + '\n';
            }
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Group[] arr = new Group[2];
            arr[0] = new Group();
            arr[1] = new Group();
            Console.WriteLine("Serialized\n");
            for(int i = 0; i < arr.Length;i++)
            {
                Console.WriteLine($"Group {i+1}");
                Console.WriteLine(arr[i]);
                Console.WriteLine();
            }
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, arr);
            }
            Group[] narr;
            using (FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate))
            {
                narr = bf.Deserialize(fs) as Group[];
            }

            Console.WriteLine("Deserialized\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Group {i+1}");
                Console.WriteLine(arr[i]);
                Console.WriteLine();
            }
        }
    }
}
