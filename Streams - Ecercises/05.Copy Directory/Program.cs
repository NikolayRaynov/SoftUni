using System;
using System.IO;

namespace _05.Copy_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = Console.ReadLine();
            string outputPath = Console.ReadLine();

            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath);
            }
            else
            {
                Directory.CreateDirectory(outputPath);
            }

            string[] files = Directory.GetDirectories(inputPath);

            foreach (var file in files)
            {
                string fileName = outputPath + "\\" + Path.GetDirectoryName(file);
                File.Move(file, fileName);
            }
        }
    }
}
