using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] numbers = new int[num];
            int sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.Write(sum);
        }
    }
}
//A train has an **n** number of wagons (integer, received as input). On the next n lines, you will receive the amount of people that are going to get on each wagon. Print out the number of passengers in each wagon followed by the total number of passengers on the train.