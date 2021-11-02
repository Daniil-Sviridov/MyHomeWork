using System;

namespace Check
{
    class Program
    {
        static void Main(string[] args)
        {

            string NameOrg = "ООО \"Социальная аптека 8\"";
            string NameShop = "Аптека №154";
            DateTime datetime = new DateTime(2021, 11, 2, 19, 26, 0);

            Console.WriteLine("     "+NameOrg);
            Console.WriteLine($"          { NameShop}");
            Console.WriteLine("ПРИХОД");
            Console.WriteLine("0");
            Console.WriteLine("Родиолы экстракт 30МЛ");
            Console.WriteLine("01           2.000*32.00 = 64");
            Console.WriteLine("  НДС 10%                = 5.82");
            Console.WriteLine("  ТОВАР");
            Console.WriteLine("  ПОЛНЫЙ РАСЧЕТ");
            Console.WriteLine("Родиолы экстракт 30МЛ");
            Console.WriteLine("01           2.000*37.00 = 74");
            Console.WriteLine("  НДС 10%                = 6.73");
            Console.WriteLine("  ТОВАР");
            Console.WriteLine("  ПОЛНЫЙ РАСЧЕТ");
            Console.WriteLine("ИТОГ    = 138.00");
            Console.WriteLine("  Сумма НДС 10%          = 12.55");
            Console.WriteLine("БЕЗНАЛИЧНЫМИ             = 138.00");
            Console.WriteLine("ПОЛУЧЕНО                  = 138.00");
            Console.WriteLine("СНО:                       ОСН");
            Console.WriteLine(NameOrg);
            Console.WriteLine("344038, Ростов-на-Дону \n +  г, Ленина ПР-КТ, 107 д.");
            Console.WriteLine($"Место расчетов:          {NameShop}");
            Console.WriteLine("Кассир:              Семченко Т.А.");
            Console.WriteLine("САЙТ ФНС:          www.nalog.ru");
            Console.WriteLine("♠ЗН ККТ            00106707162988♠");
            Console.WriteLine($"Дата Время         {datetime }");
            Console.WriteLine("ОФД:               ООО УД \"ИНИТПРО\"");
            Console.WriteLine("ИНН:               6166074939");
            Console.WriteLine("РН ККТ:             0004857554054116");
            Console.WriteLine("ФН                 9289440300742922");
            Console.WriteLine("ФД                  0000036898");
            Console.WriteLine("ФП:                 2047770755");
            Console.WriteLine("     СПАСИБО");
            Console.WriteLine("    ЗА ПОКУПКУ!");




        }
    }
}

