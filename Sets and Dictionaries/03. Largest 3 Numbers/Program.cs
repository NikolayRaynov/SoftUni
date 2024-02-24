using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> sorted = numbers.OrderByDescending(n => n).Take(3).ToList();

            foreach (var sort in sorted)
            {
                Console.Write($"{sort} ");
            }
        }
    }
}
