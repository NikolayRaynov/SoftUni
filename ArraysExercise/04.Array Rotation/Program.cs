using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int rotation = 0; rotation < rotations; rotation++)
            {
                int temp = arr[0];
                for (int operations = 0; operations < arr.Length - 1; operations++)
                {
                    arr[operations] = arr[operations + 1];
                }
                arr[arr.Length - 1] = temp;
            }

            Console.WriteLine(string.Join(" ", arr));

        }
    }
}
//Create a program that receives an array and a number of rotations that you have to perform. The rotations are done by moving the first element of the array from the front to the back. Print the resulting array.