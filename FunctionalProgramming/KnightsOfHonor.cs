using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Action<string[]> printNames = a => Console.WriteLine($"Sir {string.Join("\nSir ",a)}");

            printNames(names);
        }
    }
}
