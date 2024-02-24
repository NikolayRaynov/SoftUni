using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> evenNumbers = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!evenNumbers.ContainsKey(number))
                {
                    evenNumbers.Add(number, 0);
                }

                evenNumbers[number]++;
            }

            int evenTimesNumber = evenNumbers.First(kvp => kvp.Value % 2 == 0).Key;

            Console.WriteLine(evenTimesNumber);
        }
    }
}