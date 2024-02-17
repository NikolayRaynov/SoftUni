using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] InputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < InputArr.Length; i++)
            {
                bool currentInternationNumIsBigger = true;
                for (int j = i + 1; j < InputArr.Length; j++)
                {
                    if (InputArr[i] <= InputArr[j])
                    {
                        currentInternationNumIsBigger = false;
                    }
                }

                if (currentInternationNumIsBigger)
                {
                    Console.Write(InputArr[i] + " ");
                }
            }
        }
    }
}
//Create a program to find all the top integers in an array. A top integer is an integer that is greater than all the elements to its right.