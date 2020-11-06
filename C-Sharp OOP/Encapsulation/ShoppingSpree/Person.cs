using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {

        private string name;
        private decimal money;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            this.products = new List<Product>();
        }

        public List<Product> products { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    
                    throw new ArgumentException("Name cannot be empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value >= 0)
                {
                    this.money = value;
                }
                else
                {
                    throw new ArgumentException("Money cannot be negative");
                }
            }
        }

        public void CanBuy(Product product)
        {
            if (Money >= product.Cost)
            {
                Money -= product.Cost;
                products.Add(product);
                Console.WriteLine($"{this.name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }

        public void Print()
        {
            if (this.products.Count == 0)
            {
                Console.WriteLine($"{this.Name} - Nothing bought");
            }
            else
            {
                string[] productNames = FindProductsNames();

                Console.WriteLine($"{this.Name} - {string.Join(", ", productNames)}");
            }
        }

        private string[] FindProductsNames()
        {
            string[] productsNames = new string[this.products.Count];

            for (int i = 0; i < this.products.Count; i++)
            {
                productsNames[i] = this.products[i].Name;
            }

            return productsNames;
        }

    }
}
