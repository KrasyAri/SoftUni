using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> values = new List<double>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double currentValue = double.Parse(Console.ReadLine());
                values.Add(currentValue);
            }
            Box<double> box = new Box<double>(values);

            var compareDouble = double.Parse(Console.ReadLine());

            Console.WriteLine(box.Compare(compareDouble));
        }
    }
}
