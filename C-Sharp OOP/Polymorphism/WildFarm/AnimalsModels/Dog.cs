using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.FoodModels;

namespace WildFarm.AnimalsModels
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }



        public override void AskForFood()
        {
            Console.WriteLine("Woof!");
        }

        public override void Feed(Food food)
        {
            string[] menu = new string[] { "Meat" };

            if (menu.Any(f => f == food.GetType().Name))
            {
                this.Weight += food.Quantity * 0.40;
                this.FoodEaten += food.Quantity;
            }

            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
