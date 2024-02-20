using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> nums = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!nums.ContainsKey(number))
                {
                    nums.Add(number, 0);
                }
                nums[number]++;
            }

            foreach (var num in nums)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}