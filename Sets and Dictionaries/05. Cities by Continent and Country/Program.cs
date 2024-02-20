using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> data = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!data.ContainsKey(continent))
                {
                    data.Add(continent, new Dictionary<string, List<string>>() { { country, new List<string>() { city } } });
                }
                else
                {
                    if (!data[continent].ContainsKey(country))
                    {
                        data[continent].Add(country, new List<string>() { city });
                    }
                    else
                    {
                        data[continent][country].Add(city);
                    }
                }
            }

            foreach (var continent in data)
            {
                Console.WriteLine($"{continent.Key}: ");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }
    }
}