using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class GeomProgr
    {
        // поле класса - счетчик созданных объектов: 
        public static uint objectNumber = 0;
        double _b; // первый член прогрессии b!=0
        double _q; // знаменатель прогрессии q!=0
        public double B
        {
            get { return _b; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Недопустимое значение первого члена прогрессии!");
                _b = value;
            }
        }
        public double Q
        {
            get { return _q; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Недопустимое значение знаменателя прогрессии!");
                _q = value;
            }
        }

        // Конструкторы 
        // Конструктор без параметров (конструктор умолчания):
        public GeomProgr()
        {
            _b = 1;
            _q = 1;
            objectNumber++;
            Console.WriteLine(objectNumber + ": Конструктор без параметров");
        }
        // Конструктор общего вида (конструктор с параметрами):
        public GeomProgr(double b, double q) : this()
        {
            if (b == 0 || q == 0)
            {
                objectNumber--;
                throw new ArgumentException("Ошибка в аргументах конструктора!");
            }
            _b = b;
            _q = q;
            Console.WriteLine(objectNumber + ": Конструктор с параметрами");
        }

        // методы для "работы" с объектами класса
        public double this[int n]
        { // n-ый член прогрессии
            get
            {
                if (n <= 0)
                {
                    throw new ArgumentOutOfRangeException("Ошибка аргумента");
                }
                return B * Math.Pow(Q, n - 1);
            }
        }

        public double ProgrSum(int n)
        { // сумма n членов прогрессии
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException("Ошибка аргумента");
            }
            double sum = _b;
            for (int i = 1; i < n; i++)
            {
                sum *= Q;
                sum += B;
            }
            return sum;
        } // end of ProgrSum()
    } // end of class GeomProgr
}
