using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            Dictionary<double, int> grades = new Dictionary<double, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!grades.ContainsKey(nums[i]))
                {
                    grades.Add(nums[i], 0);
                }
                grades[nums[i]]++;
            }

            foreach (var item in grades)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
