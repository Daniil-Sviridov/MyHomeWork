using System;

namespace L4TM_Fib
{
    class Program
    {
        static int FibNum(int n)
        {
            if (n == 0 | n == 1) return n;

            return FibNum(n - 1) + FibNum(n - 2);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Размер последовательности:");
            int Num = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < Num; i++)
            Console.WriteLine($"{i+1} {FibNum(i)}");

            Console.ReadKey();
        }
    }
}
