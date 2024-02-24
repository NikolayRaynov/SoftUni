using System;
using System.IO;
using System.IO.Compression;

namespace _06.Zip_and_Extracts
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = @"..\..\..\copyMe.png";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\extracted.png";

            using ZipArchive zipFile = ZipFile.Open(zipArchiveFile, ZipArchiveMode.Create);

            zipFile.CreateEntryFromFile(inputFile, "copyMe.png");

            var fileNameOnly = Path.GetFileName(inputFile);

            //-----------------------------------------------------------

            using ZipArchive zip = ZipFile.OpenRead(zipArchiveFile);

            var currentZip = zip.GetEntry(fileNameOnly);

            currentZip.ExtractToFile(extractedFile);
        }
    }
}
