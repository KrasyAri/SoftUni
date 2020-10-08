using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> people = Console.ReadLine().Split().ToList();

            Func<string, int> GetAsciiSum = p => p.Select(c=> (int)c).Sum();

            //string person = GetName(people, n, GetAsciiSum);

            //Console.WriteLine(person);

            Func<List<string>, int, Func<string, int>, string> nameFunc = (people, n, func)
                => people.FirstOrDefault(p => func(p) >= n);
            string res = nameFunc(people, n, GetAsciiSum);
            Console.WriteLine(res);

        }

        static string GetName (List<string>people, int n, Func<string,int> predicate)
        {
            string result = null;
            foreach (string person in people)
            {
                if (predicate(person)>=n)
                {
                    result = person;
                }
            }
            return result;
        }
    }
}
