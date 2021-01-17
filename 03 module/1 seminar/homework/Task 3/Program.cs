using System;

namespace Task_3
{
    delegate double delegateConvertTemperature(double a);

    class TemperatureConverterImp
    {
        public double FahrenheitToCelsius(double val) => 5 * (val - 32) / 9;
        public double CelsiusToFahrenheit(double val) => 9 * val / 5 + 32;
    }
    static class StaticTempConverters
    {
        public static double CelsiusToKelvin(double val) => val + 273.15;
        public static double CelsiusToRankine(double val) => (val + 273.15) * 9 / 5;
        public static double CelsiusToReaumur(double val) => 5 * val / 4;
        public static double KelvinToCelsius(double val) => val - 273.15;
        public static double RankineToCelsius(double val) => (val - 491.67) * 5 / 9;
        public static double ReamurToCelsius(double val) => 4 * val / 5;
    }
    class Program
    {
        static void Main(string[] args)
        {
            delegateConvertTemperature[] arr = new delegateConvertTemperature[3];
            arr[0] = new delegateConvertTemperature(StaticTempConverters.CelsiusToKelvin);
            arr[1] = new delegateConvertTemperature(StaticTempConverters.CelsiusToRankine);
            arr[2] = new delegateConvertTemperature(StaticTempConverters.CelsiusToReaumur);
            double val;
            while (true)
            {
                do
                {
                    Console.WriteLine("Введите температуру в цельсиях");
                }
                while (!double.TryParse(Console.ReadLine(), out val));
                Console.WriteLine($"Celsius to Kelvin: {val} -> {arr[0](val)}");
                Console.WriteLine($"Celsius to Rankine: {val} -> {arr[1](val)}");
                Console.WriteLine($"Celsius to Reaumur: {val} -> {arr[2](val)}");
            }

        }
    }
}
