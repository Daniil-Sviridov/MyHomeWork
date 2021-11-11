using System;
using System.Linq;

namespace L_T2_AddNumFStr
{
    

    class Program
    {
        static int Sum(params int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите целые числа через пробел:");
            string Str = Console.ReadLine();
            Console.WriteLine("Сумма:");
            Console.WriteLine(Sum(Str.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray()));
            
            Console.ReadKey();
        }
    }
}
