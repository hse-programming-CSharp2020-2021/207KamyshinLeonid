using System;
using System.ComponentModel.DataAnnotations;
using System.Xml;

class Birthday
{
    string name = ""; // закрытое поле - фамилия
    int year, month, day; // Закрытые поля: год, месяц, день рождения
    public Birthday(string name, int y, int m, int d)
    { // Конструктор
        this.name = name;
        year = y; month = m; day = d;
    }
    public Birthday()
    {
        year = 1970;
        month = 1;
        day = 1;
    }
    DateTime Date
    { // закрытое свойство - дата рождения
        get { return new DateTime(year, month, day); }
    }
    public string Information
    {   // свойство - сведения о человеке
        get
        {
            return name + ", дата рождения " + day + ":" + month + ":" + year;
        }
    }
    public string InformationDMY
    {
        get
        {
            string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            string days = day.ToString();
            if (days.Length == 1)
            {
                days = "0" + days;
            }
            return name + ", дата рождения " + days + " " + months[month - 1] + " " + year;
        }
    }
    public string InformationDDMMYY
    {
        get
        {
            string days = day.ToString();
            if (days.Length == 1)
            {
                days = "0" + days;
            }
            string months = month.ToString();
            if (months.Length == 1)
            {
                months = "0" + months;
            }
            string years = year.ToString().Substring(year.ToString().Length - 2, 2);
            return name + ", дата рождения " + days + "-" + months + "-" + years;
        }
    }
    public int HowManyDays
    { // свойство - сколько дней до дня рождения
        get
        {
            // номер сего дня от начала года:
            int nowDOY = DateTime.Now.DayOfYear;
            //  номер дня рождения от начала года: 
            int myDOY = Date.DayOfYear;
            int period = myDOY >= nowDOY ? myDOY - nowDOY :
                                           365 - nowDOY + myDOY;
            return period;
        }

    }
    class Program
    {
        static void Main()
        {
            DateTime user;
            do Console.WriteLine("Введите дату вашего рождения:");
            while (!DateTime.TryParse(Console.ReadLine(), out user));
            Birthday res = new Birthday("Вы", user.Year, user.Month, user.Day);
            Console.WriteLine("До следующего дня рождения дней осталось: ");
            Console.WriteLine(res.HowManyDays);
            Console.WriteLine(res.InformationDDMMYY);
            Console.WriteLine(res.InformationDMY);
        }
    }
}