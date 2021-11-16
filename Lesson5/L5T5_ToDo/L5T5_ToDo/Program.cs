using System;
using System.Text.Json;
using System.IO;

namespace L5T5_ToDo
{

    class Program
    {
        static void Main(string[] args)
        {
            ToDo[] Tasks;

            FileInfo fi = new FileInfo(@"tasks.json");

            if (fi.Exists)
            {
                Console.WriteLine("Задачи загружены");
                
                string json = File.ReadAllText(fi.Name);
                Tasks  = JsonSerializer.Deserialize<ToDo[]>(json);
             }
            else
            {
                Tasks = new ToDo[0];
            };

            bool notfinish = true;

            do
            {
                //Console.Clear();
                Console.WriteLine("Введите:");
                Console.WriteLine("1 - Добавить задачу");
                Console.WriteLine("2 - Вывести список");
                Console.WriteLine("3 - отметить выполененой");
                Console.WriteLine("EXIT - завершить");

                switch (Console.ReadLine())
                {
                    case "EXIT":
                        notfinish = false;
                        break;
                    case "1":
                        Console.WriteLine("ВВедите наименование задачи:");

                        ToDo newTask = new ToDo(Console.ReadLine());

                        Array.Resize(ref Tasks, Tasks.Length+1);

                        Tasks[Tasks.Length - 1] = newTask;
                        
                        break;
                    case "2":

                        for (int i = 0; i < Tasks.Length; i++)
                            {
                            Console.Write($"{i} - "); Tasks[i].printTask();
                        };
                        break;
                    case "3":

                        Console.WriteLine("Введите индекс задачи:");

                        Tasks[Convert.ToInt32(Console.ReadLine())].DoIt();

                        break;
                    default:
                        Console.Clear();
                        break;
                }

            } while (notfinish);

            if (Tasks.Length > 0) 
                {
                string json = JsonSerializer.Serialize(Tasks);
                File.WriteAllText(fi.Name, json);

            };
        }


        
    }
}
