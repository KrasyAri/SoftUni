using System;

namespace _01.Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ");

            Action<string[]> action = a => Console.WriteLine(string.Join(Environment.NewLine, a));

            action(names);
        }
    }
}
