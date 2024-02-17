using System;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ");
            string[] secondArray = Console.ReadLine().Split(" ");

            for (int i = 0; i < secondArray.Length; i++)
            {
                string elementsFromSecondArray = secondArray[i];
                for (int j = 0; j < firstArray.Length; j++)
                {
                    string elementsFromFirstArray = firstArray[j];
                    if (elementsFromSecondArray == elementsFromFirstArray)
                    {
                        Console.Write(elementsFromFirstArray + " ");
                        break;
                    }
                }
            }
        }
    }
}
//Create a program that prints out all common elements in two arrays. You have to compare the elements of the second array to the elements of the first.