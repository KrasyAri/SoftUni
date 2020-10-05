using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

           SortedDictionary<string, Dictionary<string, double>> shopInfo = new SortedDictionary<string, Dictionary<string, double>>();

            while (comand != "Revision")
            {
                string[] splited = comand.Split(", ");
                string shop = splited[0];
                string product = splited[1];
                double price = double.Parse(splited[2]);

                if (!shopInfo.ContainsKey(shop))
                {
                    shopInfo.Add(shop, new Dictionary<string, double>());
                }
                shopInfo[shop].Add(product, price);

                comand = Console.ReadLine();
            }

            foreach (var shop in shopInfo)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }

            }
        }
    }
}
