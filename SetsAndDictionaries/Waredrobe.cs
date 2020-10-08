using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                //"{color} -> {item1},{item2},{item3}…"
                string[] input = Console.ReadLine().Split(" -> ");
                string colour = input[0];
                string[] clothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[colour].ContainsKey(clothes[j]))
                    {
                        wardrobe[colour].Add(clothes[j], 0);
                    }
                    wardrobe[colour][clothes[j]]++;
                }
               
            }

            var clothToFind = Console.ReadLine().Split();

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var cloth in item.Value)
                {
                    Console.Write($"* {cloth.Key} - {cloth.Value} ");

                    if (cloth.Key == clothToFind[1] && item.Key == clothToFind[0])
                    {
                        Console.Write("(found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
