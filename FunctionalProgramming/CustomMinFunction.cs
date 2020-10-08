using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> minValNum = nums =>
            {
                int minValue = int.MaxValue;
                foreach (var num in nums)
                {
                    if (num<minValue)
                    {
                        minValue = num;
                    }

                }
                return minValue;
            };

            Console.WriteLine(minValNum(numbers));
        }
    }
}
