using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> data = new SortedDictionary<string, Dictionary<string, double>>();
            string input = Console.ReadLine();
            while (input != "Revision")
            {
                string[] tokens = input.Split(", ");
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!data.ContainsKey(shop))
                {
                    data.Add(shop, new Dictionary<string, double>() { { product, price } });
                }
                else
                {
                    data[shop].Add(product, price );
                }

                input = Console.ReadLine();
            }

            foreach (var shop in data)
            {
                Console.WriteLine($"{shop.Key}-> ");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}