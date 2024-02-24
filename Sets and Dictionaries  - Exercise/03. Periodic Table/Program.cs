using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> periodicTable = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] chemicals = Console.ReadLine().Split();

                foreach (var chemical in chemicals)
                {
                    periodicTable.Add(chemical);
                }
            }

            foreach (var element in periodicTable)
            {
                Console.Write($"{element} ");
            }
        }
    }
}