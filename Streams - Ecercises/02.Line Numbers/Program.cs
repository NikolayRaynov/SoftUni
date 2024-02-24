using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"..\..\..\text.txt";
            string outputPath = @"..\..\..\output.txt";

            StringBuilder sb = new StringBuilder();
            string[] lines = File.ReadAllLines(inputPath);

            for (int i = 0; i < lines.Length; i++)
            {
                string sentence = lines[i];
                int countOfLetters = sentence.Count(x => char.IsLetter(x));
                int punctMarks = sentence.Count(x => char.IsPunctuation(x));

                sb.AppendLine($"Line {i + 1}: {sentence} ({countOfLetters})({punctMarks})");
            }

            File.WriteAllText(outputPath, sb.ToString().TrimEnd());
        }
    }
}
