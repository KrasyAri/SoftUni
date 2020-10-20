using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class SpeedRacing
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] current = Console.ReadLine().Split(" ");

                string model = current[0];
                double fuelAmount = double.Parse(current[1]);
                double fuelConsumptionPerKilometer = double.Parse(current[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {

                string[] splited = command.Split(" ");

                string model = splited[1];
                double amountOfKilometers = double.Parse(splited[2]);

                foreach (var item in cars)
                {
                    if (item.Model == model)
                    {
                        item.Drive(amountOfKilometers);
                    }
                }
                
                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
