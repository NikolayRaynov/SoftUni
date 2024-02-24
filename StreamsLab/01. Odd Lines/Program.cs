using System;
using System.IO;

namespace _01._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\input.txt";
            string outputFilePath = @"..\..\..\output.txt";
            ExtractOddLines(inputFilePath, outputFilePath);
        }

        private static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (var writer = new StreamWriter(@"..\..\..\output.txt"))
            {
                using (StreamReader reader = new StreamReader(@"..\..\..\input.txt"))
                {
                    int index = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine((reader.ReadLine()));
                        if (index % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        index++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }



}
