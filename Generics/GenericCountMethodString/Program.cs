using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    public class Program
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
            Box<string> box = new Box<string>(values);

            var compareString = Console.ReadLine();

            Console.WriteLine(box.Compare(compareString));
        }
    }
}
