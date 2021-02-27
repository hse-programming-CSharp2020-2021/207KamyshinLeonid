using System;

namespace Task2
{
    interface ISequence
    {
        double this[int i]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }

    class ArithmeticProgression : ISequence
    {
        double startVal, k;

        public ArithmeticProgression(double startVal, double k)
        {
            this.startVal = startVal;
            this.k = k;
        }

        public double this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                return startVal + k * (i - 1);
            }
        }
    }

    class GeometricProgression : ISequence
    {
        double startVal, q;

        public GeometricProgression(double startVal, double q)
        {
            this.startVal = startVal;
            this.q = q;
        }

        public double this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                return startVal * Math.Pow(q, i);
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Func<ArithmeticProgression, int, double> SumAp = (ap, index) =>
             {
                 double sum = 0;
                 for (int i = 0; i <= index; i++)
                 {
                     sum += ap[i];
                 }
                 return sum;
             };

            Func<GeometricProgression, int, double> SumGp = (gp, index) =>
            {
                double sum = 0;
                for (int i = 0; i <= index; i++)
                {
                    sum += gp[i];
                }
                return sum;
            };

            var s1 = SumAp(new ArithmeticProgression(4.2, 3), 10);
            var s2 = SumGp(new GeometricProgression(2.3, 1.3), 10);
            Console.WriteLine($"Arithmetic progression: {s1:f3}");
            Console.WriteLine($"Geometric progression: {s2:f3}");
        }
    }
}
