using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> parking = new HashSet<string>();

            while (input != "END")
            {
                var splited = input.Split(", ");

                string act = splited[0];
                string num = splited[1];

                if (act == "IN")
                {
                    parking.Add(num);
                }
                else
                {
                    parking.Remove(num);
                }

                input = Console.ReadLine();
            }

            if (parking.Count>0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, parking));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
