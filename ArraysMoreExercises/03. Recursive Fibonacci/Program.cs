using System;
using System.Linq;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonachiNumber = int.Parse(Console.ReadLine());

            int[] startArr = new int[] { 1, 1 };


            for (int i = 0; i < fibonachiNumber; i++)
            {
                int[] sequenceOfFibonachi = new int[startArr.Length + 1];
                sequenceOfFibonachi[0] = 1;
                sequenceOfFibonachi[1] = 1;

                for (int j = 2; j < sequenceOfFibonachi.Length; j++)
                {
                    sequenceOfFibonachi[j] = startArr[j - 2] + startArr[j - 1];
                }

                startArr = sequenceOfFibonachi.ToArray();
            }

            Console.WriteLine($"{startArr[fibonachiNumber - 1]}");
        }
    }
}