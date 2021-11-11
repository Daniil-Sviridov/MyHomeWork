using System;

namespace L4T2_GetFullName
{
    class Program
    {

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{firstName} {lastName} {patronymic}";
        }

        static string ReadConsole(string firstName)
        {
            Console.WriteLine(firstName);
            Console.WriteLine("(Для завершения ввода введите \"EXIT\".)");
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {

            while (true) 
                {

                string firstname, lastName,patronymic;

                firstname = ReadConsole("Введите фамилию:");

                if (firstname == "EXIT") 
                    { break; } 
                else 
                    {
                    lastName = ReadConsole("Введите имя:");

                    if (lastName == "EXIT")
                        {
                        Console.WriteLine(GetFullName(firstname, "", ""));
                        break;
                        }
                    else 
                        {
                        patronymic = ReadConsole("Введите отчество:");

                        if (patronymic == "EXIT")
                            {
                            Console.WriteLine(GetFullName(firstname, lastName, ""));
                            break;
                        }
                        else 
                            {
                            Console.WriteLine(GetFullName(firstname, lastName, patronymic));
                        };

                        };

                    };

                

            }

        }

        
    }
}
