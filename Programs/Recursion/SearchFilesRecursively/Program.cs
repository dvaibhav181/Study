using System;
using System.Collections.Generic;
using System.IO;

namespace SearchFilesRecursively
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Find Files Recursively
        /// </summary>
        /// <param name="filePath">Folder Path</param>
        /// <param name="fileName">File Name</param>
        /// <returns>Return list of files, else return empty</returns>
        public static List<string> SearchFiles(string filePath, string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return false;

            DirectoryInfo di = new DirectoryInfo(filePath);
            DirectoryInfo[] arrDir = di.GetDirectories();
            
            foreach (DirectoryInfo dir in arrDir)
            {
                if (FindFile(di + dir.ToString() + "\\", fileName))
                    return true;
            }

            foreach (FileInfo fi in di.GetFiles("*.*"))
            {
                if (fi.Name == fileName)
                    return true;
            }
            return false;
        }
    }
}
