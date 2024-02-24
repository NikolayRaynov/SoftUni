using System;
using System.IO;

namespace _07._Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The size is {0} bytes.", DirectorySize(new DirectoryInfo(@"..\..\..\")));
        }

        public static long DirectorySize(DirectoryInfo directory)
        {
            long sizeSum = 0;
            // Add file sizes.
            FileInfo[] files = directory.GetFiles();
            foreach (FileInfo file in files)
            {
                sizeSum += file.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] directorySize = directory.GetDirectories();
            foreach (DirectoryInfo size in directorySize)
            {
                sizeSum += DirectorySize(size);
            }
            return sizeSum;
        }
    }
}
