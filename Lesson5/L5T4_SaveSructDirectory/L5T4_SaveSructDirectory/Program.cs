using System;
using System.IO;

namespace L5T4_SaveSructDirectory
{
    
    class Program
    {
        static StreamWriter FileWrite;

        static void SavedDirTree(DirectoryInfo root)
        {
            FileInfo[] files;
            DirectoryInfo[] directory;
                        
             files = root.GetFiles("*.*");
            
            foreach (FileInfo fi in files)
                {
                FileWrite.WriteLine($"  {fi.Name}");
                }   
            
            directory = root.GetDirectories();

            foreach (DirectoryInfo dirI in directory)
                {
                FileWrite.WriteLine(dirI.FullName);

                SavedDirTree(dirI);
                }
        }
    
    static void Main(string[] args)
        {


            FileWrite = new StreamWriter("DirTre1.txt");

            SavedDirTree(new DirectoryInfo(@"C:\Jawa_my\"));

            FileWrite.Close();

            FileWrite = new StreamWriter("DirTre2.txt");

            string[] entries = Directory.GetFileSystemEntries(@"C:\Jawa_my\", "*", SearchOption.AllDirectories);

            for (int i = 0; i < entries.Length; i++)
            {

                FileInfo fi = new FileInfo(entries[i]);


                string prefstring = "";
                if (fi.Exists) prefstring = "    ";

                FileWrite.WriteLine(prefstring + entries[i]);
            }

            FileWrite.Close();
       
        }
    }
}
