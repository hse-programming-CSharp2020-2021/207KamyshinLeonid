using System;

namespace A
{
    class Program
    {
        // Проверка на валидные входные данные
        private static bool checkYear(int year)
        {
            // Проверка что год 18 век.
            if (year < 1701 || year > 1800)
            {
                return false;
            }
            return true;
        }
        private static bool checkMonth(int month)
        {
            // Проверка что такой месяц есть.
            if (month < 1 || month > 12)
            {
                return false;
            }
            return true;

        }
        private static bool checkDay(int day, int month, bool vis)
        {
            // Проверка что такой день существует.
            if (day < 1)
            {
                // Если день неположителен.
                return false;
            }
            int[] days = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (vis)
            {
                days[2]++;
            }
            return day <= days[month - 1];

        }
        private static bool isVis(int year)
        {
            // Високосный ли год.
            if (year % 400 == 0)
            {
                return true;
            }
            if (year % 100 == 0)
            {
                return false;
            }
            if (year % 4 == 0)
            {
                return true;
            }
            return false;
        }
        private static bool ValidateData(int day, int month, int year)
        {
            bool vis = isVis(year);
            return (checkDay(day, month, vis) && checkMonth(month) && checkYear(year));
        }

        /// <summary>
        /// Получение дня недели
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns>Возвращает число от 1 до 7, где 1 - понедельник, и т.д. </returns>

        private static int getYearCode(int year)
        {
            // Получаем код года.
            // 1 - 1800 год, 0 - 1701-1799.
            int[] centuryConst = new int[2] { 4, 2 };

            int res = centuryConst[year / 1800] + year % 100 + (year % 100) / 4;
            res %= 7;
            return res;
        }
        private static int getMonthCode(int month)
        {
            // Получаем код месяца.
            int[] monthConst = new int[12] { 1, 4, 4, 0, 2, 5, 0, 3, 6, 1, 4, 6 };
            return monthConst[month - 1];
        }
        private static void nextDay(ref int day, ref int month, ref int year, ref bool vis)
        {
            // Прибавление 1 дня к текущей дате.
            int[] days = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (vis)
            {
                days[2]++;
            }
            day++;
            if (day > days[month])
            {
                day = 1;
                month++;
            }
            if (month > 12)
            {
                year++;
                month = 1;
            }
            vis = isVis(year);

        }
        private static int GetDayOfWeek(int day, int month, int year)
        {
            bool vis = isVis(year);
            int curDate = day + getYearCode(year) + getMonthCode(month);
            if (vis)
            {
                curDate++;
            }
            curDate %= 7;
            return curDate;

        }

        private static string GetDateOfFriday(int dateOfWeek, int day, int month, int year)
        {
            bool vis = isVis(year);
            while (dateOfWeek != 6)
            {
                nextDay(ref day, ref month, ref year, ref vis);
                dateOfWeek++;
                dateOfWeek %= 7;
            }
            string res = "";
            if (month < 10)
            {
                res += ($"{day}.0{month}.{year}");
            }
            else
            {
                res += ($"{day}.{month}.{year}");
            }
            return res;

        }
        static void Main(string[] args)
        {

            int day, month, year;
            bool x, y, z, vis;
            x = int.TryParse(Console.ReadLine(), out day);
            y = int.TryParse(Console.ReadLine(), out month);
            z = int.TryParse(Console.ReadLine(), out year);
            vis = isVis(year);
            if (x && y && z && checkYear(year) && checkDay(day, month, vis) && checkMonth(month))
            {
                Console.WriteLine(GetDateOfFriday(GetDayOfWeek(day, month, year), day, month, year));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
