using System;
using System.Collections.Specialized;
using System.Configuration;

using L8T1_Resurses.Properties;

namespace L8T1_Resurses
{ 
 
    class Program
    {
        static void SaveSettings(string key, string value)
        {
             var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
              var settings = configFile.AppSettings.Settings;
              if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
              else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        
        static void Main(string[] args)
        {

            Console.WriteLine(Resources.Hello);

            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            string UsrName;
            string UsrAge;
            string UsrOccupation;

            if ((ConfigurationManager.AppSettings["UsrName"] != null)&(ConfigurationManager.AppSettings["UsrAge"] != null)&(ConfigurationManager.AppSettings["UsrOccupation"] != null))
                {

                UsrName = ConfigurationManager.AppSettings["UsrName"];
                UsrAge  = ConfigurationManager.AppSettings["UsrAge"];
                UsrOccupation = ConfigurationManager.AppSettings["UsrOccupation"];

                Console.WriteLine($"Привет, {UsrName}! Тебе {UsrAge} лет. Твое занятие {UsrOccupation}");
            }
            else
                {
                Console.WriteLine("Давай знакомиться!");
                Console.WriteLine("Как тебя зовут?:");
                UsrName = Console.ReadLine();
                Console.WriteLine("Сколько лет?:");
                UsrAge = Console.ReadLine();
                Console.WriteLine("Чем зпнимаешься?:");
                UsrOccupation = Console.ReadLine();

            }

            SaveSettings("UsrName", UsrName);
            SaveSettings("UsrAge", UsrAge);
            SaveSettings("UsrOccupation", UsrOccupation);
        }
    }
}
