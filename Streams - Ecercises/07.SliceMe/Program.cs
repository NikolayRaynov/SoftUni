using System;
using System.IO;
using System.Threading.Tasks;

namespace _07.SliceMe
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int parts = 4;
            byte[] buffer = new byte[4096];
            int totalBytes = 0;

            using (FileStream inputFile = new FileStream("sliceMe.txt", FileMode.Open, FileAccess.Read))
            {
                int partSize = (int)Math.Ceiling((decimal)inputFile.Length / parts);

                for (int i = 1; i <= parts; i++)
                {
                    int readBytes = 0;

                    using (FileStream outputFile = new FileStream($"Part-{i}.txt", FileMode.Create, FileAccess.Write))
                    {
                        while (readBytes < partSize && totalBytes < inputFile.Length)
                        {
                            int bytesToRead = Math.Min(buffer.Length, partSize - readBytes);
                            int bytes = await inputFile.ReadAsync(buffer, 0, bytesToRead);
                            await outputFile.WriteAsync(buffer, 0, bytes);
                            readBytes += bytes;
                            totalBytes += bytes;
                        }
                    }
                }
            }
        }
    }
}