﻿using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 0;
            string str = "";

            Console.WriteLine("Введите целое число:");

            try
            {
                str = Console.ReadLine();
                Num = Convert.ToInt32(str);
            }
            catch 
            {
                Console.WriteLine($"Ошибка преобразования к числовому значению: {str}");
                Console.ReadKey();
                return;
            };

            Console.Clear();
            Console.Write($"Введеное число {Num} четное: ");

            if (Num % 2 == 0) 
                {
                Console.Write("Да.");
            } 
            else 
                {
                Console.Write("Нет.");
                };

            Console.ReadKey();
            
        }
    }
}
