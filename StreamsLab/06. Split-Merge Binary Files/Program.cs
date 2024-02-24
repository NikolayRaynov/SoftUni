using System;
using System.IO;

namespace _06._Split_Merge_Binary_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (FileStream reader = new FileStream(@"..\..\..\university.png", FileMode.Open))
            //using (FileStream writer = new FileStream(@"..\..\..\newFile.png", FileMode.Create))
            //{
            //    byte[] buffer = new byte[4096];
            //    int bytesRead;
            //    while ((bytesRead = reader.Read(buffer, 0, buffer.Length)) > 0)
            //    {
            //        writer.Write(buffer, 0, bytesRead);
            //    }
            //}
            using (FileStream reader = new FileStream(@"..\..\..\university.png", FileMode.Open, FileAccess.Read))
            using (FileStream writer = new FileStream(@"..\..\..\newFile.png", FileMode.Create, FileAccess.Write))
            {
                reader.CopyTo(writer);
            }
        }
    }
}
