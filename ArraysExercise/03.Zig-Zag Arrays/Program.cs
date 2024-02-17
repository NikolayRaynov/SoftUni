using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] evenArray = new int[lines];
            int[] oddArray = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    evenArray[i] = numbers[0];
                    oddArray[i] = numbers[1];
                }
                else
                {
                    evenArray[i] = numbers[1];
                    oddArray[i] = numbers[0];
                }
            }

            Console.WriteLine(String.Join(" ", evenArray));
            Console.WriteLine(String.Join(" ", oddArray));
        }
    }
}
//Create a program that creates 2 arrays. You will be given an integer n. On the next n lines, you will get 2 integers. Form 2 new arrays in a zig-zag pattern as shown below.