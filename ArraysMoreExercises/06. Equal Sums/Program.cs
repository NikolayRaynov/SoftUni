using System;
using System.Linq;

namespace _06._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (number.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            int leftSum = 0;
            int rightSum = 0;
            

            for (int i = 0; i < number.Length - 1; i++)
            {
                leftSum = number.Take(i).Sum();
                //var result = number.TakeWhile(number.Take(number[i]) <= number.Max());
                rightSum = number.Skip(i + 1).Sum();

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

             Console.WriteLine("no");
        }
    }
}
