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
            
            using (FileStream FS = new FileStream("Bformatter.dat", FileMode.OpenOrCreate))
            {                
                Bformatter.Serialize(FS, arr);
            }
                                        
            using (FileStream fs = File.OpenRead("Bformatter.dat"))
                {
                    int[] x = (int[])Bformatter.Deserialize(fs);

                    Console.WriteLine("Десериализация");
                    for (int i = 0; i < x.Length; i++)
                    {
                    Console.Write($" {x[i]}");
                    }
                Console.Write("\n");
            }
           


        }
    }
}
