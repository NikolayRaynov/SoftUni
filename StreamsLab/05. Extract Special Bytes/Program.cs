using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _05._Extract_Special_Bytes
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtractBytes.ExtractBytesFromBinaryFile(@"C:\Users\35989\OneDrive\Работен плот\example.png", @"..\..\..\bytes.txt", 
                @"..\..\..\output.txt");
        }

    }

    public class ExtractBytes
    {
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using StreamReader streamReader = new StreamReader(bytesFilePath);
            byte[] fileBytes = File.ReadAllBytes(binaryFilePath);
            List<String> bytesList = new List<String>();
            StringBuilder sb = new StringBuilder();

            while (!streamReader.EndOfStream)
            {
                bytesList.Add(streamReader.ReadLine());
            }
            foreach (var item in fileBytes)
            {
                if (bytesList.Contains(item.ToString()))
                {
                    sb.AppendLine(item.ToString());
                }

            }
            using StreamWriter file = new StreamWriter(outputPath);
            file.WriteLine(sb.ToString().Trim());
        }
    }
}
