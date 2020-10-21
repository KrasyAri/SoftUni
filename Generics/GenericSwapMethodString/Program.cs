using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> values = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string currentValue = Console.ReadLine();
                values.Add(currentValue);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            Box<string> box = new Box<string>(values);

            box.Swap(firstIndex, secondIndex);

            foreach (var item in values)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
