using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderNamesPath;
            string folderDirPath;
            string[] folderNames;

            Console.WriteLine("Welcome to the folder generator");

            Console.WriteLine("Please specify path to text file containing names of folders.");
            folderNamesPath = Console.ReadLine();

            Console.WriteLine("\nPlease specify directory for folders to be created in: ");
            folderDirPath = Console.ReadLine();

            StreamReader sr = new StreamReader(folderNamesPath);
            
            folderNames = sr.ReadToEnd().Split(new char[] { ' ', '\n', '\t', ',' });
            foreach (string item in folderNames)
            {
                Directory.CreateDirectory(folderDirPath + @"\" + item);
            }

            Console.WriteLine("\nFolders have been created in {0}", folderDirPath);
            Console.ReadLine();

            
        }
    }
}
