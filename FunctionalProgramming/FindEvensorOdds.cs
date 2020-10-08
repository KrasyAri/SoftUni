using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startRange = range[0];
            int endRange = range[1];

            Func<int, int, List<int>> generateList = (start, end) =>
            {
                List<int> nums = new List<int>();

                for (int i = start; i <= end; i++)
                {
                    nums.Add(i);
                }

                return nums;
            };

            List<int> numbers = generateList(startRange, endRange);

            string command = Console.ReadLine();


            if (command == "odd")
            {
                var odd = numbers.Where(a => a % 2 != 0);
                Console.WriteLine(string.Join(" ", odd));
            }
            else if (command == "even")
            {
                var even = numbers.Where(a => a % 2 == 0);
                Console.WriteLine(string.Join(" ", even));
            }

        }
    }
}
