using System;
using System.IO;

namespace _04._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstDocument = File.ReadAllLines(@"..\..\..\input1.txt");
            string[] secondDocument = File.ReadAllLines(@"..\..\..\input2.txt");
            int longestStream = Math.Max(firstDocument.Length, secondDocument.Length);
            int shortestStream = Math.Min(firstDocument.Length, secondDocument.Length);

            using (StreamWriter output = new StreamWriter(@"..\..\..\output.txt"))
            {
                for (int i = 0; i < longestStream; i++)
                {
                    if (i >= shortestStream && secondDocument.Length > firstDocument.Length)
                    {
                        output.WriteLine(secondDocument[i]);
                        break;
                    }
                    else if (i >= shortestStream && firstDocument.Length > secondDocument.Length)
                    {
                        output.WriteLine(firstDocument[i]);
                        break;
                    }
                    else
                    {
                        output.WriteLine(firstDocument[i]);
                        output.WriteLine(secondDocument[i]);
                    }
                }
            }
        }
    }
}
