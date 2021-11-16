using System;
using System.IO;

namespace L5T1_SaveToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("Task.txt", Console.ReadLine());
            Console.ReadKey();
        }
    }
}
