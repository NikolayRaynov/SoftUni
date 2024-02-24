using System;
using System.IO;

namespace _03.Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"..\..\..\copyMe.png";
            string outputPath = @"..\..\..\copyMe-copy.png";

            using FileStream fileStreamReader = new FileStream(inputPath, FileMode.Open);
            using FileStream fileStreamWriter = new FileStream(outputPath, FileMode.Create);

            byte[] bytes = new byte[256];

            while (true)
            {
                int currentBytes = fileStreamReader.Read(bytes, 0, bytes.Length);

                if (currentBytes == 0)
                {
                    break;
                }

                fileStreamWriter.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
