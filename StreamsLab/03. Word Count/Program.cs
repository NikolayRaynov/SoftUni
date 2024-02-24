using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            string inputWords = File.ReadAllText(@"..\..\..\words.txt");
            string[] words = inputWords.Split();
            using StreamWriter writer = new StreamWriter(@"..\..\..\output.txt");

            using (StreamReader reader = new StreamReader(@"..\..\..\text.txt"))
            {
                string currentSentence = reader.ReadLine();

                while (currentSentence != null)
                {
                    foreach (var word in words)
                    {
                        string[] currentRowWords = currentSentence.ToLower()
                            .Split(new string[] { " ", ", ", " ", "-", ".", "?!", "?", "!"}, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var currentWord in currentRowWords)
                        {
                            if (currentWord == word)
                            {
                                if (!dictionary.ContainsKey(word))
                                {
                                    dictionary.Add(word, 0);
                                    dictionary[word]++;
                                }
                                else
                                {
                                    dictionary[word]++;
                                }
                            }
                        }
                    }
                    currentSentence = reader.ReadLine();
                }

                foreach (var word in dictionary.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
