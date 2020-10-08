using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = nums[0];
            int m = nums[1];

            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int firstN = int.Parse(Console.ReadLine());
                first.Add(firstN);
            }

            for (int j = 0; j < m; j++)
            {
                int secondN = int.Parse(Console.ReadLine());
                second.Add(secondN);
            }

            first.IntersectWith(second);

            Console.WriteLine(string.Join(" ",first));
        }
    }
}
