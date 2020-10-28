using System;

namespace Task5._2_0
{
    class MyComplex
    {
        double _re;
        double _im;
        public double Re
        {
            get
            {
                return _re;
            }
            set
            {
                _re = value;
            }
        }
        public double Im
        {
            get
            {
                return _im;
            }
            set
            {
                _im = value;
            }
        }
        public double Abs
        {
            get
            {
                return Math.Sqrt(Re * Re + Im * Im);
            }
        }
        public double Arg
        {
            get
            {
                return Math.Atan2(Im, Re);
            }
        }
        public MyComplex()
        {
            Re = Im = 0;
        }
        public MyComplex(double a, double b)
        {
            Re = a;
            Im = b;
        }
        public MyComplex(MyComplex a)
        {
            Re = a.Re;
            Im = a.Im;
        }
        public override string ToString()
        {
            return $"Real: {Re}, Imaginary: {Im}";
        }
        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.Re + b.Re, a.Im + b.Im);
        }
        public static MyComplex operator +(MyComplex a, int b)
        {
            return new MyComplex(a.Re + b, a.Im);
        }
        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.Re - b.Re, a.Im - b.Im);
        }
        public static MyComplex operator -(MyComplex a, int b)
        {
            return new MyComplex(a.Re - b, a.Im);
        }
        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.Re * b.Re - a.Im * b.Im, a.Re * b.Im + a.Im * b.Re);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
