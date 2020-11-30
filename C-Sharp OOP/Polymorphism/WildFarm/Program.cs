using System;
using System.Collections.Generic;
using WildFarm.AnimalsModels;
using WildFarm.FoodModels;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string[] animalInfo = Console.ReadLine().Split();

                if (animalInfo[0] == "End")
                {
                    break;
                }

                string[] foodInfo = Console.ReadLine().Split();

                Animal animal = CreateAnimal(animalInfo);

                Food food = CreateFood(foodInfo);

                animal.AskForFood();

                animal.Feed(food);

                animals.Add(animal);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        public static Animal CreateAnimal(string[] animalInfo)
        {
            Animal animal;

            switch (animalInfo[0])
            {
                case "Cat":
                    animal = new Cat(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                    break;

                case "Tiger":
                    animal = new Tiger(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                    break;

                case "Owl":
                    animal = new Owl(animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3]));
                    break;

                case "Hen":
                    animal = new Hen(animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3]));
                    break;

                case "Mouse":
                    animal = new Mouse(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                    break;

                case "Dog":
                    animal = new Dog(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                    break;

                default:
                    throw new ArgumentException("Invalid animal type!");
            }

            return animal;
        }

        public static Food CreateFood(string[] foodInfo)
        {
            Food food;

            switch (foodInfo[0])
            {
                case "Fruit":
                    food = new Fruit(int.Parse(foodInfo[1]));
                    break;

                case "Vegetable":
                    food = new Vegetable(int.Parse(foodInfo[1]));
                    break;

                case "Meat":
                    food = new Meat(int.Parse(foodInfo[1]));
                    break;

                case "Seeds":
                    food = new Seeds(int.Parse(foodInfo[1]));
                    break;

                default:
                    throw new ArgumentException("Invalid food type!");
            }

            return food;
        }
    }
}
