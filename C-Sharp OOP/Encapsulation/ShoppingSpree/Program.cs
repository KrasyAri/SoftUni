using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] peopleInfo = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] productsInfo = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            try
            {
               
                for (int i = 0; i < peopleInfo.Length; i += 2)
                {
                    people.Add(new Person(peopleInfo[i], decimal.Parse(peopleInfo[i + 1])));
                }

                for (int i = 0; i < productsInfo.Length; i += 2)
                {
                    products.Add(new Product(productsInfo[i], decimal.Parse(productsInfo[i + 1])));
                }

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] splitedCommand = command.Split(' ');

                    Person person = people.Find(p => p.Name == splitedCommand[0]);
                    Product product = products.Find(p => p.Name == splitedCommand[1]);
                    person.CanBuy(product);

                    command = Console.ReadLine();
                }

                foreach (var person in people)
                {
                    person.Print();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
