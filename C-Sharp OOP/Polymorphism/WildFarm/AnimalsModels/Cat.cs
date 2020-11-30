using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.FoodModels;

namespace WildFarm.AnimalsModels
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }



        public override void AskForFood()
        {
            Console.WriteLine("Meow");
        }

        public override void Feed(Food food)
        {
            string[] menu = new string[] { "Vegetable", "Meat" };

            if (menu.Any(f => f == food.GetType().Name))
            {
                this.Weight += food.Quantity * 0.30;
                this.FoodEaten += food.Quantity;
            }

            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
