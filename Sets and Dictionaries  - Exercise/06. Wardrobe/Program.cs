using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" -> ").ToArray();
                string color = tokens[0];
                string[] clothes = tokens[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());

                    AddClothes(wardrobe, color, clothes);
                }
                else
                {
                    AddClothes(wardrobe, color, clothes);
                }
            }

            string[] searchingOutfit = Console.ReadLine().Split();
            string searchingColor = searchingOutfit[0];
            string searchingDress = searchingOutfit[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var dress in color.Value)
                {
                    if (searchingColor == color.Key && searchingDress == dress.Key)
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value}");
                    }
                }
            }

        }

        private static void AddClothes(Dictionary<string, Dictionary<string, int>> wardrobe, string color, string[] clothes)
        {
            foreach (var dress in clothes)
            {
                if (wardrobe[color].ContainsKey(dress))
                {
                    wardrobe[color][dress]++;
                }
                else
                {
                    wardrobe[color].Add(dress, 0);
                    wardrobe[color][dress]++;
                }

            }
        }
    }
}