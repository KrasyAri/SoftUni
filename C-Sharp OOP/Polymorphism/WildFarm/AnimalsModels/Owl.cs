using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.FoodModels;

namespace WildFarm.AnimalsModels
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }



        public override void AskForFood()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override void Feed(Food food)
        {
            string[] menu = new string[] { "Meat" };

            if (menu.Any(f => f == food.GetType().Name))
            {
                this.Weight += food.Quantity * 0.25;
                this.FoodEaten += food.Quantity;
            }

            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
