using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> leftSet = new HashSet<int>();
            HashSet<int> rightSet = new HashSet<int>();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int nLenght = numbers[0];
            int mLenght = numbers[1];

            for (int i = 0; i < nLenght; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                leftSet.Add(currentNumber);
            }

            for (int i = 0; i < mLenght; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                rightSet.Add(currentNumber);
            }

            List<int> nums = leftSet.Intersect(rightSet).ToList();

            foreach (var num in nums)
            {
                Console.Write($"{num} ");
            }
        }
    }
}