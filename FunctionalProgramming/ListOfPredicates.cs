using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            List<int> arr = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .Distinct()
                 .ToList();


            List<int> result = new List<int>();
            result = GetDivisibleNumbers(end, arr);

            Console.WriteLine(string.Join(" ", result));

        }

        private static List<int> GetDivisibleNumbers(int n, List<int> divisors)
        {
            var divisibleNumbers = new List<int>();

            for (int num = 1; num <= n; num++)
            {
                bool isDivisible = true;

                foreach (var d in divisors)
                {
                    Predicate<int> isNotDivisor = x => num % x != 0;

                    if (isNotDivisor(d))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    divisibleNumbers.Add(num);
                }
            }
            return divisibleNumbers;
        }
    }
}
