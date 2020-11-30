using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.FoodModels;

namespace WildFarm.AnimalsModels
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }



        public override void AskForFood()
        {
            Console.WriteLine("Cluck");
        }

        public override void Feed(Food food)
        {
            this.Weight += food.Quantity * 0.35;
            this.FoodEaten += food.Quantity;
        }
    }
}
