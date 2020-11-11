using System;
/*
 Реализовать класс, представляющий сведения о человеке Person.
Реализовать свойства: Ф.И.О.(string FullName), дата рождения (DateTime BirthDate), пол (bool IsMale).
Реализовать метод для вывода информации о человеке void ShowInfo().
Реализовать класс, представляющий сведения о студенте Student (наследуется от Person).
Реализовать свойства: название ВУЗа (string Institute), специальность (string Speciality).
Реализовать класс, представляющий сведения о сотруднике фирмы Employee (наследуется от Person).
Реализовать свойства: название компании (string CompanyName), должность (string Post), график (string Schedule),
оклад (decimal Salary).
 
В основной программе решить задачи:
- Создать  объекты всех трех типов и вызвать ShowInfo(), чтобы показать всю доступную информацию.
- Создать массив Person[] arr и присвоить его членам объекты всех трех типов. Продемонстрировать работу метода ShowInfo() на массиве. 
 */

class Person
{
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsMale { get; set; }

    public Person(string f, DateTime d, bool m)
    {
        FullName = f;
        BirthDate = d;
        IsMale = m;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Full Name: {FullName}\nBirth Date {BirthDate}\nIsMale: {IsMale}");
    }
}

class Student : Person
{
    public string Institute { get; set; }
    public string Speciality { get; set; }

    public Student(string f, DateTime d, bool m, string inst, string spec) : base(f, d, m)
    {
        Institute = inst;
        Speciality = spec;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Institute: {Institute}\nSpeciality: {Speciality}");
    }
}
class Employee : Student
{
    public string CompanyName { get; set; }
    public string Post { get; set; }
    public string Schedule { get; set; }
    public decimal Salary { get; set; }
    public Employee(string f, DateTime d, bool m, string inst, string spec, string companyName, string post, string schedule, decimal salary) : base(f, d, m, inst, spec)
    {
        CompanyName = companyName;
        Post = post;
        Schedule = schedule;
        Salary = salary;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Company: {CompanyName}\nPost: {Post}\nSchedule: {Schedule}\nSalary: {Salary}");
    }
}
class Program
{
    static void Main()
    {
        Person person = new Person("ewfewfef", new DateTime(2000, 10, 10), true);
        Student student = new Student("oieweqvb", new DateTime(2010, 5, 5), false, "3grh4", "r4tgrv");
        Employee employee = new Employee("wasdasd", new DateTime(1901, 1, 1), true, "mipt", "santehnik", "yandex", "mainSantehnik", "everyday9to5", 2);
        Person[] arr = new Person[3];
        arr[0] = person;
        arr[1] = student;
        arr[2] = employee;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i].ShowInfo();
            Console.WriteLine("---------------------------------");
        }


    }
}