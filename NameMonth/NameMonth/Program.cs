using System;

namespace NameMonth
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер месяца(от 1 до 12):");
            int month = Convert.ToInt32(Console.ReadLine());

            DateTime date = new DateTime(2021, month, 1);

            Console.WriteLine(date.ToString("MMMM"));

            Console.ReadKey();
        }
    }
}
