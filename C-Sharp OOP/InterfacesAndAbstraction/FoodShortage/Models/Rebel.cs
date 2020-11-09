using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    public class Rebel : IBuyer
    {
        private int startFood = 0;
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food
        {
            get
            {
                return this.startFood;
            }
            set
            {
                this.startFood = value;
            }
        }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
