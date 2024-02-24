using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            string followers = "followers";
            string following = "following";
            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] tokens = input.Split();
                string actionVloger = tokens[0];
                string action = tokens[1];
                string otherVloger = tokens[2];

                if (action == "joined")
                {
                    if (!vloggers.ContainsKey(actionVloger))
                    {
                        vloggers.Add(actionVloger, new Dictionary<string, HashSet<string>>());
                        vloggers[actionVloger].Add(followers, new HashSet<string>());
                        vloggers[actionVloger].Add(following, new HashSet<string>());
                    }
                }
                else if (action == "followed")
                {
                    if (vloggers.ContainsKey(actionVloger) && vloggers.ContainsKey(otherVloger) &&
                        !vloggers[actionVloger][following].Contains(otherVloger) && actionVloger != otherVloger)
                    {
                        vloggers[actionVloger][following].Add(otherVloger);
                        vloggers[otherVloger][followers].Add(actionVloger);
                    }
                }



                input = Console.ReadLine();
            }


            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int count = 1;
            foreach (var vlogger in vloggers.OrderByDescending(v => v.Value["followers"].Count).ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (count == 1)
                {
                    foreach (string follower in vlogger.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                count++;
            }
        }
    }
}
