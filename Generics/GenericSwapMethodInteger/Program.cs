using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int currentValue = int.Parse(Console.ReadLine());
                values.Add(currentValue);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            Box<int> box = new Box<int>(values);

            box.Swap(firstIndex, secondIndex);

            foreach (var item in values)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
