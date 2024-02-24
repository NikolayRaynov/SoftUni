using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _01.Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\text.txt";

            StreamReader streamReader = new StreamReader(inputFilePath);
            StringBuilder sb = new StringBuilder();
            char[] symbols = { '-', ',', '.', '!', '?' };
            int counter = 0;

            while (true)
            {
                string result = streamReader.ReadLine();

                if (result == null)
                {
                    break;
                }

                if (counter % 2 != 0)
                {
                    counter++;
                    continue;
                }

                foreach (var symbol in symbols)
                {
                    result = result.Replace(symbol, '@');
                }

                result = string.Join(" ", result.Split().Reverse());

                sb.AppendLine(result);

                counter++;
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
