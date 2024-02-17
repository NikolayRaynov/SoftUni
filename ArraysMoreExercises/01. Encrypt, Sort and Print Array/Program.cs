using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int[] results = new int[n];

            string vowels = "EeUuIiOoAa";

            for (int i = 0; i < n; i++)
            {
                double totalSum = 0.00;
                string name = Console.ReadLine();
                double sumVolews = 0.00;
                double sumConsonants = 0.00;

                for (int j = 0; j < name.Length; j++)
                {
                    if (vowels.Contains(name[j]))
                    {
                        totalSum += name[j] * name.Length;
                    }
                    else
                    {
                        totalSum += name[j] / name.Length;
                    }
                }
                totalSum += sumVolews + sumConsonants;
                results[i] = (int)totalSum;
            }

            Array.Sort(results);

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
