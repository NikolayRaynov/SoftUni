using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
            int counter = 0;
            int winningCounter = 0;
            int index = 0;
            string number = string.Empty;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    if (counter > winningCounter)
                    {
                        winningCounter = counter;
                        index = i;
                        number = numbers[i].ToString();
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            for (int i = 0; i <= winningCounter; i++)
            {
                Console.Write(number + " ");
            }
        }
    }
}
//Create a program that finds the longest sequence of equal elements in an array of integers. If several equal sequences are present in the array, print out the leftmost one.