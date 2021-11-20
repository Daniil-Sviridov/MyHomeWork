
using System;
using System.Diagnostics;

// Decompiled with JetBrains decompiler
// Type: L6_TaskMgr.Program
// Assembly: L6_TaskMgr, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2B5A6B4C-4191-4CB7-B151-97769AC9C3E2
// Assembly location: C:\Users\Daniil\Documents\GitHub\MyHomeWork\Lesson6\L6_TaskMgr\L6_TaskMgr\bin\Debug\net5.0\L6_TaskMgr.dll



namespace L6_TaskMgr
{
  internal class Program
  {
        private static void Main(string[] args)
        {
            bool flag = false;

            using (Process process1 = new Process())
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("Что делать?");
                    Console.WriteLine("1  - Вывести список");
                    Console.WriteLine("2  - Завершить процесс");
                    Console.WriteLine("Ex - Выход");
                    string str1 = Console.ReadLine();
                    if (!(str1 == "1"))
                    {
                        if (!(str1 == "2"))
                        {
                            if (str1 == "Ex")
                                flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Введите Name или PID процеса");
                            string str2 = Console.ReadLine();
                            string str3;
                            try
                            {
                                str3 = string.Format("/pid {0} /F", (object)Convert.ToInt32(str2));
                            }
                            catch (FormatException ex)
                            {
                                str3 = "/im " + str2 + " /F";
                            }
                            process1.StartInfo.FileName = "taskkill.exe";
                            process1.StartInfo.Arguments = str3;
                            process1.StartInfo.UseShellExecute = false;
                            process1.Start();
                        }
                    }
                    else
                    {
                        process1.StartInfo.FileName = "tasklist.exe";
                        process1.StartInfo.Arguments = "";
                        process1.StartInfo.UseShellExecute = false;
                        process1.StartInfo.RedirectStandardOutput = true;
                        process1.Start();
                        while (!process1.StandardOutput.EndOfStream)
                            Console.WriteLine(process1.StandardOutput.ReadLine());
                    }
                    if (!flag)
                        Console.ReadKey();
                }
                while (!flag);
            }
        }
  }
}
