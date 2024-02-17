using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int foldPoint = arr.Length / 2 / 2;

            int[] resultArr = new int[foldPoint * 2];

            for (int i = 0; i < foldPoint; i++)
            {
                resultArr[i] = arr[i + foldPoint] + arr[foldPoint - 1 - i];

                resultArr[i + foldPoint] = arr[i + 2 * foldPoint] + arr[arr.Length - 1 - i];

            }

            Console.WriteLine(String.Join(' ', resultArr));
        }
    }
}
