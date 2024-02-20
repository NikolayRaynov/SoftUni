using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> party = new HashSet<string>();
            HashSet<string> toBePrinted = new HashSet<string>();
            bool isBreak = false;

            while (command != "END")
            {
                if (command == "PARTY")
                {
                    while (command != "END")
                    {
                        if (party.Contains(command))
                        {
                            party.Remove(command);
                        }
                        command = Console.ReadLine();
                        if (command == "END")
                        {
                            isBreak = true;
                        }
                    }
                    if (isBreak)
                    {
                        break;
                    }
                }
                else
                {
                    party.Add(command);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(party.Count);
            foreach (string person in party)
            {
                if (char.IsDigit(person[0]))
                {
                    Console.WriteLine(person);
                }
                else
                {
                    toBePrinted.Add(person);
                }
            }

            foreach (string person in toBePrinted)
            {
                Console.WriteLine(person);
            }
        }
    }
}
