using System;
using System.Linq;
namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            short sizeOfField = short.Parse(Console.ReadLine());    // Field size input

            int[] initIndexes = Console.ReadLine()  // Array of the ladybug indexes of the next array
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();

            int[] ladybugArray = new int[sizeOfField];  // Creating the lady bug array

            for (int i = 0; i < initIndexes.Length; i++)    // Filling the ladybug array with 1s on their indexes
            {

                if (initIndexes[i] >= 0 &&          // Checking if the current index is in bounds of the ladyBug array
                    initIndexes[i] < sizeOfField)   // to avoid out of bounds exceptions
                {
                    ladybugArray[initIndexes[i]] = 1;
                }
            }

            string command = Console.ReadLine();    // Getting the input commands -> [ladybugIndex] [left/right] [jumpPlaces] / end

            while (command != "end")
            {
                string[] commandArray = command.Split();    // Splitting the command string into a string array of 3 instructions

                int whichBug = int.Parse(commandArray[0]);  // Parsing the first command index to get the index of the bug as a number

                if (whichBug >= 0 && whichBug < sizeOfField)    // Checking the index of the bug is in bounds to avoid exceptions, but
                {
                    int jumpPlaces = int.Parse(commandArray[2]);    // Parsing the last index of the command array to get the jump length

                    if (ladybugArray[whichBug] == 1)    // Checking if there's a bug in the index we are trying to move
                    {
                        if (commandArray[1] == "left")  // Checking the middle command
                        {
                            int jumpCount = 1;  // Initializing the number of jumps - in case landing index is occupied

                            int currLanding = whichBug - jumpPlaces * jumpCount;        // Initializing the current landing index

                            while (currLanding >= 0 && ladybugArray[currLanding] == 1)  // Checking if we are inside the array and if the landing index is occupied
                            {
                                if (jumpPlaces == 0) break; // Breaking the loop if we jump 0 spaces to avoid perma-loop

                                jumpCount++;    // Increasing our jump multiplier if landing index is occupied

                                currLanding = whichBug - jumpPlaces * jumpCount;    // Setting the new land index
                            }
                            if (currLanding >= 0)   // Checking if we are still in bounds, otherwise we dont need to change the landing value
                            {
                                ladybugArray[currLanding] = 1;
                            }

                            if (jumpPlaces != 0)    // Checking if we jumped 0 spaces to avoid nulling our current value
                            {
                                ladybugArray[whichBug] = 0;
                            }
                        }

                        // Same logic like in "left" but reversed
                        else if (commandArray[1] == "right")
                        {
                            int jumpCount = 1;
                            int currLanding = whichBug + jumpPlaces * jumpCount;

                            while (currLanding < sizeOfField && ladybugArray[currLanding] == 1)
                            {
                                if (jumpPlaces == 0) break;

                                jumpCount++;
                                currLanding = whichBug + jumpPlaces * jumpCount;
                            }

                            if (currLanding < sizeOfField)
                            {
                                ladybugArray[currLanding] = 1;
                            }

                            if (jumpPlaces != 0)
                            {
                                ladybugArray[whichBug] = 0;
                            }
                        }
                    }
                }
                // Entering the new command in the end of the current cycle
                command = Console.ReadLine();
            }
            // Writting the ladybug array split by spaces
            Console.WriteLine(string.Join(" ", ladybugArray));
        }
    }
}
/*You are given a field size and the indexes where ladybugs can be found on the field. On every new line, until the "end" command is given, a ladybug changes its position either to its left or to its right by a given fly length. A movement description command looks like this: "0 right 1". This means that the little insect placed on index 0 should fly one index to its right. If the ladybug lands on another ladybug, it continues to fly in the same direction repeating the specified flight length. If the ladybug flies out of the field, it is gone.

Example: you are given a field of size 3 there are ladybugs on indexes 0 and 1. If the ladybug on index 0 needs to fly to its right by the length of 1 (0 right 1) it will attempt to land on index 1 but as there is another ladybug there, so it will continue further to the right passing 1 index in length, landing on index 2. After that, if the same ladybug needs to fly to its right passing 1 index (2 right 1), it will land somewhere outside of the field, so it flies away:

If we receive an initial index that does not contain a ladybug nothing happens. If you are given a ladybug index that is outside the field, nothing happens. In the end, print all cells of the field separated by blank spaces. For each cell that has a ladybug in it print '1' and for each empty cell print '0'. The output of the example above should be '0 1 0'.
*/