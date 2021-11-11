using System;
using System.IO;

namespace L5T2_AddDateToFile
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime Dat =  DateTime.Now;

            File.AppendAllText("startup.txt", $"\n  {Dat.TimeOfDay.ToString()}");            
        }
    }
}
