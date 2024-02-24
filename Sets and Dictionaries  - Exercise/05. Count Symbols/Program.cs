using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> symbols = new Dictionary<char, int>();

            string text = Console.ReadLine();

            foreach (var ch in text)
            {
                if (!symbols.ContainsKey(ch))
                {
                    symbols.Add(ch, 0);
                }

                symbols[ch]++;
            }

            foreach (var symbol in symbols.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}