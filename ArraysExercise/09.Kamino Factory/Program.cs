using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenseLenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] DNA = new int[sequenseLenght];
            int dnaSum = 0;
            int dnaCount = 0;
            int dnaStartIndex = 0;
            int dnaSamples = 0;

            int sample = 0;
            while (input != "Clone them!")
            {
                sample++;
                int[] currDNA = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currCount = 0;
                int currStartIndex = -1;
                int currEndIndex = -1;
                int currDnaSum = 0;
                bool iscurrDNABetter = false;

                int count = 0;
                for (int i = 0; i < currDNA.Length; i++)
                {
                    if (currDNA[i] != 1)
                    {
                        count = 0;
                        continue;
                    }

                    count++;
                    if (count > currCount)
                    {
                        currCount = count;
                        currEndIndex = i;
                    }
                }
                currStartIndex = currEndIndex - currCount + 1;
                currDnaSum = currDNA.Sum();

                if (currCount > dnaCount)
                {
                    iscurrDNABetter = true;
                }
                else if (currCount == dnaCount)
                {
                    if (currStartIndex < dnaStartIndex)
                    {
                        iscurrDNABetter = true;
                    }
                    else if (currStartIndex == dnaStartIndex)
                    {
                        if (currDnaSum > dnaSum)
                        {
                            iscurrDNABetter = true;
                        }
                    }
                }

                if (iscurrDNABetter)
                {
                    DNA = currDNA;
                    dnaCount = currCount;
                    dnaStartIndex = currStartIndex;
                    dnaSum = currDnaSum;
                    dnaSamples = sample;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {dnaSamples} with sum: {dnaSum}.");
            Console.WriteLine(string.Join(" ", DNA));
        }
    }
}
/*You will receive the DNA length and until you receive the command "Clone them!" you will be receiving a DNA sequences of ones and zeroes, split by "!" (one or several).

You should select the sequence with the longest subsequence of ones. If there are several sequences with same length of subsequence of ones, print the one with the leftmost starting index, if there are several sequences with same length and starting index, select the sequence with the greater sum of its elements.

After you receive the last command "Clone them!" you should print the collected information in the following format:

"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
"{DNA sequence, joined by space}"
*/