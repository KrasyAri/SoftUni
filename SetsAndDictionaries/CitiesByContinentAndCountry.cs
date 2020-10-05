using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> world = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!world.ContainsKey(continent))
                {
                    world.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!world[continent].ContainsKey(country))
                {
                    world[continent].Add(country, new List<string>());
                }
                world[continent][country].Add(city);
            }

            foreach (var continents in world)
            {
                Console.WriteLine($"{continents.Key}:");

                foreach (var item in continents.Value)
                {
                    Console.WriteLine($"  { item.Key} -> { string.Join(", ", item.Value)} ");
                }
            }
        }
    }
}
