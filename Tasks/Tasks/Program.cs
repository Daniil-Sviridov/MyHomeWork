using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDateTime = DateTime.Today;
            string str;

            //Напишем комментарий
            Console.WriteLine("Ваше имя? :");
            str = Console.ReadLine();
            Console.WriteLine($"Hello {str}! Сегодня {myDateTime.ToString("dd/MM/yyyy")} г.");
            Console.ReadKey();
        }
    }
}

