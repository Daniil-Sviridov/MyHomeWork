using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] PhonB = new string[5, 2] { { "Андрей", "andr85@mail.ru" },
                                                 { "Борис","bs_70@aaanet.ru" },
                                                 { "Владимир","vovas@gmail.com" },
                                                 { "Генадий","gvb@pisem.net" },
                                                 { "Дмитрий","eda_l@mail.ru" }};

            Console.WriteLine("Контакты:");
            for(int i = 0; i < PhonB.GetLength(0); i++)
                {
                Console.WriteLine($"{i+1}   {PhonB[i,0]}    {PhonB[i, 1]}");
            }

            
        }
    }
}
