using System;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace L5T3_SaveBFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массив чисел. Через пробел:");
            string Str = Console.ReadLine();
            var arr =  Str.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            BinaryFormatter Bformatter = new BinaryFormatter();

            FileStream FS = new FileStream("Bformatter.dat", FileMode.OpenOrCreate);
                
                Bformatter.Serialize(FS, arr);


                
                //Console.WriteLine(Bformatter.Deserialize(FS).ToString());

                /*int[] Array;
                
                Array = (int[])Bformatter.Deserialize(FS);
                */


                /*for (int i = 0; i < Array.Length; i++)
                    {
                    Console.WriteLine(Array[i]);
                    }*/
            

        }
    }
}
