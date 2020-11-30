using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.FoodModels;

namespace WildFarm.AnimalsModels
{
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }



        public string Name { get; set; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }



        public abstract void AskForFood();

        public abstract void Feed(Food food);
    }
}
