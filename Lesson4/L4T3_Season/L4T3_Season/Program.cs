using System;

namespace L4T3_Season
{
    class Program
    {
        public enum Season
        {
            Winter, Spring, Summer, Autumn
        }


        public class EnumConversionExample
        {

            static int GetNumMonth(int x = 0)
                {

                Console.Clear();

                if (x < 0) {Console.WriteLine("Ошибка: введите число от 1 до 12"); };

                Console.WriteLine("ВВедите номе месяца:");
                x = Convert.ToInt32(Console.ReadLine());
                                
                if (x < 1 | x > 12) { x = GetNumMonth(-1); };

                return x;
                }

            static Season GetSeason(int x)
                {

                if (x >= 3 | x <= 5) 
                    { return Season.Spring; }

                if (x >= 6 | x <= 8)
                { return Season.Summer; }

                if (x >= 9 | x <= 11)
                { return Season.Autumn; }

                return Season.Winter;
                }


            public static void Main()
            {
                
                Console.WriteLine(GetSeason(GetNumMonth()));

            }
        }
    }
}
