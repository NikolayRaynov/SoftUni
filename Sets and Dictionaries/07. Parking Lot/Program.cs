using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> parking = new HashSet<string>();

            while (input != "END")
            {
                string[] tokens = input.Split(", ");
                string command = tokens[0];
                string numberOfCar = tokens[1];

                if (command == "IN")
                {
                    parking.Add(numberOfCar);
                }
                else
                {
                    parking.Remove(numberOfCar);
                }

                input = Console.ReadLine();
            }

            if (parking.Count > 0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
