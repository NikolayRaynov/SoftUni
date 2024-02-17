
using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int bestLengh = 1;
            int bestStartIndex = 0;
            int bestSequenceSum = 0;
            int sequenceCounter = 0;
            int bestSequenceIndexCounter = 0;

            int[] bestSequence = new int[n];

            while (input != "Clone them!")
            {
                int[] currentSequence = input
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                sequenceCounter++;

                int lenght = 1;
                int bestCurrentLenght = 1;
                int startIndex = 0;
                int currentSequenceSum = 0;

                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    if (currentSequence[i] == currentSequence[i + 1])
                    {
                        lenght++;
                    }
                    else
                    {
                        lenght = 1;
                    }

                    if (lenght > bestCurrentLenght)
                    {
                        bestCurrentLenght = lenght;
                        startIndex = i;
                    }

                    currentSequenceSum += currentSequence[i];
                }

                currentSequenceSum += currentSequence[n - 1];

                if (bestCurrentLenght > bestLengh)
                {
                    bestLengh = bestCurrentLenght;
                    bestStartIndex = startIndex;
                    bestSequenceSum = currentSequenceSum;
                    bestSequenceIndexCounter = sequenceCounter;
                    bestSequence = currentSequence.ToArray();
                }
                else if (bestCurrentLenght == bestLengh)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLengh = bestCurrentLenght;
                        bestStartIndex = startIndex;
                        bestSequenceSum = currentSequenceSum;
                        bestSequenceIndexCounter = sequenceCounter;
                        bestSequence = currentSequence.ToArray();


                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currentSequenceSum > bestSequenceSum)
                        {
                            bestLengh = bestCurrentLenght;
                            bestStartIndex = startIndex;
                            bestSequenceSum = currentSequenceSum;
                            bestSequenceIndexCounter = sequenceCounter;
                            bestSequence = currentSequence.ToArray();
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndexCounter} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(' ', bestSequence));
        }
    }
}
