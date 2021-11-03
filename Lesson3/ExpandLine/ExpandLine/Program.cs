using System;

namespace ExpandLine
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("Введите строку: \n");

            String str = Console.ReadLine();
            
            int strLength = str.Length;

            for (int i = strLength - 1; i >= 0; i--)
            {
                System.Console.Write(str[i]);
            }
            
        }
    }
}
