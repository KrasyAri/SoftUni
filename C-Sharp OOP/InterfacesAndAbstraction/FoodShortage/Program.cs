using FoodShortage.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length == 4)
                {
                    buyers.Add(new Citizens(input[2], int.Parse(input[1]), input[3], input[0])); 
                }
                else
                {
                    buyers.Add(new Rebel(input[0], int.Parse(input[1]),input[2]));
                }
            }

            string names = Console.ReadLine();

            while (names != "End")
            {
                if (buyers.Any(i => i.Name == names))
                {
                    IBuyer person = buyers.Find(p => p.Name == names);
                    person.BuyFood();
                }
                
                names = Console.ReadLine();
            }

            int totalFood = 0;

            foreach (var item in buyers)
            {
                totalFood += item.Food;
            }

            Console.WriteLine(totalFood);
        }
    }
}
