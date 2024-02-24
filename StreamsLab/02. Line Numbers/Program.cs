using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader sr = new StreamReader(@"..\..\..\input.txt");
            using StreamWriter sw = new StreamWriter(@"..\..\..\output.txt");

            int rowNumber = 1;
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                sw.WriteLine($"{rowNumber}. {line}");
                rowNumber++ ;
            }
        }
        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            // TODO: write your code here…
        }

    }
}
