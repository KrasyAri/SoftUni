using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    public class Citizens : IIdable, IBirthable, IBuyer
    {
        private int startFood = 0;

        public Citizens(string id, int age, string birthDate, string name)
        {
            Id = id;
            Age = age;
            BirthDate = birthDate;
            Name = name;
        }

        public string Id { get; set; }
        
        public int Age { get; set; }
        public string BirthDate { get ; set ; }

        public string Name { get; set; }
        public int Food 
        {
            get
            {
                return this.startFood;
            }
            set
            {
                startFood = value;
            }
        }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
