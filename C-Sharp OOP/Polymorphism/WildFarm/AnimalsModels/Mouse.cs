using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.FoodModels;

namespace WildFarm.AnimalsModels
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }



        public override void AskForFood()
        {
            Console.WriteLine("Squeak");
        }

        public override void Feed(Food food)
        {
            string[] menu = new string[] { "Vegetable", "Fruit" };

            if (menu.Any(f => f == food.GetType().Name))
            {
                this.Weight += food.Quantity * 0.10;
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
