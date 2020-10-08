using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> letters = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentLeter = input[i];

                if (!letters.ContainsKey(currentLeter))
                {
                    letters.Add(currentLeter, 0);
                }

                letters[currentLeter]++;
            }

            foreach (var item in letters)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s"); //S: 1 time/s
            }
        }
    }
}
