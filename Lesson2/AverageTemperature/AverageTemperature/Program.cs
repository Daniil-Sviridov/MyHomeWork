using System;

namespace AverageTemperature
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите данные!");
            Console.WriteLine("Минимальная температура? :");
            double minTemp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Минимальная температура? :");
            double maxTemp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Средняя температура  {(minTemp + maxTemp) / 2}");

            Console.ReadKey();


        }
    }
}
