using System;

namespace Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5] { { 11, 12, 13, 14, 15 },
                                            { 21, 22, 23, 24, 25 },
                                            { 31, 32, 33, 34, 35 },
                                            { 41, 42, 43, 44, 45 },
                                            { 51, 52, 53, 54, 55 } };

            Console.WriteLine("Пример 1:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                    System.Console.Write($"{matrix[i, i]} ");
            }

            Console.WriteLine("");

            int[,] array = new int[7, 5] { { 11, 12, 13, 14, 15 }, 
                                           { 21, 22, 23, 24, 25 }, 
                                           { 31, 32, 33, 34, 35 }, 
                                           { 41, 42, 43, 44, 45 }, 
                                           { 51, 52, 53, 54, 55 }, 
                                           { 61, 62, 63, 64, 65 }, 
                                           { 71, 72, 73, 74, 75 } };

            int maxDimension = 1;
            int minDimension = 0;
            if (array.GetLength(0) > array.GetLength(1))
            { 
                maxDimension = 0;
                minDimension = 1;            
            };

            Console.WriteLine("Пример 2:");

            int y = 0, lenghtMax = array.GetLength(maxDimension), lenghtMin = array.GetLength(minDimension);

            for (int x = 0; x < lenghtMax; x++)
            {
                System.Console.Write($"{array[x, y]} ");

                if ((float) x / lenghtMax >= (float) y / lenghtMin) { y++;  };
                
            }
        }
    }
}
