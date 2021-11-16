using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace L6_TaskMgr
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isEnd = false;
            Process process = new Process();

            do
            {

                Console.Clear();
                Console.WriteLine("Что делать?");
                Console.WriteLine("1  - Вывести список");
                Console.WriteLine("2  - Завершить процесс");
                Console.WriteLine("Ex - Выход");

                switch (Console.ReadLine())
                {
                    case "1":

                        process.StartInfo.FileName = @"tasklist.exe";
                        process.StartInfo.Arguments = "";//"/fo csv";
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.RedirectStandardOutput = true;

                        process.Start();

                        while (!process.StandardOutput.EndOfStream)
                        {
                            var str = process.StandardOutput.ReadLine();
                            Console.WriteLine(str);
                            //var arrstr = str.Split(',');
                            //Console.WriteLine($"{ arrstr[0]}, {arrstr[1]}, {arrstr[2]}, {arrstr[3]}, {arrstr[4]}");
                        };
                        break;

                    case "2":

                        Console.WriteLine("Введите Name или PID процеса");

                        var arg = Console.ReadLine();

                        try
                        {
                            arg = $"/pid {Convert.ToInt32(arg)} /F";
                        }
                        catch (FormatException)
                        {
                            arg = $"/im {arg} /F";
                        };

                        process.StartInfo.FileName = @"taskkill.exe";
                        process.StartInfo.Arguments = arg;
                        process.StartInfo.UseShellExecute = false;
                        //  process.StartInfo.RedirectStandardOutput = true;

                        process.Start();

                        break;

                    case "Ex":
                        isEnd = true;
                        break;

                        /*default:  
                            Console.Clear();
                            break;*/
                };

                if (!isEnd)
                    Console.ReadKey();

            } while (!isEnd);

            /*Process process = new Process();
            process.StartInfo.FileName = @"tasklist.exe";
            process.StartInfo.Arguments = "/fo csv";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true; 
            
            process.Start();
            while(!process.StandardOutput.EndOfStream)
                {
                var str = process.StandardOutput.ReadLine();
                Console.WriteLine(str);
                var arrstr = str.Split(',');
                Console.WriteLine($"{ arrstr[0]}, {arrstr[1]}, {arrstr[2]}, {arrstr[3]}, {arrstr[4]}");
                
                };
            */

        }
    }
}