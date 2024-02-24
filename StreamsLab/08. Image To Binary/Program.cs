using System;
using System.IO;

namespace _08._Image_To_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ImageToBinary(@"example.png"));
        }
        public static byte[] ImageToBinary(string _path)
        {
            FileStream fS = new FileStream(@"example.png", FileMode.Open, FileAccess.Read);
            byte[] b = new byte[fS.Length];
            fS.Read(b, 0, (int)fS.Length);
            fS.Close();
            return b;
        }
    }
}
